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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FlightSimulation
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
            dataGridView_table.Columns.Add("Parameter", "");
            dataGridView_table.Rows.Add("Шаг");
            dataGridView_table.Rows.Add("Дистанция");
            dataGridView_table.Rows.Add("Максимальная высота");
            dataGridView_table.Rows.Add("Скорость в последней точке");
        }

        const double g = 9.81;
        const double C = 0.15;
        const double rho = 1.29;
        double t, x, y, V0, cos_a, sin_a, S, m, k, Vx, Vy;
        private void button_startModeling_Click(object sender, EventArgs e)
        {
            //Validation
            string height = textBox_height.Text;
            string speed = textBox_speed.Text;
            string angle = textBox_angle.Text;
            string square = textBox_square.Text;
            string weight = textBox_weight.Text;
            string modelingStep = textBox_modelingStep.Text;

            double heightValue, speedValue, angleValue, squareValue, weightValue, modelingStepValue;

            if (!double.TryParse(height, out heightValue) || heightValue < 0)
            {
                MessageBox.Show("Введите корректное значение для высоты (>= 0)!");
                return;
            }

            if (!double.TryParse(speed, out speedValue) || speedValue < 0)
            {
                MessageBox.Show("Введите корректное значение для скорости (>= 0)!");
                return;
            }

            if (!double.TryParse(angle, out angleValue) || angleValue < 0 || angleValue > 90)
            {
                MessageBox.Show("Введите корректное значение для угла (в диапозоне [0, 90] градусов)!");
                return;
            }

            if (!double.TryParse(square, out squareValue) || squareValue <= 0)
            {
                MessageBox.Show("Введите корректное значение для площади (> 0)!");
                return;
            }

            if (!double.TryParse(weight, out weightValue) || weightValue <= 0)
            {
                MessageBox.Show("Введите корректное значение для массы (> 0)!");
                return;
            }

            if (!double.TryParse(modelingStep, out modelingStepValue) || modelingStepValue <= 0)
            {
                MessageBox.Show("Введите корректное значение для шага моделирования (> 0)!");
                return;
            }
            // Validation

            //Theory
            chart.Series[0].Points.Clear();
            t = 0;
            x = 0;
            y = heightValue;
            V0 = speedValue;
            double a = angleValue * Math.PI / 180;
            cos_a = Math.Cos(a);
            sin_a = Math.Sin(a);
            S = squareValue;
            m = weightValue;
            k = (0.5 * C * rho * S) / m;
            Vx = V0 * cos_a;
            Vy = V0 * sin_a;
            chart.Series[0].Points.AddXY(x, y);
            while (y >= 0)
            {
                t += modelingStepValue;
                double V = Math.Sqrt((Vx * Vx + Vy * Vy));
                Vx = Vx - k * Vx * V * modelingStepValue;
                Vy = Vy - (g + k * Vy * V) * modelingStepValue;
                x = x + Vx * modelingStepValue;
                y = y + Vy * modelingStepValue;
                chart.Series[0].Points.AddXY(x, y);
            }
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.ChartAreas[0].AxisY.Minimum = 0;

            dataGridView_table.Columns.Add("Parameter", "");

            // номер добавленного столбца
            int newColumnIndex = dataGridView_table.Columns.Count - 1;

            dataGridView_table.Rows[0].Cells[newColumnIndex].Value = modelingStepValue;
            dataGridView_table.Rows[1].Cells[newColumnIndex].Value = x.ToString("F3");
            dataGridView_table.Rows[2].Cells[newColumnIndex].Value = chart.Series[0].Points.FindMaxByValue("Y").YValues[0].ToString("F3");
            dataGridView_table.Rows[3].Cells[newColumnIndex].Value = Math.Sqrt(Vx * Vx + Vy * Vy).ToString("F3");
        }
    }
}
