﻿namespace Ejercicio1
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
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese numero";
            // 
            // numeros
            // 
            this.numeros.AccessibleName = "";
            this.numeros.Location = new System.Drawing.Point(102, 95);
            this.numeros.Multiline = true;
            this.numeros.Name = "numeros";
            this.numeros.Size = new System.Drawing.Size(219, 30);
            this.numeros.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.AccessibleName = "";
            this.btn1.Location = new System.Drawing.Point(173, 144);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Ingresar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(102, 243);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(247, 173);
            this.list.TabIndex = 3;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(159, 214);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(117, 23);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "Calcular media";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(132, 185);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(176, 23);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "Mostrar numero mayor y menor ";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.list);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.numeros);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
    }
}

