namespace GameDiary
{
    partial class frmPS4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvPS4 = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.LinkNew = new System.Windows.Forms.LinkLabel();
            this.picPS4 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPS4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPS4)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPS4
            // 
            this.DgvPS4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPS4.Location = new System.Drawing.Point(2, 135);
            this.DgvPS4.Name = "DgvPS4";
            this.DgvPS4.Size = new System.Drawing.Size(422, 314);
            this.DgvPS4.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Info;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(318, 464);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 29);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LinkNew
            // 
            this.LinkNew.AutoSize = true;
            this.LinkNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkNew.LinkColor = System.Drawing.Color.Black;
            this.LinkNew.Location = new System.Drawing.Point(12, 464);
            this.LinkNew.Name = "LinkNew";
            this.LinkNew.Size = new System.Drawing.Size(145, 24);
            this.LinkNew.TabIndex = 11;
            this.LinkNew.TabStop = true;
            this.LinkNew.Text = "Add New Game";
            this.LinkNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkNew_LinkClicked);
            // 
            // picPS4
            // 
            this.picPS4.Image = global::GameDiary.Properties.Resources.ps4_menu;
            this.picPS4.Location = new System.Drawing.Point(75, 12);
            this.picPS4.Name = "picPS4";
            this.picPS4.Size = new System.Drawing.Size(266, 58);
            this.picPS4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPS4.TabIndex = 5;
            this.picPS4.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(128, 97);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(272, 20);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(25, 93);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 24);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "Search:";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.SystemColors.Info;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(193, 464);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(98, 29);
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmPS4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(428, 503);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.LinkNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picPS4);
            this.Controls.Add(this.DgvPS4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPS4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPS4";
            this.Load += new System.EventHandler(this.frmPS4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPS4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPS4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPS4;
        private System.Windows.Forms.PictureBox picPS4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel LinkNew;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button BtnDelete;
    }
}