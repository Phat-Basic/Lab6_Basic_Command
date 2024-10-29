using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Basic_Command
{
    public partial class Form1 : Form
    {
        ThuVien thuVien = new ThuVien();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            thuVien.FuncLoadButton(lvCategory);
        }

        private void lvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {   

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
