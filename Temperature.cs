using System;

namespace Projekt_GIK299
{
    public class Temperture
    {
        public double fahrenheit;
        public double celsius;
        public double kelvin;

        public void CalcDegrees(double input, string degreesType)
        {
            if (degreesType == "fahrenheit" && input >= -459.67)
            {
                fahrenheit = input;
                celsius = FahrenheitToCelsius(input);
                kelvin = FahrenheitToKelvin(input);
            }
            else if (degreesType == "celsius" && input >= -273.15)
            {
                celsius = input;
                fahrenheit = CelsiusToFahrenheit(input);
                kelvin = CelsiusToKelvin(input);
            }
            else if (degreesType == "kelvin" && input >= 0)
            {
                kelvin = input;
                celsius = KelvinToCelsius(input);
                fahrenheit = KelvinToFahrenheit(input);
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"{input} är för kallt! Vid 0k, -273,15°C och -459,67°F motsvarar den absoluta nollpunkten den temperatur där atomernas och molekylernas vibrationer helt avstannar.\nAnge en varmare temperatur :).");
                Console.ReadLine();
                kelvin = 0;
                celsius = 0;
                fahrenheit = 0;
            }
        }
        private double FahrenheitToCelsius(double f)
        {
            return (f - 32) / 1.8;
        }
        private double FahrenheitToKelvin(double f)
        {
            if (f == 459.67)
            {
                return 0;
            }
            return (f + 459.67) * 5 / 9;
        }
        private double CelsiusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }
        private double CelsiusToKelvin(double c)
        {
            return c + 273.15;
        }
        private double KelvinToFahrenheit(double k)
        {
            return (k * 5 / 9) - 459.67;
        }
        private double KelvinToCelsius(double k)
        {
            return k - 273.15;
        }
    }
}