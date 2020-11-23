namespace FormFigurasAP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LTitulo = new System.Windows.Forms.Label();
            this.PBCirculo = new System.Windows.Forms.PictureBox();
            this.PBTriangulo = new System.Windows.Forms.PictureBox();
            this.PBCuadrado = new System.Windows.Forms.PictureBox();
            this.PBRectangualo = new System.Windows.Forms.PictureBox();
            this.BSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBCirculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTriangulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCuadrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBRectangualo)).BeginInit();
            this.SuspendLayout();
            // 
            // LTitulo
            // 
            this.LTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(194, 9);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(673, 131);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Escoge una Figura para calcular su Área y Perímetro";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBCirculo
            // 
            this.PBCirculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBCirculo.Image = global::FormFigurasAP.Properties.Resources.circulo;
            this.PBCirculo.Location = new System.Drawing.Point(203, 200);
            this.PBCirculo.Name = "PBCirculo";
            this.PBCirculo.Size = new System.Drawing.Size(200, 193);
            this.PBCirculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBCirculo.TabIndex = 1;
            this.PBCirculo.TabStop = false;
            this.PBCirculo.Click += new System.EventHandler(this.PBCirculo_Click);
            // 
            // PBTriangulo
            // 
            this.PBTriangulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBTriangulo.Image = global::FormFigurasAP.Properties.Resources.triangulo;
            this.PBTriangulo.Location = new System.Drawing.Point(659, 200);
            this.PBTriangulo.Name = "PBTriangulo";
            this.PBTriangulo.Size = new System.Drawing.Size(223, 193);
            this.PBTriangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBTriangulo.TabIndex = 2;
            this.PBTriangulo.TabStop = false;
            this.PBTriangulo.Click += new System.EventHandler(this.PBTriangulo_Click);
            // 
            // PBCuadrado
            // 
            this.PBCuadrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBCuadrado.Image = global::FormFigurasAP.Properties.Resources.cuadrado;
            this.PBCuadrado.Location = new System.Drawing.Point(217, 444);
            this.PBCuadrado.Name = "PBCuadrado";
            this.PBCuadrado.Size = new System.Drawing.Size(186, 190);
            this.PBCuadrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBCuadrado.TabIndex = 3;
            this.PBCuadrado.TabStop = false;
            this.PBCuadrado.Click += new System.EventHandler(this.PBCuadrado_Click);
            // 
            // PBRectangualo
            // 
            this.PBRectangualo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBRectangualo.Image = global::FormFigurasAP.Properties.Resources.rectangulo;
            this.PBRectangualo.Location = new System.Drawing.Point(637, 459);
            this.PBRectangualo.Name = "PBRectangualo";
            this.PBRectangualo.Size = new System.Drawing.Size(269, 140);
            this.PBRectangualo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBRectangualo.TabIndex = 4;
            this.PBRectangualo.TabStop = false;
            this.PBRectangualo.Click += new System.EventHandler(this.PBRectangualo_Click);
            // 
            // BSalir
            // 
            this.BSalir.AutoSize = true;
            this.BSalir.Location = new System.Drawing.Point(962, 636);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(95, 43);
            this.BSalir.TabIndex = 5;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1081, 701);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.PBRectangualo);
            this.Controls.Add(this.PBCuadrado);
            this.Controls.Add(this.PBTriangulo);
            this.Controls.Add(this.PBCirculo);
            this.Controls.Add(this.LTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Figuras: Área y Perímetro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBCirculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTriangulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCuadrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBRectangualo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.PictureBox PBCirculo;
        private System.Windows.Forms.PictureBox PBTriangulo;
        private System.Windows.Forms.PictureBox PBCuadrado;
        private System.Windows.Forms.PictureBox PBRectangualo;
        private System.Windows.Forms.Button BSalir;
    }
}

