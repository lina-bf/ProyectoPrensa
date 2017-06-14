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
using System.Diagnostics;


//Inicio del Codigo

namespace ProyectoPrensa
{
    public partial class Progra : Form
    {
        public class Globales
        {
            public static int i;
            public static string Dpresion = "TIEMPO, PRESION, DISTANCIA";
            public static bool cicloinfinito;
            public static double Voltaje;
            public static double Distancia;
            public static string Tiempo;
            public static Stopwatch M_Tiempo = new Stopwatch();
            public static double DistanciaD;
            public static bool Avance;
            public static string Escribir;


        }

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
                //Cancela el ciclo infinito al cerrar el trabajo asincrono 

                this.backgroundWorker1.CancelAsync();
                //Envia un 0 al puerto serial , que el case de la programacion del arduino genera el cierre de comunicacion

                serialPort1.Write("0");

                Globales.cicloinfinito = false;
                //Donde se le guarda los nombres primero se pone el path donde se guarda 
                string Camino = "C:\\Users\\Lina\\Documents\\GitHub\\PRENSA_I_SEM_2017\\";
                //De la zona de ingreso del nombre lee donde guarda el nombre 
                string Nombre = IngresoNombre.Text;
                string dist = "dist";
                string pres = "pres";
                string extensioni = ".bmp";
                string extensiont = ".csv";
                //Unifica los string primero el elemento de union que es un null y los dos string que se unen y despues la otra union
                string baseGuardado = String.Join(null, Camino, Nombre);
                string imagenpre = String.Join(null, baseGuardado, dist);
                imagenpre = String.Join(null, imagenpre, extensioni);
                string imagendis = String.Join(null, baseGuardado, pres);
                imagendis = String.Join(null, imagendis, extensioni);
                string datoscsv = String.Join(null, baseGuardado, extensiont);

                //   Salva la imagen como tipo .bmp        
                PresionTiempo.SaveImage(imagenpre, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Bmp);
                DistanciaTiempo.SaveImage(imagendis, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Bmp);
                //Guarda el contenido en el csv
                File.WriteAllText(datoscsv, Globales.Dpresion.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            serialPort1.Close();
        }


        private void Lectura_Click(object sender, EventArgs e)
        {

            //Un case diferente en el cual en este caso lee un dato de la entrada analogica A0 y la transfiere por el serial 

            Globales.cicloinfinito = true;

            //Coloca los titulos en los ejes
            PresionTiempo.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            PresionTiempo.ChartAreas[0].AxisY.Title = "Presión";
            PresionTiempo.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            PresionTiempo.ChartAreas[0].AxisX.Title = "Tiempo(s)";
            DistanciaTiempo.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            DistanciaTiempo.ChartAreas[0].AxisY.Title = "Distancia(cm)";
            DistanciaTiempo.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            DistanciaTiempo.ChartAreas[0].AxisX.Title = "Tiempo(s)";
            //Inicia el trabajo de fondo donde si no se encuentra ocupado lo inicia
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void PresionTiempo_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DDist_Click(object sender, EventArgs e)
        {

        }
        //Lo que realiza en trabajo de fondo 
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Realiza un ciclo infinito hasta que se le de cancelar esto para la adquision de datos
            serialPort1.Write("2");
            string LDistancia = serialPort1.ReadLine().ToString();
            Globales.Distancia = Convert.ToDouble(LDistancia);
            while (Globales.cicloinfinito == true || Globales.Distancia != Globales.DistanciaD)
            {

                Globales.M_Tiempo.Start();
                //Escribe en el puerto serial un 6 donde solicita adquirir datos del A0
                serialPort1.Write("6");
                //lee el dato de seria
                string Dato = serialPort1.ReadLine().ToString();
                double Sensor = Convert.ToDouble(Dato);
                Globales.Voltaje = Sensor * 5 / 1023;
                //Actualiza y hace un reporte para actualizar el Form
                serialPort1.Write("2");
                LDistancia = serialPort1.ReadLine().ToString();
                Globales.Distancia = Convert.ToDouble(LDistancia);

                backgroundWorker1.ReportProgress(Globales.i);
                //Avanza el conteo
                Globales.i = Globales.i + 1;
                //Revisa si se cancela la actividad 
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;

                }

            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Luego ese dato se publica en el Label A0
            A0.Text = Globales.Voltaje.ToString();
            DDist.Text = Globales.Distancia.ToString();

            //Grafica temporal en un i que es conteo de clicks se debe cambia a grafica de tiempo
            Globales.Tiempo = Globales.M_Tiempo.Elapsed.ToString("mm\\:ss\\.ff");
            T_transcurrido.Text = Globales.Tiempo.ToString();
            PresionTiempo.Series["Presión"].Points.AddXY(Globales.Tiempo, Globales.Voltaje);
            DistanciaTiempo.Series["Distancia"].Points.AddXY(Globales.Tiempo, Globales.Distancia);
            //Va generando el string que se convierte en el csv.
            string delimitador = ",";

            Globales.Dpresion = string.Join(System.Environment.NewLine, Globales.Dpresion, Globales.Tiempo);
            Globales.Dpresion = string.Join(delimitador, Globales.Dpresion, Globales.Voltaje);
            Globales.Dpresion = string.Join(delimitador, Globales.Dpresion, Globales.Distancia);

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //No se usa en esta parte del codigo ya que nunca llega a "terminar"
            serialPort1.Write("00");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Subir_Click(object sender, EventArgs e)
        {
            Globales.Avance = true;
            Globales.Escribir = "9";
            if (!backgroundWorker2.IsBusy)
            {
                backgroundWorker2.RunWorkerAsync();
            }
        }
        private void Bajar_Click_1(object sender, EventArgs e)
        {

            Globales.Avance = true;
            Globales.Escribir = "a";
            label4.Text = "RP";
            if (!backgroundWorker2.IsBusy)
            {
                backgroundWorker2.RunWorkerAsync();
            }

        }

        private void Parar_Click(object sender, EventArgs e)
        {
            this.backgroundWorker2.CancelAsync();
            Globales.Avance = false;
            Globales.Escribir = "b";
           serialPort1.Write(Globales.Escribir);
        }
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
           
            while (Globales.Avance == true)
            {
                serialPort1.Write(Globales.Escribir);

                backgroundWorker2.ReportProgress(Globales.i);
                Globales.i = Globales.i + 1;
                if (backgroundWorker2.CancellationPending)
                {
                    e.Cancel = true;
                }
            }

            
        }
        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        
    }
}
