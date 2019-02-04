namespace Smart_Assistant
{
    partial class ForgetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPass));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.backup = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.textUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(383, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(920, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "_";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(952, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textEmail
            // 
            this.textEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textEmail.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.Color.White;
            this.textEmail.HintForeColor = System.Drawing.Color.White;
            this.textEmail.HintText = "Email";
            this.textEmail.isPassword = false;
            this.textEmail.LineFocusedColor = System.Drawing.Color.White;
            this.textEmail.LineIdleColor = System.Drawing.Color.White;
            this.textEmail.LineMouseHoverColor = System.Drawing.Color.White;
            this.textEmail.LineThickness = 3;
            this.textEmail.Location = new System.Drawing.Point(251, 300);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(467, 51);
            this.textEmail.TabIndex = 13;
            this.textEmail.TabStop = false;
            this.textEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // backup
            // 
            this.backup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.backup.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backup.ForeColor = System.Drawing.Color.White;
            this.backup.HintForeColor = System.Drawing.Color.White;
            this.backup.HintText = "Backup Pin";
            this.backup.isPassword = false;
            this.backup.LineFocusedColor = System.Drawing.Color.White;
            this.backup.LineIdleColor = System.Drawing.Color.White;
            this.backup.LineMouseHoverColor = System.Drawing.Color.White;
            this.backup.LineThickness = 3;
            this.backup.Location = new System.Drawing.Point(251, 359);
            this.backup.Margin = new System.Windows.Forms.Padding(4);
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(467, 51);
            this.backup.TabIndex = 18;
            this.backup.TabStop = false;
            this.backup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.backup.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox6_OnValueChanged);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Change Password";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.Location = new System.Drawing.Point(318, 457);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(341, 58);
            this.bunifuThinButton21.TabIndex = 19;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(439, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cancel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textUserName
            // 
            this.textUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUserName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserName.ForeColor = System.Drawing.Color.White;
            this.textUserName.HintForeColor = System.Drawing.Color.White;
            this.textUserName.HintText = "User Name";
            this.textUserName.isPassword = false;
            this.textUserName.LineFocusedColor = System.Drawing.Color.LavenderBlush;
            this.textUserName.LineIdleColor = System.Drawing.Color.Azure;
            this.textUserName.LineMouseHoverColor = System.Drawing.Color.LavenderBlush;
            this.textUserName.LineThickness = 3;
            this.textUserName.Location = new System.Drawing.Point(251, 241);
            this.textUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(467, 51);
            this.textUserName.TabIndex = 21;
            this.textUserName.TabStop = false;
            this.textUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ForgetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(996, 686);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.backup);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.ForgetPass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox backup;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textUserName;
    }
}