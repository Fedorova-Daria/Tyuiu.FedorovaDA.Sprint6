namespace Tyuiu.FedorovaDA.Sprint6.Task0.V2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textCondition_FDA = new TextBox();
            textTask_FDA = new TextBox();
            textEnter_FDA = new TextBox();
            textVarX_FDA = new TextBox();
            textConclusion_FDA = new TextBox();
            textResult_FDA = new TextBox();
            Formula = new ImageList(components);
            textBoxVarX_FDA = new TextBox();
            textBoxResult_FDA = new TextBox();
            buttonHelp_FDA = new Button();
            buttonDone_FDA = new Button();
            PictureBoxFormula_FDA = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBoxFormula_FDA).BeginInit();
            SuspendLayout();
            // 
            // textCondition_FDA
            // 
            textCondition_FDA.BackColor = SystemColors.Control;
            textCondition_FDA.BorderStyle = BorderStyle.None;
            textCondition_FDA.Location = new Point(34, 25);
            textCondition_FDA.Name = "textCondition_FDA";
            textCondition_FDA.ReadOnly = true;
            textCondition_FDA.Size = new Size(125, 20);
            textCondition_FDA.TabIndex = 0;
            textCondition_FDA.Text = "Условие";
            // 
            // textTask_FDA
            // 
            textTask_FDA.BackColor = SystemColors.Control;
            textTask_FDA.BorderStyle = BorderStyle.None;
            textTask_FDA.Location = new Point(34, 51);
            textTask_FDA.Multiline = true;
            textTask_FDA.Name = "textTask_FDA";
            textTask_FDA.ReadOnly = true;
            textTask_FDA.Size = new Size(496, 213);
            textTask_FDA.TabIndex = 1;
            textTask_FDA.Text = "Вычислить выражение по формуле";
            // 
            // textEnter_FDA
            // 
            textEnter_FDA.BackColor = SystemColors.Control;
            textEnter_FDA.BorderStyle = BorderStyle.None;
            textEnter_FDA.Location = new Point(34, 270);
            textEnter_FDA.Name = "textEnter_FDA";
            textEnter_FDA.ReadOnly = true;
            textEnter_FDA.Size = new Size(98, 20);
            textEnter_FDA.TabIndex = 2;
            textEnter_FDA.Text = "Ввод данных";
            // 
            // textVarX_FDA
            // 
            textVarX_FDA.BackColor = SystemColors.Control;
            textVarX_FDA.BorderStyle = BorderStyle.None;
            textVarX_FDA.Location = new Point(34, 307);
            textVarX_FDA.Name = "textVarX_FDA";
            textVarX_FDA.ReadOnly = true;
            textVarX_FDA.Size = new Size(112, 20);
            textVarX_FDA.TabIndex = 3;
            textVarX_FDA.Text = "Переменная Х";
            // 
            // textConclusion_FDA
            // 
            textConclusion_FDA.BackColor = SystemColors.Control;
            textConclusion_FDA.BorderStyle = BorderStyle.None;
            textConclusion_FDA.Location = new Point(492, 270);
            textConclusion_FDA.Name = "textConclusion_FDA";
            textConclusion_FDA.ReadOnly = true;
            textConclusion_FDA.RightToLeft = RightToLeft.No;
            textConclusion_FDA.Size = new Size(112, 20);
            textConclusion_FDA.TabIndex = 4;
            textConclusion_FDA.Text = "Вывод данных";
            // 
            // textResult_FDA
            // 
            textResult_FDA.BackColor = SystemColors.Control;
            textResult_FDA.BorderStyle = BorderStyle.None;
            textResult_FDA.Location = new Point(492, 307);
            textResult_FDA.Name = "textResult_FDA";
            textResult_FDA.ReadOnly = true;
            textResult_FDA.RightToLeft = RightToLeft.No;
            textResult_FDA.Size = new Size(112, 20);
            textResult_FDA.TabIndex = 5;
            textResult_FDA.Text = "Результат";
            // 
            // Formula
            // 
            Formula.ColorDepth = ColorDepth.Depth32Bit;
            Formula.ImageStream = (ImageListStreamer)resources.GetObject("Formula.ImageStream");
            Formula.TransparentColor = Color.Transparent;
            Formula.Images.SetKeyName(0, "Формула");
            // 
            // textBoxVarX_FDA
            // 
            textBoxVarX_FDA.BackColor = SystemColors.ControlLightLight;
            textBoxVarX_FDA.Location = new Point(34, 333);
            textBoxVarX_FDA.Name = "textBoxVarX_FDA";
            textBoxVarX_FDA.RightToLeft = RightToLeft.No;
            textBoxVarX_FDA.Size = new Size(112, 27);
            textBoxVarX_FDA.TabIndex = 6;
            // 
            // textBoxResult_FDA
            // 
            textBoxResult_FDA.BackColor = SystemColors.ControlLightLight;
            textBoxResult_FDA.Location = new Point(492, 333);
            textBoxResult_FDA.Name = "textBoxResult_FDA";
            textBoxResult_FDA.RightToLeft = RightToLeft.No;
            textBoxResult_FDA.Size = new Size(112, 27);
            textBoxResult_FDA.TabIndex = 7;
            textBoxResult_FDA.TextChanged += textBox8_TextChanged;
            // 
            // buttonHelp_FDA
            // 
            buttonHelp_FDA.Location = new Point(538, 390);
            buttonHelp_FDA.Name = "buttonHelp_FDA";
            buttonHelp_FDA.Size = new Size(66, 48);
            buttonHelp_FDA.TabIndex = 8;
            buttonHelp_FDA.Text = "?";
            buttonHelp_FDA.UseVisualStyleBackColor = true;
            buttonHelp_FDA.Click += button1_Click_1;
            // 
            // buttonDone_FDA
            // 
            buttonDone_FDA.Location = new Point(610, 390);
            buttonDone_FDA.Name = "buttonDone_FDA";
            buttonDone_FDA.Size = new Size(162, 48);
            buttonDone_FDA.TabIndex = 9;
            buttonDone_FDA.Text = "Выполнить";
            buttonDone_FDA.UseVisualStyleBackColor = true;
            buttonDone_FDA.Click += buttonDone_FDA_Click;
            // 
            // PictureBoxFormula_FDA
            // 
            PictureBoxFormula_FDA.Image = Properties.Resources.Снимок_экрана_2024_10_27_172222;
            PictureBoxFormula_FDA.Location = new Point(538, 51);
            PictureBoxFormula_FDA.Name = "PictureBoxFormula_FDA";
            PictureBoxFormula_FDA.Size = new Size(174, 87);
            PictureBoxFormula_FDA.TabIndex = 10;
            PictureBoxFormula_FDA.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PictureBoxFormula_FDA);
            Controls.Add(buttonDone_FDA);
            Controls.Add(buttonHelp_FDA);
            Controls.Add(textBoxResult_FDA);
            Controls.Add(textBoxVarX_FDA);
            Controls.Add(textResult_FDA);
            Controls.Add(textConclusion_FDA);
            Controls.Add(textVarX_FDA);
            Controls.Add(textEnter_FDA);
            Controls.Add(textTask_FDA);
            Controls.Add(textCondition_FDA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 2 | Федорова Д.А.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBoxFormula_FDA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textCondition_FDA;
        private TextBox textTask_FDA;
        private TextBox textEnter_FDA;
        private TextBox textVarX_FDA;
        private TextBox textConclusion_FDA;
        private TextBox textResult_FDA;
        public ImageList Formula;
        private TextBox textBoxVarX_FDA;
        private TextBox textBoxResult_FDA;
        private Button buttonHelp_FDA;
        private Button buttonDone_FDA;
        private PictureBox PictureBoxFormula_FDA;
    }
}
