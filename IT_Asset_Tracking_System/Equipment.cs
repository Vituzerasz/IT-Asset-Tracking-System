using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Asset_Tracking_System
{
    /* Creating an abstract class for physical equipment that inherits from Asset.
     This represents the intermediate category level in our inheritance hierarchy. */
    public abstract class Equipment : Asset
    {
        /* Private fields for hardware details, keeping them encapsulated. */
        private string serialNumber;
        private int warrantyMonths;
        private string location;

        /* Calling the base constructor first so all common Asset fields are set and validated. */
        protected Equipment(int assetId, string assetTag, string modelName, decimal purchasePrice, DateTime purchaseDate, string status, string serialNumber, int warrantyMonths, string location)
            : base(assetId, assetTag, modelName, purchasePrice, purchaseDate, status)
        {
            this.SerialNumber = serialNumber;
            this.WarrantyMonths = warrantyMonths;
            this.Location = location;
        }

        /* Checking that the serial number is not empty before saving. */
        public string SerialNumber
        {
            get { return serialNumber; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    serialNumber = value.Trim();
                }
            }
        }

        /* Preventing negative warranty months. */
        public int WarrantyMonths
        {
            get { return warrantyMonths; }
            set
            {
                if (value >= 0)
                {
                    warrantyMonths = value;
                }
            }
        }

        /* Checking that the location is not empty before saving. */
        public string Location
        {
            get { return location; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    location = value.Trim();
                }
            }
        }

        /* Overriding GetSummary to include where the equipment is located. */
        public override string GetSummary()
        {
            return $"{AssetTag} - {ModelName} ({Location} - {Status})";
        }
    }
}