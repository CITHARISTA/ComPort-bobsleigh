namespace ComPort.Forms
{
    partial class SettingsForm
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
            this.Save = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PilotLegs = new System.Windows.Forms.TextBox();
            this.Accelerating1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.PilotBox = new System.Windows.Forms.TextBox();
            this.Accelerating2 = new System.Windows.Forms.Label();
            this.AcceleratingBox1 = new System.Windows.Forms.TextBox();
            this.AcceleratingBox3 = new System.Windows.Forms.TextBox();
            this.AcceleratingBox2 = new System.Windows.Forms.TextBox();
            this.Accelerating3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(674, 487);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(123, 43);
            this.Back.TabIndex = 0;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(824, 487);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(123, 43);
            this.Save.TabIndex = 1;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(78, 108);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(407, 422);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Расстояние сидений от задней оси (мм)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Location = new System.Drawing.Point(36, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 143);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Тип саней - Двойки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Ноги пилота";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(172, 31);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 26);
            this.textBox4.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Разгоняющий 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Пилот";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(172, 66);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 26);
            this.textBox5.TabIndex = 41;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(172, 101);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 26);
            this.textBox6.TabIndex = 40;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.PilotLegs);
            this.groupBox2.Controls.Add(this.Accelerating1);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.PilotBox);
            this.groupBox2.Controls.Add(this.Accelerating2);
            this.groupBox2.Controls.Add(this.AcceleratingBox1);
            this.groupBox2.Controls.Add(this.AcceleratingBox3);
            this.groupBox2.Controls.Add(this.AcceleratingBox2);
            this.groupBox2.Controls.Add(this.Accelerating3);
            this.groupBox2.Location = new System.Drawing.Point(36, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 215);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип саней - Четверки";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(61, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 20);
            this.label14.TabIndex = 38;
            this.label14.Text = "Ноги пилота";
            // 
            // PilotLegs
            // 
            this.PilotLegs.Location = new System.Drawing.Point(172, 36);
            this.PilotLegs.Name = "PilotLegs";
            this.PilotLegs.Size = new System.Drawing.Size(121, 26);
            this.PilotLegs.TabIndex = 39;
            // 
            // Accelerating1
            // 
            this.Accelerating1.AutoSize = true;
            this.Accelerating1.Location = new System.Drawing.Point(40, 109);
            this.Accelerating1.Name = "Accelerating1";
            this.Accelerating1.Size = new System.Drawing.Size(126, 20);
            this.Accelerating1.TabIndex = 35;
            this.Accelerating1.Text = "Разгоняющий 1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(108, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "Пилот";
            // 
            // PilotBox
            // 
            this.PilotBox.Location = new System.Drawing.Point(172, 71);
            this.PilotBox.Name = "PilotBox";
            this.PilotBox.Size = new System.Drawing.Size(121, 26);
            this.PilotBox.TabIndex = 30;
            // 
            // Accelerating2
            // 
            this.Accelerating2.AutoSize = true;
            this.Accelerating2.Location = new System.Drawing.Point(40, 144);
            this.Accelerating2.Name = "Accelerating2";
            this.Accelerating2.Size = new System.Drawing.Size(126, 20);
            this.Accelerating2.TabIndex = 36;
            this.Accelerating2.Text = "Разгоняющий 2";
            // 
            // AcceleratingBox1
            // 
            this.AcceleratingBox1.Location = new System.Drawing.Point(172, 106);
            this.AcceleratingBox1.Name = "AcceleratingBox1";
            this.AcceleratingBox1.Size = new System.Drawing.Size(121, 26);
            this.AcceleratingBox1.TabIndex = 27;
            // 
            // AcceleratingBox3
            // 
            this.AcceleratingBox3.Location = new System.Drawing.Point(172, 176);
            this.AcceleratingBox3.Name = "AcceleratingBox3";
            this.AcceleratingBox3.Size = new System.Drawing.Size(121, 26);
            this.AcceleratingBox3.TabIndex = 29;
            // 
            // AcceleratingBox2
            // 
            this.AcceleratingBox2.Location = new System.Drawing.Point(172, 141);
            this.AcceleratingBox2.Name = "AcceleratingBox2";
            this.AcceleratingBox2.Size = new System.Drawing.Size(121, 26);
            this.AcceleratingBox2.TabIndex = 28;
            this.AcceleratingBox2.WordWrap = false;
            // 
            // Accelerating3
            // 
            this.Accelerating3.AutoSize = true;
            this.Accelerating3.Location = new System.Drawing.Point(40, 176);
            this.Accelerating3.Name = "Accelerating3";
            this.Accelerating3.Size = new System.Drawing.Size(126, 20);
            this.Accelerating3.TabIndex = 37;
            this.Accelerating3.Text = "Разгоняющий 3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(525, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 185);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Суммарный максимальный вес (кг)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 26);
            this.textBox1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Мужчины (четверка)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(211, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 26);
            this.textBox2.TabIndex = 30;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(211, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 26);
            this.textBox3.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Мужчины (двойка)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Женщины (двойка)";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Back);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox PilotLegs;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox PilotBox;
        private System.Windows.Forms.TextBox AcceleratingBox1;
        private System.Windows.Forms.TextBox AcceleratingBox2;
        private System.Windows.Forms.Label Accelerating3;
        private System.Windows.Forms.TextBox AcceleratingBox3;
        private System.Windows.Forms.Label Accelerating2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label Accelerating1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}