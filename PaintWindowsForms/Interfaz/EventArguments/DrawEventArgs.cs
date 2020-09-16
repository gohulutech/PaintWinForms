﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz.EventArguments
{
    public class DrawEventArgs : EventArgs
    {
        public DrawEventArgs(Graphics graphics, Point lastPoint, Point currentPoint)
        {
            this.LastPoint = lastPoint;
            this.CurrentPoint = currentPoint;
            this.Graphics = graphics;
        }

        public Graphics Graphics { get; private set; }
        public Point LastPoint { get; private set; }
        public Point CurrentPoint { get; private set; }
    }
}
