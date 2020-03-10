namespace ComPort.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSportsman = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.butFakt = new System.Windows.Forms.Button();
            this.butResFukt = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(55, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Режим измерения для аналитики";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(55, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "База пустых саней";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // buttonSportsman
            // 
            this.buttonSportsman.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSportsman.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSportsman.BackgroundImage")));
            this.buttonSportsman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSportsman.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.buttonSportsman.Location = new System.Drawing.Point(55, 218);
            this.buttonSportsman.Name = "buttonSportsman";
            this.buttonSportsman.Size = new System.Drawing.Size(191, 55);
            this.buttonSportsman.TabIndex = 2;
            this.buttonSportsman.Text = "База спортсменов";
            this.buttonSportsman.UseVisualStyleBackColor = true;
            this.buttonSportsman.Click += new System.EventHandler(this.ButtonSportsman_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(55, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "Аналитический расчет";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(55, 384);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(191, 55);
            this.button6.TabIndex = 5;
            this.button6.Text = "Результаты аналитики";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // butFakt
            // 
            this.butFakt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butFakt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butFakt.BackgroundImage")));
            this.butFakt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butFakt.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.butFakt.Location = new System.Drawing.Point(292, 51);
            this.butFakt.Name = "butFakt";
            this.butFakt.Size = new System.Drawing.Size(191, 55);
            this.butFakt.TabIndex = 6;
            this.butFakt.Text = "Фактический режим измерения";
            this.butFakt.UseVisualStyleBackColor = true;
            this.butFakt.Click += new System.EventHandler(this.ButFakt_Click);
            // 
            // butResFukt
            // 
            this.butResFukt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butResFukt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butResFukt.BackgroundImage")));
            this.butResFukt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butResFukt.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.butResFukt.Location = new System.Drawing.Point(292, 135);
            this.butResFukt.Name = "butResFukt";
            this.butResFukt.Size = new System.Drawing.Size(191, 55);
            this.butResFukt.TabIndex = 7;
            this.butResFukt.Text = "Результаты измерения";
            this.butResFukt.UseVisualStyleBackColor = true;
            this.butResFukt.Click += new System.EventHandler(this.ButResFukt_Click);
            // 
            // Settings
            // 
            this.Settings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Settings.BackgroundImage")));
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.Settings.Location = new System.Drawing.Point(519, 51);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(191, 55);
            this.Settings.TabIndex = 8;
            this.Settings.Text = "Настройка";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.butResFukt);
            this.Controls.Add(this.butFakt);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonSportsman);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSportsman;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button butFakt;
        private System.Windows.Forms.Button butResFukt;
        private System.Windows.Forms.Button Settings;
    }
}