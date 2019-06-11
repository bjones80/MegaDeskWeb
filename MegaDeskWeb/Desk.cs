using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskWeb
{
    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }



    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumDrawers { get; set; }
        public DesktopMaterial SurfaceMaterial { get; set; }


        // Non-Default Constructor 
        //public Desk(int pvWidth, int pvDepth, int pvDrawers, int pvMaterial)
        //{
        //    this.width = pvWidth;
        //    this.depth = pvDepth;
        //    this.numDrawers = pvDrawers;
        //    this.surfaceMaterial = pvMaterial;
        //}
        
           
        public decimal SurfaceArea()
        {
            return Width * Depth;
           
        }

    }
}
