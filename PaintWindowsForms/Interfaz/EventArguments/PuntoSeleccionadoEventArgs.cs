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

        public Point Point { get; private set; }
    }
}
