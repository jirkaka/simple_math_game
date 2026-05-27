using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programko_prace
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int cislo1;
        string spatnesprava;
        int soucet;
        string zadana;
        int pocet;
        int pocet_cisel;
        string dobresprava;
        string hotovosprava;
        int x = 75;
        int typprikladu;
        int pocet_pokusu;
        string final;
        string pravidla;
        int n; //maximalni cislo pro scitani a odcitani//
        int t; //cas na priklad//
        int m; // minimalni cislo pro scitani a odcitani//
        int pn; //maximalni cislo pro nasobeni//
        int pocetboxu = 0;
        int pm; //minimalni cislo pro nasobeni//
        int pocet_vyher;
        int op; //nejvetsi cislo pro scitani a odcitani//
        int ip; //nejmensi cislo pro scitani a odcitani//
        int opn; //nejvetsi cislo pro nasobeni//
        int ipn; //nejmensi cislo pro nasobeni//
        int od; //cislo pro odcitani//
        string zpravaproodcitani;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_normal.Checked == true)
            {
                pocetboxu++;
            }
            else if (checkBox_normal.Checked == false)
            {
                pocetboxu--;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pravidla += "Pravidla hry:";
            pravidla += Environment.NewLine;
            pravidla += Environment.NewLine;
            pravidla += Environment.NewLine;
            pravidla += "klikněte na tlačitko start a postupujte podle pokynů";
            pravidla += Environment.NewLine;
            pravidla += Environment.NewLine;
            pravidla += "pro odeslání odpovědi klikněte na tlačítko confirm";
            pravidla += Environment.NewLine;
            pravidla += Environment.NewLine;
            pravidla += "za správnou odpověď se posunete dopředu, za špatnou se posunete dozadu";
            pravidla += Environment.NewLine;
            pravidla += Environment.NewLine;
            pravidla += "obtížnosti:";
            pravidla += Environment.NewLine;
            pravidla += Environment.NewLine;
            pravidla += "čím větší obtížnost, tím rychlejší a větší budou čísla";
            pravidla += Environment.NewLine;
            pravidla += Environment.NewLine;
            pravidla += "lehka: i při špatný odpovědi se neposouváte dozadu";
            pravidla += Environment.NewLine;
            pravidla += Environment.NewLine;
            pravidla += "normální: při špatný odpovědi se posouváte dozadu o jedno pole";
            pravidla += Environment.NewLine;
            pravidla += Environment.NewLine;
            pravidla += "těžká: při špatný odpovědi se posouváte dozadu o dvě pole";
            pravidla += Environment.NewLine;
            pravidla += Environment.NewLine;
            pravidla += "nemilosrdná: při špatný odpovědi se posouváte na začátek";



            MessageBox.Show(pravidla);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen gray = new Pen(Color.Gray, 5);
            g.FillRectangle(Brushes.IndianRed, 50, 100, 100, 100);
            g.DrawRectangle(gray, 50, 100, 100, 100);
            g.FillRectangle(Brushes.YellowGreen, 150, 100, 100, 100);
            g.DrawRectangle(gray, 150, 100, 100, 100);
            g.FillRectangle(Brushes.YellowGreen, 250, 100, 100, 100);
            g.DrawRectangle(gray, 250, 100, 100, 100);
            g.FillRectangle(Brushes.YellowGreen, 350, 100, 100, 100);
            g.DrawRectangle(gray, 350, 100, 100, 100);
            g.FillRectangle(Brushes.YellowGreen, 450, 100, 100, 100);
            g.DrawRectangle(gray, 450, 100, 100, 100);
            g.FillRectangle(Brushes.YellowGreen, 550, 100, 100, 100);
            g.DrawRectangle(gray, 550, 100, 100, 100);
            g.FillRectangle(Brushes.YellowGreen, 550, 100, 100, 100);
            g.DrawRectangle(gray, 550, 100, 100, 100);
            g.FillRectangle(Brushes.Khaki, 650, 100, 100, 100);
            g.DrawRectangle(gray, 650, 100, 100, 100);
            g.FillEllipse(Brushes.Black, x, 125, 50, 50);
        }

        private async void button_start_Click(object sender, EventArgs e)
        {
            checkBox_lehka.Enabled = false;
            checkBox_normal.Enabled = false;
            checkBox_tezka.Enabled = false;
            checkBox_nemilosrdna.Enabled = false;
            button_start.Enabled = false;
            if (pocetboxu > 1)
            {
                MessageBox.Show("Vyberte pouze jednu obtížnost!");
                checkBox_normal.Enabled = true;
                checkBox_lehka.Enabled = true;
                checkBox_tezka.Enabled = true;
                checkBox_nemilosrdna.Enabled = true;
                button_start.Enabled = true;

                return;
            }
            typprikladu = rnd.Next(1, 4);
            if (checkBox_lehka.Checked == false && checkBox_normal.Checked == false && checkBox_tezka.Checked == false && checkBox_nemilosrdna.Checked == false)
            {
                MessageBox.Show("Vyberte obtížnost!");
                button_start.Enabled = true;
                checkBox_normal.Enabled = true;
                checkBox_lehka.Enabled = true;
                checkBox_tezka.Enabled = true;
                checkBox_nemilosrdna.Enabled = true;
                button_start.Enabled = true;
                return;
            }


            if (checkBox_lehka.Checked == true)
            {
                n = 5;
                t = 2000;
                m = 1;
                pn = 3;
                pm = 2;
                ip = 2;
                op = 11;
                ipn = 2;
                opn = 6;
                od = 100;
                zpravaproodcitani = "Odečítej čísla od stovky";

            }
            else if (checkBox_normal.Checked == true)
            {
                n = 5;
                t = 1000;
                m = 5;
                pn = 5;
                pm = 2;
                ip = 2;
                op = 13;
                ipn = 2;
                opn = 6;
                od = 100;
                zpravaproodcitani = "Odečítej čísla od stovky";
            }
            else if (checkBox_tezka.Checked == true)
            {
                n = 12;
                t = 700;
                m = 7;
                pn = 5;
                pm = 3;
                ip = 3;
                op = 16;
                ipn = 3;
                opn = 6;
                od = 1000;
                zpravaproodcitani = "Odečítej čísla od tisícovky";
            }
            else
            {
                n = 14;
                t = 500;
                m = 10;
                pn = 6;
                pm = 4;
                ip = 3;
                op = 21;
                ipn = 4;
                opn = 11;
                od = 1000;
                zpravaproodcitani = "Odečítej čísla od tisícovky";
            }



            pocet_pokusu++;
            if (typprikladu == 1)
            {///scitani/////////////////////////////////////////////////////////////////////////////////////////////////
                label_typhry.Text = "Sčítej";
                MessageBox.Show("sčítej čísla");
                pocet_cisel = rnd.Next(m, n);

                soucet = 0;
                pocet = 0;


                do
                {

                    cislo1 = rnd.Next(ip, op);



                    soucet += cislo1;
                    textBox_cisla.Text = cislo1.ToString();
                    Refresh();
                    await Task.Delay(t);

                    //mezera mezi cisly
                    textBox_cisla.Text = "";
                    Refresh();
                    await Task.Delay(300);


                    pocet++;
                }
                while (pocet < pocet_cisel);

                hotovosprava += "Hotovo!";
                hotovosprava += Environment.NewLine;
                hotovosprava += "Zadej výsledek!";
                await Task.Delay(500);
                textBox_cisla.Text = "";
                MessageBox.Show(hotovosprava);

                textBox_soucet.Enabled = true;
            }
            if (typprikladu == 2)
            {///odcitani///////////////////////////////////////////////////////////////////////////////////////////////////
                label_typhry.Text = "odečítej";
                MessageBox.Show(zpravaproodcitani);
                pocet_cisel = rnd.Next(m, n);

                soucet = od;
                pocet = 0;


                do
                {

                    cislo1 = rnd.Next(ip, op);



                    soucet -= cislo1;
                    textBox_cisla.Text = cislo1.ToString();
                    Refresh();
                    await Task.Delay(t);

                    //mezera mezi cisly
                    textBox_cisla.Text = "";
                    Refresh();
                    await Task.Delay(300);


                    pocet++;
                }
                while (pocet < pocet_cisel);

                hotovosprava += "Hotovo!";
                hotovosprava += Environment.NewLine;
                hotovosprava += "Zadej výsledek!";
                await Task.Delay(500);
                textBox_cisla.Text = "";
                MessageBox.Show(hotovosprava);

                textBox_soucet.Enabled = true;
            }
            if (typprikladu == 3)
            { ////nasobeni//////////////////////////////////////////////////////////////////////////////////////////////////// 
                label_typhry.Text = "Násob";
                MessageBox.Show("Násob čísla");
                pocet_cisel = rnd.Next(pm, pn);

                soucet = 1;
                pocet = 0;


                do
                {

                    cislo1 = rnd.Next(ipn, opn);

                    soucet *= cislo1;


                    textBox_cisla.Text = cislo1.ToString();
                    Refresh();
                    await Task.Delay(t);

                    //mezera mezi cisly
                    textBox_cisla.Text = "";
                    Refresh();
                    await Task.Delay(300);


                    pocet++;
                }
                while (pocet < pocet_cisel);

                hotovosprava += "Hotovo!";
                hotovosprava += Environment.NewLine;
                hotovosprava += "Zadej výsledek";
                await Task.Delay(500);
                textBox_cisla.Text = "";
                MessageBox.Show(hotovosprava);

                textBox_soucet.Enabled = true;
                button_confirm.Enabled = true;

            }
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            button_start.Enabled = true;
            zadana = textBox_soucet.Text;
            label_typhry.Text = "";

            if (zadana == soucet.ToString())
            {
                dobresprava += "Správně!";
                dobresprava += Environment.NewLine;
                dobresprava += Environment.NewLine;

                MessageBox.Show(dobresprava);
                x += 100;
            }
            else
            {
                spatnesprava += "Špatně!";
                spatnesprava += Environment.NewLine;
                spatnesprava += Environment.NewLine;
                spatnesprava += "Správná odpověď je: " + soucet.ToString();

                MessageBox.Show(spatnesprava);
                if (checkBox_nemilosrdna.Checked == true)
                {
                    x = 75;
                }
                else if (checkBox_normal.Checked == true)
                {
                    x -= 100;
                }
                else if (checkBox_tezka.Checked == true)
                {
                    x -= 200;
                }

            }
            soucet = 0;
            pocet = 0;
            hotovosprava = "";
            spatnesprava = "";
            dobresprava = "";
            textBox_soucet.Text = "";
            textBox_cisla.Text = "";
            if (x < 75)
            {
                x = 75;
            }

            Refresh();
            if (x >= 650)
            {
                x = 650;
                final += "Vyhrály jste!";
                final += Environment.NewLine;
                final += "Počet pokusů: " + pocet_pokusu.ToString();
                MessageBox.Show(final);
                x = 75;
                MessageBox.Show("Hra se restartuje");
                pocet_pokusu = 0;
                pocet_vyher++;
                label_vyhry.Text = pocet_vyher.ToString();
                checkBox_lehka.Checked = false;
                checkBox_lehka.Enabled = true;
                checkBox_normal.Checked = false;
                checkBox_normal.Enabled = true;
                checkBox_tezka.Checked = false;
                checkBox_tezka.Enabled = true;
                checkBox_nemilosrdna.Checked = false;
                checkBox_nemilosrdna.Enabled = true;



                Refresh();

            }
        }

        private void checkBox_lehka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_lehka.Checked == true)
            {
                pocetboxu++;
            }
            else if (checkBox_lehka.Checked == false)
            {
                pocetboxu--;
            }
        }

        private void checkBox_tezka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_tezka.Checked == true)
            {
                pocetboxu++;
            }
            else if (checkBox_tezka.Checked == false)
            {
                pocetboxu--;
            }
        }

        private void checkBox_nemilosrdna_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_nemilosrdna.Checked == true)
            {
                pocetboxu++;
            }
            else if (checkBox_nemilosrdna.Checked == false)
            {
                pocetboxu--;
            }
        }

        private void button_coward_Click(object sender, EventArgs e)
        {
            x = 75;
            checkBox_lehka.Checked = false;
            checkBox_normal.Checked = false;
            checkBox_tezka.Checked = false;
            checkBox_nemilosrdna.Checked = false;
            checkBox_normal.Enabled = true;
            checkBox_lehka.Enabled = true;
            checkBox_tezka.Enabled = true;
            checkBox_nemilosrdna.Enabled = true;
            button_start.Enabled = true;
            pocet_pokusu = 0;
            Refresh();
        }
    }
}
