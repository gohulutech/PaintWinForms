using FontAwesome.Sharp;
using Interfaz.EventArguments;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Interfaz
{
    public class ControlMainWindow
    {
        #region Private Fields
        private Point lastPoint;
        private bool isMouseDown;
        private string selectedButton;
        private MainWindow mainWindow;
        #endregion

        #region Constructor
        public ControlMainWindow(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;

            foreach (IconPictureBox button in this.mainWindow.Herramientas.Controls)
            {
                button.BackColor = SystemColors.Control;
                button.Click += BtnFigure_Click;
            }
            foreach (Control buttonColor in this.mainWindow.Colores.Controls)
            {
                if (buttonColor is Button)
                {
                    buttonColor.MouseClick += ButtonColor_Click;
                }
            }

            this.mainWindow.BtnPencil.Click += BtnPencil_Click;
            this.mainWindow.BtnRectangle.Click += BtnRectangle_Click;
            this.mainWindow.BtnCirculo.Click += BtnCirculo_Click;
            this.mainWindow.BtnLinea.Click += BtnLinea_Click;
            this.mainWindow.BtnBorrar.Click += BtnBorrar_Click;
            this.mainWindow.BtnNuevo.Click += BtnNuevo_Click;
            this.mainWindow.BtnAbrir.Click += BtnAbrir_Click;
            this.mainWindow.Lienzo.MouseDown += Lienzo_MouseDown;
            this.mainWindow.Lienzo.MouseMove += Lienzo_MouseMove;
            this.mainWindow.Lienzo.MouseUp += Lienzo_MouseUp;
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.mainWindow.AbrirArchivo(sender, new FileOpenEventArgs(openFileDialog.FileName));
                }
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e) =>
            this.mainWindow.NuevoArchivo(sender, e);
        #endregion

        #region Private Helpers
        private void BtnPencil_Click(object sender, EventArgs e) =>
            this.mainWindow.SeleccionarManoAlzada(sender, e);

        private void BtnRectangle_Click(object sender, EventArgs e) =>
            this.mainWindow.SeleccionarRectangulo(sender, e);

        private void BtnLinea_Click(object sender, EventArgs e) =>
            this.mainWindow.SeleccionarLinea(sender, e);

        private void BtnCirculo_Click(object sender, EventArgs e) =>
            this.mainWindow.SeleccionarElipse(sender, e);

        private void BtnBorrar_Click(object sender, EventArgs e) =>
            this.mainWindow.SeleccionarBorrador(sender, e);

        private void Lienzo_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) =>
            this.mainWindow.MoverLapiz(sender, new PuntoSeleccionadoEventArgs(e.Location));

        private void Lienzo_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) =>
            this.mainWindow.SeleccionarPunto(sender, new PuntoSeleccionadoEventArgs(e.Location));

        private void Lienzo_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e) =>
            this.mainWindow.SoltarMouse(sender, new PuntoSeleccionadoEventArgs(e.Location));

        private void BtnFigure_Click(object sender, EventArgs e)
        {
            LimpiarBotones();
            SeleccionarBoton((IconPictureBox)sender);
        }

        private void LimpiarBotones()
        {
            foreach (IconPictureBox button in this.mainWindow.Herramientas.Controls)
            {
                button.BackColor = SystemColors.Control;
            }
        }
        private void SeleccionarBoton(IconPictureBox button)
        {
            selectedButton = button.Name;
            button.BackColor = Color.LightBlue;
        }

        private void ButtonColor_Click(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            this.mainWindow.SeleccionarColor(sender, new ColorSeleccionadoEventArgs(button.BackColor));
            this.mainWindow.ColorLinea = button.BackColor;
        }
        #endregion
    }
}