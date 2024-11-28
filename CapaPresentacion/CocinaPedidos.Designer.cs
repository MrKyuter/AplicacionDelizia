namespace CapaPresentacion
{
    partial class CocinaPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CocinaPedidos));
            pan_pedidos = new Panel();
            btn_volver = new Button();
            SuspendLayout();
            // 
            // pan_pedidos
            // 
            pan_pedidos.BackColor = Color.Transparent;
            pan_pedidos.Location = new Point(70, 165);
            pan_pedidos.Name = "pan_pedidos";
            pan_pedidos.Size = new Size(703, 239);
            pan_pedidos.TabIndex = 1;
            // 
            // btn_volver
            // 
            btn_volver.Location = new Point(3, 425);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(75, 23);
            btn_volver.TabIndex = 0;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += btn_volver_Click;
            // 
            // CocinaPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(pan_pedidos);
            Controls.Add(btn_volver);
            Name = "CocinaPedidos";
            Size = new Size(843, 451);
            ResumeLayout(false);
        }

        #endregion
        private Panel pan_pedidos;
        private Button btn_volver;
    }
}
