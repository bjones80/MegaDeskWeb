using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWeb.Models
{
    public class SurfaceMaterial
    {
        public int SurfaceMaterialId { get; set; }
        public string SurfaceMaterialName { get; set; }
        public decimal SurfaceMaterialPrice { get; set; }

        /*allow foreign key to happen */
        public virtual ICollection<Desk> Desk { get; set; }

    }
}
