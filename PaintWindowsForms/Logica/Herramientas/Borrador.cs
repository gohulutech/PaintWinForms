using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Herramientas
{
    public class Borrador : Herramienta
    {
        public override void DibujarFigura(Graphics graphics, Color color, int anchoLinea, Point PuntoInicial, Point PuntoActual)
        {
            graphics.DrawLine(new Pen(color, anchoLinea), PuntoInicial, PuntoActual);
        }
    }
}
