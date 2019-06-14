using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWeb.Models
{
    public class Quote
    {
        public int QuoteId { get; set; }

        public int DeskId { get; set; }
        /* Navigation Properties */
        public virtual Desk Desk { get; set; }

        public int DeliveryId { get; set; }
        /* Navigation Properties */
        public virtual Delivery Delivery { get; set; }

        public string CustomerName { get; set; }

        [DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }

        public decimal DeskPrice { get; set; }




    }
}
