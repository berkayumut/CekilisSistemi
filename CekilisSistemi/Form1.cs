using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CekilisSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            listKatilimci.Items.Add(txtKatilimci.Text);
            txtKatilimci.Text = "";
            txtKatilimci.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listKatilimci.Items.RemoveAt(listKatilimci.SelectedIndex);
        }

        private void btnCekilisYap_Click(object sender, EventArgs e)
        {
            try
            {
                int kazananSayisi = int.Parse(txtKazananSayi.Text);
                int yedekSayisi = int.Parse(txtYedekSayi.Text);
                if (kazananSayisi + yedekSayisi > listKatilimci.Items.Count)
                {
                    MessageBox.Show("Bu Kadar Katılımcı Yok.");
                }
                else
                {
                    for (int i = 0; i < kazananSayisi; i++)
                    {
                        int kazananIndex = rnd.Next(listKatilimci.Items.Count);
                        string kazanaKisi = listKatilimci.Items[kazananIndex].ToString();
                        listKazanan.Items.Add(kazanaKisi);
                        listKatilimci.Items.RemoveAt(kazananIndex);
                    }
                    for (int i = 0; i < yedekSayisi; i++)
                    {
                        int yedekIndex = rnd.Next(listKatilimci.Items.Count);
                        string yedekKisi = listKatilimci.Items[yedekIndex].ToString();
                        listYedek.Items.Add(yedekKisi);
                        listKatilimci.Items.RemoveAt(yedekIndex);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hatalı İşlem Yaptınız.");
            }
            
            
        }
    }
}
