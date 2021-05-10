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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        private Map.Map Map;
        private void Form1_Load(object sender, EventArgs e)
        {
            string str = String.Empty;
            using (FileStream fs = new FileStream("map.json", FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    str = reader.ReadToEnd();
                }  
            }
            Map = JsonConvert.DeserializeObject<Map.Map>(str);

            List<string> CounryList = new List<string>();
            foreach (Map.country Country in Map.country)
            {
                CounryList.Add(Country.name);
            }
            comboBoxCountry.Items.AddRange(CounryList.ToArray());

            List<string> CountryCityList = new List<string>();
            foreach (Map.city City in Map.country[0].city)
            {
                CountryCityList.Add(City.name);
            }
            comboBoxCity.Items.Clear();
            comboBoxCity.Items.AddRange(CountryCityList.ToArray());
            comboBoxCountry.SelectedIndex = 0;
            comboBoxCity.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CurrentWeatherForm frm = new CurrentWeatherForm(comboBoxCity.Text,comboBoxCountry.Text);
            frm.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> CountryCityList = new List<string>();
            foreach (Map.city City in Map.country[comboBoxCountry.SelectedIndex].city)
            {
                CountryCityList.Add(City.name);
            }
            comboBoxCity.Items.Clear();
            comboBoxCity.Items.AddRange(CountryCityList.ToArray());
            comboBoxCity.SelectedIndex = 0;
        }

        private void buttonWeekWeather_Click(object sender, EventArgs e)
        {
            this.Hide();
            WeekWeatherForm frm = new WeekWeatherForm(comboBoxCity.Text, comboBoxCountry.Text);
            frm.ShowDialog();
            this.Show();
            this.Activate();
        }
    }
}
