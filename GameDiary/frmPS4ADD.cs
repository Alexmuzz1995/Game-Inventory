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
    public partial class frmPS4ADD : Form
    {

        long _PKID = 0;
        DataTable _PS4Table = null;
        bool _isNew = false;

        public frmPS4ADD()
        {
            InitializeComponent();
            _isNew = true;
            InitializeDataTable();
        }

        public frmPS4ADD(long pKID)
        {
            InitializeComponent();
            _PKID = pKID;
            InitializeDataTable();
        }

        private void InitializeDataTable()
        {
            string sqlQuery = $"SELECT * FROM PS4 WHERE PS4TitleId = {_PKID}";

            _PS4Table = Context.GetDataTable(sqlQuery, "PS4");

            if (_isNew)
            {
                DataRow row = _PS4Table.NewRow();
                _PS4Table.Rows.Add(row);
            }
        }

        private void frmPS4ADD_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
            BindControls();
        }

        private void BindControls()
        {
            txtTitle.DataBindings.Add("Text", _PS4Table, "Title");
            cboGenre.DataBindings.Add("SelectedValue", _PS4Table, "Genre");
            DtpRelease.DataBindings.Add("Text", _PS4Table, "ReleaseDate");
            chkPlatform.DataBindings.Add("Checked", _PS4Table, "Platform", true);

            if (_isNew)
            {
                cboGenre.SelectedIndex = -1;
            }

            if (_isNew || string.IsNullOrEmpty(_PS4Table.Rows[0]["ReleaseDate"].ToString()))
            {
                DtpRelease.Format = DateTimePickerFormat.Custom;
                DtpRelease.CustomFormat = " ";
            }
        }

        private void PopulateComboBox()
        {

            DataTable Genredtb = Context.GetDataTable("Genre");

            cboGenre.ValueMember = "GenreId";

            cboGenre.DisplayMember = "GenreName";

            cboGenre.DataSource = Genredtb;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _PS4Table.Rows[0].EndEdit();

            Context.SaveDatabaseTable(_PS4Table);
        }

        private void cboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (cboGenre.SelectedIndex > -1);
        }

        private void DtpRelease_ValueChanged(object sender, EventArgs e)
        {
            DtpRelease.CustomFormat = "dd-MMM-yyyy";
        }
    }
}
