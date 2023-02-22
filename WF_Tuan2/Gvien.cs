using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Tuan2
{
    public class Gvien
    {
        private string name;
        private string diachi;
        private string cmnd;
        private DateTime dob;

        public string Name { get { return name; } }
        public string Diachi { get { return diachi; } }
        public string Cmnd { get { return cmnd; } }
        public DateTime DoB { get { return dob; } }
        public Gvien(string n, string d, string c, DateTime dob)
        {
            this.name = n;
            this.diachi = d;
            this.cmnd = c;
            this.dob = dob;
        }
    }
}

