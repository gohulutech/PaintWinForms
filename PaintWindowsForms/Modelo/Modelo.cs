using Interfaz;
using System.Windows.Forms;

namespace Presentacion
{
    public class Modelo : ApplicationContext
    {
        private MainWindow vista;

        public Modelo() {
            vista = MainWindow.GetVista();
            vista.Show();
            vista.OnDibujarFigura += Vista_OnDibujarFigura;
            vista.OnSeleccionarLinea += Vista_OnSeleccionarLinea;
        }

        private void Vista_OnDibujarFigura(object sender, Interfaz.EventArguments.DrawEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Vista_OnSeleccionarLinea(object sender, Interfaz.EventArguments.FiguraSeleccionadaEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
