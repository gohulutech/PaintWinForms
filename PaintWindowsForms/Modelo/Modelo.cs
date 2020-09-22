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
        private Figura figuraActual;
        private Color ColorPrincipal;
        private int AnchoLinea;
        private bool LapizAbajo;
        private Herramienta HerramientaActual;

        public Modelo() 
        {
            this.ColorPrincipal = Color.Black;
            this.AnchoLinea = 2;

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
            vista.OnNuevoArchivo += Vista_OnNuevoArchivo;
            vista.OnAbrirArchivo += Vista_OnAbrirArchivo;
            vista.OnAnchoLineaSeleccionado += Vista_OnAnchoLineaSeleccionado;
        }

        private void Vista_OnAnchoLineaSeleccionado(object sender, Interfaz.EventArguments.AnchoLineaSeleccionadoEventArgs e)
        {
            this.AnchoLinea = e.AnchoLinea;
        }

        private void Vista_OnAbrirArchivo(object sender, Interfaz.EventArguments.FileOpenEventArgs e)
        {
            vista.CargarImagen(e.FileName);
        }

        private void Vista_OnNuevoArchivo(object sender, System.EventArgs e)
        {
            figuraActual = null;
            vista.LimpiarCanvas();
        }

        private void Vista_OnSeleccionarBorrador(object sender, System.EventArgs e)
        {
            this.HerramientaActual = new Borrador();
        }

        private void Vista_OnSeleccionarLinea(object sender, System.EventArgs e)
        {
            this.HerramientaActual = new Linea();
        }

        private void Vista_OnSeleccionarRectangulo(object sender, System.EventArgs e)
        {
            this.HerramientaActual = new Rectangulo();
        }

        private void Vista_OnSeleccionarCirculo(object sender, System.EventArgs e)
        {
            this.HerramientaActual = new Elipse();
        }

        private void Vista_OnSeleccionarManoAlzada(object sender, System.EventArgs e)
        {
            this.HerramientaActual = new ManoAlzada();
        }

        private void Vista_OnSeleccionarColor(object sender, Interfaz.EventArguments.ColorSeleccionadoEventArgs e)
        {
            this.ColorPrincipal = e.Color;
            if (this.figuraActual != null)
                this.figuraActual.CambiarColor(e.Color);
        }

        private void Vista_OnMoverLapiz(object sender, Interfaz.EventArguments.PuntoSeleccionadoEventArgs e)
        {
            if (this.HerramientaActual == null || !LapizAbajo)
                return;

            if (figuraActual != null && !(this.HerramientaActual is ManoAlzada) && !(this.HerramientaActual is Borrador))
            {
                this.figuraActual.AjustarFin(e.Point.X, e.Point.Y);
                Pintar();
            }
            else if (figuraActual != null && (this.HerramientaActual is ManoAlzada))
            {
                this.figuraActual.AjustarFin(e.Point.X, e.Point.Y);
                Pintar();
                this.vista.GuardarImagen();
                this.figuraActual = new Figura(this.HerramientaActual, this.ColorPrincipal, this.AnchoLinea);
                this.figuraActual.AjustarInicio(e.Point.X, e.Point.Y);
            }
            else if (figuraActual != null && (this.HerramientaActual is Borrador))
            {
                this.figuraActual.AjustarFin(e.Point.X, e.Point.Y);
                Pintar();
                this.vista.GuardarImagen();
                this.figuraActual = new Figura(this.HerramientaActual, Color.White, this.AnchoLinea);
                this.figuraActual.AjustarInicio(e.Point.X, e.Point.Y);
            }
        }

        private void Vista_OnSoltarMouse(object sender, Interfaz.EventArguments.PuntoSeleccionadoEventArgs e)
        {
            if (!LapizAbajo || this.HerramientaActual == null)
                return;

            if ((this.HerramientaActual is ManoAlzada || this.HerramientaActual is Borrador))
            {
                this.figuraActual.AjustarFin(e.Point.X, e.Point.Y);
            }
            LapizAbajo = false;
            Pintar();
            this.vista.GuardarImagen();
            this.figuraActual = null;
        }

        private void Vista_OnPuntoSeleccionado(object sender, Interfaz.EventArguments.PuntoSeleccionadoEventArgs e)
        {
            if (!LapizAbajo && this.HerramientaActual != null)
            {
                figuraActual = new Figura(HerramientaActual, this.ColorPrincipal, this.AnchoLinea);
                LapizAbajo = true;
                this.figuraActual.AjustarInicio(e.Point.X, e.Point.Y);
            } 
            else if (!LapizAbajo && this.HerramientaActual is Borrador)
            {
                figuraActual = new Figura(HerramientaActual, Color.White, this.AnchoLinea);
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
            //foreach (Figura f in figuras)
            //    f.Dibujar(canvas);
        }
    }
}