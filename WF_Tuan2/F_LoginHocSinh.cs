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
    public partial class F_LoginHocSinh : Form
    {
        HSinhDAO hsDao = new HSinhDAO();
        public F_LoginHocSinh()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.\\SqlExpress;Initial Catalog=Test;Integrated Security=True");
        private void F_LoginHocSinh_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();                         
        }
        private void HienThiDanhSach()
        {
            this.gvHsinh.DataSource = hsDao.LayDanhSachSinhVien();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            HSinh hs = new HSinh(txtName.Text, txtAddr.Text, txtID.Text, dtpDoB.Value);
            hsDao.Them(hs);
            HienThiDanhSach();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            HSinh hs = new HSinh(txtName.Text, txtAddr.Text, txtID.Text, dtpDoB.Value);
            hsDao.Xoa(hs);
            HienThiDanhSach();
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            HSinh hs = new HSinh(txtName.Text, txtAddr.Text, txtID.Text, dtpDoB.Value);
            hsDao.Sua(hs);
            HienThiDanhSach();
        }

        private void btnGiacVien_Click(object sender, EventArgs e)
        {
            F_LoginGiaoVien gv = new F_LoginGiaoVien();
            gv.ShowDialog();
        }
    }
}
