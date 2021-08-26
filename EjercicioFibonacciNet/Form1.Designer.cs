namespace EjercicioFibonacciNet
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
            this.txtNumeroIngresado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalida = new System.Windows.Forms.Label();
            this.txtPrimo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumeroIngresado
            // 
            this.txtNumeroIngresado.Location = new System.Drawing.Point(162, 68);
            this.txtNumeroIngresado.Name = "txtNumeroIngresado";
            this.txtNumeroIngresado.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroIngresado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la posición del numero Fibonacci que desea conocer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(162, 110);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 29);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número finobacci ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSalida
            // 
            this.txtSalida.AutoSize = true;
            this.txtSalida.Location = new System.Drawing.Point(166, 201);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(14, 13);
            this.txtSalida.TabIndex = 4;
            this.txtSalida.Text = "#";
            this.txtSalida.Visible = false;
            // 
            // txtPrimo
            // 
            this.txtPrimo.AutoSize = true;
            this.txtPrimo.Location = new System.Drawing.Point(210, 201);
            this.txtPrimo.Name = "txtPrimo";
            this.txtPrimo.Size = new System.Drawing.Size(35, 13);
            this.txtPrimo.TabIndex = 5;
            this.txtPrimo.Text = "label3";
            this.txtPrimo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 312);
            this.Controls.Add(this.txtPrimo);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroIngresado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroIngresado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtSalida;
        private System.Windows.Forms.Label txtPrimo;
    }
}

