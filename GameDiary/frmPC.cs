using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDiary
{
    public partial class frmPC : Form
    {
        public frmPC()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LinkNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPCADD frm = new frmPCADD();
            frm.ShowDialog();
        }
    }
}
