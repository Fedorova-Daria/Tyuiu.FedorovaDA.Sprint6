namespace Tyuiu.FedorovaDA.Sprint6.Task3.V11
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
            groupBoxTask_FDA = new GroupBox();
            dataGridView_FDA = new DataGridView();
            textBoxTask_FDA = new TextBox();
            groupBoxResult_FDA = new GroupBox();
            textBoxRes_FDA = new TextBox();
            textBoxResult_FDA = new TextBox();
            buttonDone_FDA = new Button();
            buttonQuestion_FDA = new Button();
            groupBoxTask_FDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_FDA).BeginInit();
            groupBoxResult_FDA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_FDA
            // 
            groupBoxTask_FDA.Controls.Add(dataGridView_FDA);
            groupBoxTask_FDA.Controls.Add(textBoxTask_FDA);
            groupBoxTask_FDA.Location = new Point(12, 12);
            groupBoxTask_FDA.Name = "groupBoxTask_FDA";
            groupBoxTask_FDA.Size = new Size(560, 426);
            groupBoxTask_FDA.TabIndex = 0;
            groupBoxTask_FDA.TabStop = false;
            groupBoxTask_FDA.Text = "Условие";
            // 
            // dataGridView_FDA
            // 
            dataGridView_FDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_FDA.Location = new Point(198, 26);
            dataGridView_FDA.Name = "dataGridView_FDA";
            dataGridView_FDA.RowHeadersVisible = false;
            dataGridView_FDA.RowHeadersWidth = 51;
            dataGridView_FDA.Size = new Size(356, 394);
            dataGridView_FDA.TabIndex = 1;
            // 
            // textBoxTask_FDA
            // 
            textBoxTask_FDA.BackColor = SystemColors.Control;
            textBoxTask_FDA.BorderStyle = BorderStyle.None;
            textBoxTask_FDA.Location = new Point(6, 26);
            textBoxTask_FDA.Multiline = true;
            textBoxTask_FDA.Name = "textBoxTask_FDA";
            textBoxTask_FDA.ReadOnly = true;
            textBoxTask_FDA.Size = new Size(186, 335);
            textBoxTask_FDA.TabIndex = 0;
            textBoxTask_FDA.Text = resources.GetString("textBoxTask_FDA.Text");
            // 
            // groupBoxResult_FDA
            // 
            groupBoxResult_FDA.Controls.Add(textBoxRes_FDA);
            groupBoxResult_FDA.Controls.Add(textBoxResult_FDA);
            groupBoxResult_FDA.Location = new Point(578, 12);
            groupBoxResult_FDA.Name = "groupBoxResult_FDA";
            groupBoxResult_FDA.Size = new Size(210, 341);
            groupBoxResult_FDA.TabIndex = 1;
            groupBoxResult_FDA.TabStop = false;
            groupBoxResult_FDA.Text = "Вывод данных";
            // 
            // textBoxRes_FDA
            // 
            textBoxRes_FDA.BackColor = SystemColors.Control;
            textBoxRes_FDA.BorderStyle = BorderStyle.None;
            textBoxRes_FDA.Location = new Point(6, 26);
            textBoxRes_FDA.Name = "textBoxRes_FDA";
            textBoxRes_FDA.ReadOnly = true;
            textBoxRes_FDA.Size = new Size(186, 20);
            textBoxRes_FDA.TabIndex = 2;
            textBoxRes_FDA.Text = "\r\n Результат";
            // 
            // textBoxResult_FDA
            // 
            textBoxResult_FDA.BackColor = SystemColors.ControlLightLight;
            textBoxResult_FDA.Location = new Point(6, 52);
            textBoxResult_FDA.Multiline = true;
            textBoxResult_FDA.Name = "textBoxResult_FDA";
            textBoxResult_FDA.ReadOnly = true;
            textBoxResult_FDA.Size = new Size(198, 271);
            textBoxResult_FDA.TabIndex = 0;
            // 
            // buttonDone_FDA
            // 
            buttonDone_FDA.BackColor = SystemColors.ControlLightLight;
            buttonDone_FDA.FlatStyle = FlatStyle.Popup;
            buttonDone_FDA.Location = new Point(659, 403);
            buttonDone_FDA.Name = "buttonDone_FDA";
            buttonDone_FDA.Size = new Size(111, 29);
            buttonDone_FDA.TabIndex = 2;
            buttonDone_FDA.Text = "Выполнить";
            buttonDone_FDA.UseVisualStyleBackColor = false;
            buttonDone_FDA.Click += buttonDone_FDA_Click;
            // 
            // buttonQuestion_FDA
            // 
            buttonQuestion_FDA.BackColor = SystemColors.ControlLightLight;
            buttonQuestion_FDA.FlatStyle = FlatStyle.Popup;
            buttonQuestion_FDA.Location = new Point(595, 403);
            buttonQuestion_FDA.Name = "buttonQuestion_FDA";
            buttonQuestion_FDA.Size = new Size(58, 29);
            buttonQuestion_FDA.TabIndex = 3;
            buttonQuestion_FDA.Text = "?";
            buttonQuestion_FDA.UseVisualStyleBackColor = false;
            buttonQuestion_FDA.Click += buttonQuestion_FDA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonQuestion_FDA);
            Controls.Add(buttonDone_FDA);
            Controls.Add(groupBoxResult_FDA);
            Controls.Add(groupBoxTask_FDA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 11 | Федорова Д.А.";
            Load += FormMain_Load_1;
            groupBoxTask_FDA.ResumeLayout(false);
            groupBoxTask_FDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_FDA).EndInit();
            groupBoxResult_FDA.ResumeLayout(false);
            groupBoxResult_FDA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_FDA;
        private GroupBox groupBoxResult_FDA;
        private DataGridView dataGridView_FDA;
        private TextBox textBoxTask_FDA;
        private TextBox textBoxRes_FDA;
        private TextBox textBoxResult_FDA;
        private Button buttonDone_FDA;
        private Button buttonQuestion_FDA;
    }
}
