using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WF_Tuan2
{
    public partial class F_LoginGiaoVien : Form
    {
        GvienDAO gvDao = new GvienDAO();
        public F_LoginGiaoVien()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.\\SqlExpress;Initial Catalog=Test;Integrated Security=True");
        private void F_LoginGiaoVien_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        private void HienThiDanhSach()
        {
            this.gvGvien.DataSource = gvDao.LayDanhSachSinhVien();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Gvien gv = new Gvien(txtName.Text, txtAddr.Text, txtID.Text, dtpDoB.Value);
            gvDao.Them(gv);
            HienThiDanhSach();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Gvien gv = new Gvien(txtName.Text, txtAddr.Text, txtID.Text, dtpDoB.Value);
            gvDao.Xoa(gv);
            HienThiDanhSach();
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            Gvien hs = new Gvien(txtName.Text, txtAddr.Text, txtID.Text, dtpDoB.Value);
            gvDao.Sua(hs);
            HienThiDanhSach();
        }
    }
}
