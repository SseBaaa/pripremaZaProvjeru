using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnjanjapriprema
{
    internal class Vozilo
    {

        String naziv, marka, vrsta;
        DateTime GodPro;
        int snaga;

        public Vozilo(string naziv, string marka, string vrsta, DateTime godPro, int snaga)
        {
            this.naziv = naziv;
            this.marka = marka;
            this.vrsta = vrsta;
            GodPro = godPro;
            this.snaga = snaga;
        }

        public override string ToString()
        {
            return "Naziv: " + this.naziv + Environment.NewLine + "Marka: " +this.marka + Environment.NewLine +
                "Vrsta: " + this.vrsta + Environment.NewLine + "Godina proizvodnje: " + this.GodPro.Year + Environment.NewLine
                + "Snaga: " + this.snaga + " KS";
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Vrsta { get => vrsta; set => vrsta = value; }
        public DateTime GodPro1 { get => GodPro; set => GodPro = value; }
        public int Snaga { get => snaga; set => snaga = value; }
    }
}
