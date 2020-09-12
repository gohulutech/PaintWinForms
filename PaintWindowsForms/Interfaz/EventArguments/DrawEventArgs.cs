using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz.EventArguments
{
    public class DrawEventArgs : EventArgs
    {
        public Point PuntoInicial { get; set; }
        public Point PuntoActual { get; set; }
    }
}
