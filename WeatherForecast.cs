public class WeatherForecast{
    WeatherData Weather;
    public WeatherForecast(string city, double temperaure, double humidity, double windSpeed)
    {
        Weather = SetWeather(city,temperaure, humidity,windSpeed);
    }
    public WeatherData SetWeather(string city, double temperaure, double humidity, double windSpeed){
        var weather = new WeatherData(city,temperaure,humidity,windSpeed);
        return weather;
    }

    public string AutoDescription(){
        if (Weather.Temperature>= 30.0 && Weather.WindSpeed<10.0)
        {
            return "Hot and Calm";
        }
        else if(Weather.Temperature>= 30.0 && Weather.WindSpeed>=10.0){
            return "Hot and Windy";
        }
        else if(Weather.Temperature>= 10.0 && Weather.WindSpeed<10.0){
            return "Pleasant and Calm";
        }
        else if(Weather.Temperature<=0.0){
            return "Snowy and Rainy";
        }
        return "We wish you a good day";
    }

    public void GetWeatherForeCast(){
        System.Console.WriteLine(Weather.WeatherDescription + "\n"+AutoDescription());
    }

}