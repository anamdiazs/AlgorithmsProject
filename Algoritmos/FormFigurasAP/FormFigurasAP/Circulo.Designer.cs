namespace FormFigurasAP
{
    partial class Circulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Circulo));
            this.lCRadio = new System.Windows.Forms.Label();
            this.tBCRadio = new System.Windows.Forms.TextBox();
            this.lCArea = new System.Windows.Forms.Label();
            this.lCPerimetro = new System.Windows.Forms.Label();
            this.lCRArea = new System.Windows.Forms.Label();
            this.lCRPerimetro = new System.Windows.Forms.Label();
            this.CBSalir = new System.Windows.Forms.Button();
            this.CBCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lCRadio
            // 
            this.lCRadio.AutoSize = true;
            this.lCRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCRadio.Location = new System.Drawing.Point(291, 42);
            this.lCRadio.Name = "lCRadio";
            this.lCRadio.Size = new System.Drawing.Size(189, 29);
            this.lCRadio.TabIndex = 0;
            this.lCRadio.Text = "Ingresa el Radio";
            // 
            // tBCRadio
            // 
            this.tBCRadio.Location = new System.Drawing.Point(333, 109);
            this.tBCRadio.Name = "tBCRadio";
            this.tBCRadio.Size = new System.Drawing.Size(100, 29);
            this.tBCRadio.TabIndex = 1;
            // 
            // lCArea
            // 
            this.lCArea.AutoSize = true;
            this.lCArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCArea.Location = new System.Drawing.Point(205, 199);
            this.lCArea.Name = "lCArea";
            this.lCArea.Size = new System.Drawing.Size(69, 29);
            this.lCArea.TabIndex = 2;
            this.lCArea.Text = "Área:";
            // 
            // lCPerimetro
            // 
            this.lCPerimetro.AutoSize = true;
            this.lCPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCPerimetro.Location = new System.Drawing.Point(205, 271);
            this.lCPerimetro.Name = "lCPerimetro";
            this.lCPerimetro.Size = new System.Drawing.Size(125, 29);
            this.lCPerimetro.TabIndex = 3;
            this.lCPerimetro.Text = "Perímetro:";
            this.lCPerimetro.Click += new System.EventHandler(this.lCPerimetro_Click);
            // 
            // lCRArea
            // 
            this.lCRArea.AutoSize = true;
            this.lCRArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCRArea.Location = new System.Drawing.Point(392, 199);
            this.lCRArea.Name = "lCRArea";
            this.lCRArea.Size = new System.Drawing.Size(0, 29);
            this.lCRArea.TabIndex = 4;
            // 
            // lCRPerimetro
            // 
            this.lCRPerimetro.AutoSize = true;
            this.lCRPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCRPerimetro.Location = new System.Drawing.Point(392, 271);
            this.lCRPerimetro.Name = "lCRPerimetro";
            this.lCRPerimetro.Size = new System.Drawing.Size(0, 29);
            this.lCRPerimetro.TabIndex = 5;
            // 
            // CBSalir
            // 
            this.CBSalir.AutoSize = true;
            this.CBSalir.Location = new System.Drawing.Point(687, 395);
            this.CBSalir.Name = "CBSalir";
            this.CBSalir.Size = new System.Drawing.Size(101, 43);
            this.CBSalir.TabIndex = 6;
            this.CBSalir.Text = "Regresar";
            this.CBSalir.UseVisualStyleBackColor = true;
            this.CBSalir.Click += new System.EventHandler(this.CBSalir_Click);
            // 
            // CBCalcular
            // 
            this.CBCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCalcular.Location = new System.Drawing.Point(545, 101);
            this.CBCalcular.Name = "CBCalcular";
            this.CBCalcular.Size = new System.Drawing.Size(113, 43);
            this.CBCalcular.TabIndex = 7;
            this.CBCalcular.Text = "Calcular";
            this.CBCalcular.UseVisualStyleBackColor = true;
            this.CBCalcular.Click += new System.EventHandler(this.CBCalcular_Click);
            // 
            // Circulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CBCalcular);
            this.Controls.Add(this.CBSalir);
            this.Controls.Add(this.lCRPerimetro);
            this.Controls.Add(this.lCRArea);
            this.Controls.Add(this.lCPerimetro);
            this.Controls.Add(this.lCArea);
            this.Controls.Add(this.tBCRadio);
            this.Controls.Add(this.lCRadio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Circulo";
            this.Text = "Circulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCRadio;
        private System.Windows.Forms.TextBox tBCRadio;
        private System.Windows.Forms.Label lCArea;
        private System.Windows.Forms.Label lCPerimetro;
        private System.Windows.Forms.Label lCRArea;
        private System.Windows.Forms.Label lCRPerimetro;
        private System.Windows.Forms.Button CBSalir;
        private System.Windows.Forms.Button CBCalcular;
    }
}