namespace CapaPresentacion
{
    partial class RecepcionConfirmacion
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
            btn_anterior = new Button();
            btn_confirmar = new Button();
            pan_contenido = new Panel();
            pan_detalles = new Panel();
            lbl_total = new Label();
            pan_productos = new Panel();
            lbl_subtitulo1 = new Label();
            pan_cliente = new Panel();
            lbl_subtitulo = new Label();
            lbl_direccion = new Label();
            txt_direccion = new TextBox();
            lbl_telefono = new Label();
            txt_telefono = new TextBox();
            lbl_apellido = new Label();
            txt_apellido = new TextBox();
            lbl_nombre = new Label();
            txt_nombre = new TextBox();
            pan_contenido.SuspendLayout();
            pan_detalles.SuspendLayout();
            pan_cliente.SuspendLayout();
            SuspendLayout();
            // 
            // btn_anterior
            // 
            btn_anterior.Location = new Point(3, 400);
            btn_anterior.Name = "btn_anterior";
            btn_anterior.Size = new Size(75, 23);
            btn_anterior.TabIndex = 0;
            btn_anterior.Text = "Anterior";
            btn_anterior.UseVisualStyleBackColor = true;
            btn_anterior.Click += btn_anterior_Click;
            // 
            // btn_confirmar
            // 
            btn_confirmar.Location = new Point(698, 400);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(75, 23);
            btn_confirmar.TabIndex = 1;
            btn_confirmar.Text = "Confirmar";
            btn_confirmar.UseVisualStyleBackColor = true;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // pan_contenido
            // 
            pan_contenido.Controls.Add(pan_detalles);
            pan_contenido.Controls.Add(pan_cliente);
            pan_contenido.Location = new Point(3, 3);
            pan_contenido.Name = "pan_contenido";
            pan_contenido.Size = new Size(770, 391);
            pan_contenido.TabIndex = 2;
            // 
            // pan_detalles
            // 
            pan_detalles.Controls.Add(lbl_total);
            pan_detalles.Controls.Add(pan_productos);
            pan_detalles.Controls.Add(lbl_subtitulo1);
            pan_detalles.Location = new Point(394, 3);
            pan_detalles.Name = "pan_detalles";
            pan_detalles.Size = new Size(373, 385);
            pan_detalles.TabIndex = 1;
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Location = new Point(10, 340);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(73, 15);
            lbl_total.TabIndex = 2;
            lbl_total.Text = "$Precio total";
            // 
            // pan_productos
            // 
            pan_productos.AutoScroll = true;
            pan_productos.Location = new Point(3, 33);
            pan_productos.Name = "pan_productos";
            pan_productos.Size = new Size(367, 300);
            pan_productos.TabIndex = 1;
            // 
            // lbl_subtitulo1
            // 
            lbl_subtitulo1.AutoSize = true;
            lbl_subtitulo1.Location = new Point(10, 10);
            lbl_subtitulo1.Name = "lbl_subtitulo1";
            lbl_subtitulo1.Size = new Size(107, 15);
            lbl_subtitulo1.TabIndex = 0;
            lbl_subtitulo1.Text = "Detalles del pedido";
            // 
            // pan_cliente
            // 
            pan_cliente.Controls.Add(lbl_subtitulo);
            pan_cliente.Controls.Add(lbl_direccion);
            pan_cliente.Controls.Add(txt_direccion);
            pan_cliente.Controls.Add(lbl_telefono);
            pan_cliente.Controls.Add(txt_telefono);
            pan_cliente.Controls.Add(lbl_apellido);
            pan_cliente.Controls.Add(txt_apellido);
            pan_cliente.Controls.Add(lbl_nombre);
            pan_cliente.Controls.Add(txt_nombre);
            pan_cliente.Location = new Point(3, 3);
            pan_cliente.Name = "pan_cliente";
            pan_cliente.Size = new Size(373, 385);
            pan_cliente.TabIndex = 0;
            // 
            // lbl_subtitulo
            // 
            lbl_subtitulo.AutoSize = true;
            lbl_subtitulo.Location = new Point(10, 10);
            lbl_subtitulo.Name = "lbl_subtitulo";
            lbl_subtitulo.Size = new Size(105, 15);
            lbl_subtitulo.TabIndex = 10;
            lbl_subtitulo.Text = "Detalles del cliente";
            // 
            // lbl_direccion
            // 
            lbl_direccion.AutoSize = true;
            lbl_direccion.Location = new Point(10, 172);
            lbl_direccion.Name = "lbl_direccion";
            lbl_direccion.Size = new Size(57, 15);
            lbl_direccion.TabIndex = 7;
            lbl_direccion.Text = "Dirección";
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(10, 190);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(353, 23);
            txt_direccion.TabIndex = 6;
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.Location = new Point(10, 128);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(52, 15);
            lbl_telefono.TabIndex = 5;
            lbl_telefono.Text = "Teléfono";
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(10, 146);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(353, 23);
            txt_telefono.TabIndex = 4;
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(10, 84);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(51, 15);
            lbl_apellido.TabIndex = 3;
            lbl_apellido.Text = "Apellido";
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(10, 102);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(353, 23);
            txt_apellido.TabIndex = 2;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(10, 40);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 1;
            lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(10, 58);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(353, 23);
            txt_nombre.TabIndex = 0;
            // 
            // RecepcionConfirmacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(pan_contenido);
            Controls.Add(btn_confirmar);
            Controls.Add(btn_anterior);
            Name = "RecepcionConfirmacion";
            Size = new Size(776, 426);
            pan_contenido.ResumeLayout(false);
            pan_detalles.ResumeLayout(false);
            pan_detalles.PerformLayout();
            pan_cliente.ResumeLayout(false);
            pan_cliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_anterior;
        private Button btn_confirmar;
        private Panel pan_contenido;
        private Panel pan_detalles;
        private Panel pan_cliente;
        private Label label5;
        private TextBox textBox5;
        private Label lbl_direccion;
        private TextBox txt_direccion;
        private TextBox textBox4;
        private Label lbl_telefono;
        private TextBox txt_telefono;
        private TextBox textBox3;
        private Label lbl_apellido;
        private TextBox txt_apellido;
        private TextBox textBox2;
        private Label lbl_nombre;
        private TextBox txt_nombre;
        private Panel pan_productos;
        private Label lbl_subtitulo1;
        private Label lbl_total;
        private Label lbl_subtitulo;
    }
}
