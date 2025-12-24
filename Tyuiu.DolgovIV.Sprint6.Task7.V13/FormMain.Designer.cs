namespace Tyuiu.DolgovIV.Sprint6.Task7.V13
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
            components = new System.ComponentModel.Container();
            dataGridViewOutPut_DIV = new DataGridView();
            dataGridViewInPut_DIV = new DataGridView();
            textBoxInfo_DIV = new TextBox();
            buttonOpenFile_DIV = new Button();
            buttonSaveFile_DIV = new Button();
            buttonResult_DIV = new Button();
            openFileDialogTask = new OpenFileDialog();
            toolTipButton = new ToolTip(components);
            saveFileDialogMatrix = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_DIV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_DIV).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOutPut_DIV
            // 
            dataGridViewOutPut_DIV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut_DIV.Location = new Point(0, 85);
            dataGridViewOutPut_DIV.Name = "dataGridViewOutPut_DIV";
            dataGridViewOutPut_DIV.ReadOnly = true;
            dataGridViewOutPut_DIV.Size = new Size(661, 747);
            dataGridViewOutPut_DIV.TabIndex = 10;
            dataGridViewOutPut_DIV.CellContentClick += dataGridViewOutPut_CellContentClick;
            // 
            // dataGridViewInPut_DIV
            // 
            dataGridViewInPut_DIV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPut_DIV.Location = new Point(667, 85);
            dataGridViewInPut_DIV.Name = "dataGridViewInPut_DIV";
            dataGridViewInPut_DIV.ReadOnly = true;
            dataGridViewInPut_DIV.Size = new Size(496, 754);
            dataGridViewInPut_DIV.TabIndex = 1;
            dataGridViewInPut_DIV.CellContentClick += dataGridViewInPut_CellContentClick;
            // 
            // textBoxInfo_DIV
            // 
            textBoxInfo_DIV.Dock = DockStyle.Top;
            textBoxInfo_DIV.Location = new Point(0, 0);
            textBoxInfo_DIV.Multiline = true;
            textBoxInfo_DIV.Name = "textBoxInfo_DIV";
            textBoxInfo_DIV.ReadOnly = true;
            textBoxInfo_DIV.Size = new Size(1163, 79);
            textBoxInfo_DIV.TabIndex = 2;
            textBoxInfo_DIV.Text = "Дан файл: ";
            textBoxInfo_DIV.TextChanged += textBoxInfo_DIV_TextChanged;
            // 
            // buttonOpenFile_DIV
            // 
            buttonOpenFile_DIV.Location = new Point(307, 0);
            buttonOpenFile_DIV.Name = "buttonOpenFile_DIV";
            buttonOpenFile_DIV.Size = new Size(104, 65);
            buttonOpenFile_DIV.TabIndex = 3;
            buttonOpenFile_DIV.Text = "Открыть";
            buttonOpenFile_DIV.UseVisualStyleBackColor = true;
            buttonOpenFile_DIV.Click += buttonOpenFile_Click;
            // 
            // buttonSaveFile_DIV
            // 
            buttonSaveFile_DIV.Location = new Point(514, 0);
            buttonSaveFile_DIV.Name = "buttonSaveFile_DIV";
            buttonSaveFile_DIV.Size = new Size(90, 65);
            buttonSaveFile_DIV.TabIndex = 4;
            buttonSaveFile_DIV.Text = "Сохранить";
            buttonSaveFile_DIV.UseVisualStyleBackColor = true;
            buttonSaveFile_DIV.Click += buttonSaveFile_Click;
            // 
            // buttonResult_DIV
            // 
            buttonResult_DIV.Location = new Point(417, 0);
            buttonResult_DIV.Name = "buttonResult_DIV";
            buttonResult_DIV.Size = new Size(91, 65);
            buttonResult_DIV.TabIndex = 5;
            buttonResult_DIV.Text = "Выполнить";
            buttonResult_DIV.UseVisualStyleBackColor = true;
            buttonResult_DIV.Click += buttonResult_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1163, 929);
            Controls.Add(buttonResult_DIV);
            Controls.Add(buttonSaveFile_DIV);
            Controls.Add(buttonOpenFile_DIV);
            Controls.Add(textBoxInfo_DIV);
            Controls.Add(dataGridViewInPut_DIV);
            Controls.Add(dataGridViewOutPut_DIV);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 13 | Долгов И.В.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_DIV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_DIV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewOutPut_DIV;
        private DataGridView dataGridViewInPut_DIV;
        private TextBox textBoxInfo_DIV;
        private Button buttonOpenFile_DIV;
        private Button buttonSaveFile_DIV;
        private Button buttonResult_DIV;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTipButton;
        private SaveFileDialog saveFileDialogMatrix;
    }
}
