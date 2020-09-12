using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public delegate void SeleccionarFigura();

    public partial class MainWindow : Form
    {
        public event SeleccionarFigura OnSeleccionarCirculo;
        public event SeleccionarFigura OnSeleccionarRectangulo;
        public event SeleccionarFigura OnSeleccionarLinea;

        public MainWindow()
        {
            InitializeComponent();
        }

        public static MainWindow GetVista()
        {
            return new MainWindow();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            OnSeleccionarCirculo?.Invoke();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            OnSeleccionarRectangulo?.Invoke();
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            OnSeleccionarLinea?.Invoke();
        }
    }
}
