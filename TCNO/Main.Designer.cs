namespace TCNO
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.poisonButton1 = new ReaLTaiizor.Controls.PoisonButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.poisonTextBox1 = new ReaLTaiizor.Controls.PoisonTextBox();
            this.poisonTextBox2 = new ReaLTaiizor.Controls.PoisonTextBox();
            this.poisonButton2 = new ReaLTaiizor.Controls.PoisonButton();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonButton3 = new ReaLTaiizor.Controls.PoisonButton();
            this.poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel3 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonButton4 = new ReaLTaiizor.Controls.PoisonButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Job = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // poisonButton1
            // 
            this.poisonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.poisonButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.poisonButton1.Enabled = false;
            this.poisonButton1.Location = new System.Drawing.Point(205, 92);
            this.poisonButton1.Name = "poisonButton1";
            this.poisonButton1.Size = new System.Drawing.Size(142, 55);
            this.poisonButton1.TabIndex = 0;
            this.poisonButton1.Text = "Oluştur";
            this.poisonButton1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.poisonButton1.UseSelectable = true;
            this.poisonButton1.Click += new System.EventHandler(this.PoisonButton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.Color.Lime;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(154, 394);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // poisonTextBox1
            // 
            this.poisonTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.poisonTextBox1.CustomButton.Image = null;
            this.poisonTextBox1.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.poisonTextBox1.CustomButton.Name = "";
            this.poisonTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.poisonTextBox1.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.poisonTextBox1.CustomButton.TabIndex = 1;
            this.poisonTextBox1.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.poisonTextBox1.CustomButton.UseSelectable = true;
            this.poisonTextBox1.CustomButton.Visible = false;
            this.poisonTextBox1.Lines = new string[0];
            this.poisonTextBox1.Location = new System.Drawing.Point(205, 63);
            this.poisonTextBox1.MaxLength = 4;
            this.poisonTextBox1.Name = "poisonTextBox1";
            this.poisonTextBox1.PasswordChar = '\0';
            this.poisonTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.poisonTextBox1.SelectedText = "";
            this.poisonTextBox1.SelectionLength = 0;
            this.poisonTextBox1.SelectionStart = 0;
            this.poisonTextBox1.ShortcutsEnabled = true;
            this.poisonTextBox1.Size = new System.Drawing.Size(142, 23);
            this.poisonTextBox1.TabIndex = 2;
            this.poisonTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.poisonTextBox1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.poisonTextBox1.UseSelectable = true;
            this.poisonTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.poisonTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Italic);
            this.poisonTextBox1.TextChanged += new System.EventHandler(this.PoisonTextBox1_TextChanged);
            // 
            // poisonTextBox2
            // 
            this.poisonTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.poisonTextBox2.CustomButton.Image = null;
            this.poisonTextBox2.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.poisonTextBox2.CustomButton.Name = "";
            this.poisonTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.poisonTextBox2.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.poisonTextBox2.CustomButton.TabIndex = 1;
            this.poisonTextBox2.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.poisonTextBox2.CustomButton.UseSelectable = true;
            this.poisonTextBox2.CustomButton.Visible = false;
            this.poisonTextBox2.Lines = new string[0];
            this.poisonTextBox2.Location = new System.Drawing.Point(205, 373);
            this.poisonTextBox2.MaxLength = 11;
            this.poisonTextBox2.Name = "poisonTextBox2";
            this.poisonTextBox2.PasswordChar = '\0';
            this.poisonTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.poisonTextBox2.SelectedText = "";
            this.poisonTextBox2.SelectionLength = 0;
            this.poisonTextBox2.SelectionStart = 0;
            this.poisonTextBox2.ShortcutsEnabled = true;
            this.poisonTextBox2.Size = new System.Drawing.Size(142, 23);
            this.poisonTextBox2.TabIndex = 4;
            this.poisonTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.poisonTextBox2.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.poisonTextBox2.UseSelectable = true;
            this.poisonTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.poisonTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Italic);
            this.poisonTextBox2.TextChanged += new System.EventHandler(this.PoisonTextBox2_TextChanged);
            // 
            // poisonButton2
            // 
            this.poisonButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.poisonButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.poisonButton2.Enabled = false;
            this.poisonButton2.Location = new System.Drawing.Point(205, 402);
            this.poisonButton2.Name = "poisonButton2";
            this.poisonButton2.Size = new System.Drawing.Size(142, 55);
            this.poisonButton2.TabIndex = 3;
            this.poisonButton2.Text = "Kontrol Et";
            this.poisonButton2.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.poisonButton2.UseSelectable = true;
            this.poisonButton2.Click += new System.EventHandler(this.PoisonButton2_Click);
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.Location = new System.Drawing.Point(23, 470);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(101, 19);
            this.poisonLabel1.TabIndex = 5;
            this.poisonLabel1.Text = "Eleman Sayısı: 0";
            this.poisonLabel1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonButton3
            // 
            this.poisonButton3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.poisonButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.poisonButton3.Enabled = false;
            this.poisonButton3.Location = new System.Drawing.Point(204, 206);
            this.poisonButton3.Name = "poisonButton3";
            this.poisonButton3.Size = new System.Drawing.Size(142, 55);
            this.poisonButton3.TabIndex = 6;
            this.poisonButton3.Text = "Listeyi Temizle";
            this.poisonButton3.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.poisonButton3.UseSelectable = true;
            this.poisonButton3.Click += new System.EventHandler(this.PoisonButton3_Click);
            // 
            // poisonLabel2
            // 
            this.poisonLabel2.AutoSize = true;
            this.poisonLabel2.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.poisonLabel2.ForeColor = System.Drawing.Color.Lime;
            this.poisonLabel2.Location = new System.Drawing.Point(232, 470);
            this.poisonLabel2.Name = "poisonLabel2";
            this.poisonLabel2.Size = new System.Drawing.Size(89, 19);
            this.poisonLabel2.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            this.poisonLabel2.TabIndex = 7;
            this.poisonLabel2.Text = "Doğrulandı!";
            this.poisonLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.poisonLabel2.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.poisonLabel2.UseCustomForeColor = true;
            this.poisonLabel2.Visible = false;
            // 
            // poisonLabel3
            // 
            this.poisonLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.poisonLabel3.AutoSize = true;
            this.poisonLabel3.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.poisonLabel3.ForeColor = System.Drawing.Color.Red;
            this.poisonLabel3.Location = new System.Drawing.Point(222, 470);
            this.poisonLabel3.Name = "poisonLabel3";
            this.poisonLabel3.Size = new System.Drawing.Size(110, 19);
            this.poisonLabel3.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            this.poisonLabel3.TabIndex = 8;
            this.poisonLabel3.Text = "Doğrulanmadı!";
            this.poisonLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.poisonLabel3.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.poisonLabel3.UseCustomForeColor = true;
            this.poisonLabel3.Visible = false;
            // 
            // poisonButton4
            // 
            this.poisonButton4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.poisonButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.poisonButton4.Enabled = false;
            this.poisonButton4.Location = new System.Drawing.Point(204, 267);
            this.poisonButton4.Name = "poisonButton4";
            this.poisonButton4.Size = new System.Drawing.Size(142, 55);
            this.poisonButton4.TabIndex = 9;
            this.poisonButton4.Text = "Liste Kontrol";
            this.poisonButton4.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.poisonButton4.UseSelectable = true;
            this.poisonButton4.Click += new System.EventHandler(this.PoisonButton4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Job
            // 
            this.Job.WorkerReportsProgress = true;
            this.Job.WorkerSupportsCancellation = true;
            this.Job.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Job_Work);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(369, 503);
            this.Controls.Add(this.poisonButton4);
            this.Controls.Add(this.poisonLabel3);
            this.Controls.Add(this.poisonLabel2);
            this.Controls.Add(this.poisonButton3);
            this.Controls.Add(this.poisonLabel1);
            this.Controls.Add(this.poisonTextBox2);
            this.Controls.Add(this.poisonButton2);
            this.Controls.Add(this.poisonTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.poisonButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Text = "TCNO v1.7";
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Close);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonButton poisonButton1;
        private System.Windows.Forms.ListBox listBox1;
        private ReaLTaiizor.Controls.PoisonTextBox poisonTextBox1;
        private ReaLTaiizor.Controls.PoisonTextBox poisonTextBox2;
        private ReaLTaiizor.Controls.PoisonButton poisonButton2;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.PoisonButton poisonButton3;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel2;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel3;
        private ReaLTaiizor.Controls.PoisonButton poisonButton4;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker Job;
    }
}