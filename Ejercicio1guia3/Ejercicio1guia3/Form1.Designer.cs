namespace Ejercicio1guia3
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
            this.tbxPrueba = new System.Windows.Forms.TextBox();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxPrueba
            // 
            this.tbxPrueba.Location = new System.Drawing.Point(21, 30);
            this.tbxPrueba.Multiline = true;
            this.tbxPrueba.Name = "tbxPrueba";
            this.tbxPrueba.Size = new System.Drawing.Size(391, 151);
            this.tbxPrueba.TabIndex = 0;
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(165, 248);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba.TabIndex = 1;
            this.btnPrueba.Text = "Prueba";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 342);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.tbxPrueba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPrueba;
        private System.Windows.Forms.Button btnPrueba;
    }
}

