
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
            panelTop1_SAA = new Panel();
            buttonHelp_SAA = new Button();
            buttonDone_SAA = new Button();
            buttonLoad_SAA = new Button();
            panelTop2_SAA = new Panel();
            groupBoxTask_SAA = new GroupBox();
            textBoxTask_SAA = new TextBox();
            panelLeft_SAA = new Panel();
            groupBoxIn_SAA = new GroupBox();
            textBoxIn_SAA = new TextBox();
            panelRight_SAA = new Panel();
            groupBoxOut_SAA = new GroupBox();
            textBoxOut_SAA = new TextBox();
            openFileDialogTask_SAA = new OpenFileDialog();
            toolTip_SAA = new ToolTip(components);
            panelTop1_SAA.SuspendLayout();
            panelTop2_SAA.SuspendLayout();
            groupBoxTask_SAA.SuspendLayout();
            panelLeft_SAA.SuspendLayout();
            groupBoxIn_SAA.SuspendLayout();
            panelRight_SAA.SuspendLayout();
            groupBoxOut_SAA.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop1_SAA
            // 
            panelTop1_SAA.Controls.Add(buttonHelp_SAA);
            panelTop1_SAA.Controls.Add(buttonDone_SAA);
            panelTop1_SAA.Controls.Add(buttonLoad_SAA);
            panelTop1_SAA.Dock = DockStyle.Top;
            panelTop1_SAA.Location = new Point(0, 0);
            panelTop1_SAA.Margin = new Padding(4, 3, 4, 3);
            panelTop1_SAA.Name = "panelTop1_SAA";
            panelTop1_SAA.Size = new Size(1031, 66);
            panelTop1_SAA.TabIndex = 0;
            // 
            // buttonHelp_SAA
            // 
            buttonHelp_SAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_SAA.Image = (Image)resources.GetObject("buttonHelp_SAA.Image");
            buttonHelp_SAA.Location = new Point(940, 3);
            buttonHelp_SAA.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_SAA.Name = "buttonHelp_SAA";
            buttonHelp_SAA.Size = new Size(88, 59);
            buttonHelp_SAA.TabIndex = 2;
            toolTip_SAA.SetToolTip(buttonHelp_SAA, "Сведение о программе");
            buttonHelp_SAA.UseVisualStyleBackColor = true;
            buttonHelp_SAA.Click += buttonHelp_SAA_Click;
            // 
            // buttonDone_SAA
            // 
            buttonDone_SAA.Enabled = false;
            buttonDone_SAA.Image = (Image)resources.GetObject("buttonDone_SAA.Image");
            buttonDone_SAA.Location = new Point(98, 3);
            buttonDone_SAA.Margin = new Padding(4, 3, 4, 3);
            buttonDone_SAA.Name = "buttonDone_SAA";
            buttonDone_SAA.Size = new Size(88, 59);
            buttonDone_SAA.TabIndex = 1;
            toolTip_SAA.SetToolTip(buttonDone_SAA, "Выводит слова, в которых встречается i, в результирующую строку");
            buttonDone_SAA.UseVisualStyleBackColor = true;
            buttonDone_SAA.Click += buttonDone_SAA_Click;
            // 
            // buttonLoad_SAA
            // 
            buttonLoad_SAA.Image = (Image)resources.GetObject("buttonLoad_SAA.Image");
            buttonLoad_SAA.Location = new Point(4, 3);
            buttonLoad_SAA.Margin = new Padding(4, 3, 4, 3);
            buttonLoad_SAA.Name = "buttonLoad_SAA";
            buttonLoad_SAA.Size = new Size(88, 59);
            buttonLoad_SAA.TabIndex = 0;
            toolTip_SAA.SetToolTip(buttonLoad_SAA, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonLoad_SAA.UseVisualStyleBackColor = true;
            buttonLoad_SAA.Click += buttonLoad_SAA_Click;
            // 
            // panelTop2_SAA
            // 
            panelTop2_SAA.Controls.Add(groupBoxTask_SAA);
            panelTop2_SAA.Dock = DockStyle.Top;
            panelTop2_SAA.Location = new Point(0, 66);
            panelTop2_SAA.Margin = new Padding(4, 3, 4, 3);
            panelTop2_SAA.Name = "panelTop2_SAA";
            panelTop2_SAA.Size = new Size(1031, 74);
            panelTop2_SAA.TabIndex = 1;
            // 
            // groupBoxTask_SAA
            // 
            groupBoxTask_SAA.Controls.Add(textBoxTask_SAA);
            groupBoxTask_SAA.Dock = DockStyle.Top;
            groupBoxTask_SAA.Location = new Point(0, 0);
            groupBoxTask_SAA.Margin = new Padding(4, 3, 4, 3);
            groupBoxTask_SAA.Name = "groupBoxTask_SAA";
            groupBoxTask_SAA.Padding = new Padding(4, 3, 4, 3);
            groupBoxTask_SAA.Size = new Size(1031, 67);
            groupBoxTask_SAA.TabIndex = 0;
            groupBoxTask_SAA.TabStop = false;
            groupBoxTask_SAA.Text = "Условие:";
            // 
            // textBoxTask_SAA
            // 
            textBoxTask_SAA.BorderStyle = BorderStyle.None;
            textBoxTask_SAA.Dock = DockStyle.Top;
            textBoxTask_SAA.Location = new Point(4, 19);
            textBoxTask_SAA.Margin = new Padding(4, 3, 4, 3);
            textBoxTask_SAA.Multiline = true;
            textBoxTask_SAA.Name = "textBoxTask_SAA";
            textBoxTask_SAA.ReadOnly = true;
            textBoxTask_SAA.Size = new Size(1023, 42);
            textBoxTask_SAA.TabIndex = 0;
            textBoxTask_SAA.Text = resources.GetString("textBoxTask_SAA.Text");
            textBoxTask_SAA.TextChanged += textBoxTask_SAA_TextChanged;
            // 
            // panelLeft_SAA
            // 
            panelLeft_SAA.Controls.Add(groupBoxIn_SAA);
            panelLeft_SAA.Dock = DockStyle.Left;
            panelLeft_SAA.Location = new Point(0, 140);
            panelLeft_SAA.Margin = new Padding(4, 3, 4, 3);
            panelLeft_SAA.Name = "panelLeft_SAA";
            panelLeft_SAA.Size = new Size(531, 450);
            panelLeft_SAA.TabIndex = 2;
            // 
            // groupBoxIn_SAA
            // 
            groupBoxIn_SAA.Controls.Add(textBoxIn_SAA);
            groupBoxIn_SAA.Dock = DockStyle.Left;
            groupBoxIn_SAA.Location = new Point(0, 0);
            groupBoxIn_SAA.Margin = new Padding(4, 3, 4, 3);
            groupBoxIn_SAA.Name = "groupBoxIn_SAA";
            groupBoxIn_SAA.Padding = new Padding(4, 3, 4, 3);
            groupBoxIn_SAA.Size = new Size(527, 450);
            groupBoxIn_SAA.TabIndex = 0;
            groupBoxIn_SAA.TabStop = false;
            groupBoxIn_SAA.Text = "Ввод:";
            // 
            // textBoxIn_SAA
            // 
            textBoxIn_SAA.Dock = DockStyle.Left;
            textBoxIn_SAA.Location = new Point(4, 19);
            textBoxIn_SAA.Margin = new Padding(4, 3, 4, 3);
            textBoxIn_SAA.Multiline = true;
            textBoxIn_SAA.Name = "textBoxIn_SAA";
            textBoxIn_SAA.ReadOnly = true;
            textBoxIn_SAA.ScrollBars = ScrollBars.Vertical;
            textBoxIn_SAA.Size = new Size(516, 428);
            textBoxIn_SAA.TabIndex = 0;
            // 
            // panelRight_SAA
            // 
            panelRight_SAA.Controls.Add(groupBoxOut_SAA);
            panelRight_SAA.Dock = DockStyle.Fill;
            panelRight_SAA.Location = new Point(531, 140);
            panelRight_SAA.Margin = new Padding(4, 3, 4, 3);
            panelRight_SAA.Name = "panelRight_SAA";
            panelRight_SAA.Size = new Size(500, 450);
            panelRight_SAA.TabIndex = 3;
            // 
            // groupBoxOut_SAA
            // 
            groupBoxOut_SAA.Controls.Add(textBoxOut_SAA);
            groupBoxOut_SAA.Dock = DockStyle.Fill;
            groupBoxOut_SAA.Location = new Point(0, 0);
            groupBoxOut_SAA.Margin = new Padding(4, 3, 4, 3);
            groupBoxOut_SAA.Name = "groupBoxOut_SAA";
            groupBoxOut_SAA.Padding = new Padding(4, 3, 4, 3);
            groupBoxOut_SAA.Size = new Size(500, 450);
            groupBoxOut_SAA.TabIndex = 0;
            groupBoxOut_SAA.TabStop = false;
            groupBoxOut_SAA.Text = "Вывод:";
            // 
            // textBoxOut_SAA
            // 
            textBoxOut_SAA.Dock = DockStyle.Fill;
            textBoxOut_SAA.Location = new Point(4, 19);
            textBoxOut_SAA.Margin = new Padding(4, 3, 4, 3);
            textBoxOut_SAA.Multiline = true;
            textBoxOut_SAA.Name = "textBoxOut_SAA";
            textBoxOut_SAA.ReadOnly = true;
            textBoxOut_SAA.ScrollBars = ScrollBars.Vertical;
            textBoxOut_SAA.Size = new Size(492, 428);
            textBoxOut_SAA.TabIndex = 0;
            // 
            // openFileDialogTask_SAA
            // 
            openFileDialogTask_SAA.FileName = "openFileDialog1";
            // 
            // toolTip_SAA
            // 
            toolTip_SAA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_SAA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 590);
            Controls.Add(panelRight_SAA);
            Controls.Add(panelLeft_SAA);
            Controls.Add(panelTop2_SAA);
            Controls.Add(panelTop1_SAA);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1047, 629);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Спринт 6 | Таск 6 | Вариант 29 | Самар А. А.";
            panelTop1_SAA.ResumeLayout(false);
            panelTop2_SAA.ResumeLayout(false);
            groupBoxTask_SAA.ResumeLayout(false);
            groupBoxTask_SAA.PerformLayout();
            panelLeft_SAA.ResumeLayout(false);
            groupBoxIn_SAA.ResumeLayout(false);
            groupBoxIn_SAA.PerformLayout();
            panelRight_SAA.ResumeLayout(false);
            groupBoxOut_SAA.ResumeLayout(false);
            groupBoxOut_SAA.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop1_SAA;
        private System.Windows.Forms.Button buttonHelp_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.Button buttonLoad_SAA;
        private System.Windows.Forms.Panel panelTop2_SAA;
        private System.Windows.Forms.GroupBox groupBoxTask_SAA;
        private System.Windows.Forms.TextBox textBoxTask_SAA;
        private System.Windows.Forms.Panel panelLeft_SAA;
        private System.Windows.Forms.GroupBox groupBoxIn_SAA;
        private System.Windows.Forms.TextBox textBoxIn_SAA;
        private System.Windows.Forms.Panel panelRight_SAA;
        private System.Windows.Forms.GroupBox groupBoxOut_SAA;
        private System.Windows.Forms.TextBox textBoxOut_SAA;
        private System.Windows.Forms.ToolTip toolTip_SAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SAA;
    }
}

