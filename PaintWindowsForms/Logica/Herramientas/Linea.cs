using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Herramientas
{
    public class Linea : Herramienta
    {
        public override void DibujarFigura(Graphics graphics, Color color, int anchoLinea, Point PuntoInicial, Point PuntoActual)
        {
            Pen myPen = new Pen(color, anchoLinea);
            graphics.DrawLine(myPen, PuntoInicial, PuntoActual);
        }
    }
}
