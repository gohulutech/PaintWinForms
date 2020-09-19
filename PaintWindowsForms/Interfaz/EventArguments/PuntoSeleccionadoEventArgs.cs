using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz.EventArguments
{
    public class PuntoSeleccionadoEventArgs
    {
        public PuntoSeleccionadoEventArgs(Point point)
        {
            this.Point = point;
        }

        public PuntoSeleccionadoEventArgs(Graphics graphics, Point point)
        {
            this.Point = point;
            this.Graphics = graphics;
        }

        public Point Point { get; private set; }
        public Graphics Graphics { get; private set; }
    }
}
