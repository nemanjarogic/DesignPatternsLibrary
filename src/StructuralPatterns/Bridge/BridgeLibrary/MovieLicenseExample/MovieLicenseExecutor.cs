using BridgeLibrary.MovieLicenseExample.Models;
using BridgeLibrary.MovieLicenseExample.Models.Enums;
using BuildingBlocks;

namespace BridgeLibrary.MovieLicenseExample;

public static class MovieLicenseExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Movie license example");

        var purchaseTime = DateTime.Now;

        var license1 = new MovieLicense("Secret Life of Pets", purchaseTime, Discount.None, LicenseType.OneDay);
        var license2 = new MovieLicense("Matrix", purchaseTime, Discount.None, LicenseType.LifeLong);
        license1.Print();
        license2.Print();

        var license3 = new MovieLicense("Secret Life of Pets", purchaseTime, Discount.EarlyPayment, LicenseType.LifeLong);
        var license4 = new MovieLicense("Matrix", purchaseTime, Discount.Senior, LicenseType.SevenDays);
        license3.Print();
        license4.Print();

        var license5 = new MovieLicense("Matrix", purchaseTime, Discount.Senior, LicenseType.OneDay, SpecialOffer.SevenDaysExtension);
        license5.Print();
    }
}
