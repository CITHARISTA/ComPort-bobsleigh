namespace ComPort.Forms
{
    partial class FaktForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaktForm));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DistanceExis = new System.Windows.Forms.TextBox();
            this.Team = new System.Windows.Forms.Label();
            this.TypeText = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.TeamBox = new System.Windows.Forms.TextBox();
            this.NameMeas = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.textBoxB_percent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxF_percent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBL = new System.Windows.Forms.TextBox();
            this.textBoxBR = new System.Windows.Forms.TextBox();
            this.textBoxFL = new System.Windows.Forms.TextBox();
            this.textBoxFR = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ComPortComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.RequiredLoad = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTime);
            this.groupBox3.Location = new System.Drawing.Point(667, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 61);
            this.groupBox3.TabIndex = 75;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дата измерения";
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
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.DistanceExis);
            this.groupBox1.Location = new System.Drawing.Point(667, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 67);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Расстояние между осями (мм)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Расстояние";
            // 
            // DistanceExis
            // 
            this.DistanceExis.Location = new System.Drawing.Point(110, 37);
            this.DistanceExis.Name = "DistanceExis";
            this.DistanceExis.Size = new System.Drawing.Size(121, 20);
            this.DistanceExis.TabIndex = 0;
            // 
            // Team
            // 
            this.Team.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Team.AutoSize = true;
            this.Team.Location = new System.Drawing.Point(719, 157);
            this.Team.Name = "Team";
            this.Team.Size = new System.Drawing.Size(52, 13);
            this.Team.TabIndex = 73;
            this.Team.Text = "Команда";
            // 
            // TypeText
            // 
            this.TypeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeText.AutoSize = true;
            this.TypeText.Location = new System.Drawing.Point(719, 122);
            this.TypeText.Name = "TypeText";
            this.TypeText.Size = new System.Drawing.Size(52, 13);
            this.TypeText.TabIndex = 72;
            this.TypeText.Text = "Тип (2/4)";
            // 
            // TypeBox
            // 
            this.TypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "2",
            "4"});
            this.TypeBox.Location = new System.Drawing.Point(777, 119);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(121, 21);
            this.TypeBox.TabIndex = 71;
            this.TypeBox.Text = "2";
            // 
            // TeamBox
            // 
            this.TeamBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TeamBox.Location = new System.Drawing.Point(777, 154);
            this.TeamBox.Name = "TeamBox";
            this.TeamBox.Size = new System.Drawing.Size(121, 20);
            this.TeamBox.TabIndex = 70;
            // 
            // NameMeas
            // 
            this.NameMeas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameMeas.Location = new System.Drawing.Point(777, 85);
            this.NameMeas.Name = "NameMeas";
            this.NameMeas.Size = new System.Drawing.Size(121, 20);
            this.NameMeas.TabIndex = 69;
            // 
            // NameText
            // 
            this.NameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameText.AutoSize = true;
            this.NameText.Location = new System.Drawing.Point(655, 88);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(116, 13);
            this.NameText.TabIndex = 68;
            this.NameText.Text = "Название измерения";
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackButton.Location = new System.Drawing.Point(739, 501);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(92, 34);
            this.BackButton.TabIndex = 67;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click_1);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(852, 501);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(92, 34);
            this.SaveButton.TabIndex = 66;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(222, 22);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(100, 23);
            this.textBoxSum.TabIndex = 57;
            // 
            // textBoxB_percent
            // 
            this.textBoxB_percent.Location = new System.Drawing.Point(222, 169);
            this.textBoxB_percent.Name = "textBoxB_percent";
            this.textBoxB_percent.Size = new System.Drawing.Size(100, 23);
            this.textBoxB_percent.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 17);
            this.label9.TabIndex = 64;
            this.label9.Text = "Нагрузка на заднюю ось, %";
            // 
            // textBoxF_percent
            // 
            this.textBoxF_percent.Location = new System.Drawing.Point(222, 100);
            this.textBoxF_percent.Name = "textBoxF_percent";
            this.textBoxF_percent.Size = new System.Drawing.Size(100, 23);
            this.textBoxF_percent.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 17);
            this.label8.TabIndex = 62;
            this.label8.Text = "Нагрузка на переднюю ось, %";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(222, 140);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 23);
            this.textBoxB.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 17);
            this.label7.TabIndex = 60;
            this.label7.Text = "Нагрузка на заднюю ось, кг";
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(222, 71);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(100, 23);
            this.textBoxF.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Нагрузка на переднюю ось, кг";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Общая масса";
            // 
            // textBoxBL
            // 
            this.textBoxBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxBL.Location = new System.Drawing.Point(407, 282);
            this.textBoxBL.Name = "textBoxBL";
            this.textBoxBL.Size = new System.Drawing.Size(100, 20);
            this.textBoxBL.TabIndex = 54;
            // 
            // textBoxBR
            // 
            this.textBoxBR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxBR.Location = new System.Drawing.Point(407, 95);
            this.textBoxBR.Name = "textBoxBR";
            this.textBoxBR.Size = new System.Drawing.Size(100, 20);
            this.textBoxBR.TabIndex = 53;
            // 
            // textBoxFL
            // 
            this.textBoxFL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxFL.Location = new System.Drawing.Point(127, 282);
            this.textBoxFL.Name = "textBoxFL";
            this.textBoxFL.Size = new System.Drawing.Size(100, 20);
            this.textBoxFL.TabIndex = 52;
            // 
            // textBoxFR
            // 
            this.textBoxFR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxFR.Location = new System.Drawing.Point(127, 94);
            this.textBoxFR.Name = "textBoxFR";
            this.textBoxFR.Size = new System.Drawing.Size(100, 20);
            this.textBoxFR.TabIndex = 51;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(208, 46);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(91, 23);
            this.ConnectButton.TabIndex = 50;
            this.ConnectButton.Text = "Подключиться";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ComPortComboBox
            // 
            this.ComPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPortComboBox.FormattingEnabled = true;
            this.ComPortComboBox.Location = new System.Drawing.Point(67, 46);
            this.ComPortComboBox.Name = "ComPortComboBox";
            this.ComPortComboBox.Size = new System.Drawing.Size(121, 21);
            this.ComPortComboBox.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Задний правый";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Задний левый";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Передний левый";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Передний правый";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxB);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxB_percent);
            this.groupBox2.Controls.Add(this.textBoxF_percent);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxF);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxSum);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(67, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 217);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результаты данных с весов";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.Position);
            this.groupBox4.Controls.Add(this.Weight);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.RequiredLoad);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(469, 332);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(449, 160);
            this.groupBox4.TabIndex = 77;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Рекомендации компьютера по размещению груза";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(4, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(439, 17);
            this.label10.TabIndex = 50;
            this.label10.Text = "Для расчета положения груза введите расстояние между осями!";
            // 
            // Position
            // 
            this.Position.Location = new System.Drawing.Point(308, 97);
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Size = new System.Drawing.Size(116, 23);
            this.Position.TabIndex = 49;
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(308, 61);
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Size = new System.Drawing.Size(116, 23);
            this.Weight.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(253, 17);
            this.label12.TabIndex = 47;
            this.label12.Text = "Положение груза относительно края";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(211, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 17);
            this.label13.TabIndex = 46;
            this.label13.Text = "Вес груза, кг";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(281, 17);
            this.label16.TabIndex = 45;
            this.label16.Text = "Требуемая нагрузка на переднюю ось, %";
            // 
            // RequiredLoad
            // 
            this.RequiredLoad.Location = new System.Drawing.Point(308, 25);
            this.RequiredLoad.Name = "RequiredLoad";
            this.RequiredLoad.Size = new System.Drawing.Size(116, 23);
            this.RequiredLoad.TabIndex = 44;
            this.RequiredLoad.Text = "35";
            // 
            // Gender
            // 
            this.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.Gender.Location = new System.Drawing.Point(777, 48);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(122, 21);
            this.Gender.TabIndex = 79;
            this.Gender.SelectedIndexChanged += new System.EventHandler(this.Gender_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(734, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 17);
            this.label14.TabIndex = 78;
            this.label14.Text = "Пол";
            // 
            // FaktForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Team);
            this.Controls.Add(this.TypeText);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.TeamBox);
            this.Controls.Add(this.NameMeas);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.textBoxBL);
            this.Controls.Add(this.textBoxBR);
            this.Controls.Add(this.textBoxFL);
            this.Controls.Add(this.textBoxFR);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.ComPortComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FaktForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaktForm";
            this.Load += new System.EventHandler(this.FaktForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DistanceExis;
        private System.Windows.Forms.Label Team;
        private System.Windows.Forms.Label TypeText;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.TextBox TeamBox;
        private System.Windows.Forms.TextBox NameMeas;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.TextBox textBoxB_percent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxF_percent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBL;
        private System.Windows.Forms.TextBox textBoxBR;
        private System.Windows.Forms.TextBox textBoxFL;
        private System.Windows.Forms.TextBox textBoxFR;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.ComboBox ComPortComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox RequiredLoad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Position;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label label14;
    }
}