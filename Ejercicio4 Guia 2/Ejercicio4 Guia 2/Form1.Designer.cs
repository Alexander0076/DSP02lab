namespace Ejercicio4_Guia_2
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
            this.btn = new System.Windows.Forms.Button();
            this.tabla = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.cls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(142, 96);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(127, 23);
            this.btn.TabIndex = 0;
            this.btn.Text = "Calcular";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // tabla
            // 
            this.tabla.FormattingEnabled = true;
            this.tabla.Location = new System.Drawing.Point(130, 139);
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(151, 160);
            this.tabla.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el numero de la tabla de multiplicacción";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(149, 53);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(114, 20);
            this.number.TabIndex = 3;
            // 
            // cls
            // 
            this.cls.Location = new System.Drawing.Point(318, 262);
            this.cls.Name = "cls";
            this.cls.Size = new System.Drawing.Size(75, 23);
            this.cls.TabIndex = 4;
            this.cls.Text = "Linpiar";
            this.cls.UseVisualStyleBackColor = true;
            this.cls.Click += new System.EventHandler(this.cls_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 311);
            this.Controls.Add(this.cls);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ListBox tabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button cls;
    }
}

