using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinglePattern
{
    public partial class Form1 : Form
    {
        private FormToolbox ftb;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenToolbox();
            FormToolbox.GetInstance().Show();
        }

        //private void OpenToolbox()
        //{
        //    if (ftb == null || ftb.IsDisposed)
        //    {
        //        ftb = new FormToolbox();
        //        ftb.MdiParent = this;
        //        ftb.Show();
        //    }
        //}
    }
}
