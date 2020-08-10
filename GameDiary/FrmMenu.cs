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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPS4_Click(object sender, EventArgs e)
        {
            frmPS4 frm = new frmPS4();
            frm.ShowDialog();
        }

        private void btnXbox_Click(object sender, EventArgs e)
        {
            frmXbox frm = new frmXbox();
            frm.ShowDialog();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            frmSwitch frm = new frmSwitch();
            frm.ShowDialog();
        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            frmPC frm = new frmPC();
            frm.ShowDialog();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            
        }
    }
}
