﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint3_Asset_Tracking_without_user_input
{
    class Phone : Asset
    {
        public Phone(string brand, string model, DateTime purchaseDate, Office office, double purchasePrice, string currency, double exchangeRate)
        {
            Brand = brand;
            Model = model;
            PurchaseDate = purchaseDate;
            Office = office;
            PurchasePrice = purchasePrice;
            Currency = currency;
            ExchangeRate = exchangeRate;
        }
    }

}
