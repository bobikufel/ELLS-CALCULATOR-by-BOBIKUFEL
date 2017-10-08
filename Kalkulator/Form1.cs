using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        long MEMORY = 0;
        int licznik = 0;
        long dolna = 0;
        long gorna = 0;
        char znaq = ' ';
        public Form1()
        {
            InitializeComponent();
            refresh();
        }

        private void refresh()
        {
            if (gorna < 0)
            {
                long tmp = gorna * -1;
                gora.Text = tmp.ToString() + '-';
            }
            else
            {
                gora.Text = gorna.ToString();
            }
            if (dolna < 0)
            {
                long tmp = dolna * -1;
                dol.Text = tmp.ToString() + '-';
            }
            else
            {
                dol.Text = dolna.ToString();
            }
            znak.Text = znaq.ToString();
        }

        private void wpisz(int znaczek)
        {
            if (licznik < 16)
            {
                if (dolna >= 0)
                {
                    dolna = dolna * 10 + znaczek;
                }
                else
                { 
                    dolna = dolna * 10 - znaczek;
                }
                refresh();
                if (dolna != 0)
                { 
                licznik++;
                }
            }
            else
            {                
                ERROR.Text = "NIE WIECEJ NIŻ 16";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void numer1_Click(object sender, EventArgs e)
        {
            wpisz(1);
        }    
    
        private void button2_Click(object sender, EventArgs e)
        {
            wpisz(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wpisz(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wpisz(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            wpisz(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            wpisz(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            wpisz(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            wpisz(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            wpisz(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            wpisz(0);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            dolna = 0;
            gorna = 0;
            znaq = ' ';
            refresh();
            licznik = 0;
            ERROR.Text = " ";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            dolna = dolna / 10;
            ERROR.Text = " ";
            refresh();
            if (dolna != 0)
            { 
            licznik--;
            }
        }

        private void wylicz(char znaczek)
        {
            bool przezzero = false;
            if (znaq == ' ')
            {
                gorna = dolna;
            }
            if (znaq == '+')
            {
                gorna = gorna + dolna;
            }
            if (znaq == '-')
            {
                gorna = gorna - dolna;
            }
            if (znaq == '*')
            {
                gorna = gorna * dolna;
            }
            if (znaq == '/')
            {
                if (dolna != 0)
                {
                    gorna = gorna / dolna;
                }
                else
                {
                    przezzero = true;
                }
            }


            znaq = znaczek;
            dolna = 0;
            if (przezzero == true)
            { 
                ERROR.Text = "NIE DZIEL PRZEZ 0 DEBILU";
            }
            else
            {
                ERROR.Text = " ";
            }
            refresh();
            licznik = 0;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            wylicz('+');
        }

        private void button14_Click(object sender, EventArgs e)
        {
            wylicz('-');
        }

        private void button15_Click(object sender, EventArgs e)
        {
            wylicz('*');
        }

        private void button16_Click(object sender, EventArgs e)
        {
            wylicz('/');
        }

        private void plusminus_Click(object sender, EventArgs e)
        {
            dolna = dolna * -1;
            refresh();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            wylicz(' ');
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            dolna = gorna;
            gorna = 0;
            refresh();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MEMORY = gorna;
            refresh();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            dolna = MEMORY;
            refresh();
        }
    }
}
