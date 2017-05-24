
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPicoYPlaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text != "" && txtFecha.Text != "" && txtHora.Text != "")
            {
                Vehiculo v = new Vehiculo();
                v.nPlaca = txtPlaca.Text;
                v.fecha = txtFecha.Text;
                v.hora = txtHora.Text;
                if (!v.ComprobarPlaca() || !v.ComprobarHora())
                    MessageBox.Show("Ingrese una placa/hora válida.");
                else
                {
                    PicoYPlaca pp = new PicoYPlaca();
                    MessageBox.Show(pp.PuedeCircular(v));
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos.");
            }
        }
    }
}
