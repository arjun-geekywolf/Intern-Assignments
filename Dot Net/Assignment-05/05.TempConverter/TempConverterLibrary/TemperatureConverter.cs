
namespace TempConverterLibrary

{

    public class TemperatureConverter
    {
        TemparatureValidator validator = new TemparatureValidator();
        public void CelsiusToFahrenheit(double celcius)
        {
            if (validator.Validate(celcius)) {
                double fahrenheit = (celcius * 1.8) + 32;
                Console.WriteLine($"{celcius}°C is {fahrenheit}°F");
            }
            else
            {
                Console.WriteLine("Temperature out of range");
            }
        }

        public void FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) / 1.8;

            if (validator.Validate(celsius))
            {
                Console.WriteLine($"{fahrenheit}°F is {celsius}°C");
            }
            else
            {
                Console.WriteLine("Temperature out of range");
            }
        }

    }

}
