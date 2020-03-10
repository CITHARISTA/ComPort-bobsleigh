namespace ComPort.Forms
{
    partial class SportsmanForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.FullName = new System.Windows.Forms.TextBox();
            this.Team = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.ActionInput = new System.Windows.Forms.ComboBox();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.GenderSort = new System.Windows.Forms.CheckBox();
            this.TeamSort = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.WeightOnLeg = new System.Windows.Forms.TextBox();
            this.WeightOnBody = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Действие";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(545, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(552, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(521, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Команда";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(41, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Общий вес";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(524, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Рост, см";
            // 
            // buttonSave
            // 
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Location = new System.Drawing.Point(681, 395);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(107, 43);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Location = new System.Drawing.Point(551, 395);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(107, 43);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // listBox
            // 
            this.listBox.Enabled = false;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(171, 84);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(325, 316);
            this.listBox.TabIndex = 8;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(595, 84);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(122, 20);
            this.FullName.TabIndex = 9;
            // 
            // Team
            // 
            this.Team.Location = new System.Drawing.Point(595, 158);
            this.Team.Name = "Team";
            this.Team.Size = new System.Drawing.Size(122, 20);
            this.Team.TabIndex = 10;
            // 
            // Weight
            // 
            this.Weight.Enabled = false;
            this.Weight.Location = new System.Drawing.Point(131, 100);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(100, 24);
            this.Weight.TabIndex = 11;
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(595, 197);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(122, 20);
            this.Height.TabIndex = 12;
            // 
            // ActionInput
            // 
            this.ActionInput.FormattingEnabled = true;
            this.ActionInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ActionInput.Items.AddRange(new object[] {
            "Добавить",
            "Редактировать",
            "Удалить"});
            this.ActionInput.Location = new System.Drawing.Point(105, 55);
            this.ActionInput.Name = "ActionInput";
            this.ActionInput.Size = new System.Drawing.Size(121, 21);
            this.ActionInput.TabIndex = 13;
            this.ActionInput.Text = "Добавить";
            this.ActionInput.SelectedIndexChanged += new System.EventHandler(this.ActionInput_SelectedIndexChanged);
            // 
            // Gender
            // 
            this.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.Gender.Location = new System.Drawing.Point(595, 120);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(122, 21);
            this.Gender.TabIndex = 14;
            // 
            // GenderSort
            // 
            this.GenderSort.AutoSize = true;
            this.GenderSort.Location = new System.Drawing.Point(353, 57);
            this.GenderSort.Name = "GenderSort";
            this.GenderSort.Size = new System.Drawing.Size(51, 17);
            this.GenderSort.TabIndex = 19;
            this.GenderSort.Text = "Полу";
            this.GenderSort.UseVisualStyleBackColor = true;
            this.GenderSort.CheckedChanged += new System.EventHandler(this.GenderSort_CheckedChanged);
            // 
            // TeamSort
            // 
            this.TeamSort.AutoSize = true;
            this.TeamSort.Location = new System.Drawing.Point(276, 57);
            this.TeamSort.Name = "TeamSort";
            this.TeamSort.Size = new System.Drawing.Size(71, 17);
            this.TeamSort.TabIndex = 20;
            this.TeamSort.Text = "Команде";
            this.TeamSort.UseVisualStyleBackColor = true;
            this.TeamSort.CheckedChanged += new System.EventHandler(this.TeamSort_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(273, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Сортировать по:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dateTime);
            this.groupBox4.Location = new System.Drawing.Point(524, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(251, 61);
            this.groupBox4.TabIndex = 77;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WeightOnBody);
            this.groupBox1.Controls.Add(this.WeightOnLeg);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Weight);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(527, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 140);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Распределение веса, кг";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Вес в ногах";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Вес в корпусе";
            // 
            // WeightOnLeg
            // 
            this.WeightOnLeg.Location = new System.Drawing.Point(131, 40);
            this.WeightOnLeg.Name = "WeightOnLeg";
            this.WeightOnLeg.Size = new System.Drawing.Size(100, 24);
            this.WeightOnLeg.TabIndex = 14;
            // 
            // WeightOnBody
            // 
            this.WeightOnBody.Location = new System.Drawing.Point(131, 70);
            this.WeightOnBody.Name = "WeightOnBody";
            this.WeightOnBody.Size = new System.Drawing.Size(100, 24);
            this.WeightOnBody.TabIndex = 15;
            // 
            // SportsmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TeamSort);
            this.Controls.Add(this.GenderSort);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.ActionInput);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Team);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "SportsmanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SportsmanForm";
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.TextBox Team;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.ComboBox ActionInput;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.CheckBox GenderSort;
        private System.Windows.Forms.CheckBox TeamSort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox WeightOnBody;
        private System.Windows.Forms.TextBox WeightOnLeg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}