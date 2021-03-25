using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LV2
{
    class GrafObj
    {
       public Color boja { get; set; }
       public Point koordinata1 { get; set; }

        public void SetColor(Color color)
        {
            this.boja = color;
        }

        //public Color GetColor()
        //{
        //    return this.boja;
        //}

        public GrafObj() { }
        public GrafObj(Color Boja, Point Koordinata1)
        {
            this.boja = Boja;
            this.koordinata1 = Koordinata1;
        }
        public virtual void DrawGrafObj(Graphics graphics) { }
    }
}
