using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace MatGraphicPlotter
{
    public partial class Form1 : Form
    {

        public static float a;
        public static float b;
        public static float k;
        public static float k2;

        public static float a_comp;
        public static float b_comp;
        public static float k_comp;
        public static float k2_comp;


        public static float x;

        public static float max_value;
        public static float min_value;

        public static float x_values;
        public static float x_values1;

        public static float y;



        public static ChartArea CA;

        public static Series S1;
       


        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //NULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULL
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //NULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULL
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CA = chartGraph.ChartAreas[0];
            S1 = chartGraph.Series[0];
            S1.ChartType = SeriesChartType.Line;


            CA.AxisX.Crossing = 0;
            CA.AxisY.Crossing = 0;



            CA.AxisX.LineWidth = 3;
            CA.AxisY.LineWidth = 3;

            CA.AxisX.MajorGrid.Enabled = false;
            CA.AxisY.MajorGrid.Enabled = false;
            CA.AxisX.MinorTickMark.Enabled = false;
            CA.AxisY.MinorTickMark.Enabled = false;


            // CA.AxisY.Interval = Math.Ceiling((y_1 - y_3) / 100);


            // S1.Points.AddXY(2, 8);
            /////S1.Points.AddXY(5, 9);
            // S1.Points.AddXY(x3, y3); 

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            comboBox1.Items.Add(DBNull.Value);
            comboBox1.Items.Add("y = x");
            comboBox1.Items.Add("y = x^k");
            comboBox1.Items.Add("y = |x|");
            comboBox1.Items.Add("y = √ x");
            comboBox1.Items.Add("y = 1/x");

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            label1.Visible = false;
            label_a.Visible = false;
            label_arti.Visible = false;
            label_b.Visible = false;
            label_bir_bolu_x.Visible = false;
            
            
            label_k.Visible = false;
            label_kok_x.Visible = false;
            label_mutlak_sag.Visible = false;
            label_mutlak_sol.Visible = false;
            label_x.Visible = false;
            

            label2.Visible = false;
            textBox_a_input.Visible = false;
            textBox_a_payda.Visible = false;
            textBox_b_input.Visible = false;
            textBox_k_input.Visible = false;
            textBox_payda.Visible = false;

            button_plot_for_comparison.Visible = false;
            


        }

        private void button_choose_equation_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                label2.Visible = true;
                label_a.Visible = true;
                label_arti.Visible = true;
                label_b.Visible = true;
                label_x.Visible = true;
                textBox_a_input.Visible = true;
                textBox_a_payda.Visible = true;
                textBox_b_input.Visible = true;

                label_bir_bolu_x.Visible = false;
                label_kok_x.Visible = false;
                label_mutlak_sol.Visible = false;
                label_k.Visible = false;
                label_mutlak_sag.Visible = false;
                textBox_payda.Visible = false;
                label1.Visible = false;
                label_k_input.Visible = false;
                button_plot_for_comparison.Visible = false;
                textBox_k_input.Visible = false;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                label_a.Visible = true;
                label_arti.Visible = true;
                label_b.Visible = true;
                label_k.Visible = true;
                label_x.Visible = true;
                textBox_a_input.Visible = true;
                textBox_a_payda.Visible = true;
                textBox_b_input.Visible = true;
                textBox_k_input.Visible = true;
                textBox_payda.Visible = true;
                label2.Visible = true;

                label_bir_bolu_x.Visible = false;
                label_kok_x.Visible = false;
                label_mutlak_sol.Visible = false;
                label_k.Visible = true;
                label_mutlak_sag.Visible = false;
                textBox_payda.Visible = true;
                label1.Visible = true;
                label_k_input.Visible = true;
                textBox_k_input.Visible = true;
                button_plot_for_comparison.Visible = true;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                label2.Visible = true;
                label_a.Visible = true;
                label_arti.Visible = true;
                label_b.Visible = true;
                label_x.Visible = true;
                textBox_a_input.Visible = true;
                textBox_a_payda.Visible = true;
                textBox_b_input.Visible = true;


                label_bir_bolu_x.Visible = false;
                label_kok_x.Visible = false;
                label_mutlak_sol.Visible = true;
                label_mutlak_sag.Visible = true;
                label_k.Visible = false;
                textBox_payda.Visible = false;
                label1.Visible = false;
                label_k_input.Visible = false;
                textBox_k_input.Visible = false;
                button_plot_for_comparison.Visible = false;
            }
            if (comboBox1.SelectedIndex == 4)
            {

                label2.Visible = true;
                label_a.Visible = true;
                label_arti.Visible = true;
                label_b.Visible = true;
                label_x.Visible = true;
                textBox_a_input.Visible = true;
                textBox_a_payda.Visible = true;
                textBox_b_input.Visible = true;

                label_bir_bolu_x.Visible = false;
                label_kok_x.Visible = true;
                label_mutlak_sol.Visible = false;
                label_k.Visible = false;
                label_mutlak_sag.Visible = false;
                textBox_payda.Visible = false;
                label1.Visible = false;
                label_k_input.Visible = false;
                textBox_k_input.Visible = false;
                button_plot_for_comparison.Visible = false;
            }
            if (comboBox1.SelectedIndex == 5)
            {
                label2.Visible = true;
                label_a.Visible = true;
                label_arti.Visible = true;
                label_b.Visible = true;
                label_x.Visible = true;
                textBox_a_input.Visible = true;
                textBox_a_payda.Visible = true;
                textBox_b_input.Visible = true;

                label_bir_bolu_x.Visible = true;
                label_kok_x.Visible = false;
                label_mutlak_sol.Visible = false;
                label_k.Visible = false;
                label_mutlak_sag.Visible = false;
                label1.Visible = false;
                label_k_input.Visible = false;
                textBox_k_input.Visible = false;
                textBox_payda.Visible = false;
                button_plot_for_comparison.Visible = false;
            }
        }

        private void button_plot_Click(object sender, EventArgs e)
        {
            CA.AxisX.Interval = Math.Ceiling((Convert.ToDouble(textBox_max_value.Text) - Convert.ToDouble(textBox_min_value.Text)) / 100);

            //      CA.AxisY.Interval = Math.Ceiling((y - 0) / 100);
            if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Please Choose an Equation !");
            }
            if (textBox_max_value.Text == null || textBox_min_value.Text == null)
            {
                MessageBox.Show("Please Set values 'Max' and 'Min' !");
            }

            Series seri = S1;
            for (float x = min_value; x <= max_value; x++)
            {
                x_values = x;



                switch (comboBox1.SelectedIndex)
                {

                    case 1: // y = x

                        

                        label_bir_bolu_x.Visible = false;
                        label_kok_x.Visible = false;
                        label_mutlak_sol.Visible = false;
                        label_k.Visible = false;
                        label_mutlak_sag.Visible = false;
                        textBox_payda.Visible = false;
                        label1.Visible = false;
                        label_k_input.Visible = false;
                        button_plot_for_comparison.Visible = false;
                        textBox_k_input.Visible = false;


                        if (comboBox1.SelectedIndex == 1)
                        {
                            if (textBox_a_input.Text != "")
                            {
                                try
                                {
                                    a = (float)Convert.ToDouble(textBox_a_input.Text);
                                }
                                catch
                                {
                                    a = 0;
                                }

                            }
                            if (textBox_a_input.Text == "")
                            {
                                a = 1;
                            }

                            if (textBox_b_input.Text != "")
                            {
                                try
                                {
                                    b = (float)Convert.ToDouble(textBox_b_input.Text);
                                }
                                catch
                                {
                                    b = 0;
                                }

                            }



                        }
                        y = (a * x_values) + b;
                        S1.Points.AddXY(x_values, y);

                        break;


                    case 2:   // y = x^k
                        {
                            label_bir_bolu_x.Visible = false;
                            label_kok_x.Visible = false;
                            label_mutlak_sol.Visible = false;
                            label_k.Visible = true;
                            label_mutlak_sag.Visible = false;
                            textBox_payda.Visible = true;
                            label1.Visible = true;
                            label_k_input.Visible = true;
                            textBox_k_input.Visible = true;
                            button_plot_for_comparison.Visible = true;

                            if (comboBox1.SelectedIndex == 2)
                            {
                                if (textBox_a_input.Text != "")
                                {
                                    try
                                    {
                                        a = (float)Convert.ToDouble(textBox_a_input.Text);
                                    }
                                    catch
                                    {
                                        a = 0;
                                    }
                                   
                                }
                                if(textBox_a_payda.Text != "")
                                {
                                    var a_pay = float.Parse(textBox_a_input.Text);
                                    var a_payda = float.Parse(textBox_a_payda.Text);
                                    var a_sonuc = a_pay / a_payda;
                                    a = a_sonuc;
                                }
                                    
                                if (textBox_a_input.Text == "")
                                {
                                    a = 1;
                                }

                                if (textBox_b_input.Text != "")
                                {
                                    try
                                    {
                                        b = (float)Convert.ToDouble(textBox_b_input.Text);
                                    }
                                    catch
                                    {
                                        b = 0;
                                    }

                                }

                                if (textBox_payda.Text != "")
                                {
                                    var pay = float.Parse(textBox_k_input.Text);
                                    var payda = float.Parse(textBox_payda.Text);
                                    k2 = pay / payda;
                                    if (x_values < 0)
                                    {
                                        y = a * (float)Math.Pow(-x_values, k2) + b;
                                        if (pay % 2 != 0)
                                        {
                                            y = -y;
                                        }
                                    }
                                    else
                                    {
                                        y = a * (float)Math.Pow(x_values, k2) + b;
                                    }

                                    S1.Points.AddXY(x_values, y);

                                }

                                if (textBox_payda.Text == "")
                                {
                                    if (textBox_k_input.Text != "")
                                    {
                                        try
                                        {
                                            k = (float)Convert.ToDouble(textBox_k_input.Text);
                                        }
                                        catch
                                        {
                                            k = 0;
                                        }

                                    }

                                    y = (float)((a * ((float)Convert.ToDouble(Math.Pow(x_values, k)))) + b);
                                    S1.Points.AddXY(x_values, y);
                                }






                            }
                            break;
                        }

                    case 3: // y = |x|
                        {
                            button_plot_for_comparison.Visible = false;
                            label_bir_bolu_x.Visible = false;
                            label_kok_x.Visible = false;
                            label_mutlak_sol.Visible = true;
                            label_mutlak_sag.Visible = true;
                            label_k.Visible = false;
                            textBox_payda.Visible = false;
                            label1.Visible = false;
                            label_k_input.Visible = false;
                            textBox_k_input.Visible = false;

                            if (comboBox1.SelectedIndex == 3)
                            {
                                if (textBox_a_input.Text != "")
                                {
                                    try
                                    {
                                        a = (float)Convert.ToDouble(textBox_a_input.Text);
                                    }
                                    catch
                                    {
                                        a = 0;
                                    }

                                }

                                if (textBox_a_input.Text == "")
                                {
                                    a = 1;
                                }

                                if (textBox_b_input.Text != "")
                                {
                                    try
                                    {
                                        b = (float)Convert.ToDouble(textBox_b_input.Text);
                                    }
                                    catch
                                    {
                                        b = 0;
                                    }

                                }
                            }

                            y = (a * (Math.Abs(x_values))) + b;
                            S1.Points.AddXY(x_values, y);


                        }
                        break;

                    case 4: //y = √ x
                        {
                            button_plot_for_comparison.Visible = false;
                            label_bir_bolu_x.Visible = false;
                            label_kok_x.Visible = true;
                            label_mutlak_sol.Visible = false;
                            label_k.Visible = false;
                            label_mutlak_sag.Visible = false;
                            textBox_payda.Visible = false;
                            label1.Visible = false;
                            label_k_input.Visible = false;
                            textBox_k_input.Visible = false;


                            if (comboBox1.SelectedIndex == 4)
                            {

                                if (x_values < 0)
                                {
                                    break;
                                }



                                if (textBox_a_input.Text != "")
                                {
                                    try
                                    {
                                        a = (float)Convert.ToDouble(textBox_a_input.Text);
                                    }
                                    catch
                                    {
                                        a = 0;
                                    }

                                }

                                if (textBox_a_input.Text == "")
                                {
                                    a = 1;
                                }

                                if (textBox_b_input.Text != "")
                                {
                                    try
                                    {
                                        b = (float)Convert.ToDouble(textBox_b_input.Text);
                                    }
                                    catch
                                    {
                                        b = 0;
                                    }

                                }
                            }

                            y = (a * ((float)Convert.ToDouble(Math.Sqrt(x_values)))) + b;
                            S1.Points.AddXY(x_values, y);


                        }
                        break;

                    case 5: // y = 1/x
                        {
                            button_plot_for_comparison.Visible = false;
                            label_bir_bolu_x.Visible = true;
                            label_kok_x.Visible = false;
                            label_mutlak_sol.Visible = false;
                            label_k.Visible = false;
                            label_mutlak_sag.Visible = false;
                            label1.Visible = false;
                            label_k_input.Visible = false;
                            textBox_k_input.Visible = false;
                            textBox_payda.Visible = false;

                            if (x_values == 0)
                            {
                                seri = new Series();
                                seri.ChartType = SeriesChartType.Line;
                                chartGraph.Series.Add(seri);
                                continue;

                            }


                            if (comboBox1.SelectedIndex == 5)
                            {
                                if (textBox_a_input.Text != "")
                                {
                                    try
                                    {
                                        a = (float)Convert.ToDouble(textBox_a_input.Text);
                                    }
                                    catch
                                    {
                                        a = 0;
                                    }
                                }

                                if (textBox_a_payda.Text != "")
                                {
                                    var a_pay = float.Parse(textBox_a_input.Text);
                                    var a_payda = float.Parse(textBox_a_payda.Text);
                                    var a_sonuc = a_pay / a_payda;
                                    a = a_sonuc;
                                }
                                if (textBox_a_input.Text == "")
                                {
                                    a = 1;
                                }

                                if (textBox_b_input.Text != "")
                                {
                                    try
                                    {
                                        b = (float)Convert.ToDouble(textBox_b_input.Text);
                                    }
                                    catch
                                    {
                                        b = 0;
                                    }

                                }

                                if (textBox_b_input.Text == "")
                                {
                                    b = 0;
                                }

                            }


                            y = (a * (1 / x_values)) + b;
                            seri.Points.AddXY(x_values, y);

                        }
                        break;

                }



            }
            CA.AxisY.Interval = CA.AxisY.Interval / a;

        }

        private void textBox_max_value_TextChanged(object sender, EventArgs e)
        {
            //NULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULLNULL
        }

        private void button_set_max_min_Click(object sender, EventArgs e)
        {

            if (textBox_min_value.Text == "" || textBox_max_value.Text == "")
            {
                MessageBox.Show("Please Set values 'Max' and 'Min' ! ");
            }
            if (textBox_max_value.Text != "" && textBox_min_value.Text != "")
            {
                max_value = Convert.ToInt32(textBox_max_value.Text);
                min_value = Convert.ToInt32(textBox_min_value.Text);

                MessageBox.Show("Values are set!");
            }

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            S1.Points.Clear();
            textBox_a_input.Clear();
            textBox_b_input.Clear();
            textBox_k_input.Clear();
            textBox_max_value.Clear();
            textBox_min_value.Clear();
            comboBox1.SelectedIndex = 0;
            Application.Restart();


        }

        private void button_plot_for_comparison_Click(object sender, EventArgs e)
        {
           
               

                Series S2 = new Series();
                S2.ChartType = SeriesChartType.Line;
                chartGraph.Series.Add(S2);
            for (float x1 = min_value; x1 <= max_value; x1++)
            {

                x_values1 = x1;
                if (textBox_a_input.Text != "")
                {
                    try
                    {
                        a_comp = (float)Convert.ToDouble(textBox_a_input.Text);
                    }
                    catch
                    {
                        a_comp = 0;
                    }

                }
                if (textBox_a_input.Text == "")
                {
                    a_comp = 1;
                }

                if (textBox_b_input.Text != "")
                {
                    try
                    {
                        b_comp = (float)Convert.ToDouble(textBox_b_input.Text);
                    }
                    catch
                    {
                        b_comp = 0;
                    }

                }

                if (textBox_payda.Text != "")
                {
                    var pay = float.Parse(textBox_k_input.Text);
                    var payda = float.Parse(textBox_payda.Text);
                    k2_comp = pay / payda;
                    if (x_values1 < 0)
                    {
                        y = a * (float)Math.Pow(-x_values1, k2_comp) + b;
                        if (pay % 2 != 0)
                        {
                            y = -y;
                        }
                    }
                    else
                    {
                        y = a_comp * (float)Math.Pow(x_values1, k2_comp) + b_comp;
                    }

                    S2.Points.AddXY(x_values, y);

                }

                if (textBox_payda.Text == "")
                {
                    if (textBox_k_input.Text != "")
                    {
                        try
                        {
                            k_comp = (float)Convert.ToDouble(textBox_k_input.Text);
                        }
                        catch
                        {
                            k_comp = 0;
                        }

                    }

                    y = (float)((a_comp * ((float)Convert.ToDouble(Math.Pow(x_values1, k_comp)))) + b_comp);
                    S2.Points.AddXY(x_values1, y);
                }

            }
        }

        private void button_how_to_use_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1- Set values for x from the textboxes 'Max' and 'Min' and then Click the button 'Set' " + Environment.NewLine +
                "2- Choose an equation from the combobox" + Environment.NewLine +
                "3- Set values for each variable a,b,k" + Environment.NewLine +
                "4- If you are finished Click 'Plot'" + Environment.NewLine +
                "5- If you have chosen the equation y=x^k , follow the steps 1,2,3,4 and if you want to compare two seperate y=x^k equations Click 'Plot for Comparison' and follow the steps 1,2,3,4");
        }
    }
}
