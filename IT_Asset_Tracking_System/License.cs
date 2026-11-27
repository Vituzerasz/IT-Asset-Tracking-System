using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Asset_Tracking_System
{
    /* Creating the concrete License class inheriting directly from Asset.
     Software licenses are not physical equipment, so they have their own branch. */
    public class License : Asset
    {
        /* Private fields for software license details, keeping the data encapsulated. */
        private string licenseKey;
        private int totalSeats;
        private DateTime expirationDate;

        /* Passing common asset fields to Asset via base(), then setting license fields. */
        public License(int assetId, string assetTag, string modelName, decimal purchasePrice, DateTime purchaseDate, string status, string licenseKey, int totalSeats, DateTime expirationDate)
            : base(assetId, assetTag, modelName, purchasePrice, purchaseDate, status)
        {
            this.LicenseKey = licenseKey;
            this.TotalSeats = totalSeats;
            this.ExpirationDate = expirationDate;
        }

        /* Checking that the license key is not null, empty, or whitespace. */
        public string LicenseKey
        {
            get { return licenseKey; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    licenseKey = value.Trim();
                }
            }
        }

        /* Checking that the number of user seats is at least 1. */
        public int TotalSeats
        {
            get { return totalSeats; }
            set
            {
                if (value >= 1)
                {
                    totalSeats = value;
                }
            }
        }

        /* Checking that the expiration date is not before the purchase date. */
        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set
            {
                if (value.Date >= PurchaseDate)
                {
                    expirationDate = value.Date;
                }
            }
        }

        /* Overriding CalculateCurrentValue (Polymorphism): if the license is expired,
         its value is 0. Otherwise, it keeps 50% of the purchase price while active. */
        public override decimal CalculateCurrentValue()
        {
            if (DateTime.Today >= ExpirationDate)
            {
                return 0;
            }
            else
            {
                return PurchasePrice * 0.50m;
            }
        }

        /* Overriding GetSummary to show the number of seats and expiration date. */
        public override string GetSummary()
        {
            return $"{AssetTag} - {ModelName} ({TotalSeats} seats, expires {ExpirationDate.ToShortDateString()}) - {Status}";
        }
    }
}