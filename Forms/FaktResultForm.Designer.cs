namespace ComPort.Forms
{
    partial class FaktResultForm
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
            this.Back = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RequiredLoad = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.RP = new System.Windows.Forms.TextBox();
            this.PosLoad = new System.Windows.Forms.TextBox();
            this.FP = new System.Windows.Forms.TextBox();
            this.WeightLoad = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Names = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DistanceExis = new System.Windows.Forms.TextBox();
            this.Team = new System.Windows.Forms.Label();
            this.TypeText = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.TeamBox = new System.Windows.Forms.TextBox();
            this.NameMeas = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(613, 494);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(139, 42);
            this.Back.TabIndex = 0;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(824, 494);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(139, 42);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dateTime);
            this.groupBox5.Location = new System.Drawing.Point(700, 13);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(272, 75);
            this.groupBox5.TabIndex = 50;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Дата измерения";
            // 
            // dateTime
            // 
            this.dateTime.Enabled = false;
            this.dateTime.Location = new System.Drawing.Point(30, 37);
            this.dateTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(224, 22);
            this.dateTime.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.RP);
            this.groupBox1.Controls.Add(this.FP);
            this.groupBox1.Controls.Add(this.Weight);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(17, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(531, 271);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результат расчета";
            // 
            // RequiredLoad
            // 
            this.RequiredLoad.Location = new System.Drawing.Point(328, 43);
            this.RequiredLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RequiredLoad.Name = "RequiredLoad";
            this.RequiredLoad.ReadOnly = true;
            this.RequiredLoad.Size = new System.Drawing.Size(194, 26);
            this.RequiredLoad.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(318, 20);
            this.label16.TabIndex = 45;
            this.label16.Text = "Требуемая нагрузка на переднюю ось, %";
            // 
            // RP
            // 
            this.RP.Location = new System.Drawing.Point(328, 226);
            this.RP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RP.Name = "RP";
            this.RP.ReadOnly = true;
            this.RP.Size = new System.Drawing.Size(194, 26);
            this.RP.TabIndex = 9;
            // 
            // PosLoad
            // 
            this.PosLoad.Location = new System.Drawing.Point(328, 130);
            this.PosLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PosLoad.Name = "PosLoad";
            this.PosLoad.ReadOnly = true;
            this.PosLoad.Size = new System.Drawing.Size(194, 26);
            this.PosLoad.TabIndex = 8;
            // 
            // FP
            // 
            this.FP.Location = new System.Drawing.Point(328, 175);
            this.FP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FP.Name = "FP";
            this.FP.ReadOnly = true;
            this.FP.Size = new System.Drawing.Size(194, 26);
            this.FP.TabIndex = 7;
            // 
            // WeightLoad
            // 
            this.WeightLoad.Location = new System.Drawing.Point(328, 85);
            this.WeightLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WeightLoad.Name = "WeightLoad";
            this.WeightLoad.ReadOnly = true;
            this.WeightLoad.Size = new System.Drawing.Size(194, 26);
            this.WeightLoad.TabIndex = 6;
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(328, 27);
            this.Weight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Size = new System.Drawing.Size(194, 26);
            this.Weight.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Нагрузка на заднюю ось без груза, %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Нагрузка на переднюю ось без груза, %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Положение груза, мм";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Масса груза, кг";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Общая масса, кг";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Название измерения";
            // 
            // Names
            // 
            this.Names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Names.FormattingEnabled = true;
            this.Names.Location = new System.Drawing.Point(199, 18);
            this.Names.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(474, 24);
            this.Names.TabIndex = 47;
            this.Names.SelectedIndexChanged += new System.EventHandler(this.Names_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(328, 74);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(194, 26);
            this.textBox1.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Нагрузка на переднюю ось без груза, кг";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(292, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Нагрузка на звднюю ось без груза, кг";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(328, 125);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(194, 26);
            this.textBox2.TabIndex = 49;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PosLoad);
            this.groupBox2.Controls.Add(this.WeightLoad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.RequiredLoad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(17, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 179);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Рекомендации компьютера";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.Gender);
            this.groupBox3.Controls.Add(this.DistanceExis);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.Team);
            this.groupBox3.Controls.Add(this.TypeText);
            this.groupBox3.Controls.Add(this.TypeBox);
            this.groupBox3.Controls.Add(this.TeamBox);
            this.groupBox3.Controls.Add(this.NameMeas);
            this.groupBox3.Controls.Add(this.NameText);
            this.groupBox3.Controls.Add(this.SaveButton);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(567, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 298);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Основные данные";
            // 
            // Gender
            // 
            this.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender.Enabled = false;
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.Gender.Location = new System.Drawing.Point(257, 42);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(122, 28);
            this.Gender.TabIndex = 89;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(202, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 25);
            this.label14.TabIndex = 88;
            this.label14.Text = "Пол";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(231, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Расстояние между осями, мм";
            // 
            // DistanceExis
            // 
            this.DistanceExis.Location = new System.Drawing.Point(257, 249);
            this.DistanceExis.Name = "DistanceExis";
            this.DistanceExis.ReadOnly = true;
            this.DistanceExis.Size = new System.Drawing.Size(121, 26);
            this.DistanceExis.TabIndex = 0;
            // 
            // Team
            // 
            this.Team.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Team.AutoSize = true;
            this.Team.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.Team.Location = new System.Drawing.Point(156, 200);
            this.Team.Name = "Team";
            this.Team.Size = new System.Drawing.Size(95, 25);
            this.Team.TabIndex = 86;
            this.Team.Text = "Команда";
            // 
            // TypeText
            // 
            this.TypeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeText.AutoSize = true;
            this.TypeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.TypeText.Location = new System.Drawing.Point(158, 151);
            this.TypeText.Name = "TypeText";
            this.TypeText.Size = new System.Drawing.Size(93, 25);
            this.TypeText.TabIndex = 85;
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
            this.TypeBox.Location = new System.Drawing.Point(257, 148);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(121, 28);
            this.TypeBox.TabIndex = 84;
            this.TypeBox.Text = "2";
            // 
            // TeamBox
            // 
            this.TeamBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TeamBox.Location = new System.Drawing.Point(257, 199);
            this.TeamBox.Name = "TeamBox";
            this.TeamBox.ReadOnly = true;
            this.TeamBox.Size = new System.Drawing.Size(121, 26);
            this.TeamBox.TabIndex = 83;
            // 
            // NameMeas
            // 
            this.NameMeas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameMeas.Location = new System.Drawing.Point(258, 98);
            this.NameMeas.Name = "NameMeas";
            this.NameMeas.ReadOnly = true;
            this.NameMeas.Size = new System.Drawing.Size(121, 26);
            this.NameMeas.TabIndex = 82;
            // 
            // NameText
            // 
            this.NameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameText.AutoSize = true;
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.NameText.Location = new System.Drawing.Point(43, 99);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(209, 25);
            this.NameText.TabIndex = 81;
            this.NameText.Text = "Название измерения";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(272, 434);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(92, 34);
            this.SaveButton.TabIndex = 80;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // FaktResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Back);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FaktResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaktResultForm";
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox RP;
        private System.Windows.Forms.TextBox FP;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RequiredLoad;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox PosLoad;
        private System.Windows.Forms.TextBox WeightLoad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Names;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.TextBox DistanceExis;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Team;
        private System.Windows.Forms.Label TypeText;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.TextBox TeamBox;
        private System.Windows.Forms.TextBox NameMeas;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.Button SaveButton;
    }
}