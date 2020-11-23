namespace FormFigurasAP
{
    partial class Rectangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rectangulo));
            this.lRRPerimetro = new System.Windows.Forms.Label();
            this.lRRArea = new System.Windows.Forms.Label();
            this.tBRAltura = new System.Windows.Forms.TextBox();
            this.IRAltura = new System.Windows.Forms.Label();
            this.RBCalcular = new System.Windows.Forms.Button();
            this.lRPerimetro = new System.Windows.Forms.Label();
            this.lRArea = new System.Windows.Forms.Label();
            this.tBRBase = new System.Windows.Forms.TextBox();
            this.lRBase = new System.Windows.Forms.Label();
            this.RBSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lRRPerimetro
            // 
            this.lRRPerimetro.AutoSize = true;
            this.lRRPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRRPerimetro.Location = new System.Drawing.Point(401, 273);
            this.lRRPerimetro.Name = "lRRPerimetro";
            this.lRRPerimetro.Size = new System.Drawing.Size(0, 29);
            this.lRRPerimetro.TabIndex = 26;
            // 
            // lRRArea
            // 
            this.lRRArea.AutoSize = true;
            this.lRRArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRRArea.Location = new System.Drawing.Point(401, 201);
            this.lRRArea.Name = "lRRArea";
            this.lRRArea.Size = new System.Drawing.Size(0, 29);
            this.lRRArea.TabIndex = 25;
            // 
            // tBRAltura
            // 
            this.tBRAltura.Location = new System.Drawing.Point(116, 111);
            this.tBRAltura.Name = "tBRAltura";
            this.tBRAltura.Size = new System.Drawing.Size(100, 29);
            this.tBRAltura.TabIndex = 24;
            // 
            // IRAltura
            // 
            this.IRAltura.AutoSize = true;
            this.IRAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IRAltura.Location = new System.Drawing.Point(74, 44);
            this.IRAltura.Name = "IRAltura";
            this.IRAltura.Size = new System.Drawing.Size(185, 29);
            this.IRAltura.TabIndex = 23;
            this.IRAltura.Text = "Ingresa la Altura";
            // 
            // RBCalcular
            // 
            this.RBCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBCalcular.Location = new System.Drawing.Point(544, 103);
            this.RBCalcular.Name = "RBCalcular";
            this.RBCalcular.Size = new System.Drawing.Size(113, 43);
            this.RBCalcular.TabIndex = 22;
            this.RBCalcular.Text = "Calcular";
            this.RBCalcular.UseVisualStyleBackColor = true;
            this.RBCalcular.Click += new System.EventHandler(this.RBCalcular_Click);
            // 
            // lRPerimetro
            // 
            this.lRPerimetro.AutoSize = true;
            this.lRPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRPerimetro.Location = new System.Drawing.Point(204, 273);
            this.lRPerimetro.Name = "lRPerimetro";
            this.lRPerimetro.Size = new System.Drawing.Size(125, 29);
            this.lRPerimetro.TabIndex = 21;
            this.lRPerimetro.Text = "Perímetro:";
            // 
            // lRArea
            // 
            this.lRArea.AutoSize = true;
            this.lRArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRArea.Location = new System.Drawing.Point(204, 201);
            this.lRArea.Name = "lRArea";
            this.lRArea.Size = new System.Drawing.Size(69, 29);
            this.lRArea.TabIndex = 20;
            this.lRArea.Text = "Área:";
            // 
            // tBRBase
            // 
            this.tBRBase.Location = new System.Drawing.Point(332, 111);
            this.tBRBase.Name = "tBRBase";
            this.tBRBase.Size = new System.Drawing.Size(100, 29);
            this.tBRBase.TabIndex = 19;
            // 
            // lRBase
            // 
            this.lRBase.AutoSize = true;
            this.lRBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRBase.Location = new System.Drawing.Point(290, 44);
            this.lRBase.Name = "lRBase";
            this.lRBase.Size = new System.Drawing.Size(179, 29);
            this.lRBase.TabIndex = 18;
            this.lRBase.Text = "Ingresa la Base";
            // 
            // RBSalir
            // 
            this.RBSalir.AutoSize = true;
            this.RBSalir.Location = new System.Drawing.Point(687, 395);
            this.RBSalir.Name = "RBSalir";
            this.RBSalir.Size = new System.Drawing.Size(101, 43);
            this.RBSalir.TabIndex = 17;
            this.RBSalir.Text = "Regresar";
            this.RBSalir.UseVisualStyleBackColor = true;
            this.RBSalir.Click += new System.EventHandler(this.RBSalir_Click);
            // 
            // Rectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lRRPerimetro);
            this.Controls.Add(this.lRRArea);
            this.Controls.Add(this.tBRAltura);
            this.Controls.Add(this.IRAltura);
            this.Controls.Add(this.RBCalcular);
            this.Controls.Add(this.lRPerimetro);
            this.Controls.Add(this.lRArea);
            this.Controls.Add(this.tBRBase);
            this.Controls.Add(this.lRBase);
            this.Controls.Add(this.RBSalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rectangulo";
            this.Text = "Rectangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lRRPerimetro;
        private System.Windows.Forms.Label lRRArea;
        private System.Windows.Forms.TextBox tBRAltura;
        private System.Windows.Forms.Label IRAltura;
        private System.Windows.Forms.Button RBCalcular;
        private System.Windows.Forms.Label lRPerimetro;
        private System.Windows.Forms.Label lRArea;
        private System.Windows.Forms.TextBox tBRBase;
        private System.Windows.Forms.Label lRBase;
        private System.Windows.Forms.Button RBSalir;
    }
}