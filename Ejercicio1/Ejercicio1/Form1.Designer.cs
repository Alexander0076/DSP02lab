namespace Ejercicio1
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
            this.label1 = new System.Windows.Forms.Label();
            this.numeros = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese numero";
            // 
            // numeros
            // 
            this.numeros.AccessibleName = "";
            this.numeros.Location = new System.Drawing.Point(136, 117);
            this.numeros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numeros.Multiline = true;
            this.numeros.Name = "numeros";
            this.numeros.Size = new System.Drawing.Size(291, 36);
            this.numeros.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.AccessibleName = "";
            this.btn1.Location = new System.Drawing.Point(231, 177);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 28);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Ingresar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 16;
            this.list.Location = new System.Drawing.Point(136, 299);
            this.list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(328, 212);
            this.list.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 554);
            this.Controls.Add(this.list);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.numeros);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numeros;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.ListBox list;
    }
}

