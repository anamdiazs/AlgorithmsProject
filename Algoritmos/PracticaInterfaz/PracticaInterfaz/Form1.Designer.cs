namespace PracticaInterfaz
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
            this.LNumero1 = new System.Windows.Forms.Label();
            this.BResultado = new System.Windows.Forms.Button();
            this.LiOperador = new System.Windows.Forms.ListBox();
            this.TNum1 = new System.Windows.Forms.TextBox();
            this.TNum2 = new System.Windows.Forms.TextBox();
            this.LNumero2 = new System.Windows.Forms.Label();
            this.LOperador = new System.Windows.Forms.Label();
            this.LResultado = new System.Windows.Forms.Label();
            this.BAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LNumero1
            // 
            this.LNumero1.AutoSize = true;
            this.LNumero1.Location = new System.Drawing.Point(54, 134);
            this.LNumero1.Name = "LNumero1";
            this.LNumero1.Size = new System.Drawing.Size(97, 25);
            this.LNumero1.TabIndex = 0;
            this.LNumero1.Text = "Numero 1";
            this.LNumero1.Click += new System.EventHandler(this.LNumero1_Click);
            // 
            // BResultado
            // 
            this.BResultado.Location = new System.Drawing.Point(586, 206);
            this.BResultado.Name = "BResultado";
            this.BResultado.Size = new System.Drawing.Size(75, 42);
            this.BResultado.TabIndex = 1;
            this.BResultado.Text = "=";
            this.BResultado.UseVisualStyleBackColor = true;
            this.BResultado.Click += new System.EventHandler(this.BResultado_Click);
            // 
            // LiOperador
            // 
            this.LiOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiOperador.FormattingEnabled = true;
            this.LiOperador.ItemHeight = 32;
            this.LiOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.LiOperador.Location = new System.Drawing.Point(234, 162);
            this.LiOperador.Name = "LiOperador";
            this.LiOperador.Size = new System.Drawing.Size(120, 164);
            this.LiOperador.TabIndex = 2;
            // 
            // TNum1
            // 
            this.TNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNum1.Location = new System.Drawing.Point(59, 212);
            this.TNum1.Name = "TNum1";
            this.TNum1.Size = new System.Drawing.Size(100, 34);
            this.TNum1.TabIndex = 3;
            // 
            // TNum2
            // 
            this.TNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNum2.Location = new System.Drawing.Point(426, 212);
            this.TNum2.Name = "TNum2";
            this.TNum2.Size = new System.Drawing.Size(100, 34);
            this.TNum2.TabIndex = 4;
            // 
            // LNumero2
            // 
            this.LNumero2.AutoSize = true;
            this.LNumero2.Location = new System.Drawing.Point(429, 134);
            this.LNumero2.Name = "LNumero2";
            this.LNumero2.Size = new System.Drawing.Size(97, 25);
            this.LNumero2.TabIndex = 5;
            this.LNumero2.Text = "Numero 2";
            this.LNumero2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LOperador
            // 
            this.LOperador.AutoSize = true;
            this.LOperador.Location = new System.Drawing.Point(248, 134);
            this.LOperador.Name = "LOperador";
            this.LOperador.Size = new System.Drawing.Size(95, 25);
            this.LOperador.TabIndex = 6;
            this.LOperador.Text = "Operador";
            this.LOperador.Click += new System.EventHandler(this.label3_Click);
            // 
            // LResultado
            // 
            this.LResultado.AutoSize = true;
            this.LResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LResultado.Location = new System.Drawing.Point(716, 212);
            this.LResultado.Name = "LResultado";
            this.LResultado.Size = new System.Drawing.Size(27, 29);
            this.LResultado.TabIndex = 7;
            this.LResultado.Text = "0";
            // 
            // BAbrir
            // 
            this.BAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAbrir.Location = new System.Drawing.Point(586, 383);
            this.BAbrir.Name = "BAbrir";
            this.BAbrir.Size = new System.Drawing.Size(187, 43);
            this.BAbrir.TabIndex = 8;
            this.BAbrir.Text = "Abrir Otro Form";
            this.BAbrir.UseVisualStyleBackColor = true;
            this.BAbrir.Click += new System.EventHandler(this.BAbrir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BAbrir);
            this.Controls.Add(this.LResultado);
            this.Controls.Add(this.LOperador);
            this.Controls.Add(this.LNumero2);
            this.Controls.Add(this.TNum2);
            this.Controls.Add(this.TNum1);
            this.Controls.Add(this.LiOperador);
            this.Controls.Add(this.BResultado);
            this.Controls.Add(this.LNumero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNumero1;
        private System.Windows.Forms.Button BResultado;
        private System.Windows.Forms.ListBox LiOperador;
        private System.Windows.Forms.TextBox TNum1;
        private System.Windows.Forms.TextBox TNum2;
        private System.Windows.Forms.Label LNumero2;
        private System.Windows.Forms.Label LOperador;
        private System.Windows.Forms.Label LResultado;
        private System.Windows.Forms.Button BAbrir;
    }
}

