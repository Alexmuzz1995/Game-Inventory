namespace GameDiary
{
    partial class frmPCADD
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.DtpRelease = new System.Windows.Forms.DateTimePicker();
            this.lblRelease = new System.Windows.Forms.Label();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.LblGenre = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picPS4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPS4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Info;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(30, 231);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 29);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Info;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(197, 231);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 29);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DtpRelease
            // 
            this.DtpRelease.CustomFormat = "ddd-MMM-yyyy";
            this.DtpRelease.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DtpRelease.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpRelease.Location = new System.Drawing.Point(174, 183);
            this.DtpRelease.Name = "DtpRelease";
            this.DtpRelease.Size = new System.Drawing.Size(130, 20);
            this.DtpRelease.TabIndex = 19;
            // 
            // lblRelease
            // 
            this.lblRelease.AutoSize = true;
            this.lblRelease.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelease.Location = new System.Drawing.Point(25, 176);
            this.lblRelease.Name = "lblRelease";
            this.lblRelease.Size = new System.Drawing.Size(135, 26);
            this.lblRelease.TabIndex = 18;
            this.lblRelease.Text = "Release Date";
            // 
            // cboGenre
            // 
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(100, 138);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(205, 21);
            this.cboGenre.TabIndex = 17;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(100, 93);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(205, 20);
            this.txtTitle.TabIndex = 16;
            // 
            // LblGenre
            // 
            this.LblGenre.AutoSize = true;
            this.LblGenre.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenre.Location = new System.Drawing.Point(25, 133);
            this.LblGenre.Name = "LblGenre";
            this.LblGenre.Size = new System.Drawing.Size(69, 26);
            this.LblGenre.TabIndex = 14;
            this.LblGenre.Text = "Genre";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(25, 87);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(55, 26);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Title";
            // 
            // picPS4
            // 
            this.picPS4.Image = global::GameDiary.Properties.Resources.Pc_logo_png;
            this.picPS4.Location = new System.Drawing.Point(126, 12);
            this.picPS4.Name = "picPS4";
            this.picPS4.Size = new System.Drawing.Size(89, 62);
            this.picPS4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPS4.TabIndex = 15;
            this.picPS4.TabStop = false;
            // 
            // frmPCADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(331, 272);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.DtpRelease);
            this.Controls.Add(this.lblRelease);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.picPS4);
            this.Controls.Add(this.LblGenre);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmPCADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPCADD";
            ((System.ComponentModel.ISupportInitialize)(this.picPS4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker DtpRelease;
        private System.Windows.Forms.Label lblRelease;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.PictureBox picPS4;
        private System.Windows.Forms.Label LblGenre;
        private System.Windows.Forms.Label lblTitle;
    }
}