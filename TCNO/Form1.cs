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
                }
                else
                    MetroMessageBox.Show(this, "Üretilecek TC NO Sayısını Belirtiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "Hatalı Bir TC NO Girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(metroTextBox2.Text) && !String.IsNullOrWhiteSpace(metroTextBox2.Text) && metroTextBox2.Text.Length == 11 && !metroTextBox2.Text.Contains(" "))
                {
                    ulong Count = Convert.ToUInt64(metroTextBox2.Text);
                    if (TCN.Check(metroTextBox2.Text))
                    {
                        metroLabel2.Visible = true;
                        metroLabel3.Visible = false;
                    }
                    else
                    {
                        metroLabel2.Visible = false;
                        metroLabel3.Visible = true;
                    }
                }
                else
                    MetroMessageBox.Show(this, "Kontrol Edilecek TC NO Belirtiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "Hatalı Bir TC NO Girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            metroLabel1.Text = "Eleman Sayısı: 0";
            metroTextBox2.Text = "";
            Count2 = 0;
            metroLabel2.Visible = false;
            metroLabel3.Visible = false;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroTextBox2.Text = listBox1.SelectedItem.ToString();
        }
    }
}