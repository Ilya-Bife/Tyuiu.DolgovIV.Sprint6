namespace Tyuiu.DolgovIV.Sprint6.Task1.V7
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
            textBoxStartStepInput_DIV = new TextBox();
            groupBoxInput_DIV = new GroupBox();
            textBoxStopStepTip_DIV = new TextBox();
            textBoxStartStepTip_DIV = new TextBox();
            textBoxStopStepInput_DIV = new TextBox();
            groupBoxTask_DIV = new GroupBox();
            textBoxTask_DIV = new TextBox();
            groupBoxResult_DIV = new GroupBox();
            textBoxResult_DIV = new TextBox();
            buttonHelp_DIV = new Button();
            buttonDone_DIV = new Button();
            groupBoxInput_DIV.SuspendLayout();
            groupBoxTask_DIV.SuspendLayout();
            groupBoxResult_DIV.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxStartStepInput_DIV
            // 
            textBoxStartStepInput_DIV.Location = new Point(16, 79);
            textBoxStartStepInput_DIV.Name = "textBoxStartStepInput_DIV";
            textBoxStartStepInput_DIV.Size = new Size(100, 23);
            textBoxStartStepInput_DIV.TabIndex = 0;
            // 
            // groupBoxInput_DIV
            // 
            groupBoxInput_DIV.Controls.Add(textBoxStopStepTip_DIV);
            groupBoxInput_DIV.Controls.Add(textBoxStartStepTip_DIV);
            groupBoxInput_DIV.Controls.Add(textBoxStopStepInput_DIV);
            groupBoxInput_DIV.Controls.Add(textBoxStartStepInput_DIV);
            groupBoxInput_DIV.Location = new Point(27, 300);
            groupBoxInput_DIV.Name = "groupBoxInput_DIV";
            groupBoxInput_DIV.Size = new Size(252, 138);
            groupBoxInput_DIV.TabIndex = 1;
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
            // groupBoxTask_DIV
            // 
            groupBoxTask_DIV.Controls.Add(textBoxTask_DIV);
            groupBoxTask_DIV.Location = new Point(27, 36);
            groupBoxTask_DIV.Name = "groupBoxTask_DIV";
            groupBoxTask_DIV.Size = new Size(458, 258);
            groupBoxTask_DIV.TabIndex = 2;
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
            // groupBoxResult_DIV
            // 
            groupBoxResult_DIV.Controls.Add(textBoxResult_DIV);
            groupBoxResult_DIV.Location = new Point(491, 36);
            groupBoxResult_DIV.Name = "groupBoxResult_DIV";
            groupBoxResult_DIV.Size = new Size(297, 402);
            groupBoxResult_DIV.TabIndex = 3;
            groupBoxResult_DIV.TabStop = false;
            groupBoxResult_DIV.Text = "Результат";
            // 
            // textBoxResult_DIV
            // 
            textBoxResult_DIV.BorderStyle = BorderStyle.None;
            textBoxResult_DIV.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_DIV.Location = new Point(6, 39);
            textBoxResult_DIV.Multiline = true;
            textBoxResult_DIV.Name = "textBoxResult_DIV";
            textBoxResult_DIV.ReadOnly = true;
            textBoxResult_DIV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_DIV.Size = new Size(285, 357);
            textBoxResult_DIV.TabIndex = 3;
            // 
            // buttonHelp_DIV
            // 
            buttonHelp_DIV.BackColor = SystemColors.ActiveCaption;
            buttonHelp_DIV.Location = new Point(285, 357);
            buttonHelp_DIV.Name = "buttonHelp_DIV";
            buttonHelp_DIV.Size = new Size(75, 45);
            buttonHelp_DIV.TabIndex = 4;
            buttonHelp_DIV.Text = "Справка";
            buttonHelp_DIV.UseVisualStyleBackColor = false;
            buttonHelp_DIV.Click += buttonMessage_Click;
            // 
            // buttonDone_DIV
            // 
            buttonDone_DIV.BackColor = SystemColors.Info;
            buttonDone_DIV.Location = new Point(366, 357);
            buttonDone_DIV.Name = "buttonDone_DIV";
            buttonDone_DIV.Size = new Size(119, 45);
            buttonDone_DIV.TabIndex = 5;
            buttonDone_DIV.Text = "Выполнить";
            buttonDone_DIV.UseVisualStyleBackColor = false;
            buttonDone_DIV.Click += buttonDone_Click;
            // 
            // FormMain_DIV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_DIV);
            Controls.Add(buttonHelp_DIV);
            Controls.Add(groupBoxResult_DIV);
            Controls.Add(groupBoxTask_DIV);
            Controls.Add(groupBoxInput_DIV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain_DIV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 7 | Долгов И.В.";
            groupBoxInput_DIV.ResumeLayout(false);
            groupBoxInput_DIV.PerformLayout();
            groupBoxTask_DIV.ResumeLayout(false);
            groupBoxTask_DIV.PerformLayout();
            groupBoxResult_DIV.ResumeLayout(false);
            groupBoxResult_DIV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxStartStepInput_DIV;
        private GroupBox groupBoxInput_DIV;
        private TextBox textBoxStopStepTip_DIV;
        private TextBox textBoxStartStepTip_DIV;
        private TextBox textBoxStopStepInput_DIV;
        private GroupBox groupBoxTask_DIV;
        private TextBox textBoxTask_DIV;
        private GroupBox groupBoxResult_DIV;
        private TextBox textBoxResult_DIV;
        private Button buttonHelp_DIV;
        private Button buttonDone_DIV;
    }
}
