namespace WindowsFormsApplication1
{
    partial class Datos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdaltas = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(381, 263);
            this.dataGridView1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // cmdaltas
            // 
            this.cmdaltas.BackColor = System.Drawing.Color.Transparent;
            this.cmdaltas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdaltas.BackgroundImage")));
            this.cmdaltas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdaltas.Location = new System.Drawing.Point(48, 13);
            this.cmdaltas.Name = "cmdaltas";
            this.cmdaltas.Size = new System.Drawing.Size(30, 30);
            this.cmdaltas.TabIndex = 2;
            this.cmdaltas.UseVisualStyleBackColor = false;
            this.cmdaltas.Click += new System.EventHandler(this.cmdaltas_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.if_67_111124;
            this.cmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBuscar.Location = new System.Drawing.Point(267, 18);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(20, 20);
            this.cmdBuscar.TabIndex = 4;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdRegresar
            // 
            this.cmdRegresar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.if_arrow_back_216437;
            this.cmdRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRegresar.Location = new System.Drawing.Point(12, 12);
            this.cmdRegresar.Name = "cmdRegresar";
            this.cmdRegresar.Size = new System.Drawing.Size(30, 30);
            this.cmdRegresar.TabIndex = 1;
            this.cmdRegresar.UseVisualStyleBackColor = true;
            this.cmdRegresar.Click += new System.EventHandler(this.cmdRegresar_Click);
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(405, 323);
            this.Controls.Add(this.cmdaltas);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdRegresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(421, 362);
            this.MinimumSize = new System.Drawing.Size(421, 362);
            this.Name = "Datos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Información";
            this.Load += new System.EventHandler(this.Datos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button cmdRegresar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdaltas;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}