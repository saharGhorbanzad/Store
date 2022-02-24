using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaneiStore.ViewModel
{
    public class CustomerVM
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Date { get; set; }
        public int PlotId { get; set; }
        public string PlotName { get; set; }
        public decimal Transportation { get; set; }
        public decimal TheCostOfRepair { get; set; }
        public Nullable<decimal> FortyPercent { get; set; }
        public Nullable<decimal> SixtyPercent { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string Dsc { get; set; }
    }
}
