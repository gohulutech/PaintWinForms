using FontAwesome.Sharp;
using System.Drawing;

namespace Interfaz
{
    partial class MainWindow
    {
        var bitmap = IconChar.BatteryEmpty.ToBitmap(16, Color.Black); // Windows Forms

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
            this.AnchoLineas = new System.Windows.Forms.Panel();
            this.btnCirculo = new FontAwesome.Sharp.IconButton();
            this.BotonBorrar = new System.Windows.Forms.Button();
            this.BotonRectangulo = new System.Windows.Forms.Button();
            this.BotonLinea = new System.Windows.Forms.Button();
            this.ColorFondo = new System.Windows.Forms.PictureBox();
            this.ColorLapiz = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.AnchoLineas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorLapiz)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // AnchoLineas
            // 
            this.AnchoLineas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnchoLineas.Controls.Add(this.btnCirculo);
            this.AnchoLineas.Controls.Add(this.BotonBorrar);
            this.AnchoLineas.Controls.Add(this.BotonRectangulo);
            this.AnchoLineas.Controls.Add(this.BotonLinea);
            this.AnchoLineas.Location = new System.Drawing.Point(12, 12);
            this.AnchoLineas.Name = "AnchoLineas";
            this.AnchoLineas.Size = new System.Drawing.Size(220, 57);
            this.AnchoLineas.TabIndex = 10;
            // 
            // btnCirculo
            // 
            this.btnCirculo.BackColor = System.Drawing.SystemColors.Control;
            this.btnCirculo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCirculo.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.btnCirculo.IconColor = System.Drawing.Color.Black;
            this.btnCirculo.IconSize = 17;
            this.btnCirculo.Location = new System.Drawing.Point(3, 3);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Rotation = 0D;
            this.btnCirculo.Size = new System.Drawing.Size(24, 24);
            this.btnCirculo.TabIndex = 17;
            this.btnCirculo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCirculo.UseVisualStyleBackColor = false;
            // 
            // BotonBorrar
            // 
            this.BotonBorrar.Location = new System.Drawing.Point(153, 13);
            this.BotonBorrar.Name = "BotonBorrar";
            this.BotonBorrar.Size = new System.Drawing.Size(60, 31);
            this.BotonBorrar.TabIndex = 8;
            this.BotonBorrar.Text = "Limpiar";
            this.BotonBorrar.UseVisualStyleBackColor = true;
            // 
            // BotonRectangulo
            // 
            this.BotonRectangulo.Location = new System.Drawing.Point(53, 6);
            this.BotonRectangulo.Name = "BotonRectangulo";
            this.BotonRectangulo.Size = new System.Drawing.Size(44, 44);
            this.BotonRectangulo.TabIndex = 2;
            this.BotonRectangulo.UseVisualStyleBackColor = true;
            // 
            // BotonLinea
            // 
            this.BotonLinea.Location = new System.Drawing.Point(103, 6);
            this.BotonLinea.Name = "BotonLinea";
            this.BotonLinea.Size = new System.Drawing.Size(44, 44);
            this.BotonLinea.TabIndex = 3;
            this.BotonLinea.UseVisualStyleBackColor = true;
            // 
            // ColorFondo
            // 
            this.ColorFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorFondo.BackColor = System.Drawing.Color.White;
            this.ColorFondo.Location = new System.Drawing.Point(531, 37);
            this.ColorFondo.Name = "ColorFondo";
            this.ColorFondo.Size = new System.Drawing.Size(28, 26);
            this.ColorFondo.TabIndex = 14;
            this.ColorFondo.TabStop = false;
            // 
            // ColorLapiz
            // 
            this.ColorLapiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorLapiz.BackColor = System.Drawing.Color.Black;
            this.ColorLapiz.Location = new System.Drawing.Point(492, 37);
            this.ColorLapiz.Name = "ColorLapiz";
            this.ColorLapiz.Size = new System.Drawing.Size(28, 26);
            this.ColorLapiz.TabIndex = 15;
            this.ColorLapiz.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Linea";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fondo";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BotonColor1);
            this.panel1.Controls.Add(this.BotonColor8);
            this.panel1.Controls.Add(this.BotonColor7);
            this.panel1.Controls.Add(this.BotonColor16);
            this.panel1.Controls.Add(this.BotonColor6);
            this.panel1.Controls.Add(this.BotonColor15);
            this.panel1.Controls.Add(this.BotonColor5);
            this.panel1.Controls.Add(this.BotonColor14);
            this.panel1.Controls.Add(this.BotonColor4);
            this.panel1.Controls.Add(this.BotonColor13);
            this.panel1.Controls.Add(this.BotonColor3);
            this.panel1.Controls.Add(this.BotonColor12);
            this.panel1.Controls.Add(this.BotonColor2);
            this.panel1.Controls.Add(this.BotonColor11);
            this.panel1.Controls.Add(this.BotonColor10);
            this.panel1.Controls.Add(this.BotonColor9);
            this.panel1.Location = new System.Drawing.Point(576, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 58);
            this.panel1.TabIndex = 11;
            // 
            // BotonColor1
            // 
            this.BotonColor1.BackColor = System.Drawing.Color.White;
            this.BotonColor1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor1.Location = new System.Drawing.Point(5, 5);
            this.BotonColor1.Name = "BotonColor1";
            this.BotonColor1.Size = new System.Drawing.Size(20, 20);
            this.BotonColor1.TabIndex = 4;
            this.BotonColor1.UseVisualStyleBackColor = false;
            // 
            // BotonColor8
            // 
            this.BotonColor8.BackColor = System.Drawing.Color.Magenta;
            this.BotonColor8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor8.Location = new System.Drawing.Point(187, 5);
            this.BotonColor8.Name = "BotonColor8";
            this.BotonColor8.Size = new System.Drawing.Size(20, 20);
            this.BotonColor8.TabIndex = 4;
            this.BotonColor8.UseVisualStyleBackColor = false;
            // 
            // BotonColor7
            // 
            this.BotonColor7.BackColor = System.Drawing.Color.Blue;
            this.BotonColor7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor7.Location = new System.Drawing.Point(161, 5);
            this.BotonColor7.Name = "BotonColor7";
            this.BotonColor7.Size = new System.Drawing.Size(20, 20);
            this.BotonColor7.TabIndex = 4;
            this.BotonColor7.UseVisualStyleBackColor = false;
            // 
            // BotonColor16
            // 
            this.BotonColor16.BackColor = System.Drawing.Color.Purple;
            this.BotonColor16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor16.Location = new System.Drawing.Point(187, 31);
            this.BotonColor16.Name = "BotonColor16";
            this.BotonColor16.Size = new System.Drawing.Size(20, 20);
            this.BotonColor16.TabIndex = 4;
            this.BotonColor16.UseVisualStyleBackColor = false;
            // 
            // BotonColor6
            // 
            this.BotonColor6.BackColor = System.Drawing.Color.Cyan;
            this.BotonColor6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor6.Location = new System.Drawing.Point(135, 5);
            this.BotonColor6.Name = "BotonColor6";
            this.BotonColor6.Size = new System.Drawing.Size(20, 20);
            this.BotonColor6.TabIndex = 4;
            this.BotonColor6.UseVisualStyleBackColor = false;
            // 
            // BotonColor15
            // 
            this.BotonColor15.BackColor = System.Drawing.Color.Navy;
            this.BotonColor15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor15.Location = new System.Drawing.Point(161, 31);
            this.BotonColor15.Name = "BotonColor15";
            this.BotonColor15.Size = new System.Drawing.Size(20, 20);
            this.BotonColor15.TabIndex = 4;
            this.BotonColor15.UseVisualStyleBackColor = false;
            // 
            // BotonColor5
            // 
            this.BotonColor5.BackColor = System.Drawing.Color.Lime;
            this.BotonColor5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor5.Location = new System.Drawing.Point(109, 5);
            this.BotonColor5.Name = "BotonColor5";
            this.BotonColor5.Size = new System.Drawing.Size(20, 20);
            this.BotonColor5.TabIndex = 4;
            this.BotonColor5.UseVisualStyleBackColor = false;
            // 
            // BotonColor14
            // 
            this.BotonColor14.BackColor = System.Drawing.Color.Teal;
            this.BotonColor14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor14.Location = new System.Drawing.Point(135, 31);
            this.BotonColor14.Name = "BotonColor14";
            this.BotonColor14.Size = new System.Drawing.Size(20, 20);
            this.BotonColor14.TabIndex = 4;
            this.BotonColor14.UseVisualStyleBackColor = false;
            // 
            // BotonColor4
            // 
            this.BotonColor4.BackColor = System.Drawing.Color.Yellow;
            this.BotonColor4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor4.Location = new System.Drawing.Point(83, 5);
            this.BotonColor4.Name = "BotonColor4";
            this.BotonColor4.Size = new System.Drawing.Size(20, 20);
            this.BotonColor4.TabIndex = 4;
            this.BotonColor4.UseVisualStyleBackColor = false;
            // 
            // BotonColor13
            // 
            this.BotonColor13.BackColor = System.Drawing.Color.Green;
            this.BotonColor13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor13.Location = new System.Drawing.Point(109, 31);
            this.BotonColor13.Name = "BotonColor13";
            this.BotonColor13.Size = new System.Drawing.Size(20, 20);
            this.BotonColor13.TabIndex = 4;
            this.BotonColor13.UseVisualStyleBackColor = false;
            // 
            // BotonColor3
            // 
            this.BotonColor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BotonColor3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor3.Location = new System.Drawing.Point(57, 5);
            this.BotonColor3.Name = "BotonColor3";
            this.BotonColor3.Size = new System.Drawing.Size(20, 20);
            this.BotonColor3.TabIndex = 4;
            this.BotonColor3.UseVisualStyleBackColor = false;
            // 
            // BotonColor12
            // 
            this.BotonColor12.BackColor = System.Drawing.Color.Olive;
            this.BotonColor12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor12.Location = new System.Drawing.Point(83, 31);
            this.BotonColor12.Name = "BotonColor12";
            this.BotonColor12.Size = new System.Drawing.Size(20, 20);
            this.BotonColor12.TabIndex = 4;
            this.BotonColor12.UseVisualStyleBackColor = false;
            // 
            // BotonColor2
            // 
            this.BotonColor2.BackColor = System.Drawing.Color.Red;
            this.BotonColor2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor2.Location = new System.Drawing.Point(31, 5);
            this.BotonColor2.Name = "BotonColor2";
            this.BotonColor2.Size = new System.Drawing.Size(20, 20);
            this.BotonColor2.TabIndex = 4;
            this.BotonColor2.UseVisualStyleBackColor = false;
            // 
            // BotonColor11
            // 
            this.BotonColor11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BotonColor11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor11.Location = new System.Drawing.Point(57, 31);
            this.BotonColor11.Name = "BotonColor11";
            this.BotonColor11.Size = new System.Drawing.Size(20, 20);
            this.BotonColor11.TabIndex = 4;
            this.BotonColor11.UseVisualStyleBackColor = false;
            // 
            // BotonColor10
            // 
            this.BotonColor10.BackColor = System.Drawing.Color.Maroon;
            this.BotonColor10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor10.Location = new System.Drawing.Point(31, 31);
            this.BotonColor10.Name = "BotonColor10";
            this.BotonColor10.Size = new System.Drawing.Size(20, 20);
            this.BotonColor10.TabIndex = 4;
            this.BotonColor10.UseVisualStyleBackColor = false;
            // 
            // BotonColor9
            // 
            this.BotonColor9.BackColor = System.Drawing.Color.Black;
            this.BotonColor9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonColor9.Location = new System.Drawing.Point(5, 31);
            this.BotonColor9.Name = "BotonColor9";
            this.BotonColor9.Size = new System.Drawing.Size(20, 20);
            this.BotonColor9.TabIndex = 4;
            this.BotonColor9.UseVisualStyleBackColor = false;
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Canvas.Location = new System.Drawing.Point(12, 75);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(778, 363);
            this.Canvas.TabIndex = 16;
            this.Canvas.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.ColorFondo);
            this.Controls.Add(this.ColorLapiz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AnchoLineas);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.AnchoLineas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColorFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorLapiz)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel AnchoLineas;
        private System.Windows.Forms.Button BotonBorrar;
        private System.Windows.Forms.Button BotonRectangulo;
        private System.Windows.Forms.Button BotonLinea;
        private System.Windows.Forms.PictureBox ColorFondo;
        private System.Windows.Forms.PictureBox ColorLapiz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.PictureBox Canvas;
        private IconButton btnCirculo;
    }
}