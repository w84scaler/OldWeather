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
    public partial class WeekWeatherForm : Form
    {
        private Weather.WeekWeather wW;
        private int page = 0;

        private string City;
        private string Country;
        public WeekWeatherForm(string City, string Country)
        {
            InitializeComponent();
            this.City = City;
            this.Country = Country;
        }
        private async void WeekWeatherForm_Load(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://api.openweathermap.org/data/2.5/forecast?q=" + this.City + "," + this.Country + "&units=metric&appid=f2abde7c6bba89f37c708b5071470ed4");

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

                wW = JsonConvert.DeserializeObject<Weather.WeekWeather>(answer);

                groupBoxWeekWeather.Text = wW.city.country + " " + wW.city.name;

                ControlCreators ControlCreator = new ControlCreators();
                ControlCreator.SetPageContent(groupBoxWeekWeather, wW, ref page, 0);
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (page != 9)
            {
                ControlCreators ControlCreator = new ControlCreators();
                ControlCreator.SetPageLabel(this, page, 1);
                ControlCreator.SetPageContent(groupBoxWeekWeather, wW, ref page, 1);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (page != 0)
            {
                ControlCreators ControlCreator = new ControlCreators();
                ControlCreator.SetPageLabel(this, page, -1);
                ControlCreator.SetPageContent(groupBoxWeekWeather, wW, ref page, -1);
            }
        }
    }
}
