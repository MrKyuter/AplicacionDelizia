namespace CapaPresentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txt_cedula = new TextBox();
            txt_contrasena = new TextBox();
            btn_cancelar = new Button();
            btn_entrar = new Button();
            SuspendLayout();
            // 
            // txt_cedula
            // 
            txt_cedula.Location = new Point(297, 151);
            txt_cedula.Name = "txt_cedula";
            txt_cedula.Size = new Size(186, 23);
            txt_cedula.TabIndex = 2;
            // 
            // txt_contrasena
            // 
            txt_contrasena.Location = new Point(297, 291);
            txt_contrasena.Name = "txt_contrasena";
            txt_contrasena.Size = new Size(186, 23);
            txt_contrasena.TabIndex = 3;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(254, 361);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 4;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_entrar
            // 
            btn_entrar.Location = new Point(518, 361);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(75, 23);
            btn_entrar.TabIndex = 5;
            btn_entrar.Text = "Iniciar Sesión";
            btn_entrar.UseVisualStyleBackColor = true;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(btn_entrar);
            Controls.Add(btn_cancelar);
            Controls.Add(txt_contrasena);
            Controls.Add(txt_cedula);
            Name = "Login";
            Size = new Size(842, 454);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_cedula;
        private TextBox txt_contrasena;
        private Button btn_cancelar;
        private Button btn_entrar;
    }
}
