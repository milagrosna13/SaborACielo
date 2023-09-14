namespace SaborAcielo
{
    partial class FagregarVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bcompra = new System.Windows.Forms.Button();
            this.BcancelarCompra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ncant = new System.Windows.Forms.NumericUpDown();
            this.CBtipoProd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBproducto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBprecioProd = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BagregarCompra = new System.Windows.Forms.Button();
            this.DGcarrito = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ncant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGcarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.BagregarCompra);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TBprecioProd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CBproducto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CBtipoProd);
            this.panel1.Controls.Add(this.Ncant);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(52, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 366);
            this.panel1.TabIndex = 0;
            // 
            // Bcompra
            // 
            this.Bcompra.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcompra.Location = new System.Drawing.Point(690, 613);
            this.Bcompra.Name = "Bcompra";
            this.Bcompra.Size = new System.Drawing.Size(179, 50);
            this.Bcompra.TabIndex = 1;
            this.Bcompra.Text = "Finalizar Compra";
            this.Bcompra.UseVisualStyleBackColor = true;
            // 
            // BcancelarCompra
            // 
            this.BcancelarCompra.Font = new System.Drawing.Font("Script MT Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BcancelarCompra.Location = new System.Drawing.Point(894, 612);
            this.BcancelarCompra.Name = "BcancelarCompra";
            this.BcancelarCompra.Size = new System.Drawing.Size(148, 50);
            this.BcancelarCompra.TabIndex = 2;
            this.BcancelarCompra.Text = "Cancelar";
            this.BcancelarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BcancelarCompra.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad";
            // 
            // Ncant
            // 
            this.Ncant.Location = new System.Drawing.Point(175, 164);
            this.Ncant.Name = "Ncant";
            this.Ncant.Size = new System.Drawing.Size(77, 26);
            this.Ncant.TabIndex = 5;
            // 
            // CBtipoProd
            // 
            this.CBtipoProd.FormattingEnabled = true;
            this.CBtipoProd.Location = new System.Drawing.Point(117, 86);
            this.CBtipoProd.Name = "CBtipoProd";
            this.CBtipoProd.Size = new System.Drawing.Size(280, 28);
            this.CBtipoProd.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Venta";
            // 
            // CBproducto
            // 
            this.CBproducto.FormattingEnabled = true;
            this.CBproducto.Location = new System.Drawing.Point(604, 86);
            this.CBproducto.Name = "CBproducto";
            this.CBproducto.Size = new System.Drawing.Size(298, 28);
            this.CBproducto.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(414, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Precio Unitario";
            // 
            // TBprecioProd
            // 
            this.TBprecioProd.Location = new System.Drawing.Point(604, 168);
            this.TBprecioProd.Name = "TBprecioProd";
            this.TBprecioProd.Size = new System.Drawing.Size(298, 26);
            this.TBprecioProd.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(604, 236);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(298, 26);
            this.textBox2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(414, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Subtotal";
            // 
            // BagregarCompra
            // 
            this.BagregarCompra.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BagregarCompra.Location = new System.Drawing.Point(569, 299);
            this.BagregarCompra.Name = "BagregarCompra";
            this.BagregarCompra.Size = new System.Drawing.Size(179, 50);
            this.BagregarCompra.TabIndex = 3;
            this.BagregarCompra.Text = "Agregar";
            this.BagregarCompra.UseVisualStyleBackColor = true;
            // 
            // DGcarrito
            // 
            this.DGcarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGcarrito.Location = new System.Drawing.Point(87, 436);
            this.DGcarrito.Name = "DGcarrito";
            this.DGcarrito.RowHeadersWidth = 62;
            this.DGcarrito.RowTemplate.Height = 28;
            this.DGcarrito.Size = new System.Drawing.Size(854, 150);
            this.DGcarrito.TabIndex = 3;
            // 
            // FagregarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(1082, 675);
            this.Controls.Add(this.DGcarrito);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Bcompra);
            this.Controls.Add(this.BcancelarCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FagregarVenta";
            this.Text = "FagregarVenta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ncant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGcarrito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Bcompra;
        private System.Windows.Forms.Button BcancelarCompra;
        private System.Windows.Forms.NumericUpDown Ncant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBprecioProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBproducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBtipoProd;
        private System.Windows.Forms.Button BagregarCompra;
        private System.Windows.Forms.DataGridView DGcarrito;
    }
}