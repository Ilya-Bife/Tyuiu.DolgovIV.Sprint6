namespace Tyuiu.DolgovIV.Sprint6.Task4.V5
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxInput = new GroupBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBoxEndInput = new TextBox();
            textBoxStartInput = new TextBox();
            groupBoxOutput = new GroupBox();
            textBoxResult = new TextBox();
            buttonDone = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            chartFunction.Location = new Point(638, 27);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(417, 431);
            chartFunction.TabIndex = 0;
            chartFunction.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График функции";
            chartFunction.Titles.Add(title1);
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBox5);
            groupBoxInput.Controls.Add(textBox4);
            groupBoxInput.Controls.Add(textBoxEndInput);
            groupBoxInput.Controls.Add(textBoxStartInput);
            groupBoxInput.Location = new Point(292, 503);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(325, 100);
            groupBoxInput.TabIndex = 1;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(159, 22);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 3;
            textBox5.Text = "Конец:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(33, 22);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 2;
            textBox4.Text = "Старт:";
            // 
            // textBoxEndInput
            // 
            textBoxEndInput.Location = new Point(159, 50);
            textBoxEndInput.Name = "textBoxEndInput";
            textBoxEndInput.Size = new Size(100, 23);
            textBoxEndInput.TabIndex = 1;
            // 
            // textBoxStartInput
            // 
            textBoxStartInput.Location = new Point(33, 50);
            textBoxStartInput.Name = "textBoxStartInput";
            textBoxStartInput.Size = new Size(100, 23);
            textBoxStartInput.TabIndex = 0;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(textBoxResult);
            groupBoxOutput.Location = new Point(50, 59);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(313, 399);
            groupBoxOutput.TabIndex = 2;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 22);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(292, 371);
            textBoxResult.TabIndex = 0;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(677, 533);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(108, 49);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += ButtonDone_Click;
            // 
            // button1
            // 
            button1.Location = new Point(826, 539);
            button1.Name = "button1";
            button1.Size = new Size(108, 43);
            button1.TabIndex = 4;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonSave_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 636);
            Controls.Add(button1);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxInput);
            Controls.Add(chartFunction);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private GroupBox groupBoxInput;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBoxEndInput;
        private TextBox textBoxStartInput;
        private GroupBox groupBoxOutput;
        private TextBox textBoxResult;
        private Button buttonDone;
        private Button button1;
    }
}
