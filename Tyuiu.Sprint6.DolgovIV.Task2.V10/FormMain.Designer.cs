namespace Tyuiu.Sprint6.DolgovIV.Task2.V10
{
    partial class FormMain_DIV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dataGridViewResult_DIV = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Function = new DataGridViewTextBoxColumn();
            chartResult_DIV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_DIV = new GroupBox();
            textBoxTask_DIV = new TextBox();
            buttonDone_DIV = new Button();
            buttonHelp_DIV = new Button();
            groupBoxInput_DIV = new GroupBox();
            textBoxStopStepTip_DIV = new TextBox();
            textBoxStartStepTip_DIV = new TextBox();
            textBoxStopStepInput_DIV = new TextBox();
            textBoxStartStepInput_DIV = new TextBox();
            groupBoxOutput_DIV = new GroupBox();
            textBoxResultTip_DIV = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_DIV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartResult_DIV).BeginInit();
            groupBoxTask_DIV.SuspendLayout();
            groupBoxInput_DIV.SuspendLayout();
            groupBoxOutput_DIV.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewResult_DIV
            // 
            dataGridViewResult_DIV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_DIV.Columns.AddRange(new DataGridViewColumn[] { X, Function });
            dataGridViewResult_DIV.Location = new Point(40, 39);
            dataGridViewResult_DIV.Name = "dataGridViewResult_DIV";
            dataGridViewResult_DIV.RowHeadersVisible = false;
            dataGridViewResult_DIV.Size = new Size(125, 232);
            dataGridViewResult_DIV.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // Function
            // 
            Function.HeaderText = "F(X)";
            Function.Name = "Function";
            Function.Width = 50;
            // 
            // chartResult_DIV
            // 
            chartArea1.Name = "ChartArea1";
            chartResult_DIV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResult_DIV.Legends.Add(legend1);
            chartResult_DIV.Location = new Point(216, 22);
            chartResult_DIV.Name = "chartResult_DIV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult_DIV.Series.Add(series1);
            chartResult_DIV.Size = new Size(305, 249);
            chartResult_DIV.TabIndex = 1;
            chartResult_DIV.Text = "chart1";
            // 
            // groupBoxTask_DIV
            // 
            groupBoxTask_DIV.Controls.Add(textBoxTask_DIV);
            groupBoxTask_DIV.Location = new Point(24, 12);
            groupBoxTask_DIV.Name = "groupBoxTask_DIV";
            groupBoxTask_DIV.Size = new Size(460, 146);
            groupBoxTask_DIV.TabIndex = 3;
            groupBoxTask_DIV.TabStop = false;
            groupBoxTask_DIV.Text = "Условие";
            // 
            // textBoxTask_DIV
            // 
            textBoxTask_DIV.BorderStyle = BorderStyle.None;
            textBoxTask_DIV.Location = new Point(16, 39);
            textBoxTask_DIV.Multiline = true;
            textBoxTask_DIV.Name = "textBoxTask_DIV";
            textBoxTask_DIV.ReadOnly = true;
            textBoxTask_DIV.Size = new Size(342, 64);
            textBoxTask_DIV.TabIndex = 3;
            textBoxTask_DIV.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы\r\n";
            // 
            // buttonDone_DIV
            // 
            buttonDone_DIV.BackColor = SystemColors.Info;
            buttonDone_DIV.Location = new Point(365, 221);
            buttonDone_DIV.Name = "buttonDone_DIV";
            buttonDone_DIV.Size = new Size(119, 45);
            buttonDone_DIV.TabIndex = 8;
            buttonDone_DIV.Text = "Выполнить";
            buttonDone_DIV.UseVisualStyleBackColor = false;
            buttonDone_DIV.Click += buttonDone_Click;
            buttonDone_DIV.MouseDown += buttonDone_MouseDown;
            buttonDone_DIV.MouseEnter += buttonDone_MouseEnter;
            buttonDone_DIV.MouseLeave += buttonDone_MouseLeave;
            // 
            // buttonHelp_DIV
            // 
            buttonHelp_DIV.BackColor = SystemColors.ActiveCaption;
            buttonHelp_DIV.Location = new Point(284, 221);
            buttonHelp_DIV.Name = "buttonHelp_DIV";
            buttonHelp_DIV.Size = new Size(75, 45);
            buttonHelp_DIV.TabIndex = 7;
            buttonHelp_DIV.Text = "Справка";
            buttonHelp_DIV.UseVisualStyleBackColor = false;
            buttonHelp_DIV.Click += buttonMessage_Click;
            // 
            // groupBoxInput_DIV
            // 
            groupBoxInput_DIV.Controls.Add(textBoxStopStepTip_DIV);
            groupBoxInput_DIV.Controls.Add(textBoxStartStepTip_DIV);
            groupBoxInput_DIV.Controls.Add(textBoxStopStepInput_DIV);
            groupBoxInput_DIV.Controls.Add(textBoxStartStepInput_DIV);
            groupBoxInput_DIV.Location = new Point(24, 164);
            groupBoxInput_DIV.Name = "groupBoxInput_DIV";
            groupBoxInput_DIV.Size = new Size(252, 138);
            groupBoxInput_DIV.TabIndex = 6;
            groupBoxInput_DIV.TabStop = false;
            groupBoxInput_DIV.Text = "Ввод данных";
            // 
            // textBoxStopStepTip_DIV
            // 
            textBoxStopStepTip_DIV.BorderStyle = BorderStyle.None;
            textBoxStopStepTip_DIV.Location = new Point(143, 57);
            textBoxStopStepTip_DIV.Name = "textBoxStopStepTip_DIV";
            textBoxStopStepTip_DIV.ReadOnly = true;
            textBoxStopStepTip_DIV.Size = new Size(100, 16);
            textBoxStopStepTip_DIV.TabIndex = 4;
            textBoxStopStepTip_DIV.Text = "Конец шага:";
            // 
            // textBoxStartStepTip_DIV
            // 
            textBoxStartStepTip_DIV.BorderStyle = BorderStyle.None;
            textBoxStartStepTip_DIV.Location = new Point(16, 57);
            textBoxStartStepTip_DIV.Name = "textBoxStartStepTip_DIV";
            textBoxStartStepTip_DIV.ReadOnly = true;
            textBoxStartStepTip_DIV.Size = new Size(100, 16);
            textBoxStartStepTip_DIV.TabIndex = 3;
            textBoxStartStepTip_DIV.Text = "Старт шага:";
            // 
            // textBoxStopStepInput_DIV
            // 
            textBoxStopStepInput_DIV.Location = new Point(143, 79);
            textBoxStopStepInput_DIV.Name = "textBoxStopStepInput_DIV";
            textBoxStopStepInput_DIV.Size = new Size(100, 23);
            textBoxStopStepInput_DIV.TabIndex = 2;
            // 
            // textBoxStartStepInput_DIV
            // 
            textBoxStartStepInput_DIV.Location = new Point(16, 79);
            textBoxStartStepInput_DIV.Name = "textBoxStartStepInput_DIV";
            textBoxStartStepInput_DIV.Size = new Size(100, 23);
            textBoxStartStepInput_DIV.TabIndex = 0;
            // 
            // groupBoxOutput_DIV
            // 
            groupBoxOutput_DIV.Controls.Add(textBoxResultTip_DIV);
            groupBoxOutput_DIV.Controls.Add(dataGridViewResult_DIV);
            groupBoxOutput_DIV.Controls.Add(chartResult_DIV);
            groupBoxOutput_DIV.Location = new Point(490, 12);
            groupBoxOutput_DIV.Name = "groupBoxOutput_DIV";
            groupBoxOutput_DIV.Size = new Size(527, 290);
            groupBoxOutput_DIV.TabIndex = 9;
            groupBoxOutput_DIV.TabStop = false;
            groupBoxOutput_DIV.Text = "Вывод данных";
            // 
            // textBoxResultTip_DIV
            // 
            textBoxResultTip_DIV.BorderStyle = BorderStyle.None;
            textBoxResultTip_DIV.Location = new Point(18, 17);
            textBoxResultTip_DIV.Name = "textBoxResultTip_DIV";
            textBoxResultTip_DIV.ReadOnly = true;
            textBoxResultTip_DIV.Size = new Size(100, 16);
            textBoxResultTip_DIV.TabIndex = 5;
            textBoxResultTip_DIV.Text = "Результат:";
            // 
            // FormMain_DIV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 314);
            Controls.Add(groupBoxOutput_DIV);
            Controls.Add(buttonDone_DIV);
            Controls.Add(groupBoxTask_DIV);
            Controls.Add(buttonHelp_DIV);
            Controls.Add(groupBoxInput_DIV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain_DIV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 10 | Долгов И.В.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_DIV).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartResult_DIV).EndInit();
            groupBoxTask_DIV.ResumeLayout(false);
            groupBoxTask_DIV.PerformLayout();
            groupBoxInput_DIV.ResumeLayout(false);
            groupBoxInput_DIV.PerformLayout();
            groupBoxOutput_DIV.ResumeLayout(false);
            groupBoxOutput_DIV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewResult_DIV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_DIV;
        private GroupBox groupBoxTask_DIV;
        private TextBox textBoxTask_DIV;
        private Button buttonDone_DIV;
        private Button buttonHelp_DIV;
        private GroupBox groupBoxInput_DIV;
        private TextBox textBoxStopStepTip_DIV;
        private TextBox textBoxStartStepTip_DIV;
        private TextBox textBoxStopStepInput_DIV;
        private TextBox textBoxStartStepInput_DIV;
        private GroupBox groupBoxOutput_DIV;
        private TextBox textBoxResultTip_DIV;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Function;
    }
}
