namespace ComPort.Forms
{
    partial class BeanForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.TeamSort = new System.Windows.Forms.CheckBox();
            this.TypeSort = new System.Windows.Forms.CheckBox();
            this.ActionInput = new System.Windows.Forms.ComboBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Team = new System.Windows.Forms.Label();
            this.TypeText = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.TeamBox = new System.Windows.Forms.TextBox();
            this.NameBean = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.textBoxB_percent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxF_percent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBL = new System.Windows.Forms.TextBox();
            this.textBoxBR = new System.Windows.Forms.TextBox();
            this.textBoxFL = new System.Windows.Forms.TextBox();
            this.textBoxFR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DistanceExis = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(22, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Сортировать по:";
            // 
            // TeamSort
            // 
            this.TeamSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TeamSort.AutoSize = true;
            this.TeamSort.Location = new System.Drawing.Point(12, 531);
            this.TeamSort.Name = "TeamSort";
            this.TeamSort.Size = new System.Drawing.Size(71, 17);
            this.TeamSort.TabIndex = 27;
            this.TeamSort.Text = "Команде";
            this.TeamSort.UseVisualStyleBackColor = true;
            this.TeamSort.CheckedChanged += new System.EventHandler(this.TeamSort_CheckedChanged);
            // 
            // TypeSort
            // 
            this.TypeSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TypeSort.AutoSize = true;
            this.TypeSort.Location = new System.Drawing.Point(89, 531);
            this.TypeSort.Name = "TypeSort";
            this.TypeSort.Size = new System.Drawing.Size(50, 17);
            this.TypeSort.TabIndex = 26;
            this.TypeSort.Text = "Типу";
            this.TypeSort.UseVisualStyleBackColor = true;
            this.TypeSort.CheckedChanged += new System.EventHandler(this.TypeSort_CheckedChanged);
            // 
            // ActionInput
            // 
            this.ActionInput.FormattingEnabled = true;
            this.ActionInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ActionInput.Items.AddRange(new object[] {
            "Редактировать",
            "Удалить"});
            this.ActionInput.Location = new System.Drawing.Point(75, 23);
            this.ActionInput.Name = "ActionInput";
            this.ActionInput.Size = new System.Drawing.Size(121, 21);
            this.ActionInput.TabIndex = 25;
            this.ActionInput.Text = "Редактировать";
            this.ActionInput.SelectedIndexChanged += new System.EventHandler(this.ActionInput_SelectedIndexChanged);
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(15, 71);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(368, 420);
            this.listBox.TabIndex = 24;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Location = new System.Drawing.Point(695, 511);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(118, 37);
            this.buttonBack.TabIndex = 23;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Location = new System.Drawing.Point(840, 511);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(114, 37);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Действие";
            // 
            // Team
            // 
            this.Team.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Team.AutoSize = true;
            this.Team.Location = new System.Drawing.Point(632, 19);
            this.Team.Name = "Team";
            this.Team.Size = new System.Drawing.Size(52, 13);
            this.Team.TabIndex = 65;
            this.Team.Text = "Команда";
            // 
            // TypeText
            // 
            this.TypeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeText.AutoSize = true;
            this.TypeText.Location = new System.Drawing.Point(797, 19);
            this.TypeText.Name = "TypeText";
            this.TypeText.Size = new System.Drawing.Size(52, 13);
            this.TypeText.TabIndex = 64;
            this.TypeText.Text = "Тип (2/4)";
            // 
            // TypeBox
            // 
            this.TypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeBox.Enabled = false;
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "2",
            "4"});
            this.TypeBox.Location = new System.Drawing.Point(800, 35);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(121, 21);
            this.TypeBox.TabIndex = 63;
            // 
            // TeamBox
            // 
            this.TeamBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TeamBox.Location = new System.Drawing.Point(635, 35);
            this.TeamBox.Name = "TeamBox";
            this.TeamBox.Size = new System.Drawing.Size(121, 20);
            this.TeamBox.TabIndex = 58;
            // 
            // NameBean
            // 
            this.NameBean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBean.Location = new System.Drawing.Point(470, 35);
            this.NameBean.Name = "NameBean";
            this.NameBean.Size = new System.Drawing.Size(121, 20);
            this.NameBean.TabIndex = 57;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(467, 19);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(84, 13);
            this.NameLabel.TabIndex = 56;
            this.NameLabel.Text = "Название боба";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(63, 40);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(100, 20);
            this.textBoxSum.TabIndex = 47;
            // 
            // textBoxB_percent
            // 
            this.textBoxB_percent.Location = new System.Drawing.Point(63, 242);
            this.textBoxB_percent.Name = "textBoxB_percent";
            this.textBoxB_percent.Size = new System.Drawing.Size(100, 20);
            this.textBoxB_percent.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Нагрузка на заднюю ось, %";
            // 
            // textBoxF_percent
            // 
            this.textBoxF_percent.Location = new System.Drawing.Point(63, 203);
            this.textBoxF_percent.Name = "textBoxF_percent";
            this.textBoxF_percent.Size = new System.Drawing.Size(100, 20);
            this.textBoxF_percent.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Нагрузка на переднюю ось, %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Нагрузка на заднюю ось";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Общая масса";
            // 
            // textBoxBL
            // 
            this.textBoxBL.Location = new System.Drawing.Point(145, 80);
            this.textBoxBL.Name = "textBoxBL";
            this.textBoxBL.Size = new System.Drawing.Size(100, 20);
            this.textBoxBL.TabIndex = 45;
            // 
            // textBoxBR
            // 
            this.textBoxBR.Location = new System.Drawing.Point(145, 40);
            this.textBoxBR.Name = "textBoxBR";
            this.textBoxBR.Size = new System.Drawing.Size(100, 20);
            this.textBoxBR.TabIndex = 44;
            // 
            // textBoxFL
            // 
            this.textBoxFL.Location = new System.Drawing.Point(9, 80);
            this.textBoxFL.Name = "textBoxFL";
            this.textBoxFL.Size = new System.Drawing.Size(100, 20);
            this.textBoxFL.TabIndex = 43;
            // 
            // textBoxFR
            // 
            this.textBoxFR.Location = new System.Drawing.Point(9, 40);
            this.textBoxFR.Name = "textBoxFR";
            this.textBoxFR.Size = new System.Drawing.Size(100, 20);
            this.textBoxFR.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Задний правый";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Задний левый";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Передний левый";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Передний правый";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(63, 103);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Нагрузка на переднюю ось";
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(63, 142);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(100, 20);
            this.textBoxF.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxFR);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxBR);
            this.groupBox1.Controls.Add(this.textBoxFL);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxBL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(695, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 109);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нагрузка на полозья";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxSum);
            this.groupBox3.Controls.Add(this.textBoxB);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxF);
            this.groupBox3.Controls.Add(this.textBoxB_percent);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxF_percent);
            this.groupBox3.Location = new System.Drawing.Point(411, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 303);
            this.groupBox3.TabIndex = 72;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Масса и нагрузка на оси";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(233, 13);
            this.label12.TabIndex = 73;
            this.label12.Text = "Название - Команда - Тип - Дата измерения";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(751, 220);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 13);
            this.label14.TabIndex = 74;
            this.label14.Text = "Расстояние между осями (мм)";
            // 
            // DistanceExis
            // 
            this.DistanceExis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DistanceExis.Location = new System.Drawing.Point(786, 236);
            this.DistanceExis.Name = "DistanceExis";
            this.DistanceExis.Size = new System.Drawing.Size(100, 20);
            this.DistanceExis.TabIndex = 75;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dateTime);
            this.groupBox4.Location = new System.Drawing.Point(703, 272);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(251, 61);
            this.groupBox4.TabIndex = 76;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Дата измерения";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(23, 30);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(208, 20);
            this.dateTime.TabIndex = 43;
            // 
            // BeanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.DistanceExis);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Team);
            this.Controls.Add(this.TypeText);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.TeamBox);
            this.Controls.Add(this.NameBean);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TeamSort);
            this.Controls.Add(this.TypeSort);
            this.Controls.Add(this.ActionInput);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "BeanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeanForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox TeamSort;
        private System.Windows.Forms.CheckBox TypeSort;
        private System.Windows.Forms.ComboBox ActionInput;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Team;
        private System.Windows.Forms.Label TypeText;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.TextBox TeamBox;
        private System.Windows.Forms.TextBox NameBean;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.TextBox textBoxB_percent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxF_percent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBL;
        private System.Windows.Forms.TextBox textBoxBR;
        private System.Windows.Forms.TextBox textBoxFL;
        private System.Windows.Forms.TextBox textBoxFR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox DistanceExis;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTime;
    }
}