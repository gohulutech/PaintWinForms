using FontAwesome.Sharp;
using System.Drawing;

namespace Interfaz
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPencil = new FontAwesome.Sharp.IconPictureBox();
            this.btnBorrar = new FontAwesome.Sharp.IconPictureBox();
            this.btnLine = new FontAwesome.Sharp.IconPictureBox();
            this.btnRectangle = new FontAwesome.Sharp.IconPictureBox();
            this.btnCirculo = new FontAwesome.Sharp.IconPictureBox();
            this.ColorLapiz = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.grupoHerramientas = new System.Windows.Forms.GroupBox();
            this.grupoColores = new System.Windows.Forms.GroupBox();
            this.BotonColor1 = new System.Windows.Forms.Button();
            this.BotonColor8 = new System.Windows.Forms.Button();
            this.BotonColor7 = new System.Windows.Forms.Button();
            this.BotonColor16 = new System.Windows.Forms.Button();
            this.BotonColor6 = new System.Windows.Forms.Button();
            this.BotonColor15 = new System.Windows.Forms.Button();
            this.BotonColor5 = new System.Windows.Forms.Button();
            this.BotonColor14 = new System.Windows.Forms.Button();
            this.BotonColor4 = new System.Windows.Forms.Button();
            this.BotonColor13 = new System.Windows.Forms.Button();
            this.BotonColor3 = new System.Windows.Forms.Button();
            this.BotonColor12 = new System.Windows.Forms.Button();
            this.BotonColor2 = new System.Windows.Forms.Button();
            this.BotonColor11 = new System.Windows.Forms.Button();
            this.BotonColor10 = new System.Windows.Forms.Button();
            this.BotonColor9 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoTamanos = new System.Windows.Forms.GroupBox();
            this.btnTamañoG = new System.Windows.Forms.Button();
            this.btnTamañoM = new System.Windows.Forms.Button();
            this.btnTamañoP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnPencil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCirculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorLapiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.grupoHerramientas.SuspendLayout();
            this.grupoColores.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grupoTamanos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPencil
            // 
            this.btnPencil.BackColor = System.Drawing.SystemColors.Control;
            this.btnPencil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPencil.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnPencil.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnPencil.IconSize = 24;
            this.btnPencil.Location = new System.Drawing.Point(3, 16);
            this.btnPencil.Margin = new System.Windows.Forms.Padding(0);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(29, 24);
            this.btnPencil.TabIndex = 21;
            this.btnPencil.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBorrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnBorrar.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnBorrar.IconSize = 24;
            this.btnBorrar.Location = new System.Drawing.Point(119, 16);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(29, 24);
            this.btnBorrar.TabIndex = 20;
            this.btnBorrar.TabStop = false;
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.SystemColors.Control;
            this.btnLine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLine.IconChar = FontAwesome.Sharp.IconChar.GripLines;
            this.btnLine.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnLine.IconSize = 24;
            this.btnLine.Location = new System.Drawing.Point(90, 16);
            this.btnLine.Margin = new System.Windows.Forms.Padding(0);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(29, 24);
            this.btnLine.TabIndex = 19;
            this.btnLine.TabStop = false;
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.SystemColors.Control;
            this.btnRectangle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRectangle.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnRectangle.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnRectangle.IconSize = 24;
            this.btnRectangle.Location = new System.Drawing.Point(61, 16);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(0);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(29, 24);
            this.btnRectangle.TabIndex = 18;
            this.btnRectangle.TabStop = false;
            // 
            // btnCirculo
            // 
            this.btnCirculo.BackColor = System.Drawing.SystemColors.Control;
            this.btnCirculo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCirculo.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.btnCirculo.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCirculo.IconSize = 24;
            this.btnCirculo.Location = new System.Drawing.Point(32, 16);
            this.btnCirculo.Margin = new System.Windows.Forms.Padding(0);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(29, 24);
            this.btnCirculo.TabIndex = 17;
            this.btnCirculo.TabStop = false;
            // 
            // ColorLapiz
            // 
            this.ColorLapiz.BackColor = System.Drawing.Color.Black;
            this.ColorLapiz.Location = new System.Drawing.Point(9, 36);
            this.ColorLapiz.Name = "ColorLapiz";
            this.ColorLapiz.Size = new System.Drawing.Size(28, 26);
            this.ColorLapiz.TabIndex = 15;
            this.ColorLapiz.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Linea";
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Canvas.Location = new System.Drawing.Point(12, 108);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(778, 330);
            this.Canvas.TabIndex = 16;
            this.Canvas.TabStop = false;
            // 
            // grupoHerramientas
            // 
            this.grupoHerramientas.Controls.Add(this.btnLine);
            this.grupoHerramientas.Controls.Add(this.btnPencil);
            this.grupoHerramientas.Controls.Add(this.btnRectangle);
            this.grupoHerramientas.Controls.Add(this.btnBorrar);
            this.grupoHerramientas.Controls.Add(this.btnCirculo);
            this.grupoHerramientas.Location = new System.Drawing.Point(12, 33);
            this.grupoHerramientas.Name = "grupoHerramientas";
            this.grupoHerramientas.Size = new System.Drawing.Size(151, 69);
            this.grupoHerramientas.TabIndex = 17;
            this.grupoHerramientas.TabStop = false;
            this.grupoHerramientas.Text = "Herramientas";
            // 
            // grupoColores
            // 
            this.grupoColores.Controls.Add(this.BotonColor1);
            this.grupoColores.Controls.Add(this.BotonColor8);
            this.grupoColores.Controls.Add(this.BotonColor7);
            this.grupoColores.Controls.Add(this.ColorLapiz);
            this.grupoColores.Controls.Add(this.label2);
            this.grupoColores.Controls.Add(this.BotonColor16);
            this.grupoColores.Controls.Add(this.BotonColor6);
            this.grupoColores.Controls.Add(this.BotonColor15);
            this.grupoColores.Controls.Add(this.BotonColor5);
            this.grupoColores.Controls.Add(this.BotonColor14);
            this.grupoColores.Controls.Add(this.BotonColor4);
            this.grupoColores.Controls.Add(this.BotonColor13);
            this.grupoColores.Controls.Add(this.BotonColor3);
            this.grupoColores.Controls.Add(this.BotonColor12);
            this.grupoColores.Controls.Add(this.BotonColor2);
            this.grupoColores.Controls.Add(this.BotonColor11);
            this.grupoColores.Controls.Add(this.BotonColor10);
            this.grupoColores.Controls.Add(this.BotonColor9);
            this.grupoColores.Location = new System.Drawing.Point(169, 33);
            this.grupoColores.Name = "grupoColores";
            this.grupoColores.Size = new System.Drawing.Size(256, 69);
            this.grupoColores.TabIndex = 18;
            this.grupoColores.TabStop = false;
            this.grupoColores.Text = "Colores";
            // 
            // BotonColor1
            // 
            this.BotonColor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonColor1.BackColor = System.Drawing.Color.White;
            this.BotonColor1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor1.Location = new System.Drawing.Point(47, 16);
            this.BotonColor1.Name = "BotonColor1";
            this.BotonColor1.Size = new System.Drawing.Size(20, 20);
            this.BotonColor1.TabIndex = 5;
            this.BotonColor1.UseVisualStyleBackColor = false;
            // 
            // BotonColor8
            // 
            this.BotonColor8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonColor8.BackColor = System.Drawing.Color.Magenta;
            this.BotonColor8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor8.Location = new System.Drawing.Point(229, 16);
            this.BotonColor8.Name = "BotonColor8";
            this.BotonColor8.Size = new System.Drawing.Size(20, 20);
            this.BotonColor8.TabIndex = 6;
            this.BotonColor8.UseVisualStyleBackColor = false;
            // 
            // BotonColor7
            // 
            this.BotonColor7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonColor7.BackColor = System.Drawing.Color.Blue;
            this.BotonColor7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor7.Location = new System.Drawing.Point(203, 16);
            this.BotonColor7.Name = "BotonColor7";
            this.BotonColor7.Size = new System.Drawing.Size(20, 20);
            this.BotonColor7.TabIndex = 7;
            this.BotonColor7.UseVisualStyleBackColor = false;
            // 
            // BotonColor16
            // 
            this.BotonColor16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonColor16.BackColor = System.Drawing.Color.Purple;
            this.BotonColor16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor16.Location = new System.Drawing.Point(229, 42);
            this.BotonColor16.Name = "BotonColor16";
            this.BotonColor16.Size = new System.Drawing.Size(20, 20);
            this.BotonColor16.TabIndex = 8;
            this.BotonColor16.UseVisualStyleBackColor = false;
            // 
            // BotonColor6
            // 
            this.BotonColor6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonColor6.BackColor = System.Drawing.Color.Cyan;
            this.BotonColor6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor6.Location = new System.Drawing.Point(177, 16);
            this.BotonColor6.Name = "BotonColor6";
            this.BotonColor6.Size = new System.Drawing.Size(20, 20);
            this.BotonColor6.TabIndex = 9;
            this.BotonColor6.UseVisualStyleBackColor = false;
            // 
            // BotonColor15
            // 
            this.BotonColor15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonColor15.BackColor = System.Drawing.Color.Navy;
            this.BotonColor15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor15.Location = new System.Drawing.Point(203, 42);
            this.BotonColor15.Name = "BotonColor15";
            this.BotonColor15.Size = new System.Drawing.Size(20, 20);
            this.BotonColor15.TabIndex = 10;
            this.BotonColor15.UseVisualStyleBackColor = false;
            // 
            // BotonColor5
            // 
            this.BotonColor5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonColor5.BackColor = System.Drawing.Color.Lime;
            this.BotonColor5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor5.Location = new System.Drawing.Point(151, 16);
            this.BotonColor5.Name = "BotonColor5";
            this.BotonColor5.Size = new System.Drawing.Size(20, 20);
            this.BotonColor5.TabIndex = 11;
            this.BotonColor5.UseVisualStyleBackColor = false;
            // 
            // BotonColor14
            // 
            this.BotonColor14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonColor14.BackColor = System.Drawing.Color.Teal;
            this.BotonColor14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor14.Location = new System.Drawing.Point(177, 42);
            this.BotonColor14.Name = "BotonColor14";
            this.BotonColor14.Size = new System.Drawing.Size(20, 20);
            this.BotonColor14.TabIndex = 12;
            this.BotonColor14.UseVisualStyleBackColor = false;
            // 
            // BotonColor4
            // 
            this.BotonColor4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonColor4.BackColor = System.Drawing.Color.Yellow;
            this.BotonColor4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor4.Location = new System.Drawing.Point(125, 16);
            this.BotonColor4.Name = "BotonColor4";
            this.BotonColor4.Size = new System.Drawing.Size(20, 20);
            this.BotonColor4.TabIndex = 13;
            this.BotonColor4.UseVisualStyleBackColor = false;
            // 
            // BotonColor13
            // 
            this.BotonColor13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonColor13.BackColor = System.Drawing.Color.Green;
            this.BotonColor13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor13.Location = new System.Drawing.Point(151, 42);
            this.BotonColor13.Name = "BotonColor13";
            this.BotonColor13.Size = new System.Drawing.Size(20, 20);
            this.BotonColor13.TabIndex = 14;
            this.BotonColor13.UseVisualStyleBackColor = false;
            // 
            // BotonColor3
            // 
            this.BotonColor3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonColor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BotonColor3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor3.Location = new System.Drawing.Point(99, 16);
            this.BotonColor3.Name = "BotonColor3";
            this.BotonColor3.Size = new System.Drawing.Size(20, 20);
            this.BotonColor3.TabIndex = 15;
            this.BotonColor3.UseVisualStyleBackColor = false;
            // 
            // BotonColor12
            // 
            this.BotonColor12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonColor12.BackColor = System.Drawing.Color.Olive;
            this.BotonColor12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor12.Location = new System.Drawing.Point(125, 42);
            this.BotonColor12.Name = "BotonColor12";
            this.BotonColor12.Size = new System.Drawing.Size(20, 20);
            this.BotonColor12.TabIndex = 16;
            this.BotonColor12.UseVisualStyleBackColor = false;
            // 
            // BotonColor2
            // 
            this.BotonColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonColor2.BackColor = System.Drawing.Color.Red;
            this.BotonColor2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor2.Location = new System.Drawing.Point(73, 16);
            this.BotonColor2.Name = "BotonColor2";
            this.BotonColor2.Size = new System.Drawing.Size(20, 20);
            this.BotonColor2.TabIndex = 17;
            this.BotonColor2.UseVisualStyleBackColor = false;
            // 
            // BotonColor11
            // 
            this.BotonColor11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonColor11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BotonColor11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor11.Location = new System.Drawing.Point(99, 42);
            this.BotonColor11.Name = "BotonColor11";
            this.BotonColor11.Size = new System.Drawing.Size(20, 20);
            this.BotonColor11.TabIndex = 18;
            this.BotonColor11.UseVisualStyleBackColor = false;
            // 
            // BotonColor10
            // 
            this.BotonColor10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonColor10.BackColor = System.Drawing.Color.Maroon;
            this.BotonColor10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor10.Location = new System.Drawing.Point(73, 42);
            this.BotonColor10.Name = "BotonColor10";
            this.BotonColor10.Size = new System.Drawing.Size(20, 20);
            this.BotonColor10.TabIndex = 19;
            this.BotonColor10.UseVisualStyleBackColor = false;
            // 
            // BotonColor9
            // 
            this.BotonColor9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonColor9.BackColor = System.Drawing.Color.Black;
            this.BotonColor9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor9.Location = new System.Drawing.Point(47, 42);
            this.BotonColor9.Name = "BotonColor9";
            this.BotonColor9.Size = new System.Drawing.Size(20, 20);
            this.BotonColor9.TabIndex = 20;
            this.BotonColor9.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // grupoTamanos
            // 
            this.grupoTamanos.Controls.Add(this.btnTamañoP);
            this.grupoTamanos.Controls.Add(this.btnTamañoM);
            this.grupoTamanos.Controls.Add(this.btnTamañoG);
            this.grupoTamanos.Location = new System.Drawing.Point(431, 33);
            this.grupoTamanos.Name = "grupoTamanos";
            this.grupoTamanos.Size = new System.Drawing.Size(119, 69);
            this.grupoTamanos.TabIndex = 20;
            this.grupoTamanos.TabStop = false;
            this.grupoTamanos.Text = "Tamaños";
            // 
            // btnTamañoG
            // 
            this.btnTamañoG.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTamañoG.Location = new System.Drawing.Point(6, 15);
            this.btnTamañoG.Name = "btnTamañoG";
            this.btnTamañoG.Size = new System.Drawing.Size(105, 20);
            this.btnTamañoG.TabIndex = 0;
            this.btnTamañoG.UseVisualStyleBackColor = false;
            // 
            // btnTamañoM
            // 
            this.btnTamañoM.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTamañoM.Location = new System.Drawing.Point(6, 36);
            this.btnTamañoM.Name = "btnTamañoM";
            this.btnTamañoM.Size = new System.Drawing.Size(105, 15);
            this.btnTamañoM.TabIndex = 1;
            this.btnTamañoM.UseVisualStyleBackColor = false;
            // 
            // btnTamañoP
            // 
            this.btnTamañoP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTamañoP.Location = new System.Drawing.Point(6, 54);
            this.btnTamañoP.Name = "btnTamañoP";
            this.btnTamañoP.Size = new System.Drawing.Size(105, 10);
            this.btnTamañoP.TabIndex = 2;
            this.btnTamañoP.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grupoTamanos);
            this.Controls.Add(this.grupoColores);
            this.Controls.Add(this.grupoHerramientas);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.btnPencil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCirculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorLapiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.grupoHerramientas.ResumeLayout(false);
            this.grupoColores.ResumeLayout(false);
            this.grupoColores.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grupoTamanos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ColorLapiz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Canvas;
        private IconPictureBox btnCirculo;
        private IconPictureBox btnRectangle;
        private IconPictureBox btnLine;
        private IconPictureBox btnBorrar;
        private IconPictureBox btnPencil;
        private System.Windows.Forms.GroupBox grupoHerramientas;
        private System.Windows.Forms.GroupBox grupoColores;
        private System.Windows.Forms.Button BotonColor1;
        private System.Windows.Forms.Button BotonColor8;
        private System.Windows.Forms.Button BotonColor7;
        private System.Windows.Forms.Button BotonColor16;
        private System.Windows.Forms.Button BotonColor6;
        private System.Windows.Forms.Button BotonColor15;
        private System.Windows.Forms.Button BotonColor5;
        private System.Windows.Forms.Button BotonColor14;
        private System.Windows.Forms.Button BotonColor4;
        private System.Windows.Forms.Button BotonColor13;
        private System.Windows.Forms.Button BotonColor3;
        private System.Windows.Forms.Button BotonColor12;
        private System.Windows.Forms.Button BotonColor2;
        private System.Windows.Forms.Button BotonColor11;
        private System.Windows.Forms.Button BotonColor10;
        private System.Windows.Forms.Button BotonColor9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.GroupBox grupoTamanos;
        private System.Windows.Forms.Button btnTamañoP;
        private System.Windows.Forms.Button btnTamañoM;
        private System.Windows.Forms.Button btnTamañoG;
    }
}