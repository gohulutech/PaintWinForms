using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz.EventArguments
{
    public class ColorSeleccionadoEventArgs
    {
        public ColorSeleccionadoEventArgs(Color color)
        {
            this.Color = color;
        }
        public Color Color { get; private set; }
    }
}
