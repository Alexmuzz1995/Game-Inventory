using Controller.DAL;
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
    public partial class frmXbox : Form
    {
        DataView _DgvXbox = null;

        public frmXbox()
        {
            InitializeComponent();
        }

        private void LinkNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmXboxADD frm = new frmXboxADD();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                PopulateGrid();
            }
        }

        private void frmXbox_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            string sqlQuery =

                "SELECT Xbox_1.Title, Genre.GenreName, Platform.PlatformName, Xbox_1.ReleaseDate " +
                              "FROM Xbox AS Xbox_1 INNER JOIN " +
                              "Genre ON Xbox_1.Genre = Genre.GenreId INNER JOIN " +
                              "Platform ON Xbox_1.XboxTitleId = Platform.PlatformId ";

            DataTable dtb = Context.GetDataTable(sqlQuery, "Xbox Games", true);

            _DgvXbox = new DataView(dtb);

            DgvXbox.DataSource = _DgvXbox;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
