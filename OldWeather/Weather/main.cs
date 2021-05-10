using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldWeather.Weather
{
    class main
    {
        public double temp;
        public double humidity;
        public double temp_min;
        public double temp_max;
        public double feels_like;
        public double temp_kf;
        private double _pressure;
        public double pressure
        {
            get
            {
                return _pressure;
            }
            set
            {
                _pressure = value / 1.3332239;
            }
        }
        private double _sea_level;
        public double sea_level
        {
            get
            {
                return _sea_level;
            }
            set
            {
                _sea_level = value / 1.3332239;
            }
        }
        private double _grnd_level;
        public double grnd_level
        {
            get
            {
                return _grnd_level;
            }
            set
            {
                _grnd_level = value / 1.3332239;
            }
        }
    }
}