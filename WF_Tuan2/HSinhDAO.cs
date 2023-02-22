using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Tuan2
{
    internal class HSinhDAO
    {
        DBConnection dbConn = new DBConnection();

        public DataTable LayDanhSachSinhVien()
        {
            string sqlStr = string.Format("SELECT *FROM HocSinh");
            return dbConn.LayDanhSach(sqlStr);
        }

        public void Them(HSinh hs)
        {
            string sqlStr = string.Format("INSERT INTO Hocsinh(Ten , Diachi, CMND, DoB) VALUES ('{0}', '{1}', '{2}', '{3}')", hs.Name, hs.Diachi, hs.Cmnd, hs.DoB);
            dbConn.ThucThi(sqlStr);
        }

        public void Xoa(HSinh hs)
        {
            string sqlStr = string.Format("delete from HocSinh where Ten = '{0}'", hs.Name);
            dbConn.ThucThi(sqlStr);
        }

        public void Sua(HSinh hs)
        {
            string sqlStr = string.Format("update HocSinh set Diachi = '{0}' where Ten = '{1}'", hs.Diachi, hs.Name);
            dbConn.ThucThi(sqlStr);
        }
    }
}
