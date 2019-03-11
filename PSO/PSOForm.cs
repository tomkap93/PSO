
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSO
{
    public partial class PSOForm : Form
    {
        #region Zmienne
        public Thread thread = null;
        public Problem problem;
        public BestPosition[] spisw;
        public Param par;
        public BestPosition GlobalBest;

        public WczytajSettings wczytajSettings = new WczytajSettings();

        Random random = new Random();
        IFunkcja funkcja;
        #endregion
        #region Konstruktor
        public PSOForm()
        {
            InitializeComponent();
            funkcje_cb.Items.Add("Funkcja kwadratowa");
            funkcje_cb.Items.Add("Wielomian x^4-4x^3+5x-1");
            funkcje_cb.Items.Add("Wielomian (x+3)(x-4)x");


            progressBar.Visible = false;
            this.Height -= progressBar.Height;
            progressBar.Height = 0;

             wczytaj.Enabled=wczytajSettings.CheckSettings();
        }

        #endregion


        #region Zdarzenia
        private void funkcje_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (funkcje_cb.SelectedIndex)
            {
                case 0:
                    funkcja = new Funkcje.Kwadratowa();
                    break;

                case 1:
                    funkcja = new Funkcje.Wielomian();
                    break;
                case 2:
                    funkcja = new Funkcje.Wielomian2();
                    break;



                default:
                    break;
            }

        }
        private void start_Click(object sender, EventArgs e)
        {
            if (funkcja != null)
            {
                thread = new Thread(Nowywatek);
                progressBar.Visible = true;
                progressBar.Height = 23;

                richTextBox.Text = "";
                this.Height += progressBar.Height;
                groupBox1.Enabled = false;
                if (!thread.IsAlive)
                    thread.Start();
               


            }
            else
                MessageBox.Show("Nie została wybrana funkcja", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        private void zapisz_Click(object sender, EventArgs e)
        {
            ZapiszSettings();
        }

        private void wczytaj_Click(object sender, EventArgs e)
        {
            WczytajSet();
        }

        #endregion

        #region ConfigurationManager
        public void ZapiszSettings()
        {
            Zapisz zapisz = new Zapisz();
            try
            {
              

                zapisz.AddandUpdateSettings("funkcje_cb", Convert.ToString(funkcje_cb.SelectedIndex));
                zapisz.AddandUpdateSettings("min_fun_nud", Convert.ToString(min_fun_nud.Value));
                zapisz.AddandUpdateSettings("max_fun_nud", Convert.ToString(max_fun_nud.Value));
                zapisz.AddandUpdateSettings("literacje_nud", Convert.ToString(literacje_nud.Value));
                zapisz.AddandUpdateSettings("populacja_nud", Convert.ToString(populacja_nud.Value));
                zapisz.AddandUpdateSettings("wspolspol_nud", Convert.ToString(wspolspol_nud.Value));
                zapisz.AddandUpdateSettings("wspolbez_nud", Convert.ToString(wspolbez_nud.Value));
                zapisz.AddandUpdateSettings("wspolosob_nud", Convert.ToString(wspolosob_nud.Value));
                zapisz.AddandUpdateSettings("wspoltlumspol_nud", Convert.ToString(wspoltlumspol_nud.Value));
                MessageBox.Show("Zapis zakończoy sukcesem", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("Wystapił błąd podczas zapisu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            wczytaj.Enabled = wczytajSettings.CheckSettings();

        }
        public void WczytajSet()
        {
            try
            {

              

                    funkcje_cb.SelectedIndex = Convert.ToInt32(wczytajSettings.Wczytajdane("funkcje_cb"));
                    min_fun_nud.Value = Convert.ToDecimal(wczytajSettings.Wczytajdane("min_fun_nud"));
                    max_fun_nud.Value = Convert.ToDecimal(wczytajSettings.Wczytajdane("max_fun_nud"));
                    literacje_nud.Value = Convert.ToDecimal(wczytajSettings.Wczytajdane("literacje_nud"));
                    populacja_nud.Value = Convert.ToDecimal(wczytajSettings.Wczytajdane("populacja_nud"));
                    wspolspol_nud.Value = Convert.ToDecimal(wczytajSettings.Wczytajdane("wspolspol_nud"));
                    wspolosob_nud.Value = Convert.ToDecimal(wczytajSettings.Wczytajdane("wspolosob_nud"));
                    wspolbez_nud.Value = Convert.ToDecimal(wczytajSettings.Wczytajdane("wspolbez_nud"));
                    wspoltlumspol_nud.Value = Convert.ToDecimal(wczytajSettings.Wczytajdane("wspoltlumspol_nud"));

                  
                    MessageBox.Show("Odczyt zakończoy sukcesem", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                


            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("Błąd podczas wczytywania danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public string Wczytajdane(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    

       
        #endregion

        #region Watek

        public void Inicjalizacja()
        {
            spisw = new BestPosition[Convert.ToInt32(literacje_nud.Value)];
            problem = new Problem()
            {
                nVar = 1,
                VarMin = Convert.ToInt32(min_fun_nud.Value),
                VarMax = Convert.ToInt32(max_fun_nud.Value)
            };
            par = new Param()
            {
                MaxIterations = Convert.ToInt32(literacje_nud.Value),
                nPop = Convert.ToInt32(populacja_nud.Value),
                w = Convert.ToDouble(wspolbez_nud.Value),
                wdamp = Convert.ToDouble(wspoltlumspol_nud.Value),

                c1 = Convert.ToDouble(wspolosob_nud.Value),
                c2 = Convert.ToDouble(wspolspol_nud.Value)
            };

            GlobalBest = new BestPosition();
        }

        public void ClearProressBar(int max)
        {
            progressBar.Invoke((Action)(() => progressBar.Maximum = 0));
            progressBar.Invoke((Action)(() => progressBar.Maximum = max));
        }
        public void ClearWykres()
        {
            wykres_funkcji.Invoke((Action)(() => wykres_funkcji.Series[0].Points.Clear()));
            wykres_funkcji.Invoke((Action)(() => wykres_funkcji.Series[1].Points.Clear()));
            wykres_wynikow.Invoke((Action)(() => wykres_wynikow.Series[0].Points.Clear()));

        }
        public void Nowywatek()
        {

            Inicjalizacja();
            ClearWykres();

            Particle[] particles = PSO_algorithm.DaneStartowe(problem, par, ref GlobalBest, funkcja);
            for (int j = 0; j < par.MaxIterations; j++)
            {

                particles = PSO_algorithm.MainFloop(particles, problem, par, ref GlobalBest, funkcja);

                par.w = par.w * par.wdamp;
                spisw[j] = GlobalBest;

            }



            int maxprogressBar = (Convert.ToInt32(max_fun_nud.Value) - Convert.ToInt32(min_fun_nud.Value));
            ClearProressBar(maxprogressBar);


            for (int i = Convert.ToInt32(min_fun_nud.Value); i <= Convert.ToInt32(max_fun_nud.Value); i++)
            {
                if (progressBar.Value < maxprogressBar)
                {
                    progressBar.Invoke((Action)(() => progressBar.Value++));
                }

                wykres_funkcji.Invoke((Action)(() => wykres_funkcji.Series[0].Points.AddXY(i, funkcja.Funkcja(i))));

            }

            //wynik[0] = GlobalBest.Cost;
            // wynik[1] = GlobalBest.Position;

            int k = 0;

            double[] wynik = PSO_algorithm.Main_PSO(problem, par, ref spisw, funkcja);

            ClearProressBar(spisw.Length);


            foreach (var item in spisw)
            {
                progressBar.Invoke((Action)(() => progressBar.Value++));


                wykres_funkcji.Invoke((Action)(() => wykres_funkcji.Series[1].Points.Clear()));
                wykres_funkcji.Invoke((Action)(() => wykres_funkcji.Series[1].Points.AddXY(item.Position, funkcja.Funkcja(item.Position))));


                string napis = "Literacja nr " + (++k) + " Y : " + item.Cost.ToString("0.00000000") + " X = " + item.Position.ToString("0.00000") + "\n";

                richTextBox.Invoke((Action)(() => richTextBox.Text += napis));

                wykres_wynikow.Invoke((Action)(() => wykres_wynikow.Series[0].Points.AddXY(k, funkcja.Funkcja(item.Position))));
            }
            string wynik_napis = "Najlepsza literacja Y : " + wynik[0].ToString("0.00000000") + " X = " + wynik[1].ToString("0.00000");


            richTextBox.Invoke((Action)(() => richTextBox.Text += wynik_napis));

            wykres_funkcji.Invoke((Action)(() => wykres_funkcji.Series[1].Points.AddXY(wynik[1], funkcja.Funkcja(wynik[1]))));

            ClearProressBar(0);
            progressBar.Invoke((Action)(() => progressBar.Visible = false));
            this.Invoke((Action)(() => this.Height -= progressBar.Height));
            progressBar.Invoke((Action)(() => progressBar.Height = 0));
            groupBox1.Invoke((Action)(() => groupBox1.Enabled = true));


        }
        #endregion
    }
}
