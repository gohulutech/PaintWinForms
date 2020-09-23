using FontAwesome.Sharp;
using Interfaz.EventArguments;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class MainWindow : Form
    {
        #region Fields
        private ControlMainWindow controlador;
        
        #endregion

        #region Public Events
        public event EventHandler OnSeleccionarCirculo;
        public event EventHandler OnSeleccionarRectangulo;
        public event EventHandler OnSeleccionarLinea;
        public event EventHandler OnSeleccionarManoAlzada;
        public event EventHandler OnSeleccionarBorrador;
        public event EventHandler<PuntoSeleccionadoEventArgs> OnPuntoSeleccionado;
        public event EventHandler<PuntoSeleccionadoEventArgs> OnMoverLapiz;
        public event EventHandler<PuntoSeleccionadoEventArgs> OnSoltarMouse;
        public event EventHandler<DrawEventArgs> OnDibujarFigura;
        public event EventHandler<ColorSeleccionadoEventArgs> OnSeleccionarColor;
        public event EventHandler OnNuevoArchivo;
        public event EventHandler<FileOpenEventArgs> OnAbrirArchivo;
        public event EventHandler<AnchoLineaSeleccionadoEventArgs> OnAnchoLineaSeleccionado;
        public event EventHandler OnGuardarArchivo;
        #endregion

        #region Exported Controls to Controller
        internal PictureBox Lienzo { get { return this.Canvas; } }
        internal IconPictureBox BtnPencil { get { return this.btnPencil; } }
        internal IconPictureBox BtnRectangle { get { return this.btnRectangle; } }
        internal IconPictureBox BtnCirculo { get { return this.btnCirculo; } }
        internal IconPictureBox BtnLinea { get { return this.btnLine; } }
        internal IconPictureBox BtnBorrar { get { return this.btnBorrar; } }
        internal ToolStripMenuItem BtnNuevo { get { return this.nuevoToolStripMenuItem; } }
        internal ToolStripMenuItem BtnAbrir { get { return this.abrirToolStripMenuItem; } }
        internal GroupBox Herramientas { get { return this.grupoHerramientas; } }
        internal GroupBox Colores { get { return this.grupoColores; } }
        internal GroupBox Tamanos { get { return this.grupoTamanos; } }
        internal Color ColorLinea 
        {
            get { return this.ColorLapiz.BackColor; }
            set { this.ColorLapiz.BackColor = value; }
        }
        internal Image Image { get; set; }

        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
            controlador = new ControlMainWindow(this);
            LimpiarCanvas();
        }
        #endregion

        #region Public Interface
        public static MainWindow GetVista()
        {
            return new MainWindow();
        }

        public Graphics Graphics
        {
            get
            {
                this.Image = this.Image ?? new Bitmap(this.Canvas.Width, this.Canvas.Height);
                Canvas.Image = (Image)this.Image.Clone();
                return Graphics.FromImage(Canvas.Image);
            }
        }

        public void CargarImagen(string filename)
        {
            var bitmap = new Bitmap(filename);
            this.Canvas.Image = bitmap;
            this.GuardarImagen();
        }

        public void LimpiarCanvas()
        {
            this.Image = new Bitmap(Canvas.Width, Canvas.Height);
            this.Canvas.Image = null;
            this.GuardarImagen();
            this.Canvas.Height--;
        }

        public void GuardarImagen()
        {
            this.Image = this.Canvas.Image;
        }
        #endregion

        #region Internal Methods
        internal void DibujarFigura(object sender, DrawEventArgs drawEventArgs) => OnDibujarFigura?.Invoke(sender, drawEventArgs);

        internal void SeleccionarManoAlzada(object sender, EventArgs e) => OnSeleccionarManoAlzada?.Invoke(sender, e);

        internal void SeleccionarRectangulo(object sender, EventArgs e) => OnSeleccionarRectangulo?.Invoke(sender, e);

        internal void SeleccionarElipse(object sender, EventArgs e) => OnSeleccionarCirculo?.Invoke(sender, e);

        internal void SeleccionarLinea(object sender, EventArgs e) => OnSeleccionarLinea?.Invoke(sender, e);

        internal void SeleccionarBorrador(object sender, EventArgs e) =>  OnSeleccionarBorrador?.Invoke(sender, e);

        internal void SeleccionarColor(object sender, ColorSeleccionadoEventArgs e) => OnSeleccionarColor?.Invoke(sender, e);

        internal void SeleccionarPunto(object sender, PuntoSeleccionadoEventArgs e) => OnPuntoSeleccionado?.Invoke(sender, e);

        internal void MoverLapiz(object sender, PuntoSeleccionadoEventArgs e) => OnMoverLapiz?.Invoke(sender, e);

        internal void SoltarMouse(object sender, PuntoSeleccionadoEventArgs e) => OnSoltarMouse?.Invoke(sender, e);

        internal void NuevoArchivo(object sender, EventArgs e) =>  OnNuevoArchivo?.Invoke(sender, e);

        internal void AbrirArchivo(object sender, FileOpenEventArgs e) => OnAbrirArchivo?.Invoke(sender, e);
        internal void SeleccionarAnchoLinea(object sender, AnchoLineaSeleccionadoEventArgs e) => OnAnchoLineaSeleccionado?.Invoke(sender,e);
        #endregion

        #region Private Helpers
        
        #endregion
    }
}
