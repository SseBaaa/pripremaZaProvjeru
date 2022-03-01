using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace provjeraZnjanjapriprema
{
    public partial class Form1 : Form
    {
        List<Vozilo> listaVozila = new List<Vozilo>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            Vozilo vozilo = new Vozilo(txtNaziv.Text, txtMarka.Text, cmbVrsta.Text, dateDatum.Value, trckSnaga.Value);

            listaVozila.Add(vozilo);

            MessageBox.Show("Unos je uspješan", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void trckSnaga_Scroll(object sender, EventArgs e)
        {
            labelSnaga.Text = Convert.ToString(trckSnaga.Value);
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            richIspisi.Clear();
            foreach(Vozilo vozilo in listaVozila)
            {
                richIspisi.AppendText(vozilo.ToString());
            }
        }
    }
}
