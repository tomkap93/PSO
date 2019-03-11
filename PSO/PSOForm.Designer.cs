namespace PSO
{
    partial class PSOForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Start = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wczytaj = new System.Windows.Forms.Button();
            this.zapisz = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.wspoltlumspol_nud = new System.Windows.Forms.NumericUpDown();
            this.sss = new System.Windows.Forms.Label();
            this.wspolbez_nud = new System.Windows.Forms.NumericUpDown();
            this.dd = new System.Windows.Forms.Label();
            this.wspolosob_nud = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wspolspol_nud = new System.Windows.Forms.NumericUpDown();
            this.populacja_nud = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.literacje_nud = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.max_fun_nud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Label();
            this.min_fun_nud = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.funkcje_cb = new System.Windows.Forms.ComboBox();
            this.wykres_funkcji = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.wykres_wynikow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wspoltlumspol_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wspolbez_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wspolosob_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wspolspol_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populacja_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.literacje_nud)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_fun_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_fun_nud)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wykres_funkcji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wykres_wynikow)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(5, 273);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(223, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.start_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(263, 12);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(608, 359);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "Wprowadz dane i rozpocznyj symulacje ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wczytaj);
            this.groupBox1.Controls.Add(this.zapisz);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Start);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 359);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wprowadź dane";
            // 
            // wczytaj
            // 
            this.wczytaj.Location = new System.Drawing.Point(6, 330);
            this.wczytaj.Name = "wczytaj";
            this.wczytaj.Size = new System.Drawing.Size(223, 23);
            this.wczytaj.TabIndex = 10;
            this.wczytaj.Text = "Wczytaj ustawienia";
            this.wczytaj.UseVisualStyleBackColor = true;
            this.wczytaj.Click += new System.EventHandler(this.wczytaj_Click);
            // 
            // zapisz
            // 
            this.zapisz.Location = new System.Drawing.Point(6, 302);
            this.zapisz.Name = "zapisz";
            this.zapisz.Size = new System.Drawing.Size(223, 23);
            this.zapisz.TabIndex = 9;
            this.zapisz.Text = "Zapisz ustawienia";
            this.zapisz.UseVisualStyleBackColor = true;
            this.zapisz.Click += new System.EventHandler(this.zapisz_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.wspoltlumspol_nud);
            this.groupBox4.Controls.Add(this.sss);
            this.groupBox4.Controls.Add(this.wspolbez_nud);
            this.groupBox4.Controls.Add(this.dd);
            this.groupBox4.Controls.Add(this.wspolosob_nud);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.wspolspol_nud);
            this.groupBox4.Controls.Add(this.populacja_nud);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.literacje_nud);
            this.groupBox4.Location = new System.Drawing.Point(6, 123);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(223, 144);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dane dla PSO";
            // 
            // wspoltlumspol_nud
            // 
            this.wspoltlumspol_nud.DecimalPlaces = 2;
            this.wspoltlumspol_nud.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.wspoltlumspol_nud.Location = new System.Drawing.Point(156, 119);
            this.wspoltlumspol_nud.Name = "wspoltlumspol_nud";
            this.wspoltlumspol_nud.Size = new System.Drawing.Size(61, 20);
            this.wspoltlumspol_nud.TabIndex = 5;
            this.wspoltlumspol_nud.Value = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            // 
            // sss
            // 
            this.sss.AutoSize = true;
            this.sss.Location = new System.Drawing.Point(6, 121);
            this.sss.Name = "sss";
            this.sss.Size = new System.Drawing.Size(148, 13);
            this.sss.TabIndex = 15;
            this.sss.Text = "Współ. tłum. Współ. bezwł. :";
            // 
            // wspolbez_nud
            // 
            this.wspolbez_nud.DecimalPlaces = 2;
            this.wspolbez_nud.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.wspolbez_nud.Location = new System.Drawing.Point(156, 98);
            this.wspolbez_nud.Name = "wspolbez_nud";
            this.wspolbez_nud.Size = new System.Drawing.Size(61, 20);
            this.wspolbez_nud.TabIndex = 4;
            this.wspolbez_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dd
            // 
            this.dd.AutoSize = true;
            this.dd.Location = new System.Drawing.Point(6, 100);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(150, 13);
            this.dd.TabIndex = 11;
            this.dd.Text = "Współczynnik bezwładności :";
            // 
            // wspolosob_nud
            // 
            this.wspolosob_nud.DecimalPlaces = 2;
            this.wspolosob_nud.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.wspolosob_nud.Location = new System.Drawing.Point(156, 77);
            this.wspolosob_nud.Name = "wspolosob_nud";
            this.wspolosob_nud.Size = new System.Drawing.Size(61, 20);
            this.wspolosob_nud.TabIndex = 3;
            this.wspolosob_nud.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Współ. osobistego przyśpie. :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Współ. społ. przyśpie. :";
            // 
            // wspolspol_nud
            // 
            this.wspolspol_nud.DecimalPlaces = 2;
            this.wspolspol_nud.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.wspolspol_nud.Location = new System.Drawing.Point(156, 56);
            this.wspolspol_nud.Name = "wspolspol_nud";
            this.wspolspol_nud.Size = new System.Drawing.Size(61, 20);
            this.wspolspol_nud.TabIndex = 2;
            this.wspolspol_nud.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // populacja_nud
            // 
            this.populacja_nud.Location = new System.Drawing.Point(156, 35);
            this.populacja_nud.Name = "populacja_nud";
            this.populacja_nud.Size = new System.Drawing.Size(61, 20);
            this.populacja_nud.TabIndex = 1;
            this.populacja_nud.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ilość populacji :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ilość literacji :";
            // 
            // literacje_nud
            // 
            this.literacje_nud.Location = new System.Drawing.Point(156, 14);
            this.literacje_nud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.literacje_nud.Name = "literacje_nud";
            this.literacje_nud.Size = new System.Drawing.Size(61, 20);
            this.literacje_nud.TabIndex = 0;
            this.literacje_nud.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.max_fun_nud);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Min);
            this.groupBox3.Controls.Add(this.min_fun_nud);
            this.groupBox3.Location = new System.Drawing.Point(6, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 58);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Obszar funkcji";
            // 
            // max_fun_nud
            // 
            this.max_fun_nud.DecimalPlaces = 2;
            this.max_fun_nud.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.max_fun_nud.Location = new System.Drawing.Point(156, 35);
            this.max_fun_nud.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.max_fun_nud.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.max_fun_nud.Name = "max_fun_nud";
            this.max_fun_nud.Size = new System.Drawing.Size(61, 20);
            this.max_fun_nud.TabIndex = 3;
            this.max_fun_nud.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Max :";
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Location = new System.Drawing.Point(6, 16);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(30, 13);
            this.Min.TabIndex = 3;
            this.Min.Text = "Min :";
            // 
            // min_fun_nud
            // 
            this.min_fun_nud.DecimalPlaces = 2;
            this.min_fun_nud.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.min_fun_nud.Location = new System.Drawing.Point(156, 14);
            this.min_fun_nud.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.min_fun_nud.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.min_fun_nud.Name = "min_fun_nud";
            this.min_fun_nud.Size = new System.Drawing.Size(61, 20);
            this.min_fun_nud.TabIndex = 2;
            this.min_fun_nud.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.funkcje_cb);
            this.groupBox2.Location = new System.Drawing.Point(5, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 42);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wybierz funkcje";
            // 
            // funkcje_cb
            // 
            this.funkcje_cb.FormattingEnabled = true;
            this.funkcje_cb.Location = new System.Drawing.Point(10, 15);
            this.funkcje_cb.Name = "funkcje_cb";
            this.funkcje_cb.Size = new System.Drawing.Size(208, 21);
            this.funkcje_cb.TabIndex = 0;
            this.funkcje_cb.SelectedValueChanged += new System.EventHandler(this.funkcje_cb_SelectedValueChanged);
            // 
            // wykres_funkcji
            // 
            chartArea3.Name = "ChartArea1";
            this.wykres_funkcji.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.wykres_funkcji.Legends.Add(legend3);
            this.wykres_funkcji.Location = new System.Drawing.Point(12, 377);
            this.wykres_funkcji.Name = "wykres_funkcji";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Funkcja";
            series4.YValuesPerPoint = 2;
            series5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series5.BorderWidth = 10;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.Name = "Najlepszy punkt";
            series5.YValuesPerPoint = 2;
            this.wykres_funkcji.Series.Add(series4);
            this.wykres_funkcji.Series.Add(series5);
            this.wykres_funkcji.Size = new System.Drawing.Size(426, 274);
            this.wykres_funkcji.TabIndex = 3;
            this.wykres_funkcji.Text = "chart1";
            // 
            // wykres_wynikow
            // 
            chartArea4.Name = "ChartArea1";
            this.wykres_wynikow.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.wykres_wynikow.Legends.Add(legend4);
            this.wykres_wynikow.Location = new System.Drawing.Point(445, 377);
            this.wykres_wynikow.Name = "wykres_wynikow";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Wynik";
            this.wykres_wynikow.Series.Add(series6);
            this.wykres_wynikow.Size = new System.Drawing.Size(426, 274);
            this.wykres_wynikow.TabIndex = 4;
            this.wykres_wynikow.Text = "chart2";
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 663);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(883, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 5;
            // 
            // PSOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 686);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.wykres_wynikow);
            this.Controls.Add(this.wykres_funkcji);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PSOForm";
            this.Text = "PSO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wspoltlumspol_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wspolbez_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wspolosob_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wspolspol_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populacja_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.literacje_nud)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_fun_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_fun_nud)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wykres_funkcji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wykres_wynikow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sss;
        private System.Windows.Forms.Label dd;
        public System.Windows.Forms.RichTextBox richTextBox;
        public System.Windows.Forms.NumericUpDown min_fun_nud;
        public System.Windows.Forms.NumericUpDown max_fun_nud;
        public System.Windows.Forms.ComboBox funkcje_cb;
        public System.Windows.Forms.NumericUpDown wspolosob_nud;
        public System.Windows.Forms.NumericUpDown wspolspol_nud;
        public System.Windows.Forms.NumericUpDown populacja_nud;
        public System.Windows.Forms.NumericUpDown literacje_nud;
        public System.Windows.Forms.NumericUpDown wspoltlumspol_nud;
        public System.Windows.Forms.NumericUpDown wspolbez_nud;
        public System.Windows.Forms.DataVisualization.Charting.Chart wykres_funkcji;
        public System.Windows.Forms.DataVisualization.Charting.Chart wykres_wynikow;
        private System.Windows.Forms.Button wczytaj;
        private System.Windows.Forms.Button zapisz;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

