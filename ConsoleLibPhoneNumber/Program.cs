using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleLibPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PHONE NUMBER");

            Console.WriteLine("---------------------");
            Console.WriteLine("1-VALIDATION");
            Console.WriteLine($"Phone: 0800503020 - Region: FR - RESULT:{LibPhoneNumberHelper.IsValidPhoneNumber("0800503020", "FR")}");
            Console.WriteLine($"Phone: 0262990102 - Region: FR - RESULT:{LibPhoneNumberHelper.IsValidPhoneNumber("0262990102", "FR")}");
            Console.WriteLine($"Phone: +33647631289 - Region: FR - RESULT:{LibPhoneNumberHelper.IsValidPhoneNumber("+33647631289")}");

            Console.WriteLine("---------------------");
            Console.WriteLine("2-FORMAT INTERNATIONAL");
            Console.WriteLine($"Phone: 0800503020 - Region: FR - RESULT:{LibPhoneNumberHelper.FormatInternational("0800503020", "FR")}");

            Console.WriteLine("---------------------");
            Console.WriteLine("3-PHONE NUMBER REGION - 10 First");

            IEnumerable<(string RegionCode, string CountryCode, string PhoneNumber)> PhoneRegions = LibPhoneNumberHelper.GetSupportedRegions().Take(10);

            foreach(var phoneRegion in PhoneRegions)
            {
                Console.WriteLine($"Region Code: {phoneRegion.RegionCode} - Country Code: {phoneRegion.CountryCode} - Phone: {phoneRegion.PhoneNumber}");
            }
            Console.Read();
        }
    }
}
