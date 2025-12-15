namespace Tyuiu.DolgovIV.Sprint6.Task3.V28
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
            textBox1 = new TextBox();
            groupBoxTask = new GroupBox();
            dataGridViewMatrix = new DataGridView();
            buttonComplete = new Button();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 266);
            textBox1.TabIndex = 0;
            textBox1.Text = "Дан массив 5 на 5 элементов:\r\n\r\n-9   8   9  16 -18\r\n\r\n -13 -11 -20 -15   9\r\n\r\n  18  13 -12 -15 -11\r\n\r\n  10  -2  19  -4 -10\r\n\r\n   6 -20  -4  13 -14\r\n\r\nЗаменить четные значения в четвертой строке на 0.";
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(dataGridViewMatrix);
            groupBoxTask.Controls.Add(textBox1);
            groupBoxTask.Location = new Point(50, 50);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(547, 368);
            groupBoxTask.TabIndex = 1;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.Location = new Point(294, 90);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.Size = new Size(240, 150);
            dataGridViewMatrix.TabIndex = 2;
            // 
            // buttonComplete
            // 
            buttonComplete.Location = new Point(652, 349);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(108, 44);
            buttonComplete.TabIndex = 2;
            buttonComplete.Text = "Выполнить";
            buttonComplete.UseVisualStyleBackColor = true;
            buttonComplete.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonComplete);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private GroupBox groupBoxTask;
        private DataGridView dataGridViewMatrix;
        private Button buttonComplete;
    }
}
