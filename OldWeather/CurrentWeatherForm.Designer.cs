namespace OldWeather
{
    partial class CurrentWeatherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentWeatherForm));
            this.panelIcon = new System.Windows.Forms.Panel();
            this.groupBoxCurrentWeather = new System.Windows.Forms.GroupBox();
            this.labelPrecipitation = new System.Windows.Forms.Label();
            this.groupBoxSun = new System.Windows.Forms.GroupBox();
            this.labelSunset = new System.Windows.Forms.Label();
            this.labelSunrise = new System.Windows.Forms.Label();
            this.labelCloudiness = new System.Windows.Forms.Label();
            this.labelFeelsLike = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelWeatherDescription = new System.Windows.Forms.Label();
            this.labelWeatherName = new System.Windows.Forms.Label();
            this.groupBoxWind = new System.Windows.Forms.GroupBox();
            this.labelWindDeg = new System.Windows.Forms.Label();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.groupBoxCurrentWeather.SuspendLayout();
            this.groupBoxSun.SuspendLayout();
            this.groupBoxWind.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIcon
            // 
            this.panelIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelIcon.Location = new System.Drawing.Point(8, 40);
            this.panelIcon.Margin = new System.Windows.Forms.Padding(4);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(130, 130);
            this.panelIcon.TabIndex = 1;
            // 
            // groupBoxCurrentWeather
            // 
            this.groupBoxCurrentWeather.Controls.Add(this.labelPrecipitation);
            this.groupBoxCurrentWeather.Controls.Add(this.groupBoxSun);
            this.groupBoxCurrentWeather.Controls.Add(this.labelCloudiness);
            this.groupBoxCurrentWeather.Controls.Add(this.labelFeelsLike);
            this.groupBoxCurrentWeather.Controls.Add(this.labelPressure);
            this.groupBoxCurrentWeather.Controls.Add(this.labelHumidity);
            this.groupBoxCurrentWeather.Controls.Add(this.labelTemperature);
            this.groupBoxCurrentWeather.Controls.Add(this.labelWeatherDescription);
            this.groupBoxCurrentWeather.Controls.Add(this.labelWeatherName);
            this.groupBoxCurrentWeather.Controls.Add(this.groupBoxWind);
            this.groupBoxCurrentWeather.Controls.Add(this.panelIcon);
            this.groupBoxCurrentWeather.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCurrentWeather.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCurrentWeather.Name = "groupBoxCurrentWeather";
            this.groupBoxCurrentWeather.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCurrentWeather.Size = new System.Drawing.Size(560, 200);
            this.groupBoxCurrentWeather.TabIndex = 2;
            this.groupBoxCurrentWeather.TabStop = false;
            this.groupBoxCurrentWeather.Text = "CurrentWeather";
            // 
            // labelPrecipitation
            // 
            this.labelPrecipitation.AutoSize = true;
            this.labelPrecipitation.Location = new System.Drawing.Point(146, 120);
            this.labelPrecipitation.Name = "labelPrecipitation";
            this.labelPrecipitation.Size = new System.Drawing.Size(101, 16);
            this.labelPrecipitation.TabIndex = 11;
            this.labelPrecipitation.Text = "Precipitation: ";
            // 
            // groupBoxSun
            // 
            this.groupBoxSun.Controls.Add(this.labelSunset);
            this.groupBoxSun.Controls.Add(this.labelSunrise);
            this.groupBoxSun.Location = new System.Drawing.Point(372, 108);
            this.groupBoxSun.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSun.Name = "groupBoxSun";
            this.groupBoxSun.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSun.Size = new System.Drawing.Size(180, 60);
            this.groupBoxSun.TabIndex = 10;
            this.groupBoxSun.TabStop = false;
            this.groupBoxSun.Text = "Sun";
            // 
            // labelSunset
            // 
            this.labelSunset.AutoSize = true;
            this.labelSunset.Location = new System.Drawing.Point(8, 36);
            this.labelSunset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSunset.Name = "labelSunset";
            this.labelSunset.Size = new System.Drawing.Size(65, 16);
            this.labelSunset.TabIndex = 9;
            this.labelSunset.Text = "Sunset: ";
            // 
            // labelSunrise
            // 
            this.labelSunrise.AutoSize = true;
            this.labelSunrise.Location = new System.Drawing.Point(8, 20);
            this.labelSunrise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSunrise.Name = "labelSunrise";
            this.labelSunrise.Size = new System.Drawing.Size(67, 16);
            this.labelSunrise.TabIndex = 8;
            this.labelSunrise.Text = "Sunrise: ";
            // 
            // labelCloudiness
            // 
            this.labelCloudiness.AutoSize = true;
            this.labelCloudiness.Location = new System.Drawing.Point(146, 104);
            this.labelCloudiness.Name = "labelCloudiness";
            this.labelCloudiness.Size = new System.Drawing.Size(88, 16);
            this.labelCloudiness.TabIndex = 9;
            this.labelCloudiness.Text = "Cloudiness: ";
            // 
            // labelFeelsLike
            // 
            this.labelFeelsLike.AutoSize = true;
            this.labelFeelsLike.Location = new System.Drawing.Point(146, 56);
            this.labelFeelsLike.Name = "labelFeelsLike";
            this.labelFeelsLike.Size = new System.Drawing.Size(83, 16);
            this.labelFeelsLike.TabIndex = 8;
            this.labelFeelsLike.Text = "Feels Like: ";
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Location = new System.Drawing.Point(146, 88);
            this.labelPressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(75, 16);
            this.labelPressure.TabIndex = 7;
            this.labelPressure.Text = "Pressure: ";
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Location = new System.Drawing.Point(146, 72);
            this.labelHumidity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(75, 16);
            this.labelHumidity.TabIndex = 6;
            this.labelHumidity.Text = "Humidity: ";
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(146, 40);
            this.labelTemperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(102, 16);
            this.labelTemperature.TabIndex = 5;
            this.labelTemperature.Text = "Temperature: ";
            // 
            // labelWeatherDescription
            // 
            this.labelWeatherDescription.AutoSize = true;
            this.labelWeatherDescription.Location = new System.Drawing.Point(8, 174);
            this.labelWeatherDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWeatherDescription.Name = "labelWeatherDescription";
            this.labelWeatherDescription.Size = new System.Drawing.Size(136, 16);
            this.labelWeatherDescription.TabIndex = 4;
            this.labelWeatherDescription.Text = "WeatherDescription";
            // 
            // labelWeatherName
            // 
            this.labelWeatherName.AutoSize = true;
            this.labelWeatherName.Location = new System.Drawing.Point(8, 20);
            this.labelWeatherName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWeatherName.Name = "labelWeatherName";
            this.labelWeatherName.Size = new System.Drawing.Size(99, 16);
            this.labelWeatherName.TabIndex = 3;
            this.labelWeatherName.Text = "WeatherName";
            // 
            // groupBoxWind
            // 
            this.groupBoxWind.Controls.Add(this.labelWindDeg);
            this.groupBoxWind.Controls.Add(this.labelWindSpeed);
            this.groupBoxWind.Location = new System.Drawing.Point(372, 40);
            this.groupBoxWind.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxWind.Name = "groupBoxWind";
            this.groupBoxWind.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxWind.Size = new System.Drawing.Size(180, 60);
            this.groupBoxWind.TabIndex = 2;
            this.groupBoxWind.TabStop = false;
            this.groupBoxWind.Text = "Wind";
            // 
            // labelWindDeg
            // 
            this.labelWindDeg.AutoSize = true;
            this.labelWindDeg.Location = new System.Drawing.Point(8, 36);
            this.labelWindDeg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWindDeg.Name = "labelWindDeg";
            this.labelWindDeg.Size = new System.Drawing.Size(77, 16);
            this.labelWindDeg.TabIndex = 9;
            this.labelWindDeg.Text = "Direction: ";
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.Location = new System.Drawing.Point(8, 20);
            this.labelWindSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(60, 16);
            this.labelWindSpeed.TabIndex = 8;
            this.labelWindSpeed.Text = "Speed: ";
            // 
            // CurrentWeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 226);
            this.Controls.Add(this.groupBoxCurrentWeather);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CurrentWeatherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Current Weather";
            this.Load += new System.EventHandler(this.CurrentWeatherForm_Load);
            this.groupBoxCurrentWeather.ResumeLayout(false);
            this.groupBoxCurrentWeather.PerformLayout();
            this.groupBoxSun.ResumeLayout(false);
            this.groupBoxSun.PerformLayout();
            this.groupBoxWind.ResumeLayout(false);
            this.groupBoxWind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelIcon;
        private System.Windows.Forms.GroupBox groupBoxCurrentWeather;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelWeatherDescription;
        private System.Windows.Forms.Label labelWeatherName;
        private System.Windows.Forms.GroupBox groupBoxWind;
        private System.Windows.Forms.Label labelWindDeg;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.Label labelFeelsLike;
        private System.Windows.Forms.Label labelCloudiness;
        private System.Windows.Forms.Label labelPrecipitation;
        private System.Windows.Forms.GroupBox groupBoxSun;
        private System.Windows.Forms.Label labelSunset;
        private System.Windows.Forms.Label labelSunrise;
    }
}