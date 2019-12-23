using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWeather.Data

{
    public class DealTicket
    {

        
        public DealTicket()
        {
            Allocations = new List<DealTicketAllocation>();
        }



        public decimal Price { get; set; }
        public string Instrument { get; set; }

        public decimal  Quantity { get; set; }

        public decimal QuantityAllocated { get { return Allocations.Sum(p => p.Quantity); } }

        public List<DealTicketAllocation> Allocations { get;  set; }
    }
}
