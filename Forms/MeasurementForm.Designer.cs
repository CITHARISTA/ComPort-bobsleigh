namespace ComPort
{
    partial class MeasurementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeasurementForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComPortComboBox = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.textBoxFR = new System.Windows.Forms.TextBox();
            this.textBoxFL = new System.Windows.Forms.TextBox();
            this.textBoxBR = new System.Windows.Forms.TextBox();
            this.textBoxBL = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxF_percent = new System.Windows.Forms.TextBox();
            this.textBoxB_percent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.NameText = new System.Windows.Forms.Label();
            this.NameBean = new System.Windows.Forms.TextBox();
            this.TeamBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.TypeText = new System.Windows.Forms.Label();
            this.Team = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DistanceExis = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Передний правый";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Передний левый";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Задний левый";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Задний правый";
            // 
            // ComPortComboBox
            // 
            this.ComPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPortComboBox.FormattingEnabled = true;
            this.ComPortComboBox.Location = new System.Drawing.Point(19, 15);
            this.ComPortComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComPortComboBox.Name = "ComPortComboBox";
            this.ComPortComboBox.Size = new System.Drawing.Size(159, 25);
            this.ComPortComboBox.TabIndex = 4;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(208, 15);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(122, 30);
            this.ConnectButton.TabIndex = 5;
            this.ConnectButton.Text = "Подключиться";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // textBoxFR
            // 
            this.textBoxFR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxFR.Location = new System.Drawing.Point(145, 113);
            this.textBoxFR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFR.Name = "textBoxFR";
            this.textBoxFR.Size = new System.Drawing.Size(132, 23);
            this.textBoxFR.TabIndex = 6;
            // 
            // textBoxFL
            // 
            this.textBoxFL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxFL.Location = new System.Drawing.Point(145, 247);
            this.textBoxFL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFL.Name = "textBoxFL";
            this.textBoxFL.Size = new System.Drawing.Size(132, 23);
            this.textBoxFL.TabIndex = 7;
            // 
            // textBoxBR
            // 
            this.textBoxBR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxBR.Location = new System.Drawing.Point(509, 113);
            this.textBoxBR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBR.Name = "textBoxBR";
            this.textBoxBR.Size = new System.Drawing.Size(132, 23);
            this.textBoxBR.TabIndex = 8;
            // 
            // textBoxBL
            // 
            this.textBoxBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxBL.Location = new System.Drawing.Point(509, 247);
            this.textBoxBL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBL.Name = "textBoxBL";
            this.textBoxBL.Size = new System.Drawing.Size(132, 23);
            this.textBoxBL.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(675, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Общая масса";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(226, 26);
            this.textBoxSum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(132, 23);
            this.textBoxSum.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Нагрузка на переднюю ось";
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(226, 66);
            this.textBoxF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(132, 23);
            this.textBoxF.TabIndex = 14;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(226, 109);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(132, 23);
            this.textBoxB.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Нагрузка на заднюю ось";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Нагрузка на переднюю ось, %";
            // 
            // textBoxF_percent
            // 
            this.textBoxF_percent.Location = new System.Drawing.Point(226, 153);
            this.textBoxF_percent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxF_percent.Name = "textBoxF_percent";
            this.textBoxF_percent.Size = new System.Drawing.Size(132, 23);
            this.textBoxF_percent.TabIndex = 18;
            // 
            // textBoxB_percent
            // 
            this.textBoxB_percent.Location = new System.Drawing.Point(226, 193);
            this.textBoxB_percent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxB_percent.Name = "textBoxB_percent";
            this.textBoxB_percent.Size = new System.Drawing.Size(132, 23);
            this.textBoxB_percent.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Нагрузка на заднюю ось, %";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(114, 431);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(846, 503);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(123, 45);
            this.SaveButton.TabIndex = 22;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackButton.Location = new System.Drawing.Point(698, 503);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(123, 45);
            this.BackButton.TabIndex = 23;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NameText
            // 
            this.NameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameText.AutoSize = true;
            this.NameText.Location = new System.Drawing.Point(668, 28);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(108, 17);
            this.NameText.TabIndex = 24;
            this.NameText.Text = "Название боба";
            // 
            // NameBean
            // 
            this.NameBean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBean.Location = new System.Drawing.Point(788, 24);
            this.NameBean.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameBean.Name = "NameBean";
            this.NameBean.Size = new System.Drawing.Size(159, 23);
            this.NameBean.TabIndex = 25;
            // 
            // TeamBox
            // 
            this.TeamBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TeamBox.Location = new System.Drawing.Point(788, 115);
            this.TeamBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TeamBox.Name = "TeamBox";
            this.TeamBox.Size = new System.Drawing.Size(159, 23);
            this.TeamBox.TabIndex = 26;
            // 
            // TypeBox
            // 
            this.TypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "2",
            "4"});
            this.TypeBox.Location = new System.Drawing.Point(788, 69);
            this.TypeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(159, 25);
            this.TypeBox.TabIndex = 31;
            this.TypeBox.Text = "2";
            // 
            // TypeText
            // 
            this.TypeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeText.AutoSize = true;
            this.TypeText.Location = new System.Drawing.Point(712, 73);
            this.TypeText.Name = "TypeText";
            this.TypeText.Size = new System.Drawing.Size(67, 17);
            this.TypeText.TabIndex = 32;
            this.TypeText.Text = "Тип (2/4)";
            // 
            // Team
            // 
            this.Team.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Team.AutoSize = true;
            this.Team.Location = new System.Drawing.Point(712, 119);
            this.Team.Name = "Team";
            this.Team.Size = new System.Drawing.Size(66, 17);
            this.Team.TabIndex = 33;
            this.Team.Text = "Команда";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(843, 321);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.DistanceExis);
            this.groupBox1.Location = new System.Drawing.Point(398, 311);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(334, 104);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Расстояние между осями (мм)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Расстояние";
            // 
            // DistanceExis
            // 
            this.DistanceExis.Location = new System.Drawing.Point(147, 49);
            this.DistanceExis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DistanceExis.Name = "DistanceExis";
            this.DistanceExis.Size = new System.Drawing.Size(159, 23);
            this.DistanceExis.TabIndex = 0;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(30, 40);
            this.dateTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(214, 23);
            this.dateTime.TabIndex = 43;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTime);
            this.groupBox3.Location = new System.Drawing.Point(703, 205);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(269, 79);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дата измерения";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxB_percent);
            this.groupBox2.Controls.Add(this.textBoxB);
            this.groupBox2.Controls.Add(this.textBoxSum);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxF);
            this.groupBox2.Controls.Add(this.textBoxF_percent);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(19, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 228);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // MeasurementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Team);
            this.Controls.Add(this.TypeText);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.TeamBox);
            this.Controls.Add(this.NameBean);
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
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MeasurementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Режим измерения";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComPortComboBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox textBoxFR;
        private System.Windows.Forms.TextBox textBoxFL;
        private System.Windows.Forms.TextBox textBoxBR;
        private System.Windows.Forms.TextBox textBoxBL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxF_percent;
        private System.Windows.Forms.TextBox textBoxB_percent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.TextBox NameBean;
        private System.Windows.Forms.TextBox TeamBox;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.Label TypeText;
        private System.Windows.Forms.Label Team;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DistanceExis;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

