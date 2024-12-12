namespace Tyuiu.FedorovaDA.Sprint6.Task7.V14
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
            buttonOk_FDA = new Button();
            textBoxAboutMe_FDA = new TextBox();
            SuspendLayout();
            // 
            // buttonOk_FDA
            // 
            buttonOk_FDA.Location = new Point(576, 268);
            buttonOk_FDA.Name = "buttonOk_FDA";
            buttonOk_FDA.Size = new Size(94, 29);
            buttonOk_FDA.TabIndex = 3;
            buttonOk_FDA.Text = "Ок";
            buttonOk_FDA.UseVisualStyleBackColor = true;
            buttonOk_FDA.Click += buttonOk_FDA_Click;
            // 
            // textBoxAboutMe_FDA
            // 
            textBoxAboutMe_FDA.BorderStyle = BorderStyle.None;
            textBoxAboutMe_FDA.Location = new Point(280, 39);
            textBoxAboutMe_FDA.Multiline = true;
            textBoxAboutMe_FDA.Name = "textBoxAboutMe_FDA";
            textBoxAboutMe_FDA.ReadOnly = true;
            textBoxAboutMe_FDA.Size = new Size(410, 202);
            textBoxAboutMe_FDA.TabIndex = 2;
            textBoxAboutMe_FDA.Text = resources.GetString("textBoxAboutMe_FDA.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 303);
            Controls.Add(buttonOk_FDA);
            Controls.Add(textBoxAboutMe_FDA);
            Name = "FormAbout";
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk_FDA;
        private TextBox textBoxAboutMe_FDA;
    }
}