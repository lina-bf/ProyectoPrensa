using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ProyectoPrensa
{
    public partial class Progra : Form
    {
        public Progra()
        {
            InitializeComponent();
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            try
            {
                serialPort1.Write("1");
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Terminar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("0");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            serialPort1.Close();
        }

        private void Lectura_Click(object sender, EventArgs e)
        {

            serialPort1.Write("6");
            string Dato = serialPort1.ReadLine().ToString();
            double Sensor = Convert.ToDouble(Dato);
            double Voltaje = Sensor * 5 / 1023;
            A0.Text = Voltaje.ToString();


        }

       
    }
}
