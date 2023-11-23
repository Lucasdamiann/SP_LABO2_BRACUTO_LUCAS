namespace VideoClub
{
    partial class frmClientesRegistrados
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
            lblClientesRegistrados = new Label();
            btnClientesRegistradosBuscar = new Button();
            lstClientesRegistrados = new ListBox();
            txtClientesRegistradosBuscar = new TextBox();
            btnClientesRegistradosSalir = new Button();
            btnClientesRegistradosObtener = new Button();
            SuspendLayout();
            // 
            // lblClientesRegistrados
            // 
            lblClientesRegistrados.AutoSize = true;
            lblClientesRegistrados.Location = new Point(37, 23);
            lblClientesRegistrados.Name = "lblClientesRegistrados";
            lblClientesRegistrados.Size = new Size(113, 15);
            lblClientesRegistrados.TabIndex = 0;
            lblClientesRegistrados.Text = "Clientes Registrados";
            lblClientesRegistrados.Click += lblClientesRegistrados_Click;
            // 
            // btnClientesRegistradosBuscar
            // 
            btnClientesRegistradosBuscar.Location = new Point(22, 171);
            btnClientesRegistradosBuscar.Name = "btnClientesRegistradosBuscar";
            btnClientesRegistradosBuscar.Size = new Size(176, 44);
            btnClientesRegistradosBuscar.TabIndex = 1;
            btnClientesRegistradosBuscar.Text = "Buscar";
            btnClientesRegistradosBuscar.UseVisualStyleBackColor = true;
            btnClientesRegistradosBuscar.Click += btnClientesRegistradosBuscar_Click;
            // 
            // lstClientesRegistrados
            // 
            lstClientesRegistrados.FormattingEnabled = true;
            lstClientesRegistrados.ItemHeight = 15;
            lstClientesRegistrados.Location = new Point(239, 67);
            lstClientesRegistrados.Name = "lstClientesRegistrados";
            lstClientesRegistrados.Size = new Size(417, 469);
            lstClientesRegistrados.TabIndex = 2;
            lstClientesRegistrados.SelectedIndexChanged += lstClientesRegistrados_SelectedIndexChanged;
            // 
            // txtClientesRegistradosBuscar
            // 
            txtClientesRegistradosBuscar.Location = new Point(22, 221);
            txtClientesRegistradosBuscar.Name = "txtClientesRegistradosBuscar";
            txtClientesRegistradosBuscar.Size = new Size(176, 23);
            txtClientesRegistradosBuscar.TabIndex = 3;
            // 
            // btnClientesRegistradosSalir
            // 
            btnClientesRegistradosSalir.Location = new Point(22, 495);
            btnClientesRegistradosSalir.Name = "btnClientesRegistradosSalir";
            btnClientesRegistradosSalir.Size = new Size(176, 41);
            btnClientesRegistradosSalir.TabIndex = 4;
            btnClientesRegistradosSalir.Text = "Salir";
            btnClientesRegistradosSalir.UseVisualStyleBackColor = true;
            btnClientesRegistradosSalir.Click += btnClientesRegistradosSalir_Click;
            // 
            // btnClientesRegistradosObtener
            // 
            btnClientesRegistradosObtener.Location = new Point(22, 67);
            btnClientesRegistradosObtener.Name = "btnClientesRegistradosObtener";
            btnClientesRegistradosObtener.Size = new Size(176, 44);
            btnClientesRegistradosObtener.TabIndex = 5;
            btnClientesRegistradosObtener.Text = "Obtener Clientes";
            btnClientesRegistradosObtener.UseVisualStyleBackColor = true;
            btnClientesRegistradosObtener.Click += btnClientesRegistradosObtener_Click;
            // 
            // frmClientesRegistrados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 556);
            Controls.Add(btnClientesRegistradosObtener);
            Controls.Add(btnClientesRegistradosSalir);
            Controls.Add(txtClientesRegistradosBuscar);
            Controls.Add(lstClientesRegistrados);
            Controls.Add(btnClientesRegistradosBuscar);
            Controls.Add(lblClientesRegistrados);
            Name = "frmClientesRegistrados";
            Text = "Clientes Registrados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClientesRegistrados;
        private Button btnClientesRegistradosBuscar;
        private ListBox lstClientesRegistrados;
        private TextBox txtClientesRegistradosBuscar;
        private Button btnClientesRegistradosSalir;
        private Button btnClientesRegistradosObtener;
    }
}