namespace GameDiary
{
    partial class frmPC
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
            this.DgvPS4 = new System.Windows.Forms.DataGridView();
            this.picPS4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPS4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPS4)).BeginInit();
            this.SuspendLayout();
            // 
            // LinkNew
            // 
            this.LinkNew.AutoSize = true;
            this.LinkNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkNew.LinkColor = System.Drawing.Color.Black;
            this.LinkNew.Location = new System.Drawing.Point(12, 405);
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
            this.btnExit.Location = new System.Drawing.Point(255, 405);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 29);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DgvPS4
            // 
            this.DgvPS4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPS4.Location = new System.Drawing.Point(7, 76);
            this.DgvPS4.Name = "DgvPS4";
            this.DgvPS4.Size = new System.Drawing.Size(422, 314);
            this.DgvPS4.TabIndex = 12;
            // 
            // picPS4
            // 
            this.picPS4.Image = global::GameDiary.Properties.Resources.Pc_logo_png;
            this.picPS4.Location = new System.Drawing.Point(140, 12);
            this.picPS4.Name = "picPS4";
            this.picPS4.Size = new System.Drawing.Size(152, 58);
            this.picPS4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPS4.TabIndex = 13;
            this.picPS4.TabStop = false;
            // 
            // frmPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(436, 444);
            this.Controls.Add(this.LinkNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picPS4);
            this.Controls.Add(this.DgvPS4);
            this.Name = "frmPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPC";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPS4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPS4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LinkNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picPS4;
        private System.Windows.Forms.DataGridView DgvPS4;
    }
}