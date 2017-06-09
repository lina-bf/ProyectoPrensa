//Proyecto de Automatizacion de un Prensa
//Insituto Tecnologico de Costa Rica
//Area Academica Ingeneria Mecatronica
//Curso de Automatizacion y Redes Industriales
//Grupo 02
//Estudiantes:
//Lina Bourrouet Formoso
//Debora Gonzalez Gamez
//Allison Mendoza Manzanares
//Geronimo Ruepert Belderbos

//Agregando Biblioteca

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
using System.IO;

//Inicio del Codigo
namespace ProyectoPrensa
{
    public partial class Progra : Form
    {
        public Progra()
        {
            InitializeComponent();
        }
        
        //Inicio de la comunicacion Serial al hacer click al boton Inicio
        private void Inicio_Click(object sender, EventArgs e)
        {
            //Abre el puerto serial 1 el cual esta configurado al COM donde esta conectado el Arduino
            serialPort1.Open();
            try
            {
                //Envia un 1 al puerto serial, el cual dentro del Case empieza la conexion oficial
                serialPort1.Write("1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Terminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Envia un 0 al puerto serial , que el case de la programacion del arduino genera el cierre de comunicacion
                serialPort1.Write("0");
                PresionTiempo.SaveImage("C:\\Users\\Lina\\Documents\\GitHub\\PRENSA_I_SEM_2017\\test.bmp", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Bmp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            serialPort1.Close();
        }
        private void Grafico()
        {
            PresionTiempo.Series.Clear();
            PresionTiempo.Series.Add("Presión");
            PresionTiempo.Series["Presión"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            PresionTiempo.ChartAreas[0].AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            PresionTiempo.ChartAreas[0].AxisY2.Title = "Presión";

        }
        private void Distancia_Click(object sender, EventArgs e)
        {
            //Lectura del Sensor ultrasonico
            serialPort1.Write("2");
            string LDistancia = serialPort1.ReadLine().ToString();
            double LDS = Convert.ToDouble(LDistancia);
            DDist.Text = LDS.ToString();
        }
        private void Lectura_Click(object sender, EventArgs e)
        {

            //Un case diferente en el cual en este caso lee un dato de la entrada analogica A0 y la transfiere por el serial 
            serialPort1.Write("6");
            string Dato = serialPort1.ReadLine().ToString();
            double Sensor = Convert.ToDouble(Dato);
            double Voltaje = Sensor * 5 / 1023;
            //Luego ese dato se publica en el Label A0
            A0.Text = Voltaje.ToString();

            //Grafica temporal en un i que es conteo de clicks se debe cambia a grafica de tiempo
            int i = 0;
            PresionTiempo.Series["Presión"].Points.AddXY(i, Voltaje);
            i = i + 1;

        }
        
        private void PresionTiempo_Click(object sender, EventArgs e)
        {

        }

     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
   
