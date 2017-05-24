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
            this.Inicio = new System.Windows.Forms.Button();
            this.Terminar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Lectura = new System.Windows.Forms.Button();
            this.A0 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Inicio
            // 
            this.Inicio.Location = new System.Drawing.Point(33, 22);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(146, 56);
            this.Inicio.TabIndex = 0;
            this.Inicio.Text = "Inicio";
            this.Inicio.UseVisualStyleBackColor = true;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // Terminar
            // 
            this.Terminar.Location = new System.Drawing.Point(223, 22);
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
            this.Lectura.Location = new System.Drawing.Point(430, 21);
            this.Lectura.Name = "Lectura";
            this.Lectura.Size = new System.Drawing.Size(158, 59);
            this.Lectura.TabIndex = 2;
            this.Lectura.Text = "Lectura";
            this.Lectura.UseVisualStyleBackColor = true;
            this.Lectura.Click += new System.EventHandler(this.Lectura_Click);
            // 
            // A0
            // 
            this.A0.AutoSize = true;
            this.A0.Location = new System.Drawing.Point(427, 97);
            this.A0.Name = "A0";
            this.A0.Size = new System.Drawing.Size(22, 13);
            this.A0.TabIndex = 3;
            this.A0.Text = "0.0";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(223, 97);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(436, 300);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // Progra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 378);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.A0);
            this.Controls.Add(this.Lectura);
            this.Controls.Add(this.Terminar);
            this.Controls.Add(this.Inicio);
            this.Name = "Progra";
            this.Text = "Automatización de Prensa";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.Button Terminar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Lectura;
        private System.Windows.Forms.Label A0;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

