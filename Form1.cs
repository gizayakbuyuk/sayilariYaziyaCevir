using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayıları_Yazıya_Çevir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxSayi_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBoxSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true; // basılan tuş iptal edilir
            //e.Handled = false; // basılan tuş kabul edilir
            int tus = (int)e.KeyChar;
            if ((tus > 47 && tus < 58) || (tus == 8) )
                e.Handled = false;
            else
                e.Handled = true;
            
        }

        private void textBoxSayi_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCevir_Click(object sender, EventArgs e)
        {
            string[] birler = { "sıfır", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] onlar = { "","on", "yirmi", "otuz", "kırk", "elli", "atmış", "yetmiş", "seksen", "doksan" };

            string sayi = textBoxSayi.Text.PadLeft(4,'0');

            int[] bsmk = new int[sayi.Length];
            for (int i = 0; i < sayi.Length; i++)
                bsmk[i] = int.Parse(sayi[3-i].ToString());

            textBoxMetin.Text = ((bsmk[3] == 0) ? "" : ((bsmk[3] == 1) ? "bin" : birler[bsmk[3]] + "bin")) + ((bsmk[2] == 0) ? "" : ((bsmk[2] == 1) ? "yüz" : birler[bsmk[2]] + "yüz")) + onlar[bsmk[1]] + ((bsmk[0] == 0) ? "" : birler[bsmk[0]]);


        }
    }
}
