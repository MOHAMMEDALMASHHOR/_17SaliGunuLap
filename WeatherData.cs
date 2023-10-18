public class WeatherData{
    public double Temperature { get; set; }
    
    public double Humidity { get; set; }
    public double WindSpeed { get; set; }
    public string? City { get; set; }
    public DateTime Date { get; private set; }
    public string WeatherDescription { get{
        return string.Concat("Date: "+ Date + " City: " + City + " Temperature: " + Temperature + " Humidity: " + Humidity + " Wind Speed: " + WindSpeed);
    } }

    public WeatherData()
    {
        Date = DateTime.Now;
    }

    public WeatherData(string city, double temperaure, double humidity, double windSpeed):this()
    {
        City = city;
        Temperature = temperaure;
        Humidity = humidity;
        WindSpeed = windSpeed;
    }
}