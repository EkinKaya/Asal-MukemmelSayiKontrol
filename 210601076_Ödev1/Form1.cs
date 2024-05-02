using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesne_ödevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool Dogrula(int sayi1, int sayi2)
        {
            if (sayi2 >= sayi1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Hata! Başlangıç sayısı bitiş sayısından küçük olmalı.");
                return false;
            }
        }
        private bool Dogrula2(int sayi1, int sayi2)
        {
            if (sayi1 <= 1000 && sayi1 >= 1)
            {
                if (sayi2 <= 1000 && sayi2 >= 1)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Hata! Sayı 1 ile 1000 arasında olmalı.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Hata! Sayı 1 ile 1000 arasında olmalı.");
                return false;
            }
        }
        private bool AsalSayiKontrol(int sayi)
        {
            int kontrol = 0;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    kontrol = 1;
                    break;
                }
            }
            if (kontrol == 1)
            {
                return false;
            }
            return true;
        }

        private bool MukemmelSayiKontrol(int sayi)
        {
            int toplam = 0;
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }
            }
            if (sayi == toplam)
            {
                return true;
            }
            return false;
        }
        private void btnSonuc_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, ciftSayac = 0, tekSayac = 0, fark;
            int ciftToplam = 0, tekToplam = 0, ciftCarpım = 1, tekCarpım = 1, asalToplam = 0, asalCarpım = 0;
            int mukemmelToplam = 0, mukemmelCarpım = 0;

            sayi1 = Convert.ToInt32(maskedTextBox1.Text);
            sayi2 = Convert.ToInt32(maskedTextBox2.Text);
            fark = sayi2 - sayi1;

            if (Dogrula(sayi1, sayi2) == true)
            {
                if (Dogrula(sayi1, sayi2) == true)
                {
                    int[] tek = new int[fark];
                    int[] cift = new int[fark];

                    for (int k = sayi1; k <= sayi2; k++)
                    {
                        if (k % 2 == 0)
                        {
                            cift[ciftSayac] = k;
                            ciftSayac++;

                            ciftToplam += k;
                            ciftCarpım *= k;
                        }
                        else
                        {
                            tek[tekSayac] = k;
                            tekSayac++;

                            tekToplam += k;
                            tekCarpım *= k;
                        }
                        if (AsalSayiKontrol(k) == true)
                        {
                            asalToplam += k;
                            asalCarpım *= k;
                            listAsalSayılar.Items.Add("Asal Sayılar: " + k + asalToplam + asalCarpım);
                        }

                        if (MukemmelSayiKontrol(k) == true)
                        {

                            mukemmelToplam += k;
                            mukemmelCarpım *= k;

                            listMukemmelSayılar.Items.Add("Mükemmel Sayılar: " + k + mukemmelToplam + mukemmelCarpım);
                        }
                    }
                    listCiftSayılar.Items.Add("Cift Sayılar: " + cift + ciftToplam + ciftCarpım);
                    listTekSayılar.Items.Add("Tek Sayılar: " + tek + tekToplam + tekCarpım);
                }
            }
        }
    }
}
