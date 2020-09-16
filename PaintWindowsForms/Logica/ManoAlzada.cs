using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ManoAlzada : Herramienta
    {
        public override void DibujarFigura(Graphics graphics, Point lastPoint, Point currentPoint)
        {
            graphics.DrawLine(new Pen(this.Color, 2), lastPoint, currentPoint);
        }
    }
}
