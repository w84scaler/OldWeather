using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace OldWeather
{
    public partial class CurrentWeatherForm : Form
    {
        public CurrentWeatherForm(string City, string Country)
        {
            InitializeComponent();
            this.City = City;
            this.Country = Country;
        }
        private string City;
        private string Country;

        private async void CurrentWeatherForm_Load(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("https://api.openweathermap.org/data/2.5/weather?q="+this.City+","+this.Country+"&units=metric&appid=f2abde7c6bba89f37c708b5071470ed4");

            request.Method = "POST";
            request.ContentType = "application/x-www-urlencoded";

            try
            {
                WebResponse response = await request.GetResponseAsync();

                string answer = String.Empty;
                using (Stream s = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(s))
                    {
                        answer = await reader.ReadToEndAsync();
                    }
                }

                response.Close();

                Weather.CurrentWeather cW = JsonConvert.DeserializeObject<Weather.CurrentWeather>(answer);

                DateTime pDate = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(cW.dt + cW.timezone);
                groupBoxCurrentWeather.Text = cW.sys.country + " " + cW.name + " " + pDate.ToString();

                panelIcon.BackgroundImage = cW.weather[0].Icon;
                labelWeatherName.Text = cW.weather[0].main;
                labelWeatherDescription.Text = cW.weather[0].description;
                labelTemperature.Text += cW.main.temp.ToString("0.##") + " °С";
                labelFeelsLike.Text += cW.main.feels_like.ToString("0.##") + " °С";
                labelHumidity.Text += cW.main.humidity.ToString() + " %";
                labelPressure.Text += ((int)cW.main.pressure).ToString() + " mm Hg";
                labelCloudiness.Text += cW.clouds.all.ToString() + " %";
                labelWindSpeed.Text += cW.wind.speed.ToString() + " m/sec";
                labelWindDeg.Text += cW.wind.deg.ToString() + "°";
                if (cW.rain != null) { labelPrecipitation.Text += cW.rain.h1.ToString() + " mm"; }
                else if (cW.snow != null) { labelPrecipitation.Text += cW.rain.h1.ToString() + " mm"; }
                else labelPrecipitation.Text = "";

                DateTime pDateSunrise = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(cW.sys.sunrise + cW.timezone);
                labelSunrise.Text += pDateSunrise.ToString().Substring(11);
                DateTime pDateSunset = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(cW.sys.sunset + cW.timezone);
                labelSunset.Text += pDateSunset.ToString().Substring(11);
            }
            catch
            {
                MessageBox.Show(
                    "City not found",
                    "404",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                this.Close();
            }
        }
    }
}
