using System.ComponentModel.DataAnnotations;

namespace BlazorTempConversion
{
    public class FormInput
    {
        [Required]
        [StringLength(11, ErrorMessage = "Name is too long.")]
        public string? From { get; set; }

        [Required]        
        public double ConversionValue {get; set;} = 0.00;
      
        public double ConvertedValue {get; set;} = 0.00;

        [Required]
        [StringLength(11, ErrorMessage = "Name is too long.")]
        public string? To { get; set; }

        public string Celsius {get;set;} = "Celsius";
        public string Fahrenheit {get;set;} = "Fahrenheit";
        public string Kelvin {get;set;} = "Kelvin";
    }
}