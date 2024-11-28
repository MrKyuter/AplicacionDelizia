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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecepcionConfirmacion));
            btn_anterior = new Button();
            btn_confirmar = new Button();
            pan_contenido = new Panel();
            pan_cliente = new Panel();
            txt_direccion = new TextBox();
            txt_telefono = new TextBox();
            txt_apellido = new TextBox();
            txt_nombre = new TextBox();
            pan_detalles = new Panel();
            lbl_total = new Label();
            pan_productos = new Panel();
            pan_contenido.SuspendLayout();
            pan_cliente.SuspendLayout();
            pan_detalles.SuspendLayout();
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
            btn_confirmar.BackgroundImage = (Image)resources.GetObject("btn_confirmar.BackgroundImage");
            btn_confirmar.Location = new Point(132, 313);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(110, 26);
            btn_confirmar.TabIndex = 1;
            btn_confirmar.UseVisualStyleBackColor = true;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // pan_contenido
            // 
            pan_contenido.Controls.Add(pan_cliente);
            pan_contenido.Controls.Add(pan_detalles);
            pan_contenido.Location = new Point(3, 3);
            pan_contenido.Name = "pan_contenido";
            pan_contenido.Size = new Size(855, 420);
            pan_contenido.TabIndex = 2;
            // 
            // pan_cliente
            // 
            pan_cliente.Controls.Add(txt_direccion);
            pan_cliente.Controls.Add(btn_confirmar);
            pan_cliente.Controls.Add(txt_telefono);
            pan_cliente.Controls.Add(txt_apellido);
            pan_cliente.Controls.Add(txt_nombre);
            pan_cliente.Location = new Point(94, 25);
            pan_cliente.Name = "pan_cliente";
            pan_cliente.Size = new Size(373, 385);
            pan_cliente.TabIndex = 0;
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(33, 273);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(353, 23);
            txt_direccion.TabIndex = 6;
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(33, 225);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(353, 23);
            txt_telefono.TabIndex = 4;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(33, 165);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(353, 23);
            txt_apellido.TabIndex = 2;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(33, 107);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(353, 23);
            txt_nombre.TabIndex = 0;
            // 
            // pan_detalles
            // 
            pan_detalles.BackColor = Color.Transparent;
            pan_detalles.Controls.Add(lbl_total);
            pan_detalles.Controls.Add(pan_productos);
            pan_detalles.Location = new Point(486, 45);
            pan_detalles.Name = "pan_detalles";
            pan_detalles.Size = new Size(366, 375);
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
            lbl_total.Click += lbl_total_Click;
            // 
            // pan_productos
            // 
            pan_productos.AutoScroll = true;
            pan_productos.Location = new Point(2, 65);
            pan_productos.Name = "pan_productos";
            pan_productos.Size = new Size(367, 300);
            pan_productos.TabIndex = 1;
            pan_productos.Paint += pan_productos_Paint;
            // 
            // RecepcionConfirmacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(pan_contenido);
            Controls.Add(btn_anterior);
            Name = "RecepcionConfirmacion";
            Size = new Size(861, 454);
            pan_contenido.ResumeLayout(false);
            pan_cliente.ResumeLayout(false);
            pan_cliente.PerformLayout();
            pan_detalles.ResumeLayout(false);
            pan_detalles.PerformLayout();
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
        private TextBox txt_direccion;
        private TextBox textBox4;
        private TextBox txt_telefono;
        private TextBox textBox3;
        private TextBox txt_apellido;
        private TextBox textBox2;
        private TextBox txt_nombre;
        private Panel pan_productos;
        private Label lbl_total;
    }
}
