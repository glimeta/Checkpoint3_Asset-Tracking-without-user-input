using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint3_Asset_Tracking_without_user_input
{
    class Asset
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Office Office { get; set; }
        public double PurchasePrice { get; set; }
        public string Currency { get; set; }
        public double ExchangeRate { get; set; }
    }



    class Computer : Asset
    {
        public Computer(string brand, string model, DateTime

}
