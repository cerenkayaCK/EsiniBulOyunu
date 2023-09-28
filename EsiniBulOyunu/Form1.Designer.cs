namespace EsiniBulOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlKartlar = new Panel();
            gboYeniOyun = new GroupBox();
            label1 = new Label();
            rb1 = new RadioButton();
            rb2 = new RadioButton();
            rb5 = new RadioButton();
            rb4 = new RadioButton();
            rb3 = new RadioButton();
            btnOyunuBaslat = new Button();
            menuStrip1 = new MenuStrip();
            yeniOyunToolStripMenuItem = new ToolStripMenuItem();
            btnYeniOyun = new ToolStripMenuItem();
            gboYeniOyun.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlKartlar
            // 
            pnlKartlar.Anchor = AnchorStyles.None;
            pnlKartlar.BackColor = Color.Transparent;
            pnlKartlar.ForeColor = SystemColors.ActiveCaption;
            pnlKartlar.Location = new Point(12, 27);
            pnlKartlar.Name = "pnlKartlar";
            pnlKartlar.Size = new Size(559, 459);
            pnlKartlar.TabIndex = 0;
            // 
            // gboYeniOyun
            // 
            gboYeniOyun.Anchor = AnchorStyles.None;
            gboYeniOyun.BackColor = Color.Transparent;
            gboYeniOyun.Controls.Add(label1);
            gboYeniOyun.Controls.Add(rb1);
            gboYeniOyun.Controls.Add(rb2);
            gboYeniOyun.Controls.Add(rb5);
            gboYeniOyun.Controls.Add(rb4);
            gboYeniOyun.Controls.Add(rb3);
            gboYeniOyun.Controls.Add(btnOyunuBaslat);
            gboYeniOyun.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            gboYeniOyun.ForeColor = Color.Green;
            gboYeniOyun.Location = new Point(131, 141);
            gboYeniOyun.Name = "gboYeniOyun";
            gboYeniOyun.Size = new Size(294, 250);
            gboYeniOyun.TabIndex = 0;
            gboYeniOyun.TabStop = false;
            gboYeniOyun.Text = "Yeni Oyun";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 39);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 2;
            label1.Text = "Zorluk Seviyesi";
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(44, 67);
            rb1.Name = "rb1";
            rb1.Size = new Size(124, 32);
            rb1.TabIndex = 1;
            rb1.TabStop = true;
            rb1.Text = "Çok Kolay";
            rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(44, 92);
            rb2.Name = "rb2";
            rb2.Size = new Size(83, 32);
            rb2.TabIndex = 1;
            rb2.TabStop = true;
            rb2.Text = "Kolay";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            rb5.AutoSize = true;
            rb5.Location = new Point(44, 167);
            rb5.Name = "rb5";
            rb5.Size = new Size(103, 32);
            rb5.TabIndex = 1;
            rb5.TabStop = true;
            rb5.Text = "Çok Zor";
            rb5.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            rb4.AutoSize = true;
            rb4.Location = new Point(44, 142);
            rb4.Name = "rb4";
            rb4.Size = new Size(62, 32);
            rb4.TabIndex = 1;
            rb4.TabStop = true;
            rb4.Text = "Zor";
            rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Checked = true;
            rb3.Location = new Point(44, 117);
            rb3.Name = "rb3";
            rb3.Size = new Size(73, 32);
            rb3.TabIndex = 1;
            rb3.TabStop = true;
            rb3.Text = "Orta";
            rb3.UseVisualStyleBackColor = true;
            // 
            // btnOyunuBaslat
            // 
            btnOyunuBaslat.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnOyunuBaslat.Location = new Point(45, 203);
            btnOyunuBaslat.Name = "btnOyunuBaslat";
            btnOyunuBaslat.Size = new Size(190, 40);
            btnOyunuBaslat.TabIndex = 0;
            btnOyunuBaslat.Text = "Oyunu Başlat";
            btnOyunuBaslat.UseVisualStyleBackColor = true;
            btnOyunuBaslat.Click += btnOyunuBaslat_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { yeniOyunToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(583, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // yeniOyunToolStripMenuItem
            // 
            yeniOyunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnYeniOyun });
            yeniOyunToolStripMenuItem.Name = "yeniOyunToolStripMenuItem";
            yeniOyunToolStripMenuItem.Size = new Size(48, 20);
            yeniOyunToolStripMenuItem.Text = "Oyun";
            // 
            // btnYeniOyun
            // 
            btnYeniOyun.Name = "btnYeniOyun";
            btnYeniOyun.ShortcutKeys = Keys.F2;
            btnYeniOyun.Size = new Size(147, 22);
            btnYeniOyun.Text = "Yeni Oyun";
            btnYeniOyun.Click += btnYeniOyun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MicrosoftTeams_image;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(583, 498);
            Controls.Add(gboYeniOyun);
            Controls.Add(menuStrip1);
            Controls.Add(pnlKartlar);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eşini Bul Oyunu";
            TopMost = true;
            gboYeniOyun.ResumeLayout(false);
            gboYeniOyun.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlKartlar;
        private GroupBox gboYeniOyun;
        private Button btnOyunuBaslat;
        private Label label1;
        private RadioButton rb1;
        private RadioButton rb2;
        private RadioButton rb5;
        private RadioButton rb4;
        private RadioButton rb3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem yeniOyunToolStripMenuItem;
        private ToolStripMenuItem btnYeniOyun;
    }
}