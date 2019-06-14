 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWeb.Models
{
    public class Desk
    {
        public int DeskId { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumDrawers { get; set; }

        public int SurfaceMaterialId { get; set; }
        /* Navigation Properties */
        public virtual SurfaceMaterial SurfaceMaterial { get; set; }

        /*allow foreign key to happen */
        public virtual ICollection<Quote> Quote { get; set; }


    }
}
