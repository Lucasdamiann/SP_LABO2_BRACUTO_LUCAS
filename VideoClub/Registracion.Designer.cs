namespace VideoClub
{
    partial class frmRegistro
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblRegistro = new Label();
            txtRegistroNombre = new TextBox();
            txtRegistroApellido = new TextBox();
            txtRegistroDireccion = new TextBox();
            lblRegistroNombre = new Label();
            lblRegistroApellido = new Label();
            lblRegistroDireccion = new Label();
            btnRegistroRegistrar = new Button();
            SuspendLayout();
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegistro.Location = new Point(116, 49);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(100, 32);
            lblRegistro.TabIndex = 0;
            lblRegistro.Text = "Registro";
            // 
            // txtRegistroNombre
            // 
            txtRegistroNombre.Location = new Point(116, 129);
            txtRegistroNombre.Name = "txtRegistroNombre";
            txtRegistroNombre.Size = new Size(210, 23);
            txtRegistroNombre.TabIndex = 1;
            // 
            // txtRegistroApellido
            // 
            txtRegistroApellido.Location = new Point(116, 186);
            txtRegistroApellido.Name = "txtRegistroApellido";
            txtRegistroApellido.Size = new Size(210, 23);
            txtRegistroApellido.TabIndex = 2;
            // 
            // txtRegistroDireccion
            // 
            txtRegistroDireccion.Location = new Point(116, 249);
            txtRegistroDireccion.Name = "txtRegistroDireccion";
            txtRegistroDireccion.Size = new Size(210, 23);
            txtRegistroDireccion.TabIndex = 3;
            // 
            // lblRegistroNombre
            // 
            lblRegistroNombre.AutoSize = true;
            lblRegistroNombre.Location = new Point(30, 137);
            lblRegistroNombre.Name = "lblRegistroNombre";
            lblRegistroNombre.Size = new Size(54, 15);
            lblRegistroNombre.TabIndex = 4;
            lblRegistroNombre.Text = "Nombre:";
            // 
            // lblRegistroApellido
            // 
            lblRegistroApellido.AutoSize = true;
            lblRegistroApellido.Location = new Point(30, 194);
            lblRegistroApellido.Name = "lblRegistroApellido";
            lblRegistroApellido.Size = new Size(54, 15);
            lblRegistroApellido.TabIndex = 5;
            lblRegistroApellido.Text = "Apellido:";
            // 
            // lblRegistroDireccion
            // 
            lblRegistroDireccion.AutoSize = true;
            lblRegistroDireccion.Location = new Point(30, 257);
            lblRegistroDireccion.Name = "lblRegistroDireccion";
            lblRegistroDireccion.Size = new Size(60, 15);
            lblRegistroDireccion.TabIndex = 6;
            lblRegistroDireccion.Text = "Direccion:";
            // 
            // btnRegistroRegistrar
            // 
            btnRegistroRegistrar.Location = new Point(150, 290);
            btnRegistroRegistrar.Name = "btnRegistroRegistrar";
            btnRegistroRegistrar.Size = new Size(103, 39);
            btnRegistroRegistrar.TabIndex = 7;
            btnRegistroRegistrar.Text = "Registrar";
            btnRegistroRegistrar.UseVisualStyleBackColor = true;
            btnRegistroRegistrar.Click += btnRegistroRegistrar_Click;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 341);
            Controls.Add(btnRegistroRegistrar);
            Controls.Add(lblRegistroDireccion);
            Controls.Add(lblRegistroApellido);
            Controls.Add(lblRegistroNombre);
            Controls.Add(txtRegistroDireccion);
            Controls.Add(txtRegistroApellido);
            Controls.Add(txtRegistroNombre);
            Controls.Add(lblRegistro);
            Name = "frmRegistro";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistro;
        private TextBox txtRegistroNombre;
        private TextBox txtRegistroApellido;
        private TextBox txtRegistroDireccion;
        private Label lblRegistroNombre;
        private Label lblRegistroApellido;
        private Label lblRegistroDireccion;
        private Button btnRegistroRegistrar;
    }
}