using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2.Controller
{
    public class DemoController : DemoConnect
    {
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        SqlCommand cmd;
        public DataTable Display()
        {
            String query = "SELECT * FROM tac_pham";

            OpenConnection();
            adapter = new SqlDataAdapter(query, _cn);
            dt = new DataTable();
            adapter.Fill(dt);
            CloseConnection();

            return dt;
        }

        private void executeMyQuery(SqlCommand cmd)
        {
            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public void Insert(DemoModel model)
        {
            cmd = new SqlCommand("INSERT INTO tac_pham(ten_sach, nam_xuat_ban, id_tac_gia) VALUES('" + model.ten_sach + "','" + model.nam_xuat_ban + "','" + model.tac_gia + "')", _cn);
            executeMyQuery(cmd);

        }
        public void Delete(DemoModel model)
        {
            cmd = new SqlCommand("DELETE FROM tac_pham WHERE ten_sach = '" + model.ten_sach + "' ", _cn);
            executeMyQuery(cmd);
        }
        public void Update(DemoModel model)
        {
            cmd = new SqlCommand("UPDATE tac_pham SET ten_sach ='" + model.ten_sach + "', nam_xuat_ban='" + model.nam_xuat_ban + "', id_tac_gia = '" + model.tac_gia  + "' ", _cn);
            executeMyQuery(cmd);
        }
    }
}
