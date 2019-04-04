using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    public class DemoModel
    {
        private string _ten_sach;
        public string ten_sach
        {
            get { return _ten_sach; }
            set { _ten_sach = value; }
        }
        

        private string _nam_xuat_ban;
        public string nam_xuat_ban
        {
            get { return _nam_xuat_ban; }
            set { _nam_xuat_ban = value; }
        }

        private string _tac_gia;
        public string tac_gia
        {
            get { return _tac_gia; }
            set { _tac_gia = value; }
        }

        public DemoModel(string pTenSach, string pNamXuatBan, string pTacGia)
        {
            this._ten_sach = pTenSach;
            this._nam_xuat_ban = pNamXuatBan;
            this._tac_gia = pTacGia;
        }
    }
}
