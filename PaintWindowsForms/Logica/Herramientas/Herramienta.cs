﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Herramientas
{
    public abstract class Herramienta
    {
        public Herramienta() { }
        public abstract void DibujarFigura(Graphics graphics, Color color, int anchoLinea, Point PuntoInicial, Point PuntoActual);
    }
}
