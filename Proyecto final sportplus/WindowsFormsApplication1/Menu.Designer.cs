namespace WindowsFormsApplication1
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.cmdfutbol = new System.Windows.Forms.Button();
            this.cmdbase = new System.Windows.Forms.Button();
            this.cmdbasket = new System.Windows.Forms.Button();
            this.cmdamericano = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdfutbol
            // 
            this.cmdfutbol.BackColor = System.Drawing.Color.Transparent;
            this.cmdfutbol.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.volleyball_player_playing_001_512;
            this.cmdfutbol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdfutbol.Location = new System.Drawing.Point(21, 131);
            this.cmdfutbol.Name = "cmdfutbol";
            this.cmdfutbol.Size = new System.Drawing.Size(75, 63);
            this.cmdfutbol.TabIndex = 0;
            this.cmdfutbol.UseVisualStyleBackColor = false;
            this.cmdfutbol.Visible = false;
            this.cmdfutbol.Click += new System.EventHandler(this.cmdfutbol_Click);
            // 
            // cmdbase
            // 
            this.cmdbase.BackColor = System.Drawing.Color.Black;
            this.cmdbase.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.if_MB__Champions_League_81174;
            this.cmdbase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdbase.Location = new System.Drawing.Point(21, 223);
            this.cmdbase.Name = "cmdbase";
            this.cmdbase.Size = new System.Drawing.Size(75, 63);
            this.cmdbase.TabIndex = 1;
            this.cmdbase.UseVisualStyleBackColor = false;
            this.cmdbase.Visible = false;
            this.cmdbase.Click += new System.EventHandler(this.cmdbase_Click);
            // 
            // cmdbasket
            // 
            this.cmdbasket.BackColor = System.Drawing.Color.Transparent;
            this.cmdbasket.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.if_crew_2318458;
            this.cmdbasket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdbasket.Location = new System.Drawing.Point(129, 37);
            this.cmdbasket.Name = "cmdbasket";
            this.cmdbasket.Size = new System.Drawing.Size(75, 63);
            this.cmdbasket.TabIndex = 2;
            this.cmdbasket.UseVisualStyleBackColor = false;
            this.cmdbasket.Visible = false;
            this.cmdbasket.Click += new System.EventHandler(this.cmdbasket_Click);
            // 
            // cmdamericano
            // 
            this.cmdamericano.BackColor = System.Drawing.Color.Transparent;
            this.cmdamericano.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.if_sports_apparel_19_809679;
            this.cmdamericano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdamericano.ForeColor = System.Drawing.Color.Transparent;
            this.cmdamericano.Location = new System.Drawing.Point(234, 37);
            this.cmdamericano.Name = "cmdamericano";
            this.cmdamericano.Size = new System.Drawing.Size(75, 63);
            this.cmdamericano.TabIndex = 3;
            this.cmdamericano.UseVisualStyleBackColor = false;
            this.cmdamericano.Visible = false;
            this.cmdamericano.Click += new System.EventHandler(this.cmdamericano_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Captura;
            this.pictureBox1.Location = new System.Drawing.Point(114, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.if_22_171495;
            this.cmdSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdSalir.Location = new System.Drawing.Point(181, 269);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(42, 42);
            this.cmdSalir.TabIndex = 5;
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdMenu
            // 
            this.cmdMenu.BackColor = System.Drawing.Color.Transparent;
            this.cmdMenu.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.if_menu_alt_134216;
            this.cmdMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdMenu.Location = new System.Drawing.Point(21, 37);
            this.cmdMenu.Name = "cmdMenu";
            this.cmdMenu.Size = new System.Drawing.Size(75, 63);
            this.cmdMenu.TabIndex = 6;
            this.cmdMenu.UseVisualStyleBackColor = false;
            this.cmdMenu.Click += new System.EventHandler(this.cmdMenu_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(405, 323);
            this.Controls.Add(this.cmdMenu);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdamericano);
            this.Controls.Add(this.cmdbasket);
            this.Controls.Add(this.cmdbase);
            this.Controls.Add(this.cmdfutbol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(421, 362);
            this.MinimumSize = new System.Drawing.Size(421, 362);
            this.Name = "Menu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deportes";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdSalir;
        public System.Windows.Forms.Button cmdfutbol;
        public System.Windows.Forms.Button cmdbase;
        public System.Windows.Forms.Button cmdbasket;
        public System.Windows.Forms.Button cmdamericano;
        public System.Windows.Forms.Button cmdMenu;
    }
}

