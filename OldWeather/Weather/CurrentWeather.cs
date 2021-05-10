using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OldWeather.Weather
{
    class CurrentWeather
    {
        public int id;
        public int dt;
        public string name;
        public coord coord;
        public sys sys;
        public main main;
        public wind wind;
        public clouds clouds;
        public weather[] weather;
        public rain rain;
        public snow snow;
        [JsonProperty("base")]
        public string Base;
        public int timezone;
        public int cod;
    }
}