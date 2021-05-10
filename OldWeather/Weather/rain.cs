using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OldWeather.Weather
{
    class rain
    {
        [JsonProperty("1h")]
        public double h1;
        [JsonProperty("3h")]
        public double h3;
    }
}
