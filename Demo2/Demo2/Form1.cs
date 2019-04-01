using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Demo2
{
    public partial class Form1 : Form
    {/*
        private string server;
        private string database;
        private string uid;
        private string password;
        private string CharSet;
        private MySqlConnection connection;*/

        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void executeMyQuery(string query)
        {
            try
            {
                OpenConnection();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }

                else
                {
                    MessageBox.Show("Query Not Executed");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvbookLoad();
        }

        public void dgvbookLoad()
        {
            // populate the datagridview
            string selectQuery = "select b.Ten_Sach, b.Nam_Xuat_Ban,t.ten_tac_gia from book.book b JOIN book.tac_gia t where b.id_tac_gia = t.id;";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);

            dgvbook.Rows.Clear();

            foreach (DataRow row in table.Rows)
            {
                int n = dgvbook.Rows.Add();
                dgvbook.Rows[n].Cells["dgvColName"].Value = row["Ten_Sach"];
                dgvbook.Rows[n].Cells["dgvColYear"].Value = row["Nam_Xuat_Ban"];
                dgvbook.Rows[n].Cells["dgvColAuthor"].Value = row["ten_tac_gia"];
            }

            string selectAuthorQuery = "SELECT * FROM book.tac_gia";
            OpenConnection();
            MySqlCommand authorCommand = new MySqlCommand(selectAuthorQuery, connection);
            MySqlDataReader reader = authorCommand.ExecuteReader();
            while (reader.Read())
            {
                cbbTacGia.Items.Add(reader.GetString("ten_tac_gia"));
            }
            CloseConnection();

            this.dgvbook.Columns["dgvColName"].SortMode = DataGridViewColumnSortMode.Automatic;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //This is my insert query in which i am taking input from the user through windows forms  
            string insertQuery = "insert into book.book(Ten_Sach,Nam_Xuat_Ban,id_tac_gia) values('" + this.tbxname.Text + "','" + this.tbxyear.Text + "','" + this.cbbTacGia.Text + "');";
            executeMyQuery(insertQuery);
            dgvbookLoad();
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            this.Hide();
            tac_gia t = new tac_gia();
            t.Show();
        }

        private void dgvbook_MouseClick(object sender, MouseEventArgs e)
        {
            tbxname.Text = dgvbook.CurrentRow.Cells[0].Value.ToString();
            tbxyear.Text = dgvbook.CurrentRow.Cells[1].Value.ToString();
            cbbTacGia.Text = dgvbook.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM book.book WHERE Ten_Sach = '" + dgvbook.CurrentRow.Cells[0].Value.ToString() + "'";
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Delete Cnfimation",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                executeMyQuery(deleteQuery);
                dgvbookLoad();
            }
            else
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //string updateQuery = "UPDATE book.book SET Ten_Sach = '" + tbxname.Text + "', Nam_Xuat_Ban = '" + tbxyear.Text +
            //    "', ngay_sinh = '" + tbxNgaySinh.Text + "', que_quan =  '" + tbxQueQuan.Text + "' WHERE id = '" + tbxIdTacGia.Text + "';";
            //executeMyQuery(updateQuery);
            //dgvbookLoad();
        }
    }
}
