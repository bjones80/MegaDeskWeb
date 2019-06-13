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

        
    }
}
