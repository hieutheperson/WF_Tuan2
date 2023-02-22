using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Tuan2
{
    internal class GvienDAO
    {
        DBConnection dbConn = new DBConnection();
        public DataTable LayDanhSachSinhVien()
        {
            string sqlStr = string.Format("SELECT *FROM GiaoVien");
            return dbConn.LayDanhSach(sqlStr);
        }

        public void Them(Gvien gv)
        {
            string sqlStr = string.Format("INSERT INTO GiaoVien(Ten , Diachi, CMND, DoB) VALUES ('{0}', '{1}', '{2}', '{3}')", gv.Name, gv.Diachi, gv.Cmnd, gv.DoB);
            dbConn.ThucThi(sqlStr);
        }

        public void Xoa(Gvien gv)
        {
            string sqlStr = string.Format("delete from GiaoVien where Ten = '{0}'", gv.Name);
            dbConn.ThucThi(sqlStr);
        }

        public void Sua(Gvien gv)
        {
            string sqlStr = string.Format("update GiaoVien set Diachi = '{0}' where Ten = '{1}'", gv.Diachi, gv.Name);
            dbConn.ThucThi(sqlStr);
        }
    }
}
