namespace Tyuiu.DolgovIV.Sprint6.Task5.V9
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
            groupBoxResult = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            dataGridViewNums = new DataGridView();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).BeginInit();
            SuspendLayout();
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(chartFunction);
            groupBoxResult.Location = new Point(282, 248);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(642, 340);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат";
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            chartFunction.Location = new Point(46, 22);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(300, 300);
            chartFunction.TabIndex = 1;
            chartFunction.Text = "chart1";
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(646, 120);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(110, 48);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(794, 120);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(109, 48);
            buttonOpenFile.TabIndex = 2;
            buttonOpenFile.Text = "Открыть";
            buttonOpenFile.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNums
            // 
            dataGridViewNums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums.Location = new Point(12, 70);
            dataGridViewNums.Name = "dataGridViewNums";
            dataGridViewNums.Size = new Size(240, 518);
            dataGridViewNums.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 630);
            Controls.Add(dataGridViewNums);
            Controls.Add(buttonOpenFile);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxResult);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private Button buttonDone;
        private Button buttonOpenFile;
        private DataGridView dataGridViewNums;
    }
}
