namespace OldWeather
{
    partial class MenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.buttonCurrentWeather = new System.Windows.Forms.Button();
            this.buttonWeekWeather = new System.Windows.Forms.Button();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelOldWeather = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonCurrentWeather
            // 
            this.buttonCurrentWeather.Location = new System.Drawing.Point(287, 114);
            this.buttonCurrentWeather.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCurrentWeather.Name = "buttonCurrentWeather";
            this.buttonCurrentWeather.Size = new System.Drawing.Size(130, 28);
            this.buttonCurrentWeather.TabIndex = 1;
            this.buttonCurrentWeather.Text = "Current Weather";
            this.buttonCurrentWeather.UseVisualStyleBackColor = true;
            this.buttonCurrentWeather.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonWeekWeather
            // 
            this.buttonWeekWeather.Location = new System.Drawing.Point(149, 114);
            this.buttonWeekWeather.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWeekWeather.Name = "buttonWeekWeather";
            this.buttonWeekWeather.Size = new System.Drawing.Size(130, 28);
            this.buttonWeekWeather.TabIndex = 2;
            this.buttonWeekWeather.Text = "Week Weather";
            this.buttonWeekWeather.UseVisualStyleBackColor = true;
            this.buttonWeekWeather.Click += new System.EventHandler(this.buttonWeekWeather_Click);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(237, 82);
            this.comboBoxCity.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(180, 24);
            this.comboBoxCity.TabIndex = 3;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(149, 82);
            this.comboBoxCountry.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(80, 24);
            this.comboBoxCountry.TabIndex = 4;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // labelOldWeather
            // 
            this.labelOldWeather.AutoSize = true;
            this.labelOldWeather.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOldWeather.Location = new System.Drawing.Point(222, 34);
            this.labelOldWeather.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOldWeather.Name = "labelOldWeather";
            this.labelOldWeather.Size = new System.Drawing.Size(137, 25);
            this.labelOldWeather.TabIndex = 5;
            this.labelOldWeather.Text = "OldWeather";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 130);
            this.panel1.TabIndex = 6;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 151);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelOldWeather);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.buttonWeekWeather);
            this.Controls.Add(this.buttonCurrentWeather);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OldWeather";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCurrentWeather;
        private System.Windows.Forms.Button buttonWeekWeather;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelOldWeather;
        private System.Windows.Forms.Panel panel1;
    }
}

