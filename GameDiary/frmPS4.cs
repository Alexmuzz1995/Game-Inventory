using Controller.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDiary
{
    public partial class frmPS4 : Form
    {
        DataView _DgvPS4 = null;
        DataTable _PS4Table = null;
        long _PKID = 0;

        public frmPS4()
        {
            InitializeComponent();
            InitializeDataTable();
        }

        public frmPS4(long pKID)
        {
            InitializeComponent();
            _PKID = pKID;
            InitializeDataTable();
        }

 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the item", "Title",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    long PKID = long.Parse(DgvPS4[0, DgvPS4.CurrentCell.RowIndex]
                                            .Value.ToString());

                    // use the deleterecord method of context class and pass the primary key vaule to delete
                    Context.DeleteRecord("PS4", "PS4TitleId", PKID.ToString());
                    PopulateGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No record exists", "Title");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LinkNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPS4ADD frm = new frmPS4ADD();
            if (frm.ShowDialog() == DialogResult.OK)
                PopulateGrid();
        }

        private void LnkPS4ADD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPS4 frm = new frmPS4();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                PopulateGrid();
            }
        }

        private void frmPS4_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void InitializeDataTable()
        {
            _PS4Table = Context.GetDataTable($"SELECT * FROM PS4 WHERE Title = {_PKID}", "PS4");
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            string sqlQuery =

                "SELECT PS4_1.Title, Genre.GenreName, PS4_1.ReleaseDate, " +
                             "CASE WHEN Platform.PlatformId = True THEN 'PS4' ELSE 'Multi Platform' END AS PlatformId " +
                             "FROM PS4 AS PS4_1 INNER JOIN " +
                             "Genre ON PS4_1.Genre = Genre.GenreId INNER JOIN " +
                             "Platform ON PS4_1.PS4TitleId = Platform.PlatformId ";

            DataTable dtb = Context.GetDataTable(sqlQuery, "PS4", true);

            _DgvPS4 = new DataView(dtb);

            DgvPS4.DataSource = _DgvPS4;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _DgvPS4.RowFilter = $"Title LIKE '%{txtSearch.Text}%'" +
                                $"OR GenreName LIKE '%{txtSearch.Text}%'";
        }
    }
}
