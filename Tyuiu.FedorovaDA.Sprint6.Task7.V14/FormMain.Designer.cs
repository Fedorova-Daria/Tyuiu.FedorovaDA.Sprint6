namespace Tyuiu.FedorovaDA.Sprint6.Task7.V14
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
            buttonDone_FDA = new Button();
            buttonOpenFile_FDA = new Button();
            buttonQuestion_FDA = new Button();
            groupBoxResult_FDA = new GroupBox();
            dataGridViewSave_FDA = new DataGridView();
            groupBoxInput_FDA = new GroupBox();
            dataGridViewOpen_FDA = new DataGridView();
            groupBoxTask_FDA = new GroupBox();
            textBoxTask_FDA = new TextBox();
            openFileDialog_FDA = new OpenFileDialog();
            saveFileDialog_FDA = new SaveFileDialog();
            toolTip_FDA = new ToolTip(components);
            buttonSaveFile_FDA = new Button();
            groupBoxResult_FDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSave_FDA).BeginInit();
            groupBoxInput_FDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOpen_FDA).BeginInit();
            groupBoxTask_FDA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone_FDA
            // 
            buttonDone_FDA.BackgroundImage = (Image)resources.GetObject("buttonDone_FDA.BackgroundImage");
            buttonDone_FDA.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDone_FDA.Location = new Point(135, 19);
            buttonDone_FDA.Name = "buttonDone_FDA";
            buttonDone_FDA.Size = new Size(117, 85);
            buttonDone_FDA.TabIndex = 12;
            buttonDone_FDA.UseVisualStyleBackColor = true;
            buttonDone_FDA.Click += buttonDone_FDA_Click;
            // 
            // buttonOpenFile_FDA
            // 
            buttonOpenFile_FDA.BackgroundImage = (Image)resources.GetObject("buttonOpenFile_FDA.BackgroundImage");
            buttonOpenFile_FDA.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOpenFile_FDA.Location = new Point(12, 19);
            buttonOpenFile_FDA.Name = "buttonOpenFile_FDA";
            buttonOpenFile_FDA.Size = new Size(117, 85);
            buttonOpenFile_FDA.TabIndex = 11;
            buttonOpenFile_FDA.UseVisualStyleBackColor = true;
            buttonOpenFile_FDA.Click += buttonOpenFile_FDA_Click;
            // 
            // buttonQuestion_FDA
            // 
            buttonQuestion_FDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonQuestion_FDA.BackgroundImage = Properties.Resources.free_icon_question_mark_5726775;
            buttonQuestion_FDA.BackgroundImageLayout = ImageLayout.Zoom;
            buttonQuestion_FDA.Location = new Point(1108, 19);
            buttonQuestion_FDA.Name = "buttonQuestion_FDA";
            buttonQuestion_FDA.Size = new Size(117, 85);
            buttonQuestion_FDA.TabIndex = 10;
            buttonQuestion_FDA.UseVisualStyleBackColor = true;
            buttonQuestion_FDA.Click += buttonQuestion_FDA_Click;
            // 
            // groupBoxResult_FDA
            // 
            groupBoxResult_FDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxResult_FDA.Controls.Add(dataGridViewSave_FDA);
            groupBoxResult_FDA.Location = new Point(625, 233);
            groupBoxResult_FDA.Name = "groupBoxResult_FDA";
            groupBoxResult_FDA.Size = new Size(600, 376);
            groupBoxResult_FDA.TabIndex = 9;
            groupBoxResult_FDA.TabStop = false;
            groupBoxResult_FDA.Text = "Вывод";
            // 
            // dataGridViewSave_FDA
            // 
            dataGridViewSave_FDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSave_FDA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewSave_FDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSave_FDA.Location = new Point(6, 29);
            dataGridViewSave_FDA.Name = "dataGridViewSave_FDA";
            dataGridViewSave_FDA.RowHeadersWidth = 51;
            dataGridViewSave_FDA.Size = new Size(588, 288);
            dataGridViewSave_FDA.TabIndex = 1;
            // 
            // groupBoxInput_FDA
            // 
            groupBoxInput_FDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxInput_FDA.Controls.Add(dataGridViewOpen_FDA);
            groupBoxInput_FDA.Location = new Point(12, 227);
            groupBoxInput_FDA.Name = "groupBoxInput_FDA";
            groupBoxInput_FDA.Size = new Size(607, 376);
            groupBoxInput_FDA.TabIndex = 8;
            groupBoxInput_FDA.TabStop = false;
            groupBoxInput_FDA.Text = "Ввод";
            // 
            // dataGridViewOpen_FDA
            // 
            dataGridViewOpen_FDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewOpen_FDA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewOpen_FDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOpen_FDA.Location = new Point(6, 35);
            dataGridViewOpen_FDA.Name = "dataGridViewOpen_FDA";
            dataGridViewOpen_FDA.ReadOnly = true;
            dataGridViewOpen_FDA.RowHeadersWidth = 51;
            dataGridViewOpen_FDA.Size = new Size(595, 288);
            dataGridViewOpen_FDA.TabIndex = 0;
            // 
            // groupBoxTask_FDA
            // 
            groupBoxTask_FDA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask_FDA.Controls.Add(textBoxTask_FDA);
            groupBoxTask_FDA.Location = new Point(12, 110);
            groupBoxTask_FDA.Name = "groupBoxTask_FDA";
            groupBoxTask_FDA.Size = new Size(1213, 117);
            groupBoxTask_FDA.TabIndex = 7;
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
            textBoxTask_FDA.Size = new Size(1191, 85);
            textBoxTask_FDA.TabIndex = 0;
            textBoxTask_FDA.Text = resources.GetString("textBoxTask_FDA.Text");
            // 
            // openFileDialog_FDA
            // 
            openFileDialog_FDA.FileName = "openFileDialog1";
            // 
            // toolTip_FDA
            // 
            toolTip_FDA.IsBalloon = true;
            toolTip_FDA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_FDA.ToolTipTitle = "Подсказка";
            // 
            // buttonSaveFile_FDA
            // 
            buttonSaveFile_FDA.BackgroundImage = Properties.Resources.rb_5850;
            buttonSaveFile_FDA.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSaveFile_FDA.Location = new Point(258, 19);
            buttonSaveFile_FDA.Name = "buttonSaveFile_FDA";
            buttonSaveFile_FDA.Size = new Size(106, 85);
            buttonSaveFile_FDA.TabIndex = 13;
            buttonSaveFile_FDA.UseVisualStyleBackColor = true;
            buttonSaveFile_FDA.Click += buttonSaveFile_FDA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 623);
            Controls.Add(buttonSaveFile_FDA);
            Controls.Add(buttonDone_FDA);
            Controls.Add(buttonOpenFile_FDA);
            Controls.Add(buttonQuestion_FDA);
            Controls.Add(groupBoxResult_FDA);
            Controls.Add(groupBoxInput_FDA);
            Controls.Add(groupBoxTask_FDA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 14 | Федорова Д.А.";
            groupBoxResult_FDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSave_FDA).EndInit();
            groupBoxInput_FDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOpen_FDA).EndInit();
            groupBoxTask_FDA.ResumeLayout(false);
            groupBoxTask_FDA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_FDA;
        private Button buttonOpenFile_FDA;
        private Button buttonQuestion_FDA;
        private GroupBox groupBoxResult_FDA;
        private GroupBox groupBoxInput_FDA;
        private GroupBox groupBoxTask_FDA;
        private TextBox textBoxTask_FDA;
        private OpenFileDialog openFileDialog_FDA;
        private SaveFileDialog saveFileDialog_FDA;
        private ToolTip toolTip_FDA;
        private DataGridView dataGridViewSave_FDA;
        private DataGridView dataGridViewOpen_FDA;
        private Button buttonSaveFile_FDA;
    }
}
