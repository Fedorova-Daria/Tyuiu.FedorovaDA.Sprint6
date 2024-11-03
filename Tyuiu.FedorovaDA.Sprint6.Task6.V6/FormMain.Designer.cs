namespace Tyuiu.FedorovaDA.Sprint6.Task6.V6
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
            groupBoxTask_FDA = new GroupBox();
            textBoxTask_FDA = new TextBox();
            groupBoxInput_FDA = new GroupBox();
            textBoxIn_FDA = new TextBox();
            groupBoxResult_FDA = new GroupBox();
            textBoxOut_FDA = new TextBox();
            buttonQuestion_FDA = new Button();
            buttonFile_FDA = new Button();
            buttonDone_FDA = new Button();
            openFileDialogTask_FDA = new OpenFileDialog();
            toolTip_FDA = new ToolTip(components);
            groupBoxTask_FDA.SuspendLayout();
            groupBoxInput_FDA.SuspendLayout();
            groupBoxResult_FDA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_FDA
            // 
            groupBoxTask_FDA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask_FDA.Controls.Add(textBoxTask_FDA);
            groupBoxTask_FDA.Location = new Point(12, 103);
            groupBoxTask_FDA.Name = "groupBoxTask_FDA";
            groupBoxTask_FDA.Size = new Size(1233, 117);
            groupBoxTask_FDA.TabIndex = 1;
            groupBoxTask_FDA.TabStop = false;
            groupBoxTask_FDA.Text = "Условие";
            // 
            // textBoxTask_FDA
            // 
            textBoxTask_FDA.BorderStyle = BorderStyle.None;
            textBoxTask_FDA.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTask_FDA.Location = new Point(6, 26);
            textBoxTask_FDA.Multiline = true;
            textBoxTask_FDA.Name = "textBoxTask_FDA";
            textBoxTask_FDA.ReadOnly = true;
            textBoxTask_FDA.Size = new Size(1214, 85);
            textBoxTask_FDA.TabIndex = 0;
            textBoxTask_FDA.Text = resources.GetString("textBoxTask_FDA.Text");
            // 
            // groupBoxInput_FDA
            // 
            groupBoxInput_FDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxInput_FDA.Controls.Add(textBoxIn_FDA);
            groupBoxInput_FDA.Location = new Point(12, 220);
            groupBoxInput_FDA.Name = "groupBoxInput_FDA";
            groupBoxInput_FDA.Size = new Size(607, 376);
            groupBoxInput_FDA.TabIndex = 2;
            groupBoxInput_FDA.TabStop = false;
            groupBoxInput_FDA.Text = "Ввод";
            // 
            // textBoxIn_FDA
            // 
            textBoxIn_FDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxIn_FDA.BorderStyle = BorderStyle.None;
            textBoxIn_FDA.Location = new Point(6, 74);
            textBoxIn_FDA.Multiline = true;
            textBoxIn_FDA.Name = "textBoxIn_FDA";
            textBoxIn_FDA.ScrollBars = ScrollBars.Vertical;
            textBoxIn_FDA.Size = new Size(595, 296);
            textBoxIn_FDA.TabIndex = 0;
            // 
            // groupBoxResult_FDA
            // 
            groupBoxResult_FDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxResult_FDA.Controls.Add(textBoxOut_FDA);
            groupBoxResult_FDA.Location = new Point(625, 220);
            groupBoxResult_FDA.Name = "groupBoxResult_FDA";
            groupBoxResult_FDA.Size = new Size(620, 376);
            groupBoxResult_FDA.TabIndex = 3;
            groupBoxResult_FDA.TabStop = false;
            groupBoxResult_FDA.Text = "Вывод";
            // 
            // textBoxOut_FDA
            // 
            textBoxOut_FDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOut_FDA.BackColor = SystemColors.Window;
            textBoxOut_FDA.BorderStyle = BorderStyle.None;
            textBoxOut_FDA.Location = new Point(6, 26);
            textBoxOut_FDA.Multiline = true;
            textBoxOut_FDA.Name = "textBoxOut_FDA";
            textBoxOut_FDA.ReadOnly = true;
            textBoxOut_FDA.ScrollBars = ScrollBars.Vertical;
            textBoxOut_FDA.Size = new Size(595, 344);
            textBoxOut_FDA.TabIndex = 1;
            // 
            // buttonQuestion_FDA
            // 
            buttonQuestion_FDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonQuestion_FDA.BackgroundImage = Properties.Resources.free_icon_question_mark_5726775;
            buttonQuestion_FDA.BackgroundImageLayout = ImageLayout.Zoom;
            buttonQuestion_FDA.Location = new Point(1123, 12);
            buttonQuestion_FDA.Name = "buttonQuestion_FDA";
            buttonQuestion_FDA.Size = new Size(117, 85);
            buttonQuestion_FDA.TabIndex = 4;
            toolTip_FDA.SetToolTip(buttonQuestion_FDA, "Сведение о программе");
            buttonQuestion_FDA.UseVisualStyleBackColor = true;
            buttonQuestion_FDA.Click += buttonQuestion_FDA_Click;
            // 
            // buttonFile_FDA
            // 
            buttonFile_FDA.BackgroundImage = (Image)resources.GetObject("buttonFile_FDA.BackgroundImage");
            buttonFile_FDA.BackgroundImageLayout = ImageLayout.Zoom;
            buttonFile_FDA.Location = new Point(12, 12);
            buttonFile_FDA.Name = "buttonFile_FDA";
            buttonFile_FDA.Size = new Size(117, 85);
            buttonFile_FDA.TabIndex = 5;
            toolTip_FDA.SetToolTip(buttonFile_FDA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonFile_FDA.UseVisualStyleBackColor = true;
            buttonFile_FDA.Click += buttonFile_FDA_Click;
            // 
            // buttonDone_FDA
            // 
            buttonDone_FDA.BackgroundImage = Properties.Resources.free_icon_open_file_7604005;
            buttonDone_FDA.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDone_FDA.Location = new Point(135, 12);
            buttonDone_FDA.Name = "buttonDone_FDA";
            buttonDone_FDA.Size = new Size(117, 85);
            buttonDone_FDA.TabIndex = 6;
            toolTip_FDA.SetToolTip(buttonDone_FDA, "Производит поиск файла\r\nВыводится содержимое файла и вывод результата исходя из содержимого файла\r\n");
            buttonDone_FDA.UseVisualStyleBackColor = true;
            buttonDone_FDA.Click += buttonDone_FDA_Click;
            // 
            // openFileDialogTask_FDA
            // 
            openFileDialogTask_FDA.FileName = "FormAbout";
            // 
            // toolTip_FDA
            // 
            toolTip_FDA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_FDA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 608);
            Controls.Add(buttonDone_FDA);
            Controls.Add(buttonFile_FDA);
            Controls.Add(buttonQuestion_FDA);
            Controls.Add(groupBoxResult_FDA);
            Controls.Add(groupBoxInput_FDA);
            Controls.Add(groupBoxTask_FDA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 6 | Федорова Д.А.";
            groupBoxTask_FDA.ResumeLayout(false);
            groupBoxTask_FDA.PerformLayout();
            groupBoxInput_FDA.ResumeLayout(false);
            groupBoxInput_FDA.PerformLayout();
            groupBoxResult_FDA.ResumeLayout(false);
            groupBoxResult_FDA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_FDA;
        private TextBox textBoxTask_FDA;
        private GroupBox groupBoxInput_FDA;
        private TextBox textBoxIn_FDA;
        private GroupBox groupBoxResult_FDA;
        private TextBox textBoxOut_FDA;
        private Button buttonQuestion_FDA;
        private Button buttonFile_FDA;
        private Button buttonDone_FDA;
        private OpenFileDialog openFileDialogTask_FDA;
        private ToolTip toolTip_FDA;
    }
}
