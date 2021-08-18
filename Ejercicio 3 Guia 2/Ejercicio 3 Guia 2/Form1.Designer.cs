namespace Ejercicio_3_Guia_2
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
            this.btn = new System.Windows.Forms.Button();
            this.PO = new System.Windows.Forms.ListBox();
            this.NEG = new System.Windows.Forms.ListBox();
            this.CERO = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NNA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CNP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PromNeg = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PorPosi = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PorNeg = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numeros
            // 
            this.numeros.Location = new System.Drawing.Point(39, 158);
            this.numeros.Name = "numeros";
            this.numeros.Size = new System.Drawing.Size(237, 20);
            this.numeros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingese un nunero";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(81, 208);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(152, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "Ingresar numero";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // PO
            // 
            this.PO.FormattingEnabled = true;
            this.PO.Location = new System.Drawing.Point(378, 44);
            this.PO.Name = "PO";
            this.PO.Size = new System.Drawing.Size(73, 134);
            this.PO.TabIndex = 3;
            // 
            // NEG
            // 
            this.NEG.FormattingEnabled = true;
            this.NEG.Location = new System.Drawing.Point(505, 44);
            this.NEG.Name = "NEG";
            this.NEG.Size = new System.Drawing.Size(67, 134);
            this.NEG.TabIndex = 4;
            // 
            // CERO
            // 
            this.CERO.FormattingEnabled = true;
            this.CERO.Location = new System.Drawing.Point(631, 44);
            this.CERO.Name = "CERO";
            this.CERO.Size = new System.Drawing.Size(67, 134);
            this.CERO.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mayor número negativo:";
            // 
            // NNA
            // 
            this.NNA.AutoSize = true;
            this.NNA.Location = new System.Drawing.Point(528, 228);
            this.NNA.Name = "NNA";
            this.NNA.Size = new System.Drawing.Size(13, 13);
            this.NNA.TabIndex = 7;
            this.NNA.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad de números positivos:";
            // 
            // CNP
            // 
            this.CNP.AutoSize = true;
            this.CNP.Location = new System.Drawing.Point(528, 254);
            this.CNP.Name = "CNP";
            this.CNP.Size = new System.Drawing.Size(13, 13);
            this.CNP.TabIndex = 9;
            this.CNP.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Promedio de los negativos recibidos:";
            // 
            // PromNeg
            // 
            this.PromNeg.AutoSize = true;
            this.PromNeg.Location = new System.Drawing.Point(528, 281);
            this.PromNeg.Name = "PromNeg";
            this.PromNeg.Size = new System.Drawing.Size(13, 13);
            this.PromNeg.TabIndex = 11;
            this.PromNeg.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(565, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Porcentaje de los numeros positivos: ";
            // 
            // PorPosi
            // 
            this.PorPosi.AutoSize = true;
            this.PorPosi.Location = new System.Drawing.Point(753, 228);
            this.PorPosi.Name = "PorPosi";
            this.PorPosi.Size = new System.Drawing.Size(13, 13);
            this.PorPosi.TabIndex = 13;
            this.PorPosi.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(565, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Porcentaje de los numeros negativos: ";
            // 
            // PorNeg
            // 
            this.PorNeg.AutoSize = true;
            this.PorNeg.Location = new System.Drawing.Point(753, 254);
            this.PorNeg.Name = "PorNeg";
            this.PorNeg.Size = new System.Drawing.Size(13, 13);
            this.PorNeg.TabIndex = 15;
            this.PorNeg.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(565, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Ceros recibidos hasta el momento:";
            // 
            // CC
            // 
            this.CC.AutoSize = true;
            this.CC.Location = new System.Drawing.Point(753, 281);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(13, 13);
            this.CC.TabIndex = 17;
            this.CC.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 349);
            this.Controls.Add(this.CC);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PorNeg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PorPosi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PromNeg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CNP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NNA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CERO);
            this.Controls.Add(this.NEG);
            this.Controls.Add(this.PO);
            this.Controls.Add(this.btn);
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
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ListBox PO;
        private System.Windows.Forms.ListBox NEG;
        private System.Windows.Forms.ListBox CERO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NNA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CNP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PromNeg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label PorPosi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label PorNeg;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label CC;
    }
}

