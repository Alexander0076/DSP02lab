namespace Ejercicio2_guia2
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
            this.btn1 = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.list1 = new System.Windows.Forms.ListBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.list2 = new System.Windows.Forms.ListBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(324, 156);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(198, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Ingresar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(217, 93);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(120, 17);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Ingresar número: ";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(362, 93);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(231, 22);
            this.txt1.TabIndex = 2;
            // 
            // list1
            // 
            this.list1.FormattingEnabled = true;
            this.list1.ItemHeight = 16;
            this.list1.Location = new System.Drawing.Point(31, 93);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(120, 84);
            this.list1.TabIndex = 3;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(161, 294);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(323, 23);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "Generar la desviación tipica";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(533, 292);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(172, 22);
            this.txt2.TabIndex = 5;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(161, 265);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(323, 23);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "Gernerar la media ";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(533, 264);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(172, 22);
            this.txt3.TabIndex = 7;
            // 
            // list2
            // 
            this.list2.FormattingEnabled = true;
            this.list2.ItemHeight = 16;
            this.list2.Location = new System.Drawing.Point(31, 195);
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(120, 84);
            this.list2.TabIndex = 8;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(50, 383);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(162, 22);
            this.txt4.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.list2);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.list1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.ListBox list2;
        private System.Windows.Forms.TextBox txt4;
    }
}

