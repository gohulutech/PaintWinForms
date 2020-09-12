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
        }
    }
}
