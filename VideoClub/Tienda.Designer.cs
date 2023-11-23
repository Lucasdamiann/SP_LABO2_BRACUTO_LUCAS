namespace VideoClub
{
    partial class frmTienda
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
            lblBienvenido = new Label();
            lstTitulos = new ListBox();
            ptbPortada = new PictureBox();
            grbCompraAlquiler = new GroupBox();
            btnAlquilar = new Button();
            btnComprar = new Button();
            gpbConsolas = new GroupBox();
            rdbPlayStation = new RadioButton();
            rdbSega = new RadioButton();
            rdbNES = new RadioButton();
            btnCerrarSesion = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbPortada).BeginInit();
            grbCompraAlquiler.SuspendLayout();
            gpbConsolas.SuspendLayout();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            lblBienvenido.Location = new Point(12, 9);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(142, 36);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "Bienvenido";
            // 
            // lstTitulos
            // 
            lstTitulos.BackColor = SystemColors.Menu;
            lstTitulos.FormattingEnabled = true;
            lstTitulos.ItemHeight = 15;
            lstTitulos.Location = new Point(163, 68);
            lstTitulos.Name = "lstTitulos";
            lstTitulos.Size = new Size(325, 364);
            lstTitulos.TabIndex = 1;
            lstTitulos.SelectedIndexChanged += lstTitulos_SelectedIndexChanged;
            // 
            // ptbPortada
            // 
            ptbPortada.Location = new Point(504, 68);
            ptbPortada.Name = "ptbPortada";
            ptbPortada.Size = new Size(284, 178);
            ptbPortada.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbPortada.TabIndex = 2;
            ptbPortada.TabStop = false;
            ptbPortada.Click += ptbPortada_Click;
            // 
            // grbCompraAlquiler
            // 
            grbCompraAlquiler.Controls.Add(btnAlquilar);
            grbCompraAlquiler.Controls.Add(btnComprar);
            grbCompraAlquiler.Location = new Point(504, 329);
            grbCompraAlquiler.Name = "grbCompraAlquiler";
            grbCompraAlquiler.Size = new Size(284, 109);
            grbCompraAlquiler.TabIndex = 3;
            grbCompraAlquiler.TabStop = false;
            grbCompraAlquiler.Text = "Compra/Alquiler";
            // 
            // btnAlquilar
            // 
            btnAlquilar.Location = new Point(161, 47);
            btnAlquilar.Name = "btnAlquilar";
            btnAlquilar.Size = new Size(86, 43);
            btnAlquilar.TabIndex = 5;
            btnAlquilar.Text = "Alquilar";
            btnAlquilar.UseVisualStyleBackColor = true;
            btnAlquilar.Click += btnAlquilar_Click;
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(36, 47);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(86, 43);
            btnComprar.TabIndex = 4;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // gpbConsolas
            // 
            gpbConsolas.BackgroundImageLayout = ImageLayout.Stretch;
            gpbConsolas.Controls.Add(rdbPlayStation);
            gpbConsolas.Controls.Add(rdbSega);
            gpbConsolas.Controls.Add(rdbNES);
            gpbConsolas.Location = new Point(12, 68);
            gpbConsolas.Name = "gpbConsolas";
            gpbConsolas.Size = new Size(136, 103);
            gpbConsolas.TabIndex = 4;
            gpbConsolas.TabStop = false;
            gpbConsolas.Text = "Consolas";
            // 
            // rdbPlayStation
            // 
            rdbPlayStation.AutoSize = true;
            rdbPlayStation.Location = new Point(13, 72);
            rdbPlayStation.Name = "rdbPlayStation";
            rdbPlayStation.Size = new Size(84, 19);
            rdbPlayStation.TabIndex = 2;
            rdbPlayStation.TabStop = true;
            rdbPlayStation.Text = "PlayStation";
            rdbPlayStation.UseVisualStyleBackColor = true;
            rdbPlayStation.CheckedChanged += rdbPlayStation_CheckedChanged;
            // 
            // rdbSega
            // 
            rdbSega.AutoSize = true;
            rdbSega.Location = new Point(13, 47);
            rdbSega.Name = "rdbSega";
            rdbSega.Size = new Size(93, 19);
            rdbSega.TabIndex = 1;
            rdbSega.TabStop = true;
            rdbSega.Text = "Sega Genesis";
            rdbSega.UseVisualStyleBackColor = true;
            rdbSega.CheckedChanged += rdbSega_CheckedChanged;
            // 
            // rdbNES
            // 
            rdbNES.AutoSize = true;
            rdbNES.Location = new Point(13, 22);
            rdbNES.Name = "rdbNES";
            rdbNES.Size = new Size(75, 19);
            rdbNES.TabIndex = 0;
            rdbNES.TabStop = true;
            rdbNES.Text = "Nintendo";
            rdbNES.UseVisualStyleBackColor = true;
            rdbNES.CheckedChanged += rdbNES_CheckedChanged;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(34, 376);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(84, 43);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // frmTienda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrarSesion);
            Controls.Add(gpbConsolas);
            Controls.Add(grbCompraAlquiler);
            Controls.Add(ptbPortada);
            Controls.Add(lstTitulos);
            Controls.Add(lblBienvenido);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmTienda";
            Text = "Tienda";
            Load += Tienda_Load;
            ((System.ComponentModel.ISupportInitialize)ptbPortada).EndInit();
            grbCompraAlquiler.ResumeLayout(false);
            gpbConsolas.ResumeLayout(false);
            gpbConsolas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private ListBox lstTitulos;
        private PictureBox ptbPortada;
        private GroupBox grbCompraAlquiler;
        private Button btnAlquilar;
        private Button btnComprar;
        private GroupBox gpbConsolas;
        private RadioButton rdbPlayStation;
        private RadioButton rdbSega;
        private RadioButton rdbNES;
        private Button btnCerrarSesion;
    }
}