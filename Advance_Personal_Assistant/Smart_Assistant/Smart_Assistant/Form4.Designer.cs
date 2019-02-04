namespace Smart_Assistant
{
    partial class Fpasschange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fpasschange));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backup = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textRPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(377, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.backup.Location = new System.Drawing.Point(201, 387);
            this.backup.Margin = new System.Windows.Forms.Padding(4);
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(545, 51);
            this.backup.TabIndex = 20;
            this.backup.TabStop = false;
            this.backup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.backup.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox6_OnValueChanged);
            // 
            // textRPassword
            // 
            this.textRPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textRPassword.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRPassword.ForeColor = System.Drawing.Color.White;
            this.textRPassword.HintForeColor = System.Drawing.Color.White;
            this.textRPassword.HintText = "Re-Enter Password";
            this.textRPassword.isPassword = false;
            this.textRPassword.LineFocusedColor = System.Drawing.Color.White;
            this.textRPassword.LineIdleColor = System.Drawing.Color.White;
            this.textRPassword.LineMouseHoverColor = System.Drawing.Color.White;
            this.textRPassword.LineThickness = 3;
            this.textRPassword.Location = new System.Drawing.Point(201, 328);
            this.textRPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textRPassword.Name = "textRPassword";
            this.textRPassword.Size = new System.Drawing.Size(545, 51);
            this.textRPassword.TabIndex = 19;
            this.textRPassword.TabStop = false;
            this.textRPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textRPassword.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox5_OnValueChanged);
            // 
            // textPassword
            // 
            this.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.ForeColor = System.Drawing.Color.White;
            this.textPassword.HintForeColor = System.Drawing.Color.White;
            this.textPassword.HintText = "Password";
            this.textPassword.isPassword = false;
            this.textPassword.LineFocusedColor = System.Drawing.Color.White;
            this.textPassword.LineIdleColor = System.Drawing.Color.White;
            this.textPassword.LineMouseHoverColor = System.Drawing.Color.White;
            this.textPassword.LineThickness = 3;
            this.textPassword.Location = new System.Drawing.Point(201, 269);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(545, 51);
            this.textPassword.TabIndex = 18;
            this.textPassword.TabStop = false;
            this.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textPassword.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox4_OnValueChanged);
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
            this.bunifuThinButton21.ButtonText = "Confirm";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.Location = new System.Drawing.Point(335, 488);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(260, 58);
            this.bunifuThinButton21.TabIndex = 21;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(507, 579);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cancel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(338, 579);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "LogIn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(920, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 31);
            this.label4.TabIndex = 25;
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
            this.label3.TabIndex = 24;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Fpasschange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(996, 686);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.backup);
            this.Controls.Add(this.textRPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fpasschange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox backup;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textRPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textPassword;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}