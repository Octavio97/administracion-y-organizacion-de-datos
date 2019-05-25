namespace Envios
{
    partial class Envios
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Envios));
            this.lblBienvenidos = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnCarga = new System.Windows.Forms.PictureBox();
            this.btnRuta = new System.Windows.Forms.PictureBox();
            this.btnChofer = new System.Windows.Forms.PictureBox();
            this.btnTransporte = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.PictureBox();
            this.fondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChofer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTransporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenidos
            // 
            this.lblBienvenidos.AutoSize = true;
            this.lblBienvenidos.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenidos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblBienvenidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidos.ForeColor = System.Drawing.Color.Black;
            this.lblBienvenidos.Location = new System.Drawing.Point(66, 24);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(159, 33);
            this.lblBienvenidos.TabIndex = 1;
            this.lblBienvenidos.Text = "Bienvenido";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(12, 113);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(74, 24);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(12, 151);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(106, 24);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(121, 113);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(151, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(121, 151);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(151, 20);
            this.txtContraseña.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::Envios.Properties.Resources.x;
            this.btnExit.Location = new System.Drawing.Point(247, 223);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 37);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 12;
            this.btnExit.TabStop = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::Envios.Properties.Resources.if_menu_alt_134216;
            this.btnMenu.Location = new System.Drawing.Point(111, 139);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 60);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 11;
            this.btnMenu.TabStop = false;
            this.btnMenu.Visible = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnCarga
            // 
            this.btnCarga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarga.Image = global::Envios.Properties.Resources.if_package_298837;
            this.btnCarga.Location = new System.Drawing.Point(26, 177);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(60, 60);
            this.btnCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCarga.TabIndex = 10;
            this.btnCarga.TabStop = false;
            this.btnCarga.Visible = false;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // btnRuta
            // 
            this.btnRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRuta.Image = global::Envios.Properties.Resources.if_Map___Location_Solid_Style_14_2216343;
            this.btnRuta.Location = new System.Drawing.Point(190, 102);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(60, 60);
            this.btnRuta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRuta.TabIndex = 9;
            this.btnRuta.TabStop = false;
            this.btnRuta.Visible = false;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // btnChofer
            // 
            this.btnChofer.BackColor = System.Drawing.Color.Transparent;
            this.btnChofer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChofer.Image = global::Envios.Properties.Resources.chofer;
            this.btnChofer.Location = new System.Drawing.Point(190, 177);
            this.btnChofer.Name = "btnChofer";
            this.btnChofer.Size = new System.Drawing.Size(60, 60);
            this.btnChofer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnChofer.TabIndex = 8;
            this.btnChofer.TabStop = false;
            this.btnChofer.Visible = false;
            this.btnChofer.Click += new System.EventHandler(this.btnChofer_Click);
            // 
            // btnTransporte
            // 
            this.btnTransporte.BackColor = System.Drawing.Color.Transparent;
            this.btnTransporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransporte.Image = global::Envios.Properties.Resources.if_truck_115775;
            this.btnTransporte.Location = new System.Drawing.Point(26, 102);
            this.btnTransporte.Name = "btnTransporte";
            this.btnTransporte.Size = new System.Drawing.Size(60, 60);
            this.btnTransporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTransporte.TabIndex = 7;
            this.btnTransporte.TabStop = false;
            this.btnTransporte.Visible = false;
            this.btnTransporte.Click += new System.EventHandler(this.btnTransporte_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Image = global::Envios.Properties.Resources.if_Tick_Mark_Dark_1398912;
            this.btnAceptar.Location = new System.Drawing.Point(111, 189);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(60, 60);
            this.btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // fondo
            // 
            this.fondo.Image = global::Envios.Properties.Resources.envios_a_cuba;
            this.fondo.Location = new System.Drawing.Point(0, -4);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(284, 89);
            this.fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fondo.TabIndex = 0;
            this.fondo.TabStop = false;
            // 
            // Envios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnCarga);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.btnChofer);
            this.Controls.Add(this.btnTransporte);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblBienvenidos);
            this.Controls.Add(this.fondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Envios";
            this.Text = "Envios DLL";
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChofer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTransporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fondo;
        private System.Windows.Forms.Label lblBienvenidos;
        private System.Windows.Forms.PictureBox btnTransporte;
        private System.Windows.Forms.PictureBox btnChofer;
        private System.Windows.Forms.PictureBox btnRuta;
        private System.Windows.Forms.PictureBox btnCarga;
        private System.Windows.Forms.ToolTip ttMensaje;
        public System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.Label lblContraseña;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.TextBox txtContraseña;
        public System.Windows.Forms.PictureBox btnAceptar;
        public System.Windows.Forms.PictureBox btnMenu;
        public System.Windows.Forms.PictureBox btnExit;
    }
}

