
namespace Tyuiu.DolgovIV.Sprint6.Task6.V29
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelAbout_DIV = new Label();
            buttonOk_DIV = new Button();
            SuspendLayout();
            // 
            // labelAbout_DIV
            // 
            labelAbout_DIV.AutoSize = true;
            labelAbout_DIV.Location = new Point(168, 7);
            labelAbout_DIV.Margin = new Padding(4, 0, 4, 0);
            labelAbout_DIV.Name = "labelAbout_DIV";
            labelAbout_DIV.Size = new Size(302, 135);
            labelAbout_DIV.TabIndex = 1;
            labelAbout_DIV.Text = resources.GetString("labelAbout_DIV.Text");
            labelAbout_DIV.Click += labelAbout_DIV_Click;
            // 
            // buttonOk_DIV
            // 
            buttonOk_DIV.Location = new Point(412, 156);
            buttonOk_DIV.Margin = new Padding(4, 3, 4, 3);
            buttonOk_DIV.Name = "buttonOk_DIV";
            buttonOk_DIV.Size = new Size(88, 27);
            buttonOk_DIV.TabIndex = 2;
            buttonOk_DIV.Text = "OK";
            buttonOk_DIV.UseVisualStyleBackColor = true;
            buttonOk_DIV.Click += buttonOk_DIV_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 186);
            Controls.Add(buttonOk_DIV);
            Controls.Add(labelAbout_DIV);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAbout_DIV;
        private System.Windows.Forms.Button buttonOk_DIV;
    }
}