namespace FlightSimulation
{
    partial class Form_main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_height = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_speed = new System.Windows.Forms.TextBox();
            this.textBox_angle = new System.Windows.Forms.TextBox();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.textBox_square = new System.Windows.Forms.TextBox();
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.textBox_modelingStep = new System.Windows.Forms.TextBox();
            this.button_startModeling = new System.Windows.Forms.Button();
            this.label_modelingStep = new System.Windows.Forms.Label();
            this.label_weight = new System.Windows.Forms.Label();
            this.label_square = new System.Windows.Forms.Label();
            this.label_speed = new System.Windows.Forms.Label();
            this.label_angle = new System.Windows.Forms.Label();
            this.dataGridView_table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(70, 122);
            this.chart.Margin = new System.Windows.Forms.Padding(2);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(800, 400);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_height.Location = new System.Drawing.Point(5, 12);
            this.label_height.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(59, 19);
            this.label_height.TabIndex = 1;
            this.label_height.Text = "Высота";
            this.label_height.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_speed);
            this.panel1.Controls.Add(this.textBox_angle);
            this.panel1.Controls.Add(this.textBox_height);
            this.panel1.Controls.Add(this.textBox_square);
            this.panel1.Controls.Add(this.textBox_weight);
            this.panel1.Controls.Add(this.textBox_modelingStep);
            this.panel1.Controls.Add(this.button_startModeling);
            this.panel1.Controls.Add(this.label_modelingStep);
            this.panel1.Controls.Add(this.label_weight);
            this.panel1.Controls.Add(this.label_square);
            this.panel1.Controls.Add(this.label_speed);
            this.panel1.Controls.Add(this.label_angle);
            this.panel1.Controls.Add(this.label_height);
            this.panel1.Location = new System.Drawing.Point(70, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 114);
            this.panel1.TabIndex = 3;
            // 
            // textBox_speed
            // 
            this.textBox_speed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_speed.Location = new System.Drawing.Point(81, 84);
            this.textBox_speed.Name = "textBox_speed";
            this.textBox_speed.Size = new System.Drawing.Size(100, 26);
            this.textBox_speed.TabIndex = 19;
            this.textBox_speed.Text = "15";
            // 
            // textBox_angle
            // 
            this.textBox_angle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_angle.Location = new System.Drawing.Point(51, 46);
            this.textBox_angle.Name = "textBox_angle";
            this.textBox_angle.Size = new System.Drawing.Size(100, 26);
            this.textBox_angle.TabIndex = 18;
            this.textBox_angle.Text = "30";
            // 
            // textBox_height
            // 
            this.textBox_height.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_height.Location = new System.Drawing.Point(69, 9);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(100, 26);
            this.textBox_height.TabIndex = 17;
            this.textBox_height.Text = "5";
            // 
            // textBox_square
            // 
            this.textBox_square.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_square.Location = new System.Drawing.Point(293, 10);
            this.textBox_square.Name = "textBox_square";
            this.textBox_square.Size = new System.Drawing.Size(100, 26);
            this.textBox_square.TabIndex = 16;
            this.textBox_square.Text = "1,5";
            // 
            // textBox_weight
            // 
            this.textBox_weight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_weight.Location = new System.Drawing.Point(275, 46);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(100, 26);
            this.textBox_weight.TabIndex = 15;
            this.textBox_weight.Text = "0,8";
            // 
            // textBox_modelingStep
            // 
            this.textBox_modelingStep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_modelingStep.Location = new System.Drawing.Point(371, 81);
            this.textBox_modelingStep.Name = "textBox_modelingStep";
            this.textBox_modelingStep.Size = new System.Drawing.Size(100, 26);
            this.textBox_modelingStep.TabIndex = 14;
            this.textBox_modelingStep.Text = "0,1";
            // 
            // button_startModeling
            // 
            this.button_startModeling.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_startModeling.Location = new System.Drawing.Point(690, 42);
            this.button_startModeling.Margin = new System.Windows.Forms.Padding(2);
            this.button_startModeling.Name = "button_startModeling";
            this.button_startModeling.Size = new System.Drawing.Size(80, 32);
            this.button_startModeling.TabIndex = 13;
            this.button_startModeling.Text = "Запуск";
            this.button_startModeling.UseVisualStyleBackColor = true;
            this.button_startModeling.Click += new System.EventHandler(this.button_startModeling_Click);
            // 
            // label_modelingStep
            // 
            this.label_modelingStep.AutoSize = true;
            this.label_modelingStep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_modelingStep.Location = new System.Drawing.Point(219, 84);
            this.label_modelingStep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_modelingStep.Name = "label_modelingStep";
            this.label_modelingStep.Size = new System.Drawing.Size(147, 19);
            this.label_modelingStep.TabIndex = 11;
            this.label_modelingStep.Text = "Шаг моделирования";
            this.label_modelingStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_weight.Location = new System.Drawing.Point(219, 48);
            this.label_weight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(51, 19);
            this.label_weight.TabIndex = 9;
            this.label_weight.Text = "Масса";
            this.label_weight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_square
            // 
            this.label_square.AutoSize = true;
            this.label_square.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_square.Location = new System.Drawing.Point(219, 13);
            this.label_square.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_square.Name = "label_square";
            this.label_square.Size = new System.Drawing.Size(69, 19);
            this.label_square.TabIndex = 7;
            this.label_square.Text = "Площадь";
            this.label_square.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_speed.Location = new System.Drawing.Point(5, 87);
            this.label_speed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(71, 19);
            this.label_speed.TabIndex = 5;
            this.label_speed.Text = "Скорость";
            this.label_speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_angle
            // 
            this.label_angle.AutoSize = true;
            this.label_angle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_angle.Location = new System.Drawing.Point(5, 49);
            this.label_angle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_angle.Name = "label_angle";
            this.label_angle.Size = new System.Drawing.Size(41, 19);
            this.label_angle.TabIndex = 3;
            this.label_angle.Text = "Угол";
            this.label_angle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_table
            // 
            this.dataGridView_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_table.Location = new System.Drawing.Point(70, 527);
            this.dataGridView_table.Name = "dataGridView_table";
            this.dataGridView_table.ReadOnly = true;
            this.dataGridView_table.Size = new System.Drawing.Size(800, 150);
            this.dataGridView_table.TabIndex = 4;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.dataGridView_table);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_main";
            this.Text = "Form_main";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_startModeling;
        private System.Windows.Forms.Label label_modelingStep;
        private System.Windows.Forms.Label label_weight;
        private System.Windows.Forms.Label label_square;
        private System.Windows.Forms.Label label_speed;
        private System.Windows.Forms.Label label_angle;
        private System.Windows.Forms.DataGridView dataGridView_table;
        private System.Windows.Forms.TextBox textBox_speed;
        private System.Windows.Forms.TextBox textBox_angle;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.TextBox textBox_square;
        private System.Windows.Forms.TextBox textBox_weight;
        private System.Windows.Forms.TextBox textBox_modelingStep;
    }
}

