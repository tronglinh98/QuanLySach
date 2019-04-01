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
    public partial class tac_gia : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;

        Form1 form = new Form1();

        public tac_gia()
        {
            InitializeComponent();
        }

        private void btnTacPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
        }

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

        private void tac_gia_Load(object sender, EventArgs e)
        {
            dgvTacGiaLoad();
        }

        private void dgvTacGiaLoad()
        {
            // populate the datagridview
            string selectQuery = "select * FROM book.tac_gia;";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);

            dgvTacGia.Rows.Clear();

            foreach (DataRow row in table.Rows)
            {
                int n = dgvTacGia.Rows.Add();
                dgvTacGia.Rows[n].Cells["dgvIdTacGia"].Value = row["id"];
                dgvTacGia.Rows[n].Cells["dgvTenTacGia"].Value = row["ten_tac_gia"];
                dgvTacGia.Rows[n].Cells["dgvNgaySinh"].Value = row["ngay_sinh"];
                dgvTacGia.Rows[n].Cells["dgvQueQuan"].Value = row["que_quan"];
            }

            this.dgvTacGia.Columns["dgvIdTacGia"].SortMode = DataGridViewColumnSortMode.Automatic;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            string insertQuery = "insert into book.tac_gia(id,ten_tac_gia,ngay_sinh, que_quan) values('" + this.tbxIdTacGia.Text + "','" + this.tbxTenTacGia.Text + "','" + this.tbxNgaySinh.Text + "','" + this.tbxQueQuan.Text + "');";
            executeMyQuery(insertQuery);
            dgvTacGiaLoad();
        }

        private void dgvTacGia_MouseClick(object sender, MouseEventArgs e)
        {
            tbxIdTacGia.Text = dgvTacGia.CurrentRow.Cells[0].Value.ToString();
            tbxTenTacGia.Text = dgvTacGia.CurrentRow.Cells[1].Value.ToString();
            tbxNgaySinh.Text = dgvTacGia.CurrentRow.Cells[2].Value.ToString();
            tbxQueQuan.Text = dgvTacGia.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM book.tac_gia WHERE id = '" + dgvTacGia.CurrentRow.Cells[0].Value.ToString() + "'";
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Delete Cnfimation",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                executeMyQuery(deleteQuery);
                dgvTacGiaLoad();
            }
            else
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE book.tac_gia SET id = '" + tbxIdTacGia.Text + "', ten_tac_gia = '" + tbxTenTacGia.Text +
                "', ngay_sinh = '" + tbxNgaySinh.Text + "', que_quan =  '" + tbxQueQuan.Text + "' WHERE id = '" + tbxIdTacGia.Text + "';";
            executeMyQuery(updateQuery);
            form.dgvbookLoad();
        }
    }
}
