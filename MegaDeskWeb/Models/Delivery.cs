using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWeb.Models
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public string DeliveryName { get; set; }
        public decimal LessThan1000 { get; set; }
        public decimal From1000To2000 { get; set; }
        public decimal GreaterThan2000 { get; set; }

        /*allow foreign key to happen */
        public virtual ICollection<Quote> Quote { get; set; }

    }
}
