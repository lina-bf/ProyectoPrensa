namespace ProyectoPrensa
{
    partial class Progra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Progra));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Inicio = new System.Windows.Forms.Button();
            this.Terminar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Lectura = new System.Windows.Forms.Button();
            this.A0 = new System.Windows.Forms.Label();
            this.PresionTiempo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DDist = new System.Windows.Forms.Label();
            this.IngresoNombre = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.DistanciaTiempo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.T_transcurrido = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Temp2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Temp1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DistanciaMax = new System.Windows.Forms.TextBox();
            this.Bajar = new System.Windows.Forms.Button();
            this.Subir = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Parar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.T1D = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.T2D = new System.Windows.Forms.TextBox();
            this.PuertoCOM = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SoloLectura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PresionTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanciaTiempo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Inicio
            // 
            this.Inicio.Location = new System.Drawing.Point(12, 12);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(146, 56);
            this.Inicio.TabIndex = 0;
            this.Inicio.Text = "Inicio";
            this.Inicio.UseVisualStyleBackColor = true;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // Terminar
            // 
            this.Terminar.Location = new System.Drawing.Point(12, 74);
            this.Terminar.Name = "Terminar";
            this.Terminar.Size = new System.Drawing.Size(146, 56);
            this.Terminar.TabIndex = 1;
            this.Terminar.Text = "Terminar";
            this.Terminar.UseVisualStyleBackColor = true;
            this.Terminar.Click += new System.EventHandler(this.Terminar_Click);
            // 
            // Lectura
            // 
            this.Lectura.Location = new System.Drawing.Point(12, 136);
            this.Lectura.Name = "Lectura";
            this.Lectura.Size = new System.Drawing.Size(146, 59);
            this.Lectura.TabIndex = 2;
            this.Lectura.Text = "Lectura";
            this.Lectura.UseVisualStyleBackColor = true;
            this.Lectura.Click += new System.EventHandler(this.Lectura_Click);
            // 
            // A0
            // 
            this.A0.AutoSize = true;
            this.A0.Location = new System.Drawing.Point(48, 0);
            this.A0.Name = "A0";
            this.A0.Size = new System.Drawing.Size(22, 13);
            this.A0.TabIndex = 3;
            this.A0.Text = "0.0";
            // 
            // PresionTiempo
            // 
            chartArea3.Name = "ChartArea1";
            this.PresionTiempo.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.PresionTiempo.Legends.Add(legend3);
            this.PresionTiempo.Location = new System.Drawing.Point(750, 24);
            this.PresionTiempo.Name = "PresionTiempo";
            this.PresionTiempo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Presión";
            this.PresionTiempo.Series.Add(series3);
            this.PresionTiempo.Size = new System.Drawing.Size(436, 300);
            this.PresionTiempo.TabIndex = 4;
            this.PresionTiempo.Text = "Gráfico de Presión";
            this.PresionTiempo.Click += new System.EventHandler(this.PresionTiempo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1048, 464);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(176, 125);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DDist
            // 
            this.DDist.AutoSize = true;
            this.DDist.Location = new System.Drawing.Point(57, 0);
            this.DDist.Name = "DDist";
            this.DDist.Size = new System.Drawing.Size(22, 13);
            this.DDist.TabIndex = 8;
            this.DDist.Text = "0.0";
            this.DDist.Click += new System.EventHandler(this.DDist_Click);
            // 
            // IngresoNombre
            // 
            this.IngresoNombre.Location = new System.Drawing.Point(15, 286);
            this.IngresoNombre.Name = "IngresoNombre";
            this.IngresoNombre.Size = new System.Drawing.Size(135, 20);
            this.IngresoNombre.TabIndex = 9;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingrese el nombre  de los archivos a guardar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DistanciaTiempo
            // 
            chartArea4.Name = "ChartArea1";
            this.DistanciaTiempo.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.DistanciaTiempo.Legends.Add(legend4);
            this.DistanciaTiempo.Location = new System.Drawing.Point(255, 24);
            this.DistanciaTiempo.Name = "DistanciaTiempo";
            this.DistanciaTiempo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Distancia";
            this.DistanciaTiempo.Series.Add(series4);
            this.DistanciaTiempo.Size = new System.Drawing.Size(436, 300);
            this.DistanciaTiempo.TabIndex = 11;
            this.DistanciaTiempo.Text = "DistanciaTiempo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Distancia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "cm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Presión:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "MPa";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.DDist);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(255, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 25);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.A0);
            this.groupBox2.Location = new System.Drawing.Point(750, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 25);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.T_transcurrido);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(255, 376);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 21);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "s";
            // 
            // T_transcurrido
            // 
            this.T_transcurrido.AutoSize = true;
            this.T_transcurrido.Location = new System.Drawing.Point(57, 0);
            this.T_transcurrido.Name = "T_transcurrido";
            this.T_transcurrido.Size = new System.Drawing.Size(22, 13);
            this.T_transcurrido.TabIndex = 19;
            this.T_transcurrido.Text = "0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tiempo:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.Temp2);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.Temp1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(750, 376);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 42);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(179, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "°C  ";
            // 
            // Temp2
            // 
            this.Temp2.AutoSize = true;
            this.Temp2.Location = new System.Drawing.Point(135, 16);
            this.Temp2.Name = "Temp2";
            this.Temp2.Size = new System.Drawing.Size(22, 13);
            this.Temp2.TabIndex = 24;
            this.Temp2.Text = "0.0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-3, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Temperatura Placa Inferior:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "°C   ";
            // 
            // Temp1
            // 
            this.Temp1.AutoSize = true;
            this.Temp1.Location = new System.Drawing.Point(135, 0);
            this.Temp1.Name = "Temp1";
            this.Temp1.Size = new System.Drawing.Size(22, 13);
            this.Temp1.TabIndex = 24;
            this.Temp1.Text = "0.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Temperatura Placa Superior:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ingrese la distancia deseada:";
            // 
            // DistanciaMax
            // 
            this.DistanciaMax.Location = new System.Drawing.Point(12, 354);
            this.DistanciaMax.Name = "DistanciaMax";
            this.DistanciaMax.Size = new System.Drawing.Size(135, 20);
            this.DistanciaMax.TabIndex = 21;
            // 
            // Bajar
            // 
            this.Bajar.Location = new System.Drawing.Point(12, 460);
            this.Bajar.Name = "Bajar";
            this.Bajar.Size = new System.Drawing.Size(145, 57);
            this.Bajar.TabIndex = 0;
            this.Bajar.Text = "Bajar";
            this.Bajar.UseVisualStyleBackColor = true;
            this.Bajar.Click += new System.EventHandler(this.Bajar_Click_1);
            // 
            // Subir
            // 
            this.Subir.Location = new System.Drawing.Point(12, 395);
            this.Subir.Name = "Subir";
            this.Subir.Size = new System.Drawing.Size(145, 59);
            this.Subir.TabIndex = 22;
            this.Subir.Text = "Subir";
            this.Subir.UseVisualStyleBackColor = true;
            this.Subir.Click += new System.EventHandler(this.Subir_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Parar
            // 
            this.Parar.Location = new System.Drawing.Point(12, 523);
            this.Parar.Name = "Parar";
            this.Parar.Size = new System.Drawing.Size(145, 57);
            this.Parar.TabIndex = 23;
            this.Parar.Text = "Parar avance";
            this.Parar.UseVisualStyleBackColor = true;
            this.Parar.Click += new System.EventHandler(this.Parar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(252, 405);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Temperatura Placa Superior:";
            // 
            // T1D
            // 
            this.T1D.Location = new System.Drawing.Point(404, 405);
            this.T1D.Name = "T1D";
            this.T1D.Size = new System.Drawing.Size(51, 20);
            this.T1D.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(252, 435);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Temperatura Placa Inferior:";
            // 
            // T2D
            // 
            this.T2D.Location = new System.Drawing.Point(404, 432);
            this.T2D.Name = "T2D";
            this.T2D.Size = new System.Drawing.Size(51, 20);
            this.T2D.TabIndex = 27;
            // 
            // PuertoCOM
            // 
            this.PuertoCOM.FormattingEnabled = true;
            this.PuertoCOM.Location = new System.Drawing.Point(12, 227);
            this.PuertoCOM.Name = "PuertoCOM";
            this.PuertoCOM.Size = new System.Drawing.Size(121, 21);
            this.PuertoCOM.TabIndex = 28;
            this.PuertoCOM.DropDown += new System.EventHandler(this.PuertoCOM_DropDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Selección de Puerto:";
            // 
            // SoloLectura
            // 
            this.SoloLectura.Location = new System.Drawing.Point(256, 464);
            this.SoloLectura.Name = "SoloLectura";
            this.SoloLectura.Size = new System.Drawing.Size(138, 57);
            this.SoloLectura.TabIndex = 30;
            this.SoloLectura.Text = "Lectura de Datos";
            this.SoloLectura.UseVisualStyleBackColor = true;
            this.SoloLectura.Click += new System.EventHandler(this.SoloLectura_Click);
            // 
            // Progra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 599);
            this.Controls.Add(this.SoloLectura);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.PuertoCOM);
            this.Controls.Add(this.T2D);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.T1D);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Parar);
            this.Controls.Add(this.Bajar);
            this.Controls.Add(this.Subir);
            this.Controls.Add(this.DistanciaMax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DistanciaTiempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IngresoNombre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PresionTiempo);
            this.Controls.Add(this.Lectura);
            this.Controls.Add(this.Terminar);
            this.Controls.Add(this.Inicio);
            this.Name = "Progra";
            this.Text = "Automatización de Prensa";
            this.Load += new System.EventHandler(this.Progra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PresionTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanciaTiempo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.Button Terminar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Lectura;
        private System.Windows.Forms.Label A0;
        private System.Windows.Forms.DataVisualization.Charting.Chart PresionTiempo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label DDist;
        private System.Windows.Forms.TextBox IngresoNombre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart DistanciaTiempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label T_transcurrido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DistanciaMax;
        private System.Windows.Forms.Button Bajar;
        private System.Windows.Forms.Button Subir;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button Parar;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Temp2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Temp1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox T1D;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox T2D;
        private System.Windows.Forms.ComboBox PuertoCOM;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button SoloLectura;
    }
}

