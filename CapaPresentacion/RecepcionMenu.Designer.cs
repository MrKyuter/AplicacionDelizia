namespace CapaPresentacion
{
    partial class RecepcionMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecepcionMenu));
            btn_nuevopedido = new Button();
            btn_salir = new Button();
            SuspendLayout();
            // 
            // btn_nuevopedido
            // 
            btn_nuevopedido.BackgroundImage = (Image)resources.GetObject("btn_nuevopedido.BackgroundImage");
            btn_nuevopedido.Location = new Point(330, 154);
            btn_nuevopedido.Name = "btn_nuevopedido";
            btn_nuevopedido.Size = new Size(114, 27);
            btn_nuevopedido.TabIndex = 0;
            btn_nuevopedido.UseVisualStyleBackColor = true;
            btn_nuevopedido.Click += btn_nuevopedido_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.Location = new Point(330, 291);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(114, 24);
            btn_salir.TabIndex = 1;
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // RecepcionMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(btn_salir);
            Controls.Add(btn_nuevopedido);
            Name = "RecepcionMenu";
            Size = new Size(861, 454);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_nuevopedido;
        private Button btn_salir;
    }
}
