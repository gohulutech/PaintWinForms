using Interfaz;
using Logica;
using System.Windows.Forms;

namespace Presentacion
{
    public class Modelo : ApplicationContext
    {
        private MainWindow vista;
        private Herramienta herramientaActual;

        public Modelo() 
        {
            vista = MainWindow.GetVista();
            vista.Show();
            vista.OnDibujarFigura += Vista_OnDibujarFigura;
            vista.OnSeleccionarManoAlzada += Vista_OnSeleccionarManoAlzada;
        }

        private void Vista_OnSeleccionarManoAlzada(object sender, System.EventArgs e)
        {
            this.herramientaActual = new ManoAlzada();
        }

        private void Vista_OnDibujarFigura(object sender, Interfaz.EventArguments.DrawEventArgs e)
        {
            this.herramientaActual.DibujarFigura(e.Graphics, e.LastPoint, e.CurrentPoint);
        }
    }
}
