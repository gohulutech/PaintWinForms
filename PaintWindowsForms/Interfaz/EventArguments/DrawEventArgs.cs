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
        public DrawEventArgs(bool isMouseDown, Point lastPoint)
        {
            this.IsMouseDown = isMouseDown;
            this.LastPoint = lastPoint;
        }

        public bool IsMouseDown { get; set; }
        public Point LastPoint { get; set; }
    }
}
