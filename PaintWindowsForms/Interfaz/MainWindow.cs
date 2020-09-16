using FontAwesome.Sharp;
using Interfaz.EventArguments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class MainWindow : Form
    {
        private Point lastPoint;
        private bool isMouseDown;

        private string selectedButton;

        public event EventHandler<FiguraSeleccionadaEventArgs> OnSeleccionarCirculo;
        public event EventHandler<FiguraSeleccionadaEventArgs> OnSeleccionarRectangulo;
        public event EventHandler<FiguraSeleccionadaEventArgs> OnSeleccionarLinea;
        public event EventHandler<FiguraSeleccionadaEventArgs> OnSeleccionarManoAlzada;
        public event EventHandler<FiguraSeleccionadaEventArgs> OnSeleccionarBorrador;
        public event EventHandler<DrawEventArgs> OnDibujarFigura;

        public MainWindow()
        {
            InitializeComponent();
            foreach (IconPictureBox button in this.AnchoLineas.Controls)
            {
                button.BackColor = SystemColors.Control;
                button.Click += BtnFigure_Click;
            }
        }

        private void BtnFigure_Click(object sender, EventArgs e)
        {
            LimpiarBotones();
            SeleccionarBoton((IconPictureBox)sender);
        }

        public static MainWindow GetVista()
        {
            return new MainWindow();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
        }

        private void btnFigure_MouseDown(object sender, EventArgs e)
        {
            IconPictureBox button = (IconPictureBox)sender;
            button.BackColor = Color.LightBlue;
        }

        private void btnBorrar_MouseLeave(object sender, EventArgs e)
        {
            IconPictureBox button = (IconPictureBox)sender;
            if (button.Name != selectedButton)
            {
                button.BackColor = SystemColors.Control;
            }
        }

        private void LimpiarBotones()
        {
            foreach (IconPictureBox button in this.AnchoLineas.Controls)
            {
                button.BackColor = SystemColors.Control;
            }
        }
        private void SeleccionarBoton(IconPictureBox button)
        {
            selectedButton = button.Name;
            button.BackColor = Color.LightBlue;
        }

        private void btnPencil_Click(object sender, EventArgs e)
        {
            OnSeleccionarManoAlzada?.Invoke(sender, new FiguraSeleccionadaEventArgs());
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            isMouseDown = true;
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true && lastPoint != null)
            {
                if (this.Canvas.Image == null)
                {
                    Bitmap bmp = new Bitmap(this.Canvas.Width, this.Canvas.Height);
                    this.Canvas.Image = bmp; 
                }

                using (Graphics g = Graphics.FromImage(this.Canvas.Image))
                {
                    g.DrawLine(new Pen(Color.Black, 2), lastPoint, e.Location);
                }
                this.Canvas.Invalidate();
                lastPoint = e.Location;
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            lastPoint = Point.Empty;
        }
    }
}
