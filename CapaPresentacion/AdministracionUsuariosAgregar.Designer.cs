namespace CapaPresentacion
{
    partial class AdministracionUsuariosAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracionUsuariosAgregar));
            panel1 = new Panel();
            button1 = new Button();
            txt_direccion = new TextBox();
            label6 = new Label();
            txt_apellido = new TextBox();
            label3 = new Label();
            txt_nombre = new TextBox();
            label2 = new Label();
            txt_cedula = new TextBox();
            label1 = new Label();
            btn_activo_no = new RadioButton();
            btn_activo_si = new RadioButton();
            menu_rol = new NumericUpDown();
            label5 = new Label();
            lbl_activo = new Label();
            label10 = new Label();
            label8 = new Label();
            txt_telefono = new TextBox();
            label4 = new Label();
            btn_ingresar = new Button();
            txt_correo = new TextBox();
            label7 = new Label();
            txt_contrasena = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu_rol).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txt_direccion);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_apellido);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_nombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_cedula);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_activo_no);
            panel1.Controls.Add(btn_activo_si);
            panel1.Controls.Add(menu_rol);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lbl_activo);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txt_telefono);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btn_ingresar);
            panel1.Controls.Add(txt_correo);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_contrasena);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(773, 423);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(22, 394);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 23;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(178, 316);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(225, 23);
            txt_direccion.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(178, 290);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 10;
            label6.Text = "Dirección";
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(178, 258);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(225, 23);
            txt_apellido.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 225);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(178, 188);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(225, 23);
            txt_nombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 159);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txt_cedula
            // 
            txt_cedula.Location = new Point(178, 122);
            txt_cedula.Name = "txt_cedula";
            txt_cedula.Size = new Size(225, 23);
            txt_cedula.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 95);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cédula";
            // 
            // btn_activo_no
            // 
            btn_activo_no.AutoSize = true;
            btn_activo_no.Location = new Point(502, 353);
            btn_activo_no.Name = "btn_activo_no";
            btn_activo_no.Size = new Size(41, 19);
            btn_activo_no.TabIndex = 18;
            btn_activo_no.TabStop = true;
            btn_activo_no.Text = "No";
            btn_activo_no.UseVisualStyleBackColor = true;
            // 
            // btn_activo_si
            // 
            btn_activo_si.AutoSize = true;
            btn_activo_si.Location = new Point(443, 353);
            btn_activo_si.Name = "btn_activo_si";
            btn_activo_si.Size = new Size(34, 19);
            btn_activo_si.TabIndex = 17;
            btn_activo_si.TabStop = true;
            btn_activo_si.Text = "Sí";
            btn_activo_si.UseVisualStyleBackColor = true;
            // 
            // menu_rol
            // 
            menu_rol.Location = new Point(592, 316);
            menu_rol.Name = "menu_rol";
            menu_rol.Size = new Size(120, 23);
            menu_rol.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(487, 304);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 12;
            label5.Text = "Rol";
            // 
            // lbl_activo
            // 
            lbl_activo.AutoSize = true;
            lbl_activo.Location = new Point(470, 324);
            lbl_activo.Name = "lbl_activo";
            lbl_activo.Size = new Size(41, 15);
            lbl_activo.TabIndex = 19;
            lbl_activo.Text = "Activo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(534, 69);
            label10.Name = "label10";
            label10.Size = new Size(85, 15);
            label10.TabIndex = 22;
            label10.Text = "Datos de inicio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(502, 95);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 14;
            label8.Text = "Teléfono";
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(487, 122);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(225, 23);
            txt_telefono.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(487, 159);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "Correo";
            // 
            // btn_ingresar
            // 
            btn_ingresar.Location = new Point(692, 394);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(75, 23);
            btn_ingresar.TabIndex = 16;
            btn_ingresar.Text = "Crear usuario";
            btn_ingresar.UseVisualStyleBackColor = true;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // txt_correo
            // 
            txt_correo.Location = new Point(487, 188);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(225, 23);
            txt_correo.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(487, 225);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 8;
            label7.Text = "Contraseña";
            // 
            // txt_contrasena
            // 
            txt_contrasena.Location = new Point(487, 258);
            txt_contrasena.Name = "txt_contrasena";
            txt_contrasena.Size = new Size(225, 23);
            txt_contrasena.TabIndex = 9;
            // 
            // AdministracionUsuariosAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AdministracionUsuariosAgregar";
            Size = new Size(776, 426);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menu_rol).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private TextBox txt_direccion;
        private Label label6;
        private TextBox txt_apellido;
        private Label label3;
        private TextBox txt_nombre;
        private Label label2;
        private TextBox txt_cedula;
        private Label label1;
        private Button btn_ingresar;
        private RadioButton btn_activo_no;
        private RadioButton btn_activo_si;
        private NumericUpDown menu_rol;
        private Label lbl_activo;
        private Label label10;
        private Label label8;
        private TextBox txt_telefono;
        private Label label4;
        private TextBox txt_correo;
        private Label label7;
        private TextBox txt_contrasena;
        private Button button1;
    }
}
