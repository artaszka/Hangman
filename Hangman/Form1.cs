using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class form1 : Form
    {
        string slowo;
        int ilePudel=0;

        public form1()
        {
            InitializeComponent();
            Losuj_Slowo();
        }
                
        private void button1_Click(object sender, EventArgs e)
        {
            string litera = tbLitera.Text;
            bool trafiona = false;
            int ktoraLitera = 0;

            for (int i = 1; i<6; i++)
            {
                if ( litera == Convert.ToString(slowo[i]))
                {
                    trafiona = true;
                    ktoraLitera = i;
                    if ( ktoraLitera==1) { litera2.Text = litera; }
                    if (ktoraLitera == 2) { litera3.Text = litera; }
                    if (ktoraLitera == 3) { litera4.Text = litera; }
                    if (ktoraLitera == 4) { litera5.Text = litera; }
                    if (ktoraLitera == 5) { litera6.Text = litera; }
                }
            }
            if (trafiona==false)
            {
                ilePudel++;
                if (ilePudel == 1) { pictureBox1.Image = Hangman.Properties.Resources.wisi1; }
                if (ilePudel == 2) { pictureBox1.Image = Hangman.Properties.Resources.wisi2; }
                if (ilePudel == 3) { pictureBox1.Image = Hangman.Properties.Resources.wisi3; }
                if (ilePudel == 4) { pictureBox1.Image = Hangman.Properties.Resources.wisi4; }
                if (ilePudel == 5) { pictureBox1.Image = Hangman.Properties.Resources.wisi5; }
                if (ilePudel == 6) { pictureBox1.Image = Hangman.Properties.Resources.end1; }

            }
        }

        private void Losuj_Slowo()
        {
            string[] slownik =
            {
                "krokusy",
                "liliput",
                "marchew",
                "selerek",
                "krakers",
                "klakier",
                "kosmita",
                "alkomat",
                "pacynka",
                "pieczeń",
                "padalec",
                "padlina",
                "pagórek",
                "pajacyk",
                "pianino",
                "Biebrza",
                "biegacz",
                "kobieta",
            };
            int ile_slow = slownik.Length;

            Random gen = new Random();
            int indeks_slowa = gen.Next(0, ile_slow);
            slowo = slownik[indeks_slowa];
            litera1.Text = Convert.ToString(slowo[0]);
            litera7.Text = Convert.ToString(slowo[6]);
        }
    }
}
