namespace VideoClub
{
    partial class frmMenu
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
            lblRegistros = new Label();
            btnRegistrosNuevo = new Button();
            btnRegistrosClientes = new Button();
            btnRegistrosSalir = new Button();
            btnTienda = new Button();
            SuspendLayout();
            // 
            // lblRegistros
            // 
            lblRegistros.AutoSize = true;
            lblRegistros.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegistros.Location = new Point(223, 9);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(110, 32);
            lblRegistros.TabIndex = 0;
            lblRegistros.Text = "Registros";
            // 
            // btnRegistrosNuevo
            // 
            btnRegistrosNuevo.Location = new Point(317, 83);
            btnRegistrosNuevo.Name = "btnRegistrosNuevo";
            btnRegistrosNuevo.Size = new Size(183, 110);
            btnRegistrosNuevo.TabIndex = 1;
            btnRegistrosNuevo.Text = "Nuevo";
            btnRegistrosNuevo.UseVisualStyleBackColor = true;
            btnRegistrosNuevo.Click += btnRegistrosNuevo_Click;
            // 
            // btnRegistrosClientes
            // 
            btnRegistrosClientes.Location = new Point(317, 219);
            btnRegistrosClientes.Name = "btnRegistrosClientes";
            btnRegistrosClientes.Size = new Size(183, 110);
            btnRegistrosClientes.TabIndex = 2;
            btnRegistrosClientes.Text = "Clientes";
            btnRegistrosClientes.UseVisualStyleBackColor = true;
            btnRegistrosClientes.Click += btnRegistrosClientes_Click;
            // 
            // btnRegistrosSalir
            // 
            btnRegistrosSalir.Location = new Point(69, 401);
            btnRegistrosSalir.Name = "btnRegistrosSalir";
            btnRegistrosSalir.Size = new Size(97, 47);
            btnRegistrosSalir.TabIndex = 3;
            btnRegistrosSalir.Text = "Salir";
            btnRegistrosSalir.UseVisualStyleBackColor = true;
            btnRegistrosSalir.Click += btnRegistrosSalir_Click;
            // 
            // btnTienda
            // 
            btnTienda.Location = new Point(69, 83);
            btnTienda.Name = "btnTienda";
            btnTienda.Size = new Size(224, 246);
            btnTienda.TabIndex = 4;
            btnTienda.Text = "Tienda";
            btnTienda.UseVisualStyleBackColor = true;
            btnTienda.Click += btnTienda_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 480);
            Controls.Add(btnTienda);
            Controls.Add(btnRegistrosSalir);
            Controls.Add(btnRegistrosClientes);
            Controls.Add(btnRegistrosNuevo);
            Controls.Add(lblRegistros);
            Name = "frmMenu";
            Text = "Registros";
            Load += frmRegistros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistros;
        private Button btnRegistrosNuevo;
        private Button btnRegistrosClientes;
        private Button btnRegistrosSalir;
        private Button btnTienda;
    }
}