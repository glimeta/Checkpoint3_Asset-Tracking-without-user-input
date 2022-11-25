using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint3_Asset_Tracking_without_user_input
{
    class ExchangeRate
    {
        public ExchangeRate(string currency, double rate)
        {
            Currency = currency;
            Rate = rate;
        }

        public string Currency { get; set; }
        public double Rate { get; set; }
    }



}
