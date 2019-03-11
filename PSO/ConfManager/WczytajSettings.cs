using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSO
{
 public   class WczytajSettings
    {

        public bool CheckSettings()
        {
            bool wynik = false;
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings.Count != 0)
                    wynik = true;



            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("Błąd podczas odczytywania danych  z AppSettings", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return wynik;
        }

        public string Wczytajdane(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

    }
}
