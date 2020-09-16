using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class Herramienta
    {
        public Herramienta()
        {
            this.Color = Color.Black;
        }

        public virtual Color Color { get; set; }
        public abstract void DibujarFigura(Graphics graphics, Point lastPoint, Point currentPoint);
    }
}
