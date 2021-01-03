using System;
using BridgeLibrary.MovieLicenseExample.Models.Enums;

namespace BridgeLibrary.MovieLicenseExample.Models
{
    /// <summary>
    /// We can use enums for alternative implementation of the Bridge design pattern.
    /// For more details see Vladimir Khorikov's course:
    /// https://app.pluralsight.com/library/courses/design-patterns-c-sharp-bridge
    /// </summary>
    public class MovieLicense
    {
        private readonly Discount _discount;
        private readonly LicenceType _licenceType;
        private readonly SpecialOffer _specialOffer;

        public MovieLicense(
            string movie,
            DateTime purchaseTime,
            Discount discount,
            LicenceType licenceType,
            SpecialOffer specialOffer = SpecialOffer.None)
        {
            Movie = movie;
            PurchaseTime = purchaseTime;

            _discount = discount;
            _licenceType = licenceType;
            _specialOffer = specialOffer;
        }

        public string Movie { get; }

        public DateTime PurchaseTime { get; }

        public decimal GetPrice()
        {
            int discount = GetDiscount();
            decimal multiplier = 1 - (discount / 100m);

            return GetBasePrice() * multiplier;
        }

        public DateTime? GetExpirationDate()
        {
            DateTime? expirationDate = GetBaseExpirationDate();
            TimeSpan extension = GetSpecialOfferExtension();

            return expirationDate?.Add(extension);
        }

        private int GetDiscount()
        {
            return _discount switch
            {
                Discount.None => 0,
                Discount.EarlyPayment => 10,
                Discount.Senior => 20,

                _ => throw new ArgumentOutOfRangeException(),
            };
        }

        private decimal GetBasePrice()
        {
            return _licenceType switch
            {
                LicenceType.OneDay => 10,
                LicenceType.SevenDays => 60,
                LicenceType.LifeLong => 150,

                _ => throw new ArgumentOutOfRangeException(),
            };
        }

        private TimeSpan GetSpecialOfferExtension()
        {
            return _specialOffer switch
            {
                SpecialOffer.None => TimeSpan.Zero,
                SpecialOffer.OneDayExtension => TimeSpan.FromDays(1),
                SpecialOffer.SevenDaysExtension => TimeSpan.FromDays(7),

                _ => throw new ArgumentOutOfRangeException(),
            };
        }

        private DateTime? GetBaseExpirationDate()
        {
            return _licenceType switch
            {
                LicenceType.OneDay => PurchaseTime.AddDays(1) as DateTime?,
                LicenceType.SevenDays => PurchaseTime.AddDays(7) as DateTime?,
                LicenceType.LifeLong => null,

                _ => throw new ArgumentOutOfRangeException(),
            };
        }
    }
}
