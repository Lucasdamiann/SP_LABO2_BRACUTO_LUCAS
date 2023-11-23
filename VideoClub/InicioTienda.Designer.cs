namespace VideoClub
{
    partial class FrmInicioTienda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioTienda));
            lblNombreTienda = new Label();
            lblNombreUsuario = new Label();
            lblContraseña = new Label();
            txtNombreUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnIniciar = new Button();
            btnSalir = new Button();
            pbxIconoCd = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxIconoCd).BeginInit();
            SuspendLayout();
            // 
            // lblNombreTienda
            // 
            lblNombreTienda.AutoSize = true;
            lblNombreTienda.Location = new Point(68, 46);
            lblNombreTienda.Name = "lblNombreTienda";
            lblNombreTienda.Size = new Size(52, 15);
            lblNombreTienda.TabIndex = 0;
            lblNombreTienda.Text = "Tienda X";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(141, 131);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(109, 15);
            lblNombreUsuario.TabIndex = 1;
            lblNombreUsuario.Text = "Nombre de usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(141, 201);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(141, 149);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(232, 23);
            txtNombreUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(141, 219);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(232, 23);
            txtContraseña.TabIndex = 4;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(192, 265);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(118, 33);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(192, 304);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(118, 23);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pbxIconoCd
            // 
            pbxIconoCd.Image = (Image)resources.GetObject("pbxIconoCd.Image");
            pbxIconoCd.Location = new Point(43, 43);
            pbxIconoCd.Name = "pbxIconoCd";
            pbxIconoCd.Size = new Size(19, 18);
            pbxIconoCd.SizeMode = PictureBoxSizeMode.Zoom;
            pbxIconoCd.TabIndex = 7;
            pbxIconoCd.TabStop = false;
            // 
            // FrmInicioTienda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 379);
            Controls.Add(pbxIconoCd);
            Controls.Add(btnSalir);
            Controls.Add(btnIniciar);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblNombreTienda);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInicioTienda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TiendaX";
            Load += frmTienda_Load;
            ((System.ComponentModel.ISupportInitialize)pbxIconoCd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreTienda;
        private Label lblNombreUsuario;
        private Label lblContraseña;
        private TextBox txtNombreUsuario;
        private TextBox txtContraseña;
        private Button btnIniciar;
        private Button btnSalir;
        private PictureBox pbxIconoCd;
    }
}