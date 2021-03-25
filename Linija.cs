using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LV2
{
    class Linija : GrafObj
    {
        public Point koordinata2 { get; set; }
        public Linija() { }
        public Linija(Color Boja, Point Koordinata1, Point Koordinata2)
            : base(Boja, Koordinata1)
        {
            this.koordinata2 = Koordinata2;
        }
        public override void DrawGrafObj(Graphics graphics)
        {
            Pen pen = new Pen(boja);
            graphics.DrawLine(pen, koordinata1, koordinata2);
        }
    }

    
}
