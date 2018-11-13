namespace exan_de_angie
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cli = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.Panel();
            this.pro1 = new System.Windows.Forms.Button();
            this.sub1 = new System.Windows.Forms.TextBox();
            this.isv2 = new System.Windows.Forms.TextBox();
            this.total3 = new System.Windows.Forms.TextBox();
            this.isv = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.subtotal = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pro2 = new System.Windows.Forms.Button();
            this.pro3 = new System.Windows.Forms.Button();
            this.pro4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cli
            // 
            this.cli.AutoSize = true;
            this.cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cli.Location = new System.Drawing.Point(57, 10);
            this.cli.Name = "cli";
            this.cli.Size = new System.Drawing.Size(98, 25);
            this.cli.TabIndex = 0;
            this.cli.Text = "Clientes";
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.Color.PowderBlue;
            this.nombre.Location = new System.Drawing.Point(191, 16);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(242, 20);
            this.nombre.TabIndex = 1;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.Color.NavajoWhite;
            this.descripcion.Location = new System.Drawing.Point(21, 59);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(241, 180);
            this.descripcion.TabIndex = 2;
            // 
            // pro1
            // 
            this.pro1.BackColor = System.Drawing.Color.PaleGreen;
            this.pro1.Location = new System.Drawing.Point(280, 59);
            this.pro1.Name = "pro1";
            this.pro1.Size = new System.Drawing.Size(93, 25);
            this.pro1.TabIndex = 3;
            this.pro1.Text = "Lavadora";
            this.pro1.UseVisualStyleBackColor = false;
            this.pro1.Click += new System.EventHandler(this.pro1_Click);
            // 
            // sub1
            // 
            this.sub1.BackColor = System.Drawing.Color.PowderBlue;
            this.sub1.Location = new System.Drawing.Point(374, 244);
            this.sub1.Name = "sub1";
            this.sub1.Size = new System.Drawing.Size(98, 20);
            this.sub1.TabIndex = 4;
            this.sub1.TextChanged += new System.EventHandler(this.sub1_TextChanged);
            // 
            // isv2
            // 
            this.isv2.BackColor = System.Drawing.Color.PowderBlue;
            this.isv2.Location = new System.Drawing.Point(374, 274);
            this.isv2.Name = "isv2";
            this.isv2.Size = new System.Drawing.Size(98, 20);
            this.isv2.TabIndex = 4;
            // 
            // total3
            // 
            this.total3.BackColor = System.Drawing.Color.PowderBlue;
            this.total3.Location = new System.Drawing.Point(374, 300);
            this.total3.Name = "total3";
            this.total3.Size = new System.Drawing.Size(98, 20);
            this.total3.TabIndex = 4;
            // 
            // isv
            // 
            this.isv.AutoSize = true;
            this.isv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isv.Location = new System.Drawing.Point(276, 272);
            this.isv.Name = "isv";
            this.isv.Size = new System.Drawing.Size(49, 20);
            this.isv.TabIndex = 0;
            this.isv.Text = "I.S.V";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(613, 542);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(61, 20);
            this.textBox5.TabIndex = 4;
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.Location = new System.Drawing.Point(276, 242);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(81, 20);
            this.subtotal.TabIndex = 0;
            this.subtotal.Text = "SubTotal";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(276, 298);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(49, 20);
            this.total.TabIndex = 0;
            this.total.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 5;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.MintCream;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lbl1.Location = new System.Drawing.Point(18, 267);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(45, 16);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "label6";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // pro2
            // 
            this.pro2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pro2.Location = new System.Drawing.Point(280, 102);
            this.pro2.Name = "pro2";
            this.pro2.Size = new System.Drawing.Size(93, 25);
            this.pro2.TabIndex = 3;
            this.pro2.Text = "Secadora";
            this.pro2.UseVisualStyleBackColor = false;
            // 
            // pro3
            // 
            this.pro3.BackColor = System.Drawing.Color.PaleGreen;
            this.pro3.Location = new System.Drawing.Point(280, 145);
            this.pro3.Name = "pro3";
            this.pro3.Size = new System.Drawing.Size(115, 25);
            this.pro3.TabIndex = 3;
            this.pro3.Text = "Aire Acondicionado";
            this.pro3.UseVisualStyleBackColor = false;
            // 
            // pro4
            // 
            this.pro4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pro4.Location = new System.Drawing.Point(280, 187);
            this.pro4.Name = "pro4";
            this.pro4.Size = new System.Drawing.Size(93, 25);
            this.pro4.TabIndex = 3;
            this.pro4.Text = "Televisor";
            this.pro4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.total3);
            this.Controls.Add(this.pro4);
            this.Controls.Add(this.isv2);
            this.Controls.Add(this.pro3);
            this.Controls.Add(this.pro2);
            this.Controls.Add(this.sub1);
            this.Controls.Add(this.pro1);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.total);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.isv);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.cli);
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cli;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Panel descripcion;
        private System.Windows.Forms.Button pro1;
        private System.Windows.Forms.TextBox sub1;
        private System.Windows.Forms.TextBox isv2;
        private System.Windows.Forms.TextBox total3;
        private System.Windows.Forms.Label isv;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button pro2;
        private System.Windows.Forms.Button pro3;
        private System.Windows.Forms.Button pro4;
    }
}

