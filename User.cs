/* class Program{
    static void Main(){
        WeathererForeCast city1 = new WeathererForeCast("Samsun",-12.2,5000.9,3434.2);
        city1.GetWeatherForeCast();
    }
} */
class Program
{
    private static void Main(string[] args)
    {
        WeatherForecast city1 = new WeatherForecast("Samsun", 172.2, 5000.9, 3434.2);
        city1.GetWeatherForeCast();
    }
}