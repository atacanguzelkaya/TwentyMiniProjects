using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace Project13_WeatherApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://open-weather13.p.rapidapi.com/city/Istanbul/TR"),
				Headers =
	{
		{ "x-rapidapi-key", "7d4d381d99mshe5918e75b67b15ap1f1272jsnf639ac9d84dc" },
		{ "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var json = JObject.Parse(body);

				var windSpeed = json["wind"]["speed"].ToString();
				lblWindSpeed.Text = (double.Parse(windSpeed) * 1.60934).ToString("F2") + " km/s"; // MPH to KMH

				var humidity = json["main"]["humidity"].ToString();
				lblHumidity.Text = humidity;

				var fahrenheit = json["main"]["temp"].ToString();
				lblFahrenheit.Text = fahrenheit;

				double celcius = (double.Parse(fahrenheit) - 32) / 1.8; // Fahrenheit to Celcius
				lblCelcius.Text = celcius.ToString("F2");

				#region Weather Icons

				var main = json["weather"][0]["main"].ToString();

				string imagePath = @"C:\Users\Atacan\source\repos\TwentyMiniProjects\Project13_WeatherApp\images\";
				string imageFile = "";

				switch (main)
				{
					case "Clouds":
						imageFile = "cloud.png";
						break;

					case "Clear":
						imageFile = "cloudandsun.png";
						break;

					case "Rain":
						imageFile = "rainy.png";
						break;

					case "Snow":
						imageFile = "snow.png";
						break;

					case "Sun":
						imageFile = "sun.png";
						break;

					default:
						imageFile = "cloudandsun.png";
						break;
				}

				string fullImagePath = Path.Combine(imagePath, imageFile);
				pictureBox1.Image = Image.FromFile(fullImagePath);

				#endregion
			}
		}
	}
}
