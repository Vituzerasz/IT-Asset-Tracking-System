using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Asset_Tracking_System
{
    /* Creating the abstract class to act as a blueprint to all company assets.
     Also, the abstract class cannot be instantiated. */
    public abstract class Asset
    {
        /* Using private fields so we can apply Encapsulation and keep the internal data safe. */
        private int assetId;
        private string assetTag;
        private string modelName;
        private decimal purchasePrice;
        private DateTime purchaseDate;
        private string status;

        /* Protecting the constructor so it can only be called by the classes that inherit from Asset. */
        protected Asset(int assetId, string assetTag, string modelName, decimal purchasePrice, DateTime purchaseDate, string status)
        {
            this.AssetId = assetId;
            this.AssetTag = assetTag;
            this.ModelName = modelName;
            this.PurchasePrice = purchasePrice;
            this.PurchaseDate = purchaseDate;
            this.Status = status;
        }

        /* Creating the validation to prevent negative asset IDs. */
        public int AssetId
        {
            get { return assetId; }
            set
            {
                if (value >= 0)
                {
                    assetId = value;
                }
            }
        }

        /* Checking that the asset tag is not empty before saving. */
        public string AssetTag
        {
            get { return assetTag; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    assetTag = value.Trim();
                }
            }
        }

        /* Checking that the model name is not empty before saving. */
        public string ModelName
        {
            get { return modelName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    modelName = value.Trim();
                }
            }
        }

        /* Preventing negative purchase prices. */
        public decimal PurchasePrice
        {
            get { return purchasePrice; }
            set
            {
                if (value >= 0)
                {
                    purchasePrice = value;
                }
            }
        }

        /* Preventing purchase dates in the future. */
        public DateTime PurchaseDate
        {
            get { return purchaseDate; }
            set
            {
                if (value.Date <= DateTime.Today)
                {
                    purchaseDate = value.Date;
                }
            }
        }

        /* Only allowing valid statuses for the asset. */
        public string Status
        {
            get { return status; }
            set
            {
                if (value == "Available" || value == "Assigned" || value == "Maintenance" || value == "Retired")
                {
                    status = value;
                }
                else if (status == "")
                {
                    /* Setting a default status if none was set yet. */
                    status = "Available";
                }
            }
        }

        /* Abstract method so each specific asset type can calculate its current value differently. */
        public abstract decimal CalculateCurrentValue();

        /* Virtual method for a default summary that child classes can override if they want. */
        public virtual string GetSummary()
        {
            return $"{AssetTag} - {ModelName} ({Status})";
        }
    }
}