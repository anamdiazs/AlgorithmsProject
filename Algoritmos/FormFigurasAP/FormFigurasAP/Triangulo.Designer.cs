namespace FormFigurasAP
{
    partial class Triangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Triangulo));
            this.TBSalir = new System.Windows.Forms.Button();
            this.TBCalcular = new System.Windows.Forms.Button();
            this.lTPerimetro = new System.Windows.Forms.Label();
            this.lTArea = new System.Windows.Forms.Label();
            this.tBTBase = new System.Windows.Forms.TextBox();
            this.lTBase = new System.Windows.Forms.Label();
            this.tBTAltura = new System.Windows.Forms.TextBox();
            this.ITAltura = new System.Windows.Forms.Label();
            this.lTRPerimetro = new System.Windows.Forms.Label();
            this.lTRArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBSalir
            // 
            this.TBSalir.AutoSize = true;
            this.TBSalir.Location = new System.Drawing.Point(687, 395);
            this.TBSalir.Name = "TBSalir";
            this.TBSalir.Size = new System.Drawing.Size(101, 43);
            this.TBSalir.TabIndex = 7;
            this.TBSalir.Text = "Regresar";
            this.TBSalir.UseVisualStyleBackColor = true;
            this.TBSalir.Click += new System.EventHandler(this.TBSalir_Click);
            // 
            // TBCalcular
            // 
            this.TBCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCalcular.Location = new System.Drawing.Point(544, 103);
            this.TBCalcular.Name = "TBCalcular";
            this.TBCalcular.Size = new System.Drawing.Size(113, 43);
            this.TBCalcular.TabIndex = 12;
            this.TBCalcular.Text = "Calcular";
            this.TBCalcular.UseVisualStyleBackColor = true;
            this.TBCalcular.Click += new System.EventHandler(this.TBCalcular_Click);
            // 
            // lTPerimetro
            // 
            this.lTPerimetro.AutoSize = true;
            this.lTPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTPerimetro.Location = new System.Drawing.Point(204, 273);
            this.lTPerimetro.Name = "lTPerimetro";
            this.lTPerimetro.Size = new System.Drawing.Size(125, 29);
            this.lTPerimetro.TabIndex = 11;
            this.lTPerimetro.Text = "Perímetro:";
            // 
            // lTArea
            // 
            this.lTArea.AutoSize = true;
            this.lTArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTArea.Location = new System.Drawing.Point(204, 201);
            this.lTArea.Name = "lTArea";
            this.lTArea.Size = new System.Drawing.Size(69, 29);
            this.lTArea.TabIndex = 10;
            this.lTArea.Text = "Área:";
            // 
            // tBTBase
            // 
            this.tBTBase.Location = new System.Drawing.Point(332, 111);
            this.tBTBase.Name = "tBTBase";
            this.tBTBase.Size = new System.Drawing.Size(100, 29);
            this.tBTBase.TabIndex = 9;
            // 
            // lTBase
            // 
            this.lTBase.AutoSize = true;
            this.lTBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTBase.Location = new System.Drawing.Point(290, 44);
            this.lTBase.Name = "lTBase";
            this.lTBase.Size = new System.Drawing.Size(179, 29);
            this.lTBase.TabIndex = 8;
            this.lTBase.Text = "Ingresa la Base";
            // 
            // tBTAltura
            // 
            this.tBTAltura.Location = new System.Drawing.Point(116, 111);
            this.tBTAltura.Name = "tBTAltura";
            this.tBTAltura.Size = new System.Drawing.Size(100, 29);
            this.tBTAltura.TabIndex = 14;
            // 
            // ITAltura
            // 
            this.ITAltura.AutoSize = true;
            this.ITAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITAltura.Location = new System.Drawing.Point(74, 44);
            this.ITAltura.Name = "ITAltura";
            this.ITAltura.Size = new System.Drawing.Size(185, 29);
            this.ITAltura.TabIndex = 13;
            this.ITAltura.Text = "Ingresa la Altura";
            // 
            // lTRPerimetro
            // 
            this.lTRPerimetro.AutoSize = true;
            this.lTRPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTRPerimetro.Location = new System.Drawing.Point(401, 273);
            this.lTRPerimetro.Name = "lTRPerimetro";
            this.lTRPerimetro.Size = new System.Drawing.Size(0, 29);
            this.lTRPerimetro.TabIndex = 16;
            // 
            // lTRArea
            // 
            this.lTRArea.AutoSize = true;
            this.lTRArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTRArea.Location = new System.Drawing.Point(401, 201);
            this.lTRArea.Name = "lTRArea";
            this.lTRArea.Size = new System.Drawing.Size(0, 29);
            this.lTRArea.TabIndex = 15;
            // 
            // Triangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lTRPerimetro);
            this.Controls.Add(this.lTRArea);
            this.Controls.Add(this.tBTAltura);
            this.Controls.Add(this.ITAltura);
            this.Controls.Add(this.TBCalcular);
            this.Controls.Add(this.lTPerimetro);
            this.Controls.Add(this.lTArea);
            this.Controls.Add(this.tBTBase);
            this.Controls.Add(this.lTBase);
            this.Controls.Add(this.TBSalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Triangulo";
            this.Text = "Triangulo";
            this.Load += new System.EventHandler(this.Triangulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TBSalir;
        private System.Windows.Forms.Button TBCalcular;
        private System.Windows.Forms.Label lTPerimetro;
        private System.Windows.Forms.Label lTArea;
        private System.Windows.Forms.TextBox tBTBase;
        private System.Windows.Forms.Label lTBase;
        private System.Windows.Forms.TextBox tBTAltura;
        private System.Windows.Forms.Label ITAltura;
        private System.Windows.Forms.Label lTRPerimetro;
        private System.Windows.Forms.Label lTRArea;
    }
}