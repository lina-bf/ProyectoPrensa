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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Progra));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label8 = new System.Windows.Forms.Label();
            this.DistanciaMax = new System.Windows.Forms.TextBox();
            this.Bajar = new System.Windows.Forms.Button();
            this.Subir = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Parar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Temp1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Temp2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
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
            chartArea1.Name = "ChartArea1";
            this.PresionTiempo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PresionTiempo.Legends.Add(legend1);
            this.PresionTiempo.Location = new System.Drawing.Point(750, 24);
            this.PresionTiempo.Name = "PresionTiempo";
            this.PresionTiempo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Presión";
            this.PresionTiempo.Series.Add(series1);
            this.PresionTiempo.Size = new System.Drawing.Size(436, 300);
            this.PresionTiempo.TabIndex = 4;
            this.PresionTiempo.Text = "Gráfico de Presión";
            this.PresionTiempo.Click += new System.EventHandler(this.PresionTiempo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1048, 560);
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
            this.IngresoNombre.Location = new System.Drawing.Point(15, 236);
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
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingrese el nombre  de los archivos a guardar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DistanciaTiempo
            // 
            chartArea2.Name = "ChartArea1";
            this.DistanciaTiempo.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.DistanciaTiempo.Legends.Add(legend2);
            this.DistanciaTiempo.Location = new System.Drawing.Point(255, 24);
            this.DistanciaTiempo.Name = "DistanciaTiempo";
            this.DistanciaTiempo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Distancia";
            this.DistanciaTiempo.Series.Add(series2);
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
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "MPa(?)";
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
            this.groupBox4.Size = new System.Drawing.Size(200, 67);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ingrese la distancia deseada:";
            // 
            // DistanciaMax
            // 
            this.DistanciaMax.Location = new System.Drawing.Point(12, 304);
            this.DistanciaMax.Name = "DistanciaMax";
            this.DistanciaMax.Size = new System.Drawing.Size(135, 20);
            this.DistanciaMax.TabIndex = 21;
            // 
            // Bajar
            // 
            this.Bajar.Location = new System.Drawing.Point(12, 410);
            this.Bajar.Name = "Bajar";
            this.Bajar.Size = new System.Drawing.Size(145, 57);
            this.Bajar.TabIndex = 0;
            this.Bajar.Text = "Bajar";
            this.Bajar.UseVisualStyleBackColor = true;
            this.Bajar.Click += new System.EventHandler(this.Bajar_Click_1);
            // 
            // Subir
            // 
            this.Subir.Location = new System.Drawing.Point(12, 345);
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
            this.Parar.Location = new System.Drawing.Point(12, 482);
            this.Parar.Name = "Parar";
            this.Parar.Size = new System.Drawing.Size(145, 57);
            this.Parar.TabIndex = 23;
            this.Parar.Text = "Parar avance";
            this.Parar.UseVisualStyleBackColor = true;
            this.Parar.Click += new System.EventHandler(this.Parar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Temperatura Prensa Superior:";
            // 
            // Temp1
            // 
            this.Temp1.AutoSize = true;
            this.Temp1.Location = new System.Drawing.Point(151, 0);
            this.Temp1.Name = "Temp1";
            this.Temp1.Size = new System.Drawing.Size(22, 13);
            this.Temp1.TabIndex = 24;
            this.Temp1.Text = "0.0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "°C";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-3, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Temperatura Prensa Inferior:";
            // 
            // Temp2
            // 
            this.Temp2.AutoSize = true;
            this.Temp2.Location = new System.Drawing.Point(151, 16);
            this.Temp2.Name = "Temp2";
            this.Temp2.Size = new System.Drawing.Size(22, 13);
            this.Temp2.TabIndex = 24;
            this.Temp2.Text = "0.0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(179, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "°C";
            // 
            // Progra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 697);
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
    }
}

