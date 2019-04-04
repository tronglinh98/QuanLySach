using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Controller;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void clear()
        {
            tbxTenSach.Text = "";
            tbxNamXuatBan.Text = "";
            tbxTacGia.Text = "";
        }

        DemoController controller = new DemoController();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvTacPham.DataSource = controller.Display();
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            DemoModel model = new DemoModel(tbxTenSach.Text, tbxNamXuatBan.Text, tbxTacGia.Text);
            controller.Insert(model);
            Form1_Load(sender, e);
            clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DemoModel model = new DemoModel(tbxTenSach.Text, tbxNamXuatBan.Text, tbxTacGia.Text);
            controller.Update(model);
            Form1_Load(sender, e);
            clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DemoModel model = new DemoModel(tbxTenSach.Text, tbxNamXuatBan.Text, tbxTacGia.Text);
            controller.Delete(model);
            Form1_Load(sender, e);
            clear();
        }

        private void dgvTacPham_MouseClick(object sender, MouseEventArgs e)
        {
            tbxTenSach.Text = dgvTacPham.CurrentRow.Cells[3].Value.ToString();
            tbxNamXuatBan.Text = dgvTacPham.CurrentRow.Cells[4].Value.ToString();
            tbxTacGia.Text = dgvTacPham.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
