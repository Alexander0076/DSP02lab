namespace Ejercicio3
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
            this.numeros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ingresar = new System.Windows.Forms.Button();
            this.npositivos = new System.Windows.Forms.ListBox();
            this.nnegativos = new System.Windows.Forms.ListBox();
            this.promedio = new System.Windows.Forms.Button();
            this.menor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.negativo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.positivo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numeros
            // 
            this.numeros.Location = new System.Drawing.Point(153, 43);
            this.numeros.Name = "numeros";
            this.numeros.Size = new System.Drawing.Size(158, 20);
            this.numeros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese un numero";
            // 
            // ingresar
            // 
            this.ingresar.Location = new System.Drawing.Point(340, 46);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(165, 23);
            this.ingresar.TabIndex = 2;
            this.ingresar.Text = "Ingresar";
            this.ingresar.UseVisualStyleBackColor = true;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // npositivos
            // 
            this.npositivos.FormattingEnabled = true;
            this.npositivos.Location = new System.Drawing.Point(72, 131);
            this.npositivos.Name = "npositivos";
            this.npositivos.Size = new System.Drawing.Size(45, 147);
            this.npositivos.TabIndex = 3;
            // 
            // nnegativos
            // 
            this.nnegativos.FormattingEnabled = true;
            this.nnegativos.Location = new System.Drawing.Point(166, 131);
            this.nnegativos.Name = "nnegativos";
            this.nnegativos.Size = new System.Drawing.Size(48, 147);
            this.nnegativos.TabIndex = 4;
            // 
            // promedio
            // 
            this.promedio.Location = new System.Drawing.Point(269, 231);
            this.promedio.Name = "promedio";
            this.promedio.Size = new System.Drawing.Size(226, 23);
            this.promedio.TabIndex = 5;
            this.promedio.Text = "Calcular pormedio de los numeros positivos";
            this.promedio.UseVisualStyleBackColor = true;
            this.promedio.Click += new System.EventHandler(this.promedio_Click);
            // 
            // menor
            // 
            this.menor.Location = new System.Drawing.Point(269, 274);
            this.menor.Name = "menor";
            this.menor.Size = new System.Drawing.Size(226, 23);
            this.menor.TabIndex = 6;
            this.menor.Text = "Mostrar el menor numero de los negativos";
            this.menor.UseVisualStyleBackColor = true;
            this.menor.Click += new System.EventHandler(this.menor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero menor de los negativos: ";
            // 
            // negativo
            // 
            this.negativo.AutoSize = true;
            this.negativo.Location = new System.Drawing.Point(463, 145);
            this.negativo.Name = "negativo";
            this.negativo.Size = new System.Drawing.Size(13, 13);
            this.negativo.TabIndex = 8;
            this.negativo.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Promedio de los números positivos:";
            // 
            // positivo
            // 
            this.positivo.AutoSize = true;
            this.positivo.Location = new System.Drawing.Point(463, 184);
            this.positivo.Name = "positivo";
            this.positivo.Size = new System.Drawing.Size(13, 13);
            this.positivo.TabIndex = 10;
            this.positivo.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Numeros positivos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Numeros negativos";
            // 
            // mostrar
            // 
            this.mostrar.Location = new System.Drawing.Point(340, 90);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(165, 23);
            this.mostrar.TabIndex = 13;
            this.mostrar.Text = "Mostrar numeros ingresados";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.Click += new System.EventHandler(this.mostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 378);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.positivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.negativo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menor);
            this.Controls.Add(this.promedio);
            this.Controls.Add(this.nnegativos);
            this.Controls.Add(this.npositivos);
            this.Controls.Add(this.ingresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ingresar;
        private System.Windows.Forms.ListBox npositivos;
        private System.Windows.Forms.ListBox nnegativos;
        private System.Windows.Forms.Button promedio;
        private System.Windows.Forms.Button menor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label negativo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label positivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button mostrar;
    }
}

