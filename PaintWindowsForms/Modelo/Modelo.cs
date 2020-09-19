using Interfaz;
using Logica;
using Logica.Herramientas;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
    public class Modelo : ApplicationContext
    {
        private MainWindow vista;
        private List<Figura> figuras;
        private Figura figuraActual;
        private Color ColorPrincipal;
        private bool LapizAbajo;
        private Herramienta HerramientaActual;

        public Modelo() 
        {
            figuras = new List<Figura>();

            vista = MainWindow.GetVista();
            vista.Show();
            vista.OnSeleccionarManoAlzada += Vista_OnSeleccionarManoAlzada;
            vista.OnSeleccionarRectangulo += Vista_OnSeleccionarRectangulo;
            vista.OnSeleccionarCirculo += Vista_OnSeleccionarCirculo;
            vista.OnSeleccionarLinea += Vista_OnSeleccionarLinea;
            vista.OnSeleccionarBorrador += Vista_OnSeleccionarBorrador;
            vista.FormClosed += Vista_FormClosed;
            vista.OnSeleccionarColor += Vista_OnSeleccionarColor;
            vista.OnPuntoSeleccionado += Vista_OnPuntoSeleccionado;
            vista.OnMoverLapiz += Vista_OnMoverLapiz;
            vista.OnSoltarMouse += Vista_OnSoltarMouse;
        }

        private void Vista_OnSeleccionarBorrador(object sender, System.EventArgs e)
        {
            this.HerramientaActual = new ManoAlzada();
        }

        private void Vista_OnSeleccionarLinea(object sender, System.EventArgs e)
        {
            this.HerramientaActual = new Linea();
        }

        private void Vista_OnSeleccionarRectangulo(object sender, System.EventArgs e)
        {
            HerramientaActual = new Rectangulo();
        }

        private void Vista_OnSeleccionarCirculo(object sender, System.EventArgs e)
        {
            HerramientaActual = new Elipse();
        }

        private void Vista_OnSeleccionarColor(object sender, Interfaz.EventArguments.ColorSeleccionadoEventArgs e)
        {
            this.ColorPrincipal = e.Color;
            if (this.figuraActual != null)
                this.figuraActual.CambiarColor(e.Color);
        }

        private void Vista_OnSeleccionarManoAlzada(object sender, System.EventArgs e)
        {
            HerramientaActual = new ManoAlzada();
        }

        private void Vista_OnMoverLapiz(object sender, Interfaz.EventArguments.PuntoSeleccionadoEventArgs e)
        {
            if (LapizAbajo && figuraActual != null && !(this.HerramientaActual is ManoAlzada))
            {
                this.figuraActual.AjustarFin(e.Point.X, e.Point.Y);
                Pintar();
            }
            else if (LapizAbajo && figuraActual != null && (this.HerramientaActual is ManoAlzada))
            {
                this.figuraActual.AjustarFin(e.Point.X, e.Point.Y);
                this.figuras.Add(figuraActual);
                this.figuraActual = null;
                Pintar();

                this.figuraActual = new Figura(new ManoAlzada(), this.ColorPrincipal, 2);
                this.figuraActual.AjustarInicio(e.Point.X, e.Point.Y);
            }
        }

        private void Vista_OnSoltarMouse(object sender, Interfaz.EventArguments.PuntoSeleccionadoEventArgs e)
        {
            if (LapizAbajo && !(this.HerramientaActual is ManoAlzada))
            {
                LapizAbajo = false;
                this.figuras.Add(figuraActual);
                this.figuraActual = null;
                Pintar();
            }
            else if (LapizAbajo && (this.HerramientaActual is ManoAlzada))
            {
                LapizAbajo = false;
                this.figuraActual.AjustarFin(e.Point.X, e.Point.Y);
                this.figuras.Add(figuraActual);
                this.figuraActual = null;
                Pintar();
            }
        }

        private void Vista_OnPuntoSeleccionado(object sender, Interfaz.EventArguments.PuntoSeleccionadoEventArgs e)
        {
            if (!LapizAbajo)
            {
                figuraActual = new Figura(HerramientaActual, this.ColorPrincipal, 2);
                LapizAbajo = true;
                this.figuraActual.AjustarInicio(e.Point.X, e.Point.Y);
            }
        }

        private void Vista_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ExitThread();
        }

        private void Pintar()
        {
            Graphics canvas = vista.Graphics;
            figuraActual?.Dibujar(canvas);
            foreach (Figura f in figuras)
                f.Dibujar(canvas);
        }
    }
}