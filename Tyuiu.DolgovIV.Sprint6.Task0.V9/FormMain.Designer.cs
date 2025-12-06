namespace Tyuiu.DolgovIV.Sprint6.Task0.V9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            pictureBoxTaskFormula_DIV = new PictureBox();
            textBoxVarInputX_DIV = new TextBox();
            groupBoxTask_DIV = new GroupBox();
            textBoxTask_DIV = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxInput_DIV = new GroupBox();
            textBoxVarTipX_DIV = new TextBox();
            groupBoxOutput_DIV = new GroupBox();
            textBoxResultOutput_DIV = new TextBox();
            textBoxResultTip_DIV = new TextBox();
            buttonDone_DIV = new Button();
            buttonMessage_DIV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTaskFormula_DIV).BeginInit();
            groupBoxTask_DIV.SuspendLayout();
            groupBoxInput_DIV.SuspendLayout();
            groupBoxOutput_DIV.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxTaskFormula_DIV
            // 
            pictureBoxTaskFormula_DIV.Image = (Image)resources.GetObject("pictureBoxTaskFormula_DIV.Image");
            pictureBoxTaskFormula_DIV.Location = new Point(558, 25);
            pictureBoxTaskFormula_DIV.Name = "pictureBoxTaskFormula_DIV";
            pictureBoxTaskFormula_DIV.Size = new Size(112, 67);
            pictureBoxTaskFormula_DIV.TabIndex = 0;
            pictureBoxTaskFormula_DIV.TabStop = false;
            // 
            // textBoxVarInputX_DIV
            // 
            textBoxVarInputX_DIV.Location = new Point(69, 79);
            textBoxVarInputX_DIV.Name = "textBoxVarInputX_DIV";
            textBoxVarInputX_DIV.Size = new Size(100, 23);
            textBoxVarInputX_DIV.TabIndex = 1;
            textBoxVarInputX_DIV.KeyPress += textBoxVarInputX_KeyPress;
            // 
            // groupBoxTask_DIV
            // 
            groupBoxTask_DIV.Controls.Add(pictureBoxTaskFormula_DIV);
            groupBoxTask_DIV.Controls.Add(textBoxTask_DIV);
            groupBoxTask_DIV.Location = new Point(32, 27);
            groupBoxTask_DIV.Name = "groupBoxTask_DIV";
            groupBoxTask_DIV.Size = new Size(724, 173);
            groupBoxTask_DIV.TabIndex = 2;
            groupBoxTask_DIV.TabStop = false;
            groupBoxTask_DIV.Text = "Условие";
            // 
            // textBoxTask_DIV
            // 
            textBoxTask_DIV.Location = new Point(6, 44);
            textBoxTask_DIV.Multiline = true;
            textBoxTask_DIV.Name = "textBoxTask_DIV";
            textBoxTask_DIV.ReadOnly = true;
            textBoxTask_DIV.Size = new Size(292, 115);
            textBoxTask_DIV.TabIndex = 3;
            textBoxTask_DIV.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInput_DIV
            // 
            groupBoxInput_DIV.Controls.Add(textBoxVarTipX_DIV);
            groupBoxInput_DIV.Controls.Add(textBoxVarInputX_DIV);
            groupBoxInput_DIV.Location = new Point(38, 220);
            groupBoxInput_DIV.Name = "groupBoxInput_DIV";
            groupBoxInput_DIV.Size = new Size(292, 121);
            groupBoxInput_DIV.TabIndex = 4;
            groupBoxInput_DIV.TabStop = false;
            groupBoxInput_DIV.Text = "Ввод данных";
            // 
            // textBoxVarTipX_DIV
            // 
            textBoxVarTipX_DIV.Location = new Point(69, 50);
            textBoxVarTipX_DIV.Name = "textBoxVarTipX_DIV";
            textBoxVarTipX_DIV.ReadOnly = true;
            textBoxVarTipX_DIV.Size = new Size(100, 23);
            textBoxVarTipX_DIV.TabIndex = 4;
            textBoxVarTipX_DIV.Text = "Переменная X:";
            // 
            // groupBoxOutput_DIV
            // 
            groupBoxOutput_DIV.Controls.Add(textBoxResultOutput_DIV);
            groupBoxOutput_DIV.Controls.Add(textBoxResultTip_DIV);
            groupBoxOutput_DIV.Location = new Point(487, 220);
            groupBoxOutput_DIV.Name = "groupBoxOutput_DIV";
            groupBoxOutput_DIV.Size = new Size(269, 121);
            groupBoxOutput_DIV.TabIndex = 5;
            groupBoxOutput_DIV.TabStop = false;
            groupBoxOutput_DIV.Text = "Вывод данных";
            // 
            // textBoxResultOutput_DIV
            // 
            textBoxResultOutput_DIV.Location = new Point(19, 79);
            textBoxResultOutput_DIV.Name = "textBoxResultOutput_DIV";
            textBoxResultOutput_DIV.ReadOnly = true;
            textBoxResultOutput_DIV.Size = new Size(186, 23);
            textBoxResultOutput_DIV.TabIndex = 1;
            // 
            // textBoxResultTip_DIV
            // 
            textBoxResultTip_DIV.Location = new Point(19, 50);
            textBoxResultTip_DIV.Name = "textBoxResultTip_DIV";
            textBoxResultTip_DIV.ReadOnly = true;
            textBoxResultTip_DIV.Size = new Size(100, 23);
            textBoxResultTip_DIV.TabIndex = 0;
            textBoxResultTip_DIV.Text = "Результат:";
            // 
            // buttonDone_DIV
            // 
            buttonDone_DIV.Location = new Point(614, 380);
            buttonDone_DIV.Name = "buttonDone_DIV";
            buttonDone_DIV.Size = new Size(142, 41);
            buttonDone_DIV.TabIndex = 6;
            buttonDone_DIV.Text = "Выполнить";
            buttonDone_DIV.UseVisualStyleBackColor = true;
            buttonDone_DIV.Click += buttonDone_Click;
            // 
            // buttonMessage_DIV
            // 
            buttonMessage_DIV.FlatStyle = FlatStyle.Flat;
            buttonMessage_DIV.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonMessage_DIV.Location = new Point(545, 380);
            buttonMessage_DIV.Name = "buttonMessage_DIV";
            buttonMessage_DIV.Size = new Size(43, 41);
            buttonMessage_DIV.TabIndex = 7;
            buttonMessage_DIV.Text = "?";
            buttonMessage_DIV.UseVisualStyleBackColor = true;
            buttonMessage_DIV.Click += buttonMessage_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonMessage_DIV);
            Controls.Add(buttonDone_DIV);
            Controls.Add(groupBoxOutput_DIV);
            Controls.Add(groupBoxInput_DIV);
            Controls.Add(groupBoxTask_DIV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 9 | Долгов И.В.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxTaskFormula_DIV).EndInit();
            groupBoxTask_DIV.ResumeLayout(false);
            groupBoxTask_DIV.PerformLayout();
            groupBoxInput_DIV.ResumeLayout(false);
            groupBoxInput_DIV.PerformLayout();
            groupBoxOutput_DIV.ResumeLayout(false);
            groupBoxOutput_DIV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxVarInputX_DIV;
        private PictureBox pictureBoxTaskFormula_DIV;
        private TextBox textBoxVarInputA_DIV;
        private GroupBox groupBoxTask_DIV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBoxTask_DIV;
        private GroupBox groupBoxInput_DIV;
        private TextBox textBoxVarInputC_DIV;
        private TextBox textBoxVarInputB_DIV;
        private TextBox textBoxVarTipX_DIV;
        private TextBox textBoxVarTipC_DIV;
        private TextBox textBoxVarTipB_DIV;
        private GroupBox groupBoxOutput_DIV;
        private TextBox textBoxResultOutput_DIV;
        private TextBox textBoxResultTip_DIV;
        private Button buttonDone_DIV;
        private Button buttonMessage_DIV;
    }
}
