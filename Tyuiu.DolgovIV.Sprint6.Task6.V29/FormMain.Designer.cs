
namespace Tyuiu.DolgovIV.Sprint6.Task6.V29
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop1_DIV = new Panel();
            buttonHelp_DIV = new Button();
            buttonDone_DIV = new Button();
            buttonLoad_DIV = new Button();
            panelTop2_SAA = new Panel();
            groupBoxTask_DIV = new GroupBox();
            textBoxTask_DIV = new TextBox();
            panelLeft_SAA = new Panel();
            groupBoxIn_DIV = new GroupBox();
            textBoxIn_DIV = new TextBox();
            panelRight_SAA = new Panel();
            groupBoxOut_DIV = new GroupBox();
            textBoxOut_DIV = new TextBox();
            openFileDialogTask_DIV = new OpenFileDialog();
            toolTip_DIV = new ToolTip(components);
            panelTop1_DIV.SuspendLayout();
            panelTop2_SAA.SuspendLayout();
            groupBoxTask_DIV.SuspendLayout();
            panelLeft_SAA.SuspendLayout();
            groupBoxIn_DIV.SuspendLayout();
            panelRight_SAA.SuspendLayout();
            groupBoxOut_DIV.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop1_DIV
            // 
            panelTop1_DIV.Controls.Add(buttonHelp_DIV);
            panelTop1_DIV.Controls.Add(buttonDone_DIV);
            panelTop1_DIV.Controls.Add(buttonLoad_DIV);
            panelTop1_DIV.Dock = DockStyle.Top;
            panelTop1_DIV.Location = new Point(0, 0);
            panelTop1_DIV.Margin = new Padding(4, 3, 4, 3);
            panelTop1_DIV.Name = "panelTop1_DIV";
            panelTop1_DIV.Size = new Size(1031, 66);
            panelTop1_DIV.TabIndex = 0;
            // 
            // buttonHelp_DIV
            // 
            buttonHelp_DIV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_DIV.Image = (Image)resources.GetObject("buttonHelp_DIV.Image");
            buttonHelp_DIV.Location = new Point(940, 3);
            buttonHelp_DIV.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_DIV.Name = "buttonHelp_DIV";
            buttonHelp_DIV.Size = new Size(88, 59);
            buttonHelp_DIV.TabIndex = 2;
            toolTip_DIV.SetToolTip(buttonHelp_DIV, "Сведение о программе");
            buttonHelp_DIV.UseVisualStyleBackColor = true;
            buttonHelp_DIV.Click += buttonHelp_DIV_Click;
            // 
            // buttonDone_DIV
            // 
            buttonDone_DIV.Enabled = false;
            buttonDone_DIV.Image = (Image)resources.GetObject("buttonDone_DIV.Image");
            buttonDone_DIV.Location = new Point(98, 3);
            buttonDone_DIV.Margin = new Padding(4, 3, 4, 3);
            buttonDone_DIV.Name = "buttonDone_DIV";
            buttonDone_DIV.Size = new Size(88, 59);
            buttonDone_DIV.TabIndex = 1;
            toolTip_DIV.SetToolTip(buttonDone_DIV, "Выводит слова, в которых встречается i, в результирующую строку");
            buttonDone_DIV.UseVisualStyleBackColor = true;
            buttonDone_DIV.Click += buttonDone_DIV_Click;
            // 
            // buttonLoad_DIV
            // 
            buttonLoad_DIV.Image = (Image)resources.GetObject("buttonLoad_DIV.Image");
            buttonLoad_DIV.Location = new Point(4, 3);
            buttonLoad_DIV.Margin = new Padding(4, 3, 4, 3);
            buttonLoad_DIV.Name = "buttonLoad_DIV";
            buttonLoad_DIV.Size = new Size(88, 59);
            buttonLoad_DIV.TabIndex = 0;
            toolTip_DIV.SetToolTip(buttonLoad_DIV, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonLoad_DIV.UseVisualStyleBackColor = true;
            buttonLoad_DIV.Click += buttonLoad_DIV_Click;
            // 
            // panelTop2_SAA
            // 
            panelTop2_SAA.Controls.Add(groupBoxTask_DIV);
            panelTop2_SAA.Dock = DockStyle.Top;
            panelTop2_SAA.Location = new Point(0, 66);
            panelTop2_SAA.Margin = new Padding(4, 3, 4, 3);
            panelTop2_SAA.Name = "panelTop2_SAA";
            panelTop2_SAA.Size = new Size(1031, 74);
            panelTop2_SAA.TabIndex = 1;
            // 
            // groupBoxTask_DIV
            // 
            groupBoxTask_DIV.Controls.Add(textBoxTask_DIV);
            groupBoxTask_DIV.Dock = DockStyle.Top;
            groupBoxTask_DIV.Location = new Point(0, 0);
            groupBoxTask_DIV.Margin = new Padding(4, 3, 4, 3);
            groupBoxTask_DIV.Name = "groupBoxTask_DIV";
            groupBoxTask_DIV.Padding = new Padding(4, 3, 4, 3);
            groupBoxTask_DIV.Size = new Size(1031, 67);
            groupBoxTask_DIV.TabIndex = 0;
            groupBoxTask_DIV.TabStop = false;
            groupBoxTask_DIV.Text = "Условие:";
            // 
            // textBoxTask_DIV
            // 
            textBoxTask_DIV.BorderStyle = BorderStyle.None;
            textBoxTask_DIV.Dock = DockStyle.Top;
            textBoxTask_DIV.Location = new Point(4, 19);
            textBoxTask_DIV.Margin = new Padding(4, 3, 4, 3);
            textBoxTask_DIV.Multiline = true;
            textBoxTask_DIV.Name = "textBoxTask_DIV";
            textBoxTask_DIV.ReadOnly = true;
            textBoxTask_DIV.Size = new Size(1023, 42);
            textBoxTask_DIV.TabIndex = 0;
            textBoxTask_DIV.Text = resources.GetString("textBoxTask_DIV.Text");
            textBoxTask_DIV.TextChanged += textBoxTask_DIV_TextChanged;
            // 
            // panelLeft_SAA
            // 
            panelLeft_SAA.Controls.Add(groupBoxIn_DIV);
            panelLeft_SAA.Dock = DockStyle.Left;
            panelLeft_SAA.Location = new Point(0, 140);
            panelLeft_SAA.Margin = new Padding(4, 3, 4, 3);
            panelLeft_SAA.Name = "panelLeft_SAA";
            panelLeft_SAA.Size = new Size(531, 450);
            panelLeft_SAA.TabIndex = 2;
            // 
            // groupBoxIn_DIV
            // 
            groupBoxIn_DIV.Controls.Add(textBoxIn_DIV);
            groupBoxIn_DIV.Dock = DockStyle.Left;
            groupBoxIn_DIV.Location = new Point(0, 0);
            groupBoxIn_DIV.Margin = new Padding(4, 3, 4, 3);
            groupBoxIn_DIV.Name = "groupBoxIn_DIV";
            groupBoxIn_DIV.Padding = new Padding(4, 3, 4, 3);
            groupBoxIn_DIV.Size = new Size(527, 450);
            groupBoxIn_DIV.TabIndex = 0;
            groupBoxIn_DIV.TabStop = false;
            groupBoxIn_DIV.Text = "Ввод:";
            // 
            // textBoxIn_DIV
            // 
            textBoxIn_DIV.Dock = DockStyle.Left;
            textBoxIn_DIV.Location = new Point(4, 19);
            textBoxIn_DIV.Margin = new Padding(4, 3, 4, 3);
            textBoxIn_DIV.Multiline = true;
            textBoxIn_DIV.Name = "textBoxIn_DIV";
            textBoxIn_DIV.ReadOnly = true;
            textBoxIn_DIV.ScrollBars = ScrollBars.Vertical;
            textBoxIn_DIV.Size = new Size(516, 428);
            textBoxIn_DIV.TabIndex = 0;
            // 
            // panelRight_SAA
            // 
            panelRight_SAA.Controls.Add(groupBoxOut_DIV);
            panelRight_SAA.Dock = DockStyle.Fill;
            panelRight_SAA.Location = new Point(531, 140);
            panelRight_SAA.Margin = new Padding(4, 3, 4, 3);
            panelRight_SAA.Name = "panelRight_SAA";
            panelRight_SAA.Size = new Size(500, 450);
            panelRight_SAA.TabIndex = 3;
            // 
            // groupBoxOut_DIV
            // 
            groupBoxOut_DIV.Controls.Add(textBoxOut_DIV);
            groupBoxOut_DIV.Dock = DockStyle.Fill;
            groupBoxOut_DIV.Location = new Point(0, 0);
            groupBoxOut_DIV.Margin = new Padding(4, 3, 4, 3);
            groupBoxOut_DIV.Name = "groupBoxOut_DIV";
            groupBoxOut_DIV.Padding = new Padding(4, 3, 4, 3);
            groupBoxOut_DIV.Size = new Size(500, 450);
            groupBoxOut_DIV.TabIndex = 0;
            groupBoxOut_DIV.TabStop = false;
            groupBoxOut_DIV.Text = "Вывод:";
            // 
            // textBoxOut_DIV
            // 
            textBoxOut_DIV.Dock = DockStyle.Fill;
            textBoxOut_DIV.Location = new Point(4, 19);
            textBoxOut_DIV.Margin = new Padding(4, 3, 4, 3);
            textBoxOut_DIV.Multiline = true;
            textBoxOut_DIV.Name = "textBoxOut_DIV";
            textBoxOut_DIV.ReadOnly = true;
            textBoxOut_DIV.ScrollBars = ScrollBars.Vertical;
            textBoxOut_DIV.Size = new Size(492, 428);
            textBoxOut_DIV.TabIndex = 0;
            // 
            // openFileDialogTask_DIV
            // 
            openFileDialogTask_DIV.FileName = "openFileDialog1";
            // 
            // toolTip_DIV
            // 
            toolTip_DIV.ToolTipIcon = ToolTipIcon.Info;
            toolTip_DIV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 590);
            Controls.Add(panelRight_SAA);
            Controls.Add(panelLeft_SAA);
            Controls.Add(panelTop2_SAA);
            Controls.Add(panelTop1_DIV);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1047, 629);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Спринт 6 | Таск 6 | Вариант 29 | Долгов И.В.";
            panelTop1_DIV.ResumeLayout(false);
            panelTop2_SAA.ResumeLayout(false);
            groupBoxTask_DIV.ResumeLayout(false);
            groupBoxTask_DIV.PerformLayout();
            panelLeft_SAA.ResumeLayout(false);
            groupBoxIn_DIV.ResumeLayout(false);
            groupBoxIn_DIV.PerformLayout();
            panelRight_SAA.ResumeLayout(false);
            groupBoxOut_DIV.ResumeLayout(false);
            groupBoxOut_DIV.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop1_DIV;
        private System.Windows.Forms.Button buttonHelp_DIV;
        private System.Windows.Forms.Button buttonDone_DIV;
        private System.Windows.Forms.Button buttonLoad_DIV;
        private System.Windows.Forms.Panel panelTop2_SAA;
        private System.Windows.Forms.GroupBox groupBoxTask_DIV;
        private System.Windows.Forms.TextBox textBoxTask_DIV;
        private System.Windows.Forms.Panel panelLeft_SAA;
        private System.Windows.Forms.GroupBox groupBoxIn_DIV;
        private System.Windows.Forms.TextBox textBoxIn_DIV;
        private System.Windows.Forms.Panel panelRight_SAA;
        private System.Windows.Forms.GroupBox groupBoxOut_DIV;
        private System.Windows.Forms.TextBox textBoxOut_DIV;
        private System.Windows.Forms.ToolTip toolTip_DIV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_DIV;
    }
}

