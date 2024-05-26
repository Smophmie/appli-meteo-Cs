using Newtonsoft.Json;
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
        double lon = 3.381074;
        double lat = 45.7164954;


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
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&appid={2}&lang=fr&units=metric", lat, lon, APIKey);
                var json = web.DownloadString(url);
                WeatherInfos.root Infos = JsonConvert.DeserializeObject<WeatherInfos.root>(json);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Infos.weather[0].icon + ".png";
                lab2.Text = Infos.weather[0].main;
                lab4.Text = Infos.weather[0].description;
                lab6.Text = convertDateTime(Infos.sys.sunrise).ToString("HH:mm");
                lab8.Text = convertDateTime(Infos.sys.sunset).ToString("HH:mm");

                lab10.Text = Infos.wind.speed.ToString();


            }

            DateTime convertDateTime(long sec)
            {
                DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
                day = day.AddSeconds(sec);
                return day;
            }

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
