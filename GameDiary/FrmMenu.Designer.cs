namespace GameDiary
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnPS4 = new System.Windows.Forms.Button();
            this.btnXbox = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnPC = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.PicTitle = new System.Windows.Forms.PictureBox();
            this.picPS4 = new System.Windows.Forms.PictureBox();
            this.picPC = new System.Windows.Forms.PictureBox();
            this.picXbox = new System.Windows.Forms.PictureBox();
            this.picSwitch = new System.Windows.Forms.PictureBox();
            this.btnGeneral = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPS4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwitch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPS4
            // 
            this.btnPS4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPS4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPS4.Location = new System.Drawing.Point(134, 105);
            this.btnPS4.Name = "btnPS4";
            this.btnPS4.Size = new System.Drawing.Size(232, 62);
            this.btnPS4.TabIndex = 5;
            this.btnPS4.Text = "Playstation 4 Games";
            this.btnPS4.UseVisualStyleBackColor = false;
            this.btnPS4.Click += new System.EventHandler(this.btnPS4_Click);
            // 
            // btnXbox
            // 
            this.btnXbox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnXbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXbox.Location = new System.Drawing.Point(134, 190);
            this.btnXbox.Name = "btnXbox";
            this.btnXbox.Size = new System.Drawing.Size(232, 62);
            this.btnXbox.TabIndex = 6;
            this.btnXbox.Text = "Xbox One Games";
            this.btnXbox.UseVisualStyleBackColor = false;
            this.btnXbox.Click += new System.EventHandler(this.btnXbox_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch.Location = new System.Drawing.Point(134, 277);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(232, 62);
            this.btnSwitch.TabIndex = 7;
            this.btnSwitch.Text = "Nintendo Switch Games";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnPC
            // 
            this.btnPC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPC.Location = new System.Drawing.Point(134, 359);
            this.btnPC.Name = "btnPC";
            this.btnPC.Size = new System.Drawing.Size(232, 62);
            this.btnPC.TabIndex = 8;
            this.btnPC.Text = "PC Games";
            this.btnPC.UseVisualStyleBackColor = false;
            this.btnPC.Click += new System.EventHandler(this.btnPC_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Info;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(114, 506);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 29);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PicTitle
            // 
            this.PicTitle.Image = ((System.Drawing.Image)(resources.GetObject("PicTitle.Image")));
            this.PicTitle.Location = new System.Drawing.Point(88, 12);
            this.PicTitle.Name = "PicTitle";
            this.PicTitle.Size = new System.Drawing.Size(222, 70);
            this.PicTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTitle.TabIndex = 10;
            this.PicTitle.TabStop = false;
            // 
            // picPS4
            // 
            this.picPS4.Image = ((System.Drawing.Image)(resources.GetObject("picPS4.Image")));
            this.picPS4.Location = new System.Drawing.Point(28, 105);
            this.picPS4.Name = "picPS4";
            this.picPS4.Size = new System.Drawing.Size(89, 62);
            this.picPS4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPS4.TabIndex = 4;
            this.picPS4.TabStop = false;
            // 
            // picPC
            // 
            this.picPC.Image = ((System.Drawing.Image)(resources.GetObject("picPC.Image")));
            this.picPC.Location = new System.Drawing.Point(28, 361);
            this.picPC.Name = "picPC";
            this.picPC.Size = new System.Drawing.Size(89, 60);
            this.picPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPC.TabIndex = 3;
            this.picPC.TabStop = false;
            // 
            // picXbox
            // 
            this.picXbox.Image = ((System.Drawing.Image)(resources.GetObject("picXbox.Image")));
            this.picXbox.Location = new System.Drawing.Point(28, 190);
            this.picXbox.Name = "picXbox";
            this.picXbox.Size = new System.Drawing.Size(89, 62);
            this.picXbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picXbox.TabIndex = 2;
            this.picXbox.TabStop = false;
            // 
            // picSwitch
            // 
            this.picSwitch.Image = ((System.Drawing.Image)(resources.GetObject("picSwitch.Image")));
            this.picSwitch.Location = new System.Drawing.Point(28, 277);
            this.picSwitch.Name = "picSwitch";
            this.picSwitch.Size = new System.Drawing.Size(89, 62);
            this.picSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSwitch.TabIndex = 1;
            this.picSwitch.TabStop = false;
            // 
            // btnGeneral
            // 
            this.btnGeneral.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneral.Location = new System.Drawing.Point(88, 450);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(222, 40);
            this.btnGeneral.TabIndex = 11;
            this.btnGeneral.Text = "Search All";
            this.btnGeneral.UseVisualStyleBackColor = false;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(402, 547);
            this.Controls.Add(this.btnGeneral);
            this.Controls.Add(this.PicTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPC);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnXbox);
            this.Controls.Add(this.btnPS4);
            this.Controls.Add(this.picPS4);
            this.Controls.Add(this.picPC);
            this.Controls.Add(this.picXbox);
            this.Controls.Add(this.picSwitch);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Diary";
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPS4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwitch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picSwitch;
        private System.Windows.Forms.PictureBox picXbox;
        private System.Windows.Forms.PictureBox picPC;
        private System.Windows.Forms.PictureBox picPS4;
        private System.Windows.Forms.Button btnPS4;
        private System.Windows.Forms.Button btnXbox;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnPC;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox PicTitle;
        private System.Windows.Forms.Button btnGeneral;
    }
}

