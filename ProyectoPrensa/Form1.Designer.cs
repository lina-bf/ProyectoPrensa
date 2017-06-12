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
            ((System.ComponentModel.ISupportInitialize)(this.PresionTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanciaTiempo)).BeginInit();
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
            this.A0.Location = new System.Drawing.Point(798, 357);
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
            this.DDist.Location = new System.Drawing.Point(312, 357);
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
            this.label2.Location = new System.Drawing.Point(252, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Distancia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "cm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(747, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Presión:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(846, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "MPa(?)";
            // 
            // Progra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 697);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DistanciaTiempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IngresoNombre);
            this.Controls.Add(this.DDist);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PresionTiempo);
            this.Controls.Add(this.A0);
            this.Controls.Add(this.Lectura);
            this.Controls.Add(this.Terminar);
            this.Controls.Add(this.Inicio);
            this.Name = "Progra";
            this.Text = "Automatización de Prensa";
            ((System.ComponentModel.ISupportInitialize)(this.PresionTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanciaTiempo)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

