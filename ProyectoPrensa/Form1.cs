﻿//Proyecto de Automatizacion de un Prensa
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
            public static string Dpresion = "TIEMPO, PRESION, DISTANCIA, TEMPERATURA PLACA SUPERIOR, TEMPERATURA PLACA INFERIOR";
            public static double Voltaje;
            public static double Distancia;
            public static string Tiempo;
            public static Stopwatch M_Tiempo = new Stopwatch();
            public static double DistanciaD;
            public static bool Avance;
            public static string Escribir;
            public static string Temp1;
            public static string Temp2;
            public static string Puerto;
            public static int temporal;
            public static int soyuntemporal;

        }

        public Progra()
        {
            InitializeComponent();

        }

        //Inicio de la comunicacion Serial al hacer click al boton Inicio
        private void PuertoCOM_DropDown(object sender, EventArgs e)
        {
            PuertoCOM.DataSource = SerialPort.GetPortNames();
            if (PuertoCOM.SelectedItem == null)
            {
                MessageBox.Show("No se encuentran puertos");
            }
            else
            {
                serialPort1.PortName = PuertoCOM.SelectedItem.ToString();
            }
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            //Abre el puerto serial 1 el cual esta configurado al COM donde esta conectado el Arduino


            if (IngresoNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del archivo");

            }
            if (PuertoCOM.SelectedItem == null)
            {
                MessageBox.Show("Seleccione primero el puerto a conectar");
            }
            else
            {

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
        }

        private void Terminar_Click(object sender, EventArgs e)
        {
            try
            {
                backgroundWorker1.CancelAsync();
                backgroundWorker3.CancelAsync();
                backgroundWorker4.CancelAsync();

                //Envia un 0 al puerto serial , que el case de la programacion del arduino genera el cierre de comunicacion
                serialPort1.Write("b");
                System.Threading.Thread.Sleep(20);
                serialPort1.Write("0");
                serialPort1.Write("8");
                serialPort1.Write("d");

                //Donde se le guarda los nombres primero se pone el path donde se guarda 
                string Camino = Path.GetDirectoryName(Application.ExecutablePath);
                Camino = string.Join(null, Camino, "/");
                //De la zona de ingreso del nombre lee donde guarda el nombre 
                string Nombre = IngresoNombre.Text;
                string dist = "dist";
                string pres = "pres";
                string extensioni = ".bmp";
                string extensiont = ".csv";
                //Unifica los string primero el elemento de union que es un null y los dos string que se unen y despues la otra union
                string baseGuardado = String.Join(null, Camino, Nombre);
                string imagenpre = String.Join(null, baseGuardado, pres);
                imagenpre = String.Join(null, imagenpre, extensioni);
                string imagendis = String.Join(null, baseGuardado, dist);
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
           // serialPort1.Close();
        }


        private void Lectura_Click(object sender, EventArgs e)
        {
            //Coloca los titulos en los ejes
            PresionTiempo.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            PresionTiempo.ChartAreas[0].AxisY.Title = "Presión";
            PresionTiempo.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            PresionTiempo.ChartAreas[0].AxisX.Title = "Tiempo(s)";
            DistanciaTiempo.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            DistanciaTiempo.ChartAreas[0].AxisY.Title = "Distancia(cm)";
            DistanciaTiempo.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            DistanciaTiempo.ChartAreas[0].AxisX.Title = "Tiempo(s)";
            if (T1D.Text == "" || T2D.Text == "")
            {
                MessageBox.Show("Favor Ingresar valores de temperatura deseados");

            }
            else
            {

                serialPort1.Write("2");
                string LDistancia = serialPort1.ReadLine().ToString();
                Globales.Distancia = Convert.ToDouble(LDistancia);
                DDist.Text = LDistancia.ToString();
                if (DistanciaMax.Text != "" && Convert.ToSingle(DistanciaMax.Text) < Convert.ToSingle(24.5))
                {

                    if (!backgroundWorker1.IsBusy && !backgroundWorker2.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    };

                }
                else
                {
                    if (Convert.ToSingle(DistanciaMax.Text) < 24.5)
                    {

                        MessageBox.Show("Error en la distancia máxima");
                    }
                    else
                    {
                        MessageBox.Show("Distancia fuera del rango");
                    }
                }
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

            
            
            while (true)
            {
                Globales.M_Tiempo.Start();
                //Escribe en el puerto serial un 6 donde solicita adquirir datos del A0
                serialPort1.Write("6");
                //lee el dato de serial
               
                string Dato = serialPort1.ReadLine().ToString();
                double Sensor = Convert.ToDouble(Dato);
                Globales.Voltaje = Sensor * 5 / 1023;
                //Actualiza y hace un reporte para actualizar el Form
                serialPort1.Write("2");
                string LDistancia = serialPort1.ReadLine().ToString();
                Globales.Distancia = Convert.ToDouble(LDistancia);
               
                serialPort1.Write("3");
                Globales.Temp1 = serialPort1.ReadLine();
                
                if (Convert.ToDouble(Globales.Temp1) < Convert.ToDouble(T1D.Text))
                {
                    serialPort1.Write("7");
                }
                if (Convert.ToDouble(Globales.Temp1) >= Convert.ToDouble(T1D.Text))
                {
                    serialPort1.Write("8");
                }
                
                serialPort1.Write("4");
                Globales.Temp2 = serialPort1.ReadLine();
                if (Convert.ToDouble(Globales.Temp2) < Convert.ToDouble(T2D.Text))
                {
                    serialPort1.Write("c");
                }
                if (Convert.ToDouble(Globales.Temp2) >= Convert.ToDouble(T2D.Text))
                {
                    serialPort1.Write("d");
                }
                


                serialPort1.Write("a");
                
               
                backgroundWorker1.ReportProgress(Globales.i);

                //Avanza el conteo
                Globales.i = Globales.i + 1;
                //Revisa si se cancela la actividad 
                if (backgroundWorker1.CancellationPending)
                {

                    break;
                }
                
                if (Globales.Distancia <= Convert.ToDouble(DistanciaMax.Text))
                {
                    
                    break;
                }

            }

            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Luego ese dato se publica en el Label A0
            
            A0.Text = Globales.Voltaje.ToString();
            DDist.Text = Globales.Distancia.ToString();
            Tem1.Text = Globales.Temp1.ToString();
            Tem2.Text = Globales.Temp2.ToString();
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
            Globales.Dpresion = string.Join(delimitador, Globales.Dpresion, Convert.ToDouble(Globales.Temp1));
            Globales.Dpresion = string.Join(delimitador, Globales.Dpresion, Convert.ToDouble(Globales.Temp2));

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //No se usa en esta parte del codigo ya que nunca llega a "terminar"

            serialPort1.Write("b");
            serialPort1.Write("8");
            serialPort1.Write("d");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Subir_Click(object sender, EventArgs e)
        {
            Globales.Avance = true;
            Globales.Escribir = "9";
            if (!backgroundWorker2.IsBusy && !backgroundWorker1.IsBusy && !backgroundWorker3.IsBusy)
            {
                backgroundWorker2.RunWorkerAsync();
            }
        }
        private void Bajar_Click_1(object sender, EventArgs e)
        {

            Globales.Avance = true;
            Globales.Escribir = "a";
            if (!backgroundWorker2.IsBusy&& !backgroundWorker1.IsBusy&&!backgroundWorker3.IsBusy)
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

                backgroundWorker2.ReportProgress(Globales.temporal);
                Globales.temporal = Globales.temporal +1;
                if (backgroundWorker2.CancellationPending)
                {
                    e.Cancel = true;
                }
            }


        }
        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            DDist.Text = Globales.Distancia.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Progra_Load(object sender, EventArgs e)
        {

        }

        private void C_Placas_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker4.IsBusy)
            {
                backgroundWorker4.RunWorkerAsync();
            }
        }

        private void Lect_Click(object sender, EventArgs e)
        {
            //Coloca los titulos en los ejes
            PresionTiempo.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            PresionTiempo.ChartAreas[0].AxisY.Title = "Presión";
            PresionTiempo.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            PresionTiempo.ChartAreas[0].AxisX.Title = "Tiempo(s)";
            DistanciaTiempo.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            DistanciaTiempo.ChartAreas[0].AxisY.Title = "Distancia(cm)";
            DistanciaTiempo.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            DistanciaTiempo.ChartAreas[0].AxisX.Title = "Tiempo(s)";
            if (T1D.Text == "" || T2D.Text == "")
            {
                MessageBox.Show("Favor Ingresar valores de temperatura deseados");

            }
            else
            {

                serialPort1.Write("2");
                string LDistancia = serialPort1.ReadLine().ToString();
                Globales.Distancia = Convert.ToDouble(LDistancia);
                DDist.Text = LDistancia.ToString();
                

                    if (!backgroundWorker3.IsBusy && !backgroundWorker2.IsBusy)
                    {
                        backgroundWorker3.RunWorkerAsync();
                    }

                
                
            }
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Globales.M_Tiempo.Start();
                //Escribe en el puerto serial un 6 donde solicita adquirir datos del A0
                serialPort1.Write("6");
                //lee el dato de serial

                string Dato = serialPort1.ReadLine().ToString();
                double Sensor = Convert.ToDouble(Dato);
                Globales.Voltaje = Sensor * 5 / 1023;
                //Actualiza y hace un reporte para actualizar el Form
                serialPort1.Write("2");
                string LDistancia = serialPort1.ReadLine().ToString();
                Globales.Distancia = Convert.ToDouble(LDistancia);

                serialPort1.Write("3");
                Globales.Temp1 = serialPort1.ReadLine();

                if (Convert.ToDouble(Globales.Temp1) < Convert.ToDouble(T1D.Text))
                {
                    serialPort1.Write("7");
                }
                if (Convert.ToDouble(Globales.Temp1) >= Convert.ToDouble(T1D.Text))
                {
                    serialPort1.Write("8");
                }

                serialPort1.Write("4");
                Globales.Temp2 = serialPort1.ReadLine();
                if (Convert.ToDouble(Globales.Temp2) < Convert.ToDouble(T2D.Text))
                {
                    serialPort1.Write("c");
                }
                if (Convert.ToDouble(Globales.Temp2) >= Convert.ToDouble(T2D.Text))
                {
                    serialPort1.Write("d");
                }


                backgroundWorker3.ReportProgress(Globales.i);

                //Avanza el conteo
                Globales.i = Globales.i + 1;
                //Revisa si se cancela la actividad 
                if (backgroundWorker4.CancellationPending)
                {

                    break;
                }

            }
        }

        private void backgroundWorker3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Luego ese dato se publica en el Label A0

            A0.Text = Globales.Voltaje.ToString();
            DDist.Text = Globales.Distancia.ToString();
            Tem1.Text = Globales.Temp1.ToString();
            Tem2.Text = Globales.Temp2.ToString();
            //Grafica temporal en un i que es conteo de clicks se debe cambia a grafica de tiempo
            Globales.Tiempo = Globales.M_Tiempo.Elapsed.ToString("mm\\:ss\\.ff");
            T_transcurrido.Text = Globales.Tiempo.ToString();
            PresionTiempo.Series["Presión"].Points.AddXY(Globales.Tiempo, Globales.Voltaje);
            DistanciaTiempo.Series["Distancia"].Points.AddXY(Globales.Tiempo, Globales.Distancia);
            //Va generando el string que se convierte en el csv.
            string delimitador = ",";

            Globales.Dpresion = string.Join(System.Environment.NewLine, Globales.Dpresion, Globales.Tiempo);
            Globales.Dpresion = string.Join(delimitador, Globales.Dpresion, Globales.Voltaje);
            Globales.Dpresion = string.Join(",", Globales.Dpresion, Globales.Distancia);
            Globales.Dpresion = string.Join(",", Globales.Dpresion, Convert.ToDouble(Globales.Temp1));
            Globales.Dpresion = string.Join(",", Globales.Dpresion, Convert.ToDouble(Globales.Temp2));
        }

        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //En este si no debe hacer nada
        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {

                serialPort1.Write("3");
                Globales.Temp1 = serialPort1.ReadLine();
                if (Convert.ToDouble(Globales.Temp1) < Convert.ToDouble(T1D.Text))
                {
                    serialPort1.Write("7");
                }
                if (Convert.ToDouble(Globales.Temp1) >= Convert.ToDouble(T1D.Text))
                {
                    serialPort1.Write("8");
                }

                serialPort1.Write("4");
                Globales.Temp2 = serialPort1.ReadLine();
                if (Convert.ToDouble(Globales.Temp2) < Convert.ToDouble(T2D.Text))
                {
                    serialPort1.Write("c");
                }
                if (Convert.ToDouble(Globales.Temp2) >= Convert.ToDouble(T2D.Text))
                {
                    serialPort1.Write("d");
                }
                backgroundWorker4.ReportProgress(Globales.soyuntemporal);
                Globales.soyuntemporal = Globales.soyuntemporal + 1;
                if (backgroundWorker4.CancellationPending)
                {

                    break;
                }
            }
        }

        private void backgroundWorker4_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Tem1.Text = Globales.Temp1.ToString();
            Tem2.Text = Globales.Temp2.ToString();
        }

        private void backgroundWorker4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }
    }
}

