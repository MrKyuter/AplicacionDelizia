﻿namespace CapaPresentacion
{
    partial class RecepcionProducto
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_nombre = new Label();
            btn_restar = new Button();
            btn_sumar = new Button();
            lbl_cantidad = new Label();
            lbl_precio = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(3, 10);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(122, 15);
            lbl_nombre.TabIndex = 0;
            lbl_nombre.Text = "Nombre del producto";
            // 
            // btn_restar
            // 
            btn_restar.Location = new Point(3, 224);
            btn_restar.Name = "btn_restar";
            btn_restar.Size = new Size(23, 23);
            btn_restar.TabIndex = 1;
            btn_restar.Text = "-";
            btn_restar.UseVisualStyleBackColor = true;
            btn_restar.Click += btn_restar_Click;
            // 
            // btn_sumar
            // 
            btn_sumar.Location = new Point(174, 224);
            btn_sumar.Name = "btn_sumar";
            btn_sumar.Size = new Size(23, 23);
            btn_sumar.TabIndex = 2;
            btn_sumar.Text = "+";
            btn_sumar.UseVisualStyleBackColor = true;
            btn_sumar.Click += btn_sumar_Click;
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.AutoSize = true;
            lbl_cantidad.Location = new Point(32, 224);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(13, 15);
            lbl_cantidad.TabIndex = 3;
            lbl_cantidad.Text = "0";
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Location = new Point(3, 189);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(46, 15);
            lbl_precio.TabIndex = 4;
            lbl_precio.Text = "$Precio";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(14, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // RecepcionProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pictureBox1);
            Controls.Add(lbl_precio);
            Controls.Add(lbl_cantidad);
            Controls.Add(btn_sumar);
            Controls.Add(btn_restar);
            Controls.Add(lbl_nombre);
            Name = "RecepcionProducto";
            Size = new Size(200, 250);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nombre;
        private Button btn_restar;
        private Button btn_sumar;
        private Label lbl_cantidad;
        private Label lbl_precio;
        private PictureBox pictureBox1;
    }
}
