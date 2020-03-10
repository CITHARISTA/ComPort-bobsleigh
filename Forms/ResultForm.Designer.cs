namespace ComPort.Forms
{
    partial class ResultForm
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
            this.Names = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RequiredLoad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Razgon3 = new System.Windows.Forms.TextBox();
            this.Razgon1 = new System.Windows.Forms.TextBox();
            this.Razgon2 = new System.Windows.Forms.TextBox();
            this.Pilot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Ра = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(627, 406);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(150, 32);
            this.Back.TabIndex = 0;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(816, 406);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(150, 32);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Names
            // 
            this.Names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Names.FormattingEnabled = true;
            this.Names.Location = new System.Drawing.Point(183, 38);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(357, 21);
            this.Names.TabIndex = 2;
            this.Names.SelectedIndexChanged += new System.EventHandler(this.Names_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название расчета";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RequiredLoad);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.RP);
            this.groupBox1.Controls.Add(this.PosLoad);
            this.groupBox1.Controls.Add(this.FP);
            this.groupBox1.Controls.Add(this.WeightLoad);
            this.groupBox1.Controls.Add(this.Weight);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(573, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 298);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результат расчета";
            // 
            // RequiredLoad
            // 
            this.RequiredLoad.Location = new System.Drawing.Point(246, 179);
            this.RequiredLoad.Name = "RequiredLoad";
            this.RequiredLoad.ReadOnly = true;
            this.RequiredLoad.Size = new System.Drawing.Size(147, 26);
            this.RequiredLoad.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "на переднюю ось, %";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(76, 175);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(164, 20);
            this.label16.TabIndex = 45;
            this.label16.Text = "Требуемая нагрузка ";
            // 
            // RP
            // 
            this.RP.Location = new System.Drawing.Point(246, 260);
            this.RP.Name = "RP";
            this.RP.ReadOnly = true;
            this.RP.Size = new System.Drawing.Size(147, 26);
            this.RP.TabIndex = 9;
            // 
            // PosLoad
            // 
            this.PosLoad.Location = new System.Drawing.Point(246, 132);
            this.PosLoad.Name = "PosLoad";
            this.PosLoad.ReadOnly = true;
            this.PosLoad.Size = new System.Drawing.Size(147, 26);
            this.PosLoad.TabIndex = 8;
            // 
            // FP
            // 
            this.FP.Location = new System.Drawing.Point(246, 222);
            this.FP.Name = "FP";
            this.FP.ReadOnly = true;
            this.FP.Size = new System.Drawing.Size(147, 26);
            this.FP.TabIndex = 7;
            // 
            // WeightLoad
            // 
            this.WeightLoad.Location = new System.Drawing.Point(246, 94);
            this.WeightLoad.Name = "WeightLoad";
            this.WeightLoad.ReadOnly = true;
            this.WeightLoad.Size = new System.Drawing.Size(147, 26);
            this.WeightLoad.TabIndex = 6;
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(246, 45);
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Size = new System.Drawing.Size(147, 26);
            this.Weight.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "На задней оси без груза, %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "На передней оси без груза, %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Положение груза, мм";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Масса груза, кг";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Общая масса, кг";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Razgon3);
            this.groupBox2.Controls.Add(this.Razgon1);
            this.groupBox2.Controls.Add(this.Razgon2);
            this.groupBox2.Controls.Add(this.Pilot);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Ра);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(37, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 298);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Спортсмены";
            // 
            // Razgon3
            // 
            this.Razgon3.Location = new System.Drawing.Point(146, 228);
            this.Razgon3.Name = "Razgon3";
            this.Razgon3.ReadOnly = true;
            this.Razgon3.Size = new System.Drawing.Size(325, 26);
            this.Razgon3.TabIndex = 17;
            // 
            // Razgon1
            // 
            this.Razgon1.Location = new System.Drawing.Point(146, 111);
            this.Razgon1.Name = "Razgon1";
            this.Razgon1.ReadOnly = true;
            this.Razgon1.Size = new System.Drawing.Size(325, 26);
            this.Razgon1.TabIndex = 16;
            // 
            // Razgon2
            // 
            this.Razgon2.Location = new System.Drawing.Point(146, 169);
            this.Razgon2.Name = "Razgon2";
            this.Razgon2.ReadOnly = true;
            this.Razgon2.Size = new System.Drawing.Size(325, 26);
            this.Razgon2.TabIndex = 15;
            // 
            // Pilot
            // 
            this.Pilot.Location = new System.Drawing.Point(146, 51);
            this.Pilot.Name = "Pilot";
            this.Pilot.ReadOnly = true;
            this.Pilot.Size = new System.Drawing.Size(325, 26);
            this.Pilot.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Разгоняющий  3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Разгоняющий  2";
            // 
            // Ра
            // 
            this.Ра.AutoSize = true;
            this.Ра.Location = new System.Drawing.Point(10, 114);
            this.Ра.Name = "Ра";
            this.Ра.Size = new System.Drawing.Size(130, 20);
            this.Ра.TabIndex = 11;
            this.Ра.Text = "Разгоняющий  1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Пилот";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dateTime);
            this.groupBox5.Location = new System.Drawing.Point(573, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(251, 61);
            this.groupBox5.TabIndex = 46;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Дата измерения";
            // 
            // dateTime
            // 
            this.dateTime.Enabled = false;
            this.dateTime.Location = new System.Drawing.Point(23, 30);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(208, 20);
            this.dateTime.TabIndex = 43;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Back);
            this.MaximumSize = new System.Drawing.Size(1000, 489);
            this.MinimumSize = new System.Drawing.Size(1000, 489);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ComboBox Names;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RP;
        private System.Windows.Forms.TextBox PosLoad;
        private System.Windows.Forms.TextBox FP;
        private System.Windows.Forms.TextBox WeightLoad;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Razgon3;
        private System.Windows.Forms.TextBox Razgon1;
        private System.Windows.Forms.TextBox Razgon2;
        private System.Windows.Forms.TextBox Pilot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Ра;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RequiredLoad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dateTime;
    }
}