using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaneiStore
{
    public class StoreVM
    {
        public int PlotId { get; set; }
        public string PlotName { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public int Provider { get; set; }
        public string ProviderName { get; set; }
        public string PurchaseDate { get; set; }
        public string Dsc { get; set; }
    }
}
