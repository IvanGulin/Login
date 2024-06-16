using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Aplicacion : Form
    {
        private const string apiKey = "5f623a1026f1290349fc243dc83a69c5";
        private const string apiUrl = "http://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&appid={1}";
        public Aplicacion()
        {
            InitializeComponent();
            LabelTemperatura.Text = "";
        }

        private async Task<WeatherData> GetWeatherData(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    WeatherData tiempo = JsonConvert.DeserializeObject<WeatherData>(responseBody);
                    return tiempo;
                }
                catch (HttpRequestException e)
                {
                    return null;
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string ciudadNombre = entradaCiudad.Text;

            if (string.IsNullOrEmpty(ciudadNombre))
            {
                MessageBox.Show("Por favor, introduce el nombre de una ciudad.");
                return;
            }

            string url = string.Format(apiUrl, ciudadNombre, apiKey);
            WeatherData weatherData = await GetWeatherData(url);
            if (weatherData != null)
            {
                LabelTemperatura.Text = $"La temperatura en {weatherData.name} es {weatherData.main.temp}°C";
            }
            else
            {
                MessageBox.Show("No se pudo obtener la información del clima.");
            }
        }
    }
}
