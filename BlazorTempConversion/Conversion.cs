using System;

namespace BlazorTempConversion
{
    public class Conversion
    {
        public enum ConversionMode {
            Celsius_to_Fahrenheit,
            Kelvin_to_Fahrenheit,
            Fahrenheit_to_Celsius,
            Celsius_to_Kelvin,
            Kelvin_to_Celsius,
            Fahrenheit_to_Kelvin

        }
        public double Convert(ConversionMode mode, double temperature) {
            double result = 0d;
            switch (mode) {
                case ConversionMode.Celsius_to_Fahrenheit:
                    result = (9d/5d * temperature) + 32d;
                    break;
                case ConversionMode.Kelvin_to_Fahrenheit:
                    result = Convert(Conversion.ConversionMode.Celsius_to_Fahrenheit, (temperature - 273));
                    break;
                case ConversionMode.Fahrenheit_to_Celsius:
                    result = (temperature - 32) / 1.8;
                    break;
                case ConversionMode.Celsius_to_Kelvin:
                    result = temperature + 273;
                    break;
                case ConversionMode.Kelvin_to_Celsius:
                    result = temperature - 273;
                    break;
                case ConversionMode.Fahrenheit_to_Kelvin:
                    result = Convert(Conversion.ConversionMode.Fahrenheit_to_Celsius, temperature) + 273;
                    break;
            }
            return Math.Round(result, 2);
        }
    }
}