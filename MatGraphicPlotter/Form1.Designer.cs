namespace MatGraphicPlotter
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_f_x = new System.Windows.Forms.Label();
            this.label_esittir = new System.Windows.Forms.Label();
            this.label_a = new System.Windows.Forms.Label();
            this.label_x = new System.Windows.Forms.Label();
            this.label_k = new System.Windows.Forms.Label();
            this.label_arti = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_y_esittir = new System.Windows.Forms.Label();
            this.textBox_a_input = new System.Windows.Forms.TextBox();
            this.textBox_k_input = new System.Windows.Forms.TextBox();
            this.textBox_b_input = new System.Windows.Forms.TextBox();
            this.label_a_input = new System.Windows.Forms.Label();
            this.label_k_input = new System.Windows.Forms.Label();
            this.label_b_input = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_max_value = new System.Windows.Forms.TextBox();
            this.textBox_min_value = new System.Windows.Forms.TextBox();
            this.button_set_max_min = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label_mutlak_sol = new System.Windows.Forms.Label();
            this.label_kok_x = new System.Windows.Forms.Label();
            this.label_bir_bolu_x = new System.Windows.Forms.Label();
            this.label_mutlak_sag = new System.Windows.Forms.Label();
            this.button_choose_equation = new System.Windows.Forms.Button();
            this.button_plot = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_payda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_plot_for_comparison = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_a_payda = new System.Windows.Forms.TextBox();
            this.button_how_to_use = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraph.Legends.Add(legend1);
            this.chartGraph.Location = new System.Drawing.Point(355, 15);
            this.chartGraph.Name = "chartGraph";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGraph.Series.Add(series1);
            this.chartGraph.Size = new System.Drawing.Size(934, 581);
            this.chartGraph.TabIndex = 0;
            this.chartGraph.Text = "chart1";
            // 
            // label_f_x
            // 
            this.label_f_x.AutoSize = true;
            this.label_f_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_f_x.Location = new System.Drawing.Point(78, 40);
            this.label_f_x.Name = "label_f_x";
            this.label_f_x.Size = new System.Drawing.Size(63, 37);
            this.label_f_x.TabIndex = 1;
            this.label_f_x.Text = "f(x)";
            // 
            // label_esittir
            // 
            this.label_esittir.AutoSize = true;
            this.label_esittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_esittir.Location = new System.Drawing.Point(138, 40);
            this.label_esittir.Name = "label_esittir";
            this.label_esittir.Size = new System.Drawing.Size(36, 37);
            this.label_esittir.TabIndex = 2;
            this.label_esittir.Text = "=";
            this.label_esittir.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_a.Location = new System.Drawing.Point(167, 40);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(35, 37);
            this.label_a.TabIndex = 3;
            this.label_a.Text = "a";
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_x.Location = new System.Drawing.Point(217, 40);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(32, 37);
            this.label_x.TabIndex = 4;
            this.label_x.Text = "x";
            // 
            // label_k
            // 
            this.label_k.AutoSize = true;
            this.label_k.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_k.Location = new System.Drawing.Point(235, 9);
            this.label_k.Name = "label_k";
            this.label_k.Size = new System.Drawing.Size(33, 37);
            this.label_k.TabIndex = 5;
            this.label_k.Text = "k";
            // 
            // label_arti
            // 
            this.label_arti.AutoSize = true;
            this.label_arti.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_arti.Location = new System.Drawing.Point(274, 40);
            this.label_arti.Name = "label_arti";
            this.label_arti.Size = new System.Drawing.Size(36, 37);
            this.label_arti.TabIndex = 6;
            this.label_arti.Text = "+";
            this.label_arti.Click += new System.EventHandler(this.label6_Click);
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_b.Location = new System.Drawing.Point(298, 40);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(35, 37);
            this.label_b.TabIndex = 7;
            this.label_b.Text = "b";
            // 
            // label_y_esittir
            // 
            this.label_y_esittir.AutoSize = true;
            this.label_y_esittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_y_esittir.Location = new System.Drawing.Point(12, 40);
            this.label_y_esittir.Name = "label_y_esittir";
            this.label_y_esittir.Size = new System.Drawing.Size(60, 37);
            this.label_y_esittir.TabIndex = 8;
            this.label_y_esittir.Text = "y =";
            // 
            // textBox_a_input
            // 
            this.textBox_a_input.Location = new System.Drawing.Point(92, 162);
            this.textBox_a_input.Name = "textBox_a_input";
            this.textBox_a_input.Size = new System.Drawing.Size(49, 20);
            this.textBox_a_input.TabIndex = 9;
            // 
            // textBox_k_input
            // 
            this.textBox_k_input.Location = new System.Drawing.Point(92, 203);
            this.textBox_k_input.Name = "textBox_k_input";
            this.textBox_k_input.Size = new System.Drawing.Size(49, 20);
            this.textBox_k_input.TabIndex = 10;
            // 
            // textBox_b_input
            // 
            this.textBox_b_input.Location = new System.Drawing.Point(92, 243);
            this.textBox_b_input.Name = "textBox_b_input";
            this.textBox_b_input.Size = new System.Drawing.Size(125, 20);
            this.textBox_b_input.TabIndex = 11;
            // 
            // label_a_input
            // 
            this.label_a_input.AutoSize = true;
            this.label_a_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_a_input.Location = new System.Drawing.Point(22, 147);
            this.label_a_input.Name = "label_a_input";
            this.label_a_input.Size = new System.Drawing.Size(35, 37);
            this.label_a_input.TabIndex = 14;
            this.label_a_input.Text = "a";
            // 
            // label_k_input
            // 
            this.label_k_input.AutoSize = true;
            this.label_k_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_k_input.Location = new System.Drawing.Point(22, 188);
            this.label_k_input.Name = "label_k_input";
            this.label_k_input.Size = new System.Drawing.Size(33, 37);
            this.label_k_input.TabIndex = 16;
            this.label_k_input.Text = "k";
            // 
            // label_b_input
            // 
            this.label_b_input.AutoSize = true;
            this.label_b_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_b_input.Location = new System.Drawing.Point(22, 228);
            this.label_b_input.Name = "label_b_input";
            this.label_b_input.Size = new System.Drawing.Size(35, 37);
            this.label_b_input.TabIndex = 17;
            this.label_b_input.Text = "b";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 307);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Max";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(71, 307);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Min";
            // 
            // textBox_max_value
            // 
            this.textBox_max_value.Location = new System.Drawing.Point(19, 323);
            this.textBox_max_value.Name = "textBox_max_value";
            this.textBox_max_value.Size = new System.Drawing.Size(40, 20);
            this.textBox_max_value.TabIndex = 20;
            this.textBox_max_value.TextChanged += new System.EventHandler(this.textBox_max_value_TextChanged);
            // 
            // textBox_min_value
            // 
            this.textBox_min_value.Location = new System.Drawing.Point(65, 323);
            this.textBox_min_value.Name = "textBox_min_value";
            this.textBox_min_value.Size = new System.Drawing.Size(41, 20);
            this.textBox_min_value.TabIndex = 21;
            // 
            // button_set_max_min
            // 
            this.button_set_max_min.Location = new System.Drawing.Point(19, 349);
            this.button_set_max_min.Name = "button_set_max_min";
            this.button_set_max_min.Size = new System.Drawing.Size(87, 56);
            this.button_set_max_min.TabIndex = 22;
            this.button_set_max_min.Text = "Set";
            this.button_set_max_min.UseVisualStyleBackColor = true;
            this.button_set_max_min.Click += new System.EventHandler(this.button_set_max_min_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(243, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(241, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Choose an equation";
            // 
            // label_mutlak_sol
            // 
            this.label_mutlak_sol.AutoSize = true;
            this.label_mutlak_sol.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_mutlak_sol.Location = new System.Drawing.Point(193, 40);
            this.label_mutlak_sol.Name = "label_mutlak_sol";
            this.label_mutlak_sol.Size = new System.Drawing.Size(24, 37);
            this.label_mutlak_sol.TabIndex = 25;
            this.label_mutlak_sol.Text = "|";
            // 
            // label_kok_x
            // 
            this.label_kok_x.AutoSize = true;
            this.label_kok_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kok_x.Location = new System.Drawing.Point(206, 40);
            this.label_kok_x.Name = "label_kok_x";
            this.label_kok_x.Size = new System.Drawing.Size(59, 37);
            this.label_kok_x.TabIndex = 26;
            this.label_kok_x.Text = "√ x";
            // 
            // label_bir_bolu_x
            // 
            this.label_bir_bolu_x.AutoSize = true;
            this.label_bir_bolu_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_bir_bolu_x.Location = new System.Drawing.Point(208, 40);
            this.label_bir_bolu_x.Name = "label_bir_bolu_x";
            this.label_bir_bolu_x.Size = new System.Drawing.Size(57, 37);
            this.label_bir_bolu_x.TabIndex = 27;
            this.label_bir_bolu_x.Text = "1/x";
            // 
            // label_mutlak_sag
            // 
            this.label_mutlak_sag.AutoSize = true;
            this.label_mutlak_sag.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_mutlak_sag.Location = new System.Drawing.Point(255, 40);
            this.label_mutlak_sag.Name = "label_mutlak_sag";
            this.label_mutlak_sag.Size = new System.Drawing.Size(24, 37);
            this.label_mutlak_sag.TabIndex = 28;
            this.label_mutlak_sag.Text = "|";
            // 
            // button_choose_equation
            // 
            this.button_choose_equation.Location = new System.Drawing.Point(244, 275);
            this.button_choose_equation.Name = "button_choose_equation";
            this.button_choose_equation.Size = new System.Drawing.Size(99, 62);
            this.button_choose_equation.TabIndex = 29;
            this.button_choose_equation.Text = "Choose";
            this.button_choose_equation.UseVisualStyleBackColor = true;
            this.button_choose_equation.Click += new System.EventHandler(this.button_choose_equation_Click);
            // 
            // button_plot
            // 
            this.button_plot.Location = new System.Drawing.Point(243, 343);
            this.button_plot.Name = "button_plot";
            this.button_plot.Size = new System.Drawing.Size(99, 62);
            this.button_plot.TabIndex = 30;
            this.button_plot.Text = "Plot";
            this.button_plot.UseVisualStyleBackColor = true;
            this.button_plot.Click += new System.EventHandler(this.button_plot_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(19, 490);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(323, 62);
            this.button_clear.TabIndex = 31;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_payda
            // 
            this.textBox_payda.Location = new System.Drawing.Point(168, 203);
            this.textBox_payda.Name = "textBox_payda";
            this.textBox_payda.Size = new System.Drawing.Size(49, 20);
            this.textBox_payda.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(144, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "/";
            // 
            // button_plot_for_comparison
            // 
            this.button_plot_for_comparison.Location = new System.Drawing.Point(242, 411);
            this.button_plot_for_comparison.Name = "button_plot_for_comparison";
            this.button_plot_for_comparison.Size = new System.Drawing.Size(99, 62);
            this.button_plot_for_comparison.TabIndex = 34;
            this.button_plot_for_comparison.Text = "Plot for Comparison";
            this.button_plot_for_comparison.UseVisualStyleBackColor = true;
            this.button_plot_for_comparison.Click += new System.EventHandler(this.button_plot_for_comparison_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(147, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "/";
            // 
            // textBox_a_payda
            // 
            this.textBox_a_payda.Location = new System.Drawing.Point(171, 162);
            this.textBox_a_payda.Name = "textBox_a_payda";
            this.textBox_a_payda.Size = new System.Drawing.Size(49, 20);
            this.textBox_a_payda.TabIndex = 36;
            // 
            // button_how_to_use
            // 
            this.button_how_to_use.Location = new System.Drawing.Point(127, 307);
            this.button_how_to_use.Name = "button_how_to_use";
            this.button_how_to_use.Size = new System.Drawing.Size(93, 166);
            this.button_how_to_use.TabIndex = 37;
            this.button_how_to_use.Text = "How to use ";
            this.button_how_to_use.UseVisualStyleBackColor = true;
            this.button_how_to_use.Click += new System.EventHandler(this.button_how_to_use_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 613);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Mehmet Umut İNCEER. Tüm hakları saklıdır © (2017)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "x Values";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 646);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_how_to_use);
            this.Controls.Add(this.textBox_a_payda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_plot_for_comparison);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_payda);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_plot);
            this.Controls.Add(this.button_choose_equation);
            this.Controls.Add(this.label_mutlak_sag);
            this.Controls.Add(this.label_bir_bolu_x);
            this.Controls.Add(this.label_kok_x);
            this.Controls.Add(this.label_mutlak_sol);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_set_max_min);
            this.Controls.Add(this.textBox_min_value);
            this.Controls.Add(this.textBox_max_value);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label_b_input);
            this.Controls.Add(this.label_k_input);
            this.Controls.Add(this.label_a_input);
            this.Controls.Add(this.textBox_b_input);
            this.Controls.Add(this.textBox_k_input);
            this.Controls.Add(this.textBox_a_input);
            this.Controls.Add(this.label_y_esittir);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_arti);
            this.Controls.Add(this.label_k);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.label_esittir);
            this.Controls.Add(this.label_f_x);
            this.Controls.Add(this.chartGraph);
            this.Name = "Form1";
            this.Text = "Mathematical Graph Plotter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
        private System.Windows.Forms.Label label_f_x;
        private System.Windows.Forms.Label label_esittir;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_k;
        private System.Windows.Forms.Label label_arti;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_y_esittir;
        private System.Windows.Forms.TextBox textBox_a_input;
        private System.Windows.Forms.TextBox textBox_k_input;
        private System.Windows.Forms.TextBox textBox_b_input;
        private System.Windows.Forms.Label label_a_input;
        private System.Windows.Forms.Label label_k_input;
        private System.Windows.Forms.Label label_b_input;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_max_value;
        private System.Windows.Forms.TextBox textBox_min_value;
        private System.Windows.Forms.Button button_set_max_min;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label_mutlak_sol;
        private System.Windows.Forms.Label label_kok_x;
        private System.Windows.Forms.Label label_bir_bolu_x;
        private System.Windows.Forms.Label label_mutlak_sag;
        private System.Windows.Forms.Button button_choose_equation;
        private System.Windows.Forms.Button button_plot;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_payda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_plot_for_comparison;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_a_payda;
        private System.Windows.Forms.Button button_how_to_use;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

