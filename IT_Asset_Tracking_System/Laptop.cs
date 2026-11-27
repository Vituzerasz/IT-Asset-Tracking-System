using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Asset_Tracking_System
{
    /* Creating the concrete Laptop class inheriting from Equipment (second inheritance level).
     This represents a specific asset type in the system. */
    public class Laptop : Equipment
    {
        /* Private fields for laptop specifications, keeping internal data protected. */
        private string processor;
        private int ramGb;
        private double screenSize;

        /* Passing common and hardware fields to Equipment/Asset via base(), then setting laptop fields. */
        public Laptop(int assetId, string assetTag, string modelName, decimal purchasePrice, DateTime purchaseDate, string status, string serialNumber, int warrantyMonths, string location, string processor, int ramGb, double screenSize)
            : base(assetId, assetTag, modelName, purchasePrice, purchaseDate, status, serialNumber, warrantyMonths, location)
        {
            this.Processor = processor;
            this.RamGb = ramGb;
            this.ScreenSize = screenSize;
        }

        /* Checking that the processor name is not empty. */
        public string Processor
        {
            get { return processor; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    processor = value.Trim();
                }
            }
        }

        /* Checking that RAM is at least 4 GB. */
        public int RamGb
        {
            get { return ramGb; }
            set
            {
                if (value >= 4)
                {
                    ramGb = value;
                }
            }
        }

        /* Checking that screen size is greater than 0. */
        public double ScreenSize
        {
            get { return screenSize; }
            set
            {
                if (value > 0)
                {
                    screenSize = value;
                }
            }
        }

        /* Overriding CalculateCurrentValue (Polymorphism): depreciates 25% per full year used,
         keeping at least 10% of the purchase price as minimum value. */
        public override decimal CalculateCurrentValue()
        {
            int yearsUsed = DateTime.Today.Year - PurchaseDate.Year;
            if (DateTime.Today.DayOfYear < PurchaseDate.DayOfYear)
            {
                yearsUsed = yearsUsed - 1;
            }
            if (yearsUsed < 0)
            {
                yearsUsed = 0;
            }

            decimal depreciationFactor = 1m - (yearsUsed * 0.25m);
            decimal minimumValue = PurchasePrice * 0.10m;
            decimal currentValue = PurchasePrice * depreciationFactor;

            if (currentValue < minimumValue)
            {
                currentValue = minimumValue;
            }

            return currentValue;
        }

        /* Overriding GetSummary to also show RAM and processor details. */
        public override string GetSummary()
        {
            return $"{AssetTag} - {ModelName} ({RamGb}GB RAM, {Processor}) - {Status}";
        }
    }
}