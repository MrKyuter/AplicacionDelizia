namespace CapaPresentacion
{
    partial class RepartoSeleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepartoSeleccion));
            pan_pedidos = new Panel();
            btn_volver = new Button();
            SuspendLayout();
            // 
            // pan_pedidos
            // 
            pan_pedidos.AutoScroll = true;
            pan_pedidos.AutoScrollMargin = new Size(10, 10);
            pan_pedidos.BackColor = Color.Transparent;
            pan_pedidos.Location = new Point(64, 129);
            pan_pedidos.Name = "pan_pedidos";
            pan_pedidos.Size = new Size(858, 266);
            pan_pedidos.TabIndex = 7;
            // 
            // btn_volver
            // 
            btn_volver.BackColor = Color.LightBlue;
            btn_volver.FlatStyle = FlatStyle.Popup;
            btn_volver.Font = new Font("Microsoft Sans Serif", 12.9999981F, FontStyle.Bold);
            btn_volver.ForeColor = SystemColors.ActiveCaptionText;
            btn_volver.Location = new Point(64, 417);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(92, 34);
            btn_volver.TabIndex = 6;
            btn_volver.Text = "Atrás";
            btn_volver.UseVisualStyleBackColor = false;
            btn_volver.Click += btn_volver_Click;
            // 
            // RepartoSeleccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(pan_pedidos);
            Controls.Add(btn_volver);
            Name = "RepartoSeleccion";
            Size = new Size(861, 454);
            Load += RepartoSeleccion_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel pan_pedidos;
        private Button btn_volver;
    }
}
