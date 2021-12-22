using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using TCN;

namespace TCNO
{
    public partial class Main : PoisonForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void PoisonButton1_Click(object sender, EventArgs e)
        {
            if (Job.IsBusy)
            {
                Job.CancelAsync();
            }
            else
            {
                Job.RunWorkerAsync();
            }
        }

        private void PoisonButton2_Click(object sender, EventArgs e)
        {
            Kontrol(poisonTextBox2.Text);
        }

        private void PoisonButton3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            poisonLabel1.Text = "Eleman Sayısı: 0";
            poisonTextBox2.Text = "";
            poisonButton2.Enabled = false;
            poisonLabel2.Visible = false;
            poisonLabel3.Visible = false;
            poisonButton3.Enabled = false;
            poisonButton4.Enabled = false;
        }

        private void PoisonButton4_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                Kontrol2();
            }
            else if (listBox1.Items.Count >= 1)
            {
                listBox1.SelectedIndex = 0;
                poisonButton1.Enabled = false;
                poisonButton2.Enabled = false;
                poisonButton3.Enabled = false;
                poisonTextBox1.Enabled = false;
                poisonTextBox2.Enabled = false;
                timer1.Enabled = true;
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                poisonTextBox2.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void Kontrol(string TXT, bool EXEC = false)
        {
            try
            {
                if (!string.IsNullOrEmpty(TXT) && !string.IsNullOrWhiteSpace(TXT) && TXT.Length == 11 && !TXT.Contains(" "))
                {
                    ulong Count = Convert.ToUInt64(TXT);
                    if (NO.Check(TXT))
                    {
                        poisonLabel2.Visible = true;
                        poisonLabel3.Visible = false;
                        if (EXEC)
                        {
                            listBox1.SelectedIndex++;
                        }
                    }
                    else
                    {
                        poisonLabel2.Visible = false;
                        poisonLabel3.Visible = true;
                        Kontrol2();
                    }
                }
                else
                {
                    if (timer1.Enabled)
                    {
                        Kontrol2();
                    }

                    PoisonMessageBox.Show(this, "Kontrol Edilecek TC NO Belirtiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                if (timer1.Enabled)
                {
                    Kontrol2();
                }

                PoisonMessageBox.Show(this, "Hatalı Bir TC NO Girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Kontrol2()
        {
            timer1.Enabled = false;
            poisonTextBox1.Enabled = true;
            BTN1();
            poisonTextBox2.Enabled = true;
            BTN2();
            LBX1();
        }

        private void PoisonTextBox1_TextChanged(object sender, EventArgs e)
        {
            BTN1();
        }

        private void PoisonTextBox2_TextChanged(object sender, EventArgs e)
        {
            BTN2();
        }

        private void BTN1()
        {
            if (poisonTextBox1.Text.Length > 0 && !poisonTextBox1.Text.StartsWith("0"))
            {
                poisonButton1.Enabled = true;
            }
            else
            {
                poisonButton1.Enabled = false;
            }
        }

        private void BTN2()
        {
            if (poisonTextBox2.Text.Length == 11 && !timer1.Enabled)
            {
                poisonButton2.Enabled = true;
            }
            else
            {
                poisonButton2.Enabled = false;
            }
        }

        private void LBX1()
        {
            if (listBox1.Items.Count > 0)
            {
                poisonButton3.Enabled = true;
            }
            else
            {
                poisonButton3.Enabled = false;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == listBox1.Items.Count - 1)
            {
                Kontrol(listBox1.SelectedItem.ToString());
                Kontrol2();
            }
            else
            {
                Kontrol(listBox1.SelectedItem.ToString(), true);
            }
        }

        private void Job_Work(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(poisonTextBox1.Text) && !string.IsNullOrWhiteSpace(poisonTextBox1.Text) && !poisonTextBox1.Text.StartsWith("0") && !poisonTextBox1.Text.Contains(" "))
                {
                    poisonButton3.Enabled = false;
                    poisonButton4.Enabled = false;
                    int Count = Convert.ToInt32(poisonTextBox1.Text);
                    Random RNDM = new();
                    for (int C = 0; C < Count; C++)
                    {
                        string GTCN = NO.Create(RNDM);
                        if (!listBox1.Items.Contains(GTCN))
                        {
                            listBox1.Items.Add(GTCN);
                            poisonLabel1.Text = "Eleman Sayısı: " + listBox1.Items.Count;
                            listBox1.SelectedIndex = listBox1.Items.Count - 1;
                        }
                        else
                        {
                            C--;
                        }
                    }

                    poisonButton3.Enabled = true;
                    poisonButton4.Enabled = true;
                }
                else
                {
                    PoisonMessageBox.Show(this, "Üretilecek TC NO Sayısını Belirtiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                PoisonMessageBox.Show(this, "Hatalı Bir TC NO Sayısı Girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Main_Close(object sender, FormClosingEventArgs e)
        {
            if (Job.IsBusy)
            {
                e.Cancel = true;
            }
        }
    }
}