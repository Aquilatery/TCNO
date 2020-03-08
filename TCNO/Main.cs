using TCN;
using System;
using MetroFramework;
using System.Windows.Forms;

namespace TCNO
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        static readonly NO TCN = new NO();

        public Main()
        {
            InitializeComponent();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (Job.IsBusy)
                Job.CancelAsync();
            else
                Job.RunWorkerAsync();
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            Kontrol(metroTextBox2.Text);
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            metroLabel1.Text = "Eleman Sayısı: 0";
            metroTextBox2.Text = "";
            metroButton2.Enabled = false;
            metroLabel2.Visible = false;
            metroLabel3.Visible = false;
            metroButton3.Enabled = false;
            metroButton4.Enabled = false;
        }

        private void MetroButton4_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                Kontrol2();
            else if (listBox1.Items.Count >= 1)
            {
                listBox1.SelectedIndex = 0;
                metroButton1.Enabled = false;
                metroButton2.Enabled = false;
                metroButton3.Enabled = false;
                metroTextBox1.Enabled = false;
                metroTextBox2.Enabled = false;
                timer1.Enabled = true;
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
                metroTextBox2.Text = listBox1.SelectedItem.ToString();
        }

        private void Kontrol(string TXT, bool EXEC = false)
        {
            try
            {
                if (!String.IsNullOrEmpty(TXT) && !String.IsNullOrWhiteSpace(TXT) && TXT.Length == 11 && !TXT.Contains(" "))
                {
                    ulong Count = Convert.ToUInt64(TXT);
                    if (TCN.Check(TXT))
                    {
                        metroLabel2.Visible = true;
                        metroLabel3.Visible = false;
                        if (EXEC)
                            listBox1.SelectedIndex++;
                    }
                    else
                    {
                        metroLabel2.Visible = false;
                        metroLabel3.Visible = true;
                        Kontrol2();
                    }
                }
                else
                {
                    if (timer1.Enabled)
                        Kontrol2();
                    MetroMessageBox.Show(this, "Kontrol Edilecek TC NO Belirtiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                if (timer1.Enabled)
                    Kontrol2();
                MetroMessageBox.Show(this, "Hatalı Bir TC NO Girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Kontrol2()
        {
            timer1.Enabled = false;
            metroTextBox1.Enabled = true;
            BTN1();
            metroTextBox2.Enabled = true;
            BTN2();
            LBX1();
        }

        private void MetroTextBox1_TextChanged(object sender, EventArgs e)
        {
            BTN1();
        }

        private void MetroTextBox2_TextChanged(object sender, EventArgs e)
        {
            BTN2();
        }

        private void BTN1()
        {
            if (metroTextBox1.Text.Length > 0 && !metroTextBox1.Text.StartsWith("0"))
                metroButton1.Enabled = true;
            else
                metroButton1.Enabled = false;
        }

        private void BTN2()
        {
            if (metroTextBox2.Text.Length == 11 && !timer1.Enabled)
                metroButton2.Enabled = true;
            else
                metroButton2.Enabled = false;
        }

        private void LBX1()
        {
            if (listBox1.Items.Count > 0)
                metroButton3.Enabled = true;
            else
                metroButton3.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == listBox1.Items.Count - 1)
            {
                Kontrol(listBox1.SelectedItem.ToString());
                Kontrol2();
            }
            else
                Kontrol(listBox1.SelectedItem.ToString(), true);
        }

        private void Job_Work(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(metroTextBox1.Text) && !String.IsNullOrWhiteSpace(metroTextBox1.Text) && !metroTextBox1.Text.StartsWith("0") && !metroTextBox1.Text.Contains(" "))
                {
                    int Count = Convert.ToInt32(metroTextBox1.Text);
                    Random RNDM = new Random();
                    for (int C = 0; C < Count; C++)
                    {
                        string GTCN = TCN.Create(RNDM);
                        if (!listBox1.Items.Contains(GTCN))
                        {
                            listBox1.Items.Add(GTCN);
                            metroLabel1.Text = "Eleman Sayısı: " + listBox1.Items.Count;
                            listBox1.SelectedIndex = listBox1.Items.Count - 1;
                        }
                        else
                            C--;
                    }
                    metroButton3.Enabled = true;
                    metroButton4.Enabled = true;
                }
                else
                    MetroMessageBox.Show(this, "Üretilecek TC NO Sayısını Belirtiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MetroMessageBox.Show(this, "Hatalı Bir TC NO Sayısı Girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Main_Close(object sender, FormClosingEventArgs e)
        {
            if (Job.IsBusy)
                e.Cancel = true;
        }
    }
}