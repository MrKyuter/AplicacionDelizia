﻿namespace CapaPresentacion
{
    partial class CocinaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CocinaMenu));
            btn_verpedidos = new Button();
            btn_salir = new Button();
            SuspendLayout();
            // 
            // btn_verpedidos
            // 
            btn_verpedidos.Location = new Point(358, 140);
            btn_verpedidos.Name = "btn_verpedidos";
            btn_verpedidos.Size = new Size(101, 23);
            btn_verpedidos.TabIndex = 0;
            btn_verpedidos.Text = "Ver pedidos";
            btn_verpedidos.UseVisualStyleBackColor = true;
            btn_verpedidos.Click += btn_verpedidos_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(358, 320);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(101, 23);
            btn_salir.TabIndex = 1;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // CocinaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(btn_salir);
            Controls.Add(btn_verpedidos);
            Name = "CocinaMenu";
            Size = new Size(807, 437);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_verpedidos;
        private Button btn_salir;
    }
}
