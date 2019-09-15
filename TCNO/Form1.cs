using MetroFramework;
using System;
using System.Windows.Forms;
using TCN;

namespace TCNO
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        static readonly NO TCN = new NO();

        int Count2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(metroTextBox1.Text) && !String.IsNullOrWhiteSpace(metroTextBox1.Text) && !metroTextBox1.Text.StartsWith("0") && !metroTextBox1.Text.Contains(" "))
                {
                    Int32 Count = Convert.ToInt32(metroTextBox1.Text);
                    Count2 += Count;
                    Random Random = new Random();
                    for (int C = 0; C < Count; C++)
                        listBox1.Items.Add(TCN.Create(Random));
                    metroLabel1.Text = "Eleman Sayısı: " + Count2;
                    metroButton4.Enabled = true;
                }
                else
                    MetroMessageBox.Show(this, "Üretilecek TC NO Sayısını Belirtiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Hatalı Bir TC NO Girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            Count2 = 0;
            metroLabel2.Visible = false;
            metroLabel3.Visible = false;
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
            catch (Exception)
            {
                if (timer1.Enabled)
                    Kontrol2();
                MetroMessageBox.Show(this, "Hatalı Bir TC NO Girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Kontrol2()
        {
            metroButton1.Enabled = true;
            metroButton2.Enabled = true;
            metroButton3.Enabled = true;
            metroTextBox1.Enabled = true;
            metroTextBox2.Enabled = true;
            timer1.Enabled = false;
        }
    }
}