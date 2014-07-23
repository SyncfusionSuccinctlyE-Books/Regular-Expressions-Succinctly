using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexTester
{
    public class CarSearch
    {
        private string[] CarMakes = { "ford", "honda", "toyota", "pontiac" };
        public string CarMake;
        public int? Year;
        public double? Price;

        private Regex FindPrice = new Regex(@"\$\d{3,5}|\$\d{1,2},\d{3}");
        private Regex FindYear = new Regex(@"20\d\d|'\d\d");

        public Boolean ReadAd(string AdText)
        {
            Boolean FoundCar = false;
            CarMake = "";
            Year = null;
            Price = null;

            // Search for a car make in Ad text
            foreach (string Car in CarMakes)
            {
                string CarPattern = @"\b" + @Car + @"\b";
                if (Regex.IsMatch(AdText, CarPattern, RegexOptions.IgnoreCase))
                {
                    CarMake = Car;
                    FoundCar = true;
                    break;
                }
            }
            // Try to get year and price
            if (FoundCar)
            {   
                // Can we find a price?
                Match PriceMatch = FindPrice.Match(AdText);
                if (PriceMatch.Success)
                {
                    Price = Convert.ToDouble(PriceMatch.Value.Replace(",","").Replace("$",""));
                }
                // Can we find the year
                Match YearMatch = FindYear.Match(AdText);
                if (YearMatch.Success)
                {
                    Year = Convert.ToInt16(YearMatch.Value.Replace("'", "20"));
                }
            }
            return FoundCar;
        }
    }
}
