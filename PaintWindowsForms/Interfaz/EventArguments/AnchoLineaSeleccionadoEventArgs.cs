using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz.EventArguments
{
    public class AnchoLineaSeleccionadoEventArgs : EventArgs
    {
        public int AnchoLinea { get; private set; }

        public AnchoLineaSeleccionadoEventArgs(int anchoLinea)
        {
            this.AnchoLinea = anchoLinea;
        }
    }
}
