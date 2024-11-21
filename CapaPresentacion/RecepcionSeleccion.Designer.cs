namespace CapaPresentacion
{
    partial class RecepcionSeleccion
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
            btn_cancelar = new Button();
            btn_siguiente = new Button();
            pan_productos = new Panel();
            SuspendLayout();
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(3, 400);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 0;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_siguiente
            // 
            btn_siguiente.Location = new Point(698, 400);
            btn_siguiente.Name = "btn_siguiente";
            btn_siguiente.Size = new Size(75, 23);
            btn_siguiente.TabIndex = 1;
            btn_siguiente.Text = "Siguiente";
            btn_siguiente.UseVisualStyleBackColor = true;
            btn_siguiente.Click += btn_siguiente_Click;
            // 
            // pan_productos
            // 
            pan_productos.AutoScroll = true;
            pan_productos.AutoScrollMargin = new Size(10, 10);
            pan_productos.Location = new Point(3, 3);
            pan_productos.Name = "pan_productos";
            pan_productos.Size = new Size(770, 391);
            pan_productos.TabIndex = 2;
            // 
            // RecepcionSeleccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pan_productos);
            Controls.Add(btn_siguiente);
            Controls.Add(btn_cancelar);
            Name = "RecepcionSeleccion";
            Size = new Size(776, 426);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_cancelar;
        private Button btn_siguiente;
        private Panel pan_productos;
    }
}
