using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Herramientas
{
    public class Elipse : Herramienta
    {
        public override void DibujarFigura(Graphics graphics, Color color, int anchoLinea, Point PuntoInicial, Point PuntoActual)
        {
            Pen myPen = new Pen(color, anchoLinea);
            if (PuntoInicial.X < PuntoActual.X)
            {
                if (PuntoInicial.Y < PuntoActual.Y)
                    graphics.DrawEllipse(myPen, PuntoInicial.X, PuntoInicial.Y, PuntoActual.X - PuntoInicial.X, PuntoActual.Y - PuntoInicial.Y);
                else
                    graphics.DrawEllipse(myPen, PuntoInicial.X, PuntoActual.Y, PuntoActual.X - PuntoInicial.X, PuntoInicial.Y - PuntoActual.Y);
            }
            else
            {
                if (PuntoInicial.Y < PuntoActual.Y)
                    graphics.DrawEllipse(myPen, PuntoActual.X, PuntoInicial.Y, PuntoInicial.X - PuntoActual.X, PuntoActual.Y - PuntoInicial.Y);
                else
                    graphics.DrawEllipse(myPen, PuntoActual.X, PuntoActual.Y, PuntoInicial.X - PuntoActual.X, PuntoInicial.Y - PuntoActual.Y);
            }
        }
    }
}
