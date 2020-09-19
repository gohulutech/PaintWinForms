using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Figura
    {
        public Figura(Herramientas.Herramienta herramienta, Color color, int anchoLinea)
        {
            this.Herramienta = herramienta;
            this.Color = color;
            this.AnchoLinea = anchoLinea;
        }

        public int AnchoLinea { get; private set; }
        public Color Color { get; private set; }
        public Point PuntoInicial { get; private set; }
        public Point PuntoActual { get; private set; }

        public Herramientas.Herramienta Herramienta { get; private set; }

        public void AjustarInicio(int X, int Y)
        {
            PuntoInicial = new Point(X, Y);
        }

        public void AjustarFin(int X, int Y)
        {
            PuntoActual = new Point(X, Y);
        }

        public void CambiarColor(Color color)
        {
            Color = color;
        }

        public void Dibujar(Graphics g)
        {
            this.Herramienta.DibujarFigura(g, this.Color, 2, this.PuntoInicial, this.PuntoActual);
        }
    }
}
