using System;
using BridgeLibrary.MovieLicenseExample.Models;
using BridgeLibrary.MovieLicenseExample.Models.Enums;
using BuildingBlocks;

namespace BridgeLibrary.MovieLicenseExample
{
    public static class MovieLicenseExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Movie license example");

            DateTime now = DateTime.Now;

            var license1 = new MovieLicense("Secret Life of Pets", now, Discount.None, LicenceType.OneDay);
            var license2 = new MovieLicense("Matrix", now, Discount.None, LicenceType.LifeLong);

            PrintLicenseDetails(license1);
            PrintLicenseDetails(license2);

            var license3 = new MovieLicense("Secret Life of Pets", now, Discount.EarlyPayment, LicenceType.LifeLong);
            var license4 = new MovieLicense("Matrix", now, Discount.Senior, LicenceType.SevenDays);

            PrintLicenseDetails(license3);
            PrintLicenseDetails(license4);

            var license5 = new MovieLicense("Matrix", now, Discount.Senior, LicenceType.OneDay, SpecialOffer.SevenDaysExtension);

            PrintLicenseDetails(license5);
        }

        private static void PrintLicenseDetails(MovieLicense license)
        {
            Console.WriteLine($"Movie: {license.Movie}");
            Console.WriteLine($"Price: {GetPrice(license)}");
            Console.WriteLine($"Valid for: {GetValidFor(license)}");

            Console.WriteLine();
        }

        private static string GetPrice(MovieLicense license)
        {
            return $"${license.GetPrice():0.00}";
        }

        private static string GetValidFor(MovieLicense license)
        {
            DateTime? expirationDate = license.GetExpirationDate();
            if (expirationDate == null)
            {
                return "Forever";
            }

            TimeSpan timeSpan = expirationDate.Value - DateTime.Now;

            return $"{timeSpan.Days}d {timeSpan.Hours}h {timeSpan.Minutes}m";
        }
    }
}
