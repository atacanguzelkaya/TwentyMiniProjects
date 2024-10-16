#region Menü_Başlangıcı

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

while (true)
{
	Console.WriteLine("Welcome to Api Consume \n\n");
	Console.WriteLine("### Select the Action You Want to Take ### \n\n");
	Console.WriteLine("1-Get City List");
	Console.WriteLine("2-Get City and Weather List");
	Console.WriteLine("3-Adding a New City");
	Console.WriteLine("4-Deleting a City");
	Console.WriteLine("5-Update City");
	Console.WriteLine("6-City Fetching by ID");
	Console.WriteLine("0-Exit");
	Console.WriteLine();

	#endregion

	string number;


	Console.Write("Preference: ");
	number = Console.ReadLine();
	Console.WriteLine();

	if (number == "0")
	{
		break;
	}
	if (number == "1")
	{
		string url = "https://localhost:7265/api/Weathers";
		using (HttpClient client = new HttpClient())
		{
			HttpResponseMessage response = await client.GetAsync(url);
			string responseBody = await response.Content.ReadAsStringAsync();
			JArray jArray = JArray.Parse(responseBody);
			foreach (var item in jArray)
			{
				string cityName = item["cityName"].ToString();
				Console.WriteLine($"City: {cityName}");
			}
		}
	}
	if (number == "2")
	{
		string url = "https://localhost:7265/api/Weathers";
		using (HttpClient client = new HttpClient())
		{
			HttpResponseMessage response = await client.GetAsync(url);
			string responseBody = await response.Content.ReadAsStringAsync();
			JArray jArray = JArray.Parse(responseBody);
			foreach (var item in jArray)
			{
				string cityName = item["cityName"].ToString();
				string temp = item["temp"].ToString();
				string country = item["country"].ToString();
				Console.WriteLine(cityName + "-" + country + "-->" + temp + " °C");
				Console.WriteLine("------------------------------------------------------");
			}
		}
	}
	if (number == "3")
	{
		Console.WriteLine("### New Data Entry ###");
		Console.WriteLine();
		string cityName, country, detail;
		decimal temp;

		Console.Write("City Name: ");
		cityName = Console.ReadLine();

		Console.Write("Country Name: ");
		country = Console.ReadLine();

		Console.Write("Weather Details: ");
		detail = Console.ReadLine();

		Console.Write("Temperature: ");
		temp = decimal.Parse(Console.ReadLine());


		string url = "https://localhost:7265/api/Weathers";
		var newWeatherCity = new
		{
			CityName = cityName,
			Country = country,
			Detail = detail,
			Temp = temp
		};

		using (HttpClient client = new HttpClient())
		{
			string json = JsonConvert.SerializeObject(newWeatherCity);
			StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
			HttpResponseMessage response = await client.PostAsync(url, content);
			response.EnsureSuccessStatusCode();
		}
	}
	if (number == "4")
	{
		string url = "https://localhost:7265/api/Weathers?id=";

		Console.Write("The Id Value you want to delete: ");
		int id = int.Parse(Console.ReadLine());

		using (HttpClient client = new HttpClient())
		{
			HttpResponseMessage response = await client.DeleteAsync(url + id);
			response.EnsureSuccessStatusCode();
		}
	}
	if (number == "5")
	{
		string url = "https://localhost:7265/api/Weathers";

		Console.WriteLine("### Data Update Process ###");
		Console.WriteLine();
		string cityName, country, detail;
		decimal temp;
		int cityId;

		Console.Write("City Name: ");
		cityName = Console.ReadLine();

		Console.Write("Country Name: ");
		country = Console.ReadLine();

		Console.Write("Weather Details: ");
		detail = Console.ReadLine();

		Console.Write("Temperature: ");
		temp = decimal.Parse(Console.ReadLine());

		Console.Write("City Id: ");
		cityId = int.Parse(Console.ReadLine());

		var updatedWeatherValues = new
		{
			CityId = cityId,
			CityName = cityName,
			Country = country,
			Detail = detail,
			Temp = temp
		};

		using (HttpClient client = new HttpClient())
		{
			string json = JsonConvert.SerializeObject(updatedWeatherValues);
			StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
			HttpResponseMessage response = await client.PutAsync(url, content);
			response.EnsureSuccessStatusCode();
		}
	}
	if (number == "6")
	{
		string url = "https://localhost:7265/api/Weathers/GetByIdWeatherCity?id=";

		Console.Write("The Id Value You Want to Retrieve: ");
		int id = int.Parse(Console.ReadLine());
		Console.WriteLine();

		using (HttpClient client = new HttpClient())
		{
			HttpResponseMessage response = await client.GetAsync(url + id);
			response.EnsureSuccessStatusCode();
			string responseBody = await response.Content.ReadAsStringAsync();
			JObject weatherCityObject = JObject.Parse(responseBody);

			string cityName = weatherCityObject["cityName"].ToString();
			string detail = weatherCityObject["detail"].ToString();
			string country = weatherCityObject["country"].ToString();
			decimal temp = decimal.Parse(weatherCityObject["temp"].ToString());

			Console.WriteLine("Information about the Id value you entered");
			Console.WriteLine();
			Console.Write("City: " + cityName + " Country: " + country + " Detail: " + detail + " Temperature: " + temp);


		}
	}
	Console.ReadKey();
	continue;
}
Console.Read();