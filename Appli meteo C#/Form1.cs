using Newtonsoft.Json;
using System;
using System.Net;

namespace Appli_meteo_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string APIKey = "e4b03256d47dcbd2ed577892d6a30cd8";


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&lang=fr&units=metric", TBcity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfos.root Infos = JsonConvert.DeserializeObject<WeatherInfos.root>(json);
                
                weatherData.Text = Infos.weather[0].description;

                tempData.Text = Infos.main.temp + "°C";

                double windSpeedKmH = Infos.wind.speed * 3.6; // Conversion de m/s en km/h
                windSpeed.Text = windSpeedKmH.ToString("00") + " km/h";

                int timezoneOffset = Infos.timezone;

                // Conversion des heures de lever et de coucher du soleil
                sunriseData.Text = convertDateTime(Infos.sys.sunrise, timezoneOffset).ToString("HH:mm");
                sunsetData.Text = convertDateTime(Infos.sys.sunset, timezoneOffset).ToString("HH:mm");
            }

        }

        DateTime convertDateTime(long unixTime, int timezoneOffset)
        {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            DateTime dateTime = epoch.AddSeconds(unixTime).AddSeconds(timezoneOffset).ToLocalTime();
            return dateTime;
        }
    }
}
