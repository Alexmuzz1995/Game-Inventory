namespace GameDiary
{
    partial class frmXbox
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
            this.LinkNew = new System.Windows.Forms.LinkLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.DgvXbox = new System.Windows.Forms.DataGridView();
            this.picXbox = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvXbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXbox)).BeginInit();
            this.SuspendLayout();
            // 
            // LinkNew
            // 
            this.LinkNew.AutoSize = true;
            this.LinkNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkNew.LinkColor = System.Drawing.Color.Black;
            this.LinkNew.Location = new System.Drawing.Point(12, 462);
            this.LinkNew.Name = "LinkNew";
            this.LinkNew.Size = new System.Drawing.Size(145, 24);
            this.LinkNew.TabIndex = 15;
            this.LinkNew.TabStop = true;
            this.LinkNew.Text = "Add New Game";
            this.LinkNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkNew_LinkClicked);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Info;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(250, 462);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 29);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DgvXbox
            // 
            this.DgvXbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvXbox.Location = new System.Drawing.Point(3, 133);
            this.DgvXbox.Name = "DgvXbox";
            this.DgvXbox.Size = new System.Drawing.Size(422, 314);
            this.DgvXbox.TabIndex = 12;
            // 
            // picXbox
            // 
            this.picXbox.Image = global::GameDiary.Properties.Resources.xbox_menu1;
            this.picXbox.Location = new System.Drawing.Point(92, 12);
            this.picXbox.Name = "picXbox";
            this.picXbox.Size = new System.Drawing.Size(257, 51);
            this.picXbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picXbox.TabIndex = 13;
            this.picXbox.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(130, 91);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(272, 20);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(27, 87);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 24);
            this.lblSearch.TabIndex = 16;
            this.lblSearch.Text = "Search:";
            // 
            // frmXbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(428, 503);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.LinkNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picXbox);
            this.Controls.Add(this.DgvXbox);
            this.Name = "frmXbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXbox";
            ((System.ComponentModel.ISupportInitialize)(this.DgvXbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LinkNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picXbox;
        private System.Windows.Forms.DataGridView DgvXbox;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}