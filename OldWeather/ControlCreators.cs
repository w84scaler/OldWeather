using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OldWeather
{
    class ControlCreators
    {
        public void SetPageContent(GroupBox groupBoxWeekWeather, Weather.WeekWeather wW, ref int page, int k)
        {
            page+=k;

            groupBoxWeekWeather.Controls.Clear();

            for (int i = 0; i < 4; i++)
            {
                CreateGroupBox3hWeather(groupBoxWeekWeather, wW.list[page * 4 + i], wW.city.timezone, 13 + 213 * (i % 4), 23);
            }
        }
        public void SetPageLabel(Form frm, int page, int i)
        {
            foreach (Control label in frm.Controls)
            {
                if (label.Name == $"label{page}")
                {
                    label.Font = new Font(frm.Font, FontStyle.Regular);
                }
                if (label.Name == $"label{page + i}")
                {
                    label.Font = new Font(frm.Font, FontStyle.Bold);
                }
            }
        }
        public GroupBox CreateGroupBox(GroupBox groupBox0, int x, int y, string text, int w, int h)
        {
            var groupBox = new GroupBox
            {
                Size = new Size(w, h),
                Location = new Point(x, y),
                Text = text
            };
            groupBox0.Controls.Add(groupBox);
            groupBox.BringToFront();
            return groupBox;
        }
        public void CreateLabel(GroupBox groupBox, int x, int y, string text)
        {
            var label = new Label
            {
                Location = new Point(x, y),
                AutoSize = true,
                Text = text
            };
            groupBox.Controls.Add(label);
            label.BringToFront();
        }
        public void CreatePanel(GroupBox groupBox, int x, int y, Bitmap bitmap)
        {
            var panelIcon = new Panel
            {
                Location = new Point(x, y),
                Size = new Size(130, 130),
                BackgroundImage = bitmap,
                BackgroundImageLayout = ImageLayout.Zoom
            };
            groupBox.Controls.Add(panelIcon);
            panelIcon.BringToFront();
        }
        public void CreateGroupBox3hWeather(GroupBox groupBoxWeekWeather, Weather.list list, int timezone, int x, int y)
        {
            DateTime pDate = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(list.dt + timezone);
            GroupBox groupBox = CreateGroupBox(groupBoxWeekWeather, x, y, pDate.ToString(), 200, 360);
            CreateLabel(groupBox, 8, 21, list.weather[0].main);
            CreatePanel(groupBox, 8, 41, list.weather[0].Icon);
            CreateLabel(groupBox, 8, 175, list.weather[0].description);
            CreateLabel(groupBox, 8, 191, "Temperature: " + list.main.temp.ToString("0.##") + " °С");
            CreateLabel(groupBox, 8, 207, "Feels Like: " + list.main.feels_like.ToString("0.##") + " °С");
            CreateLabel(groupBox, 8, 223, "Humidity: " + list.main.humidity.ToString() + " %");
            CreateLabel(groupBox, 8, 239, "Pressure: " + ((int)list.main.pressure).ToString() + " mm Hg");
            CreateLabel(groupBox, 8, 255, "Cloudiness: " + list.clouds.all.ToString() + " %");
            if (list.rain != null)
                CreateLabel(groupBox, 8, 271, "Precipitation: " + list.rain.h3.ToString() + " mm");
            else if (list.snow != null)
                CreateLabel(groupBox, 8, 271, "Precipitation: " + list.snow.h3.ToString() + " mm");
            GroupBox groupBoxWind = CreateGroupBox(groupBox, 10, 291, "Wind", 180, 60);
            CreateLabel(groupBoxWind, 8, 20, "Speed: " + list.wind.speed.ToString() + " m/sec");
            CreateLabel(groupBoxWind, 8, 36, "Direction: " + list.wind.deg.ToString() + "°");
        }
    }
}
