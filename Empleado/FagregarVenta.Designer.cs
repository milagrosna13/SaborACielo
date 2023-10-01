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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Fproducto = new System.Windows.Forms.TextBox();
            this.BagregarCompra = new System.Windows.Forms.Button();
            this.TBsubtotal = new System.Windows.Forms.TextBox();
            this.BcancelarCompra = new System.Windows.Forms.Button();
            this.Bcompra = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TBprecioProd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Lventa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CtipoProd = new System.Windows.Forms.ComboBox();
            this.Ncant = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGcarrito = new System.Windows.Forms.DataGridView();
            this.id_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baja = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ncant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGcarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.Fproducto);
            this.panel1.Controls.Add(this.BagregarCompra);
            this.panel1.Controls.Add(this.TBsubtotal);
            this.panel1.Controls.Add(this.BcancelarCompra);
            this.panel1.Controls.Add(this.Bcompra);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TBprecioProd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Lventa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CtipoProd);
            this.panel1.Controls.Add(this.Ncant);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(52, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 366);
            this.panel1.TabIndex = 0;
            // 
            // Fproducto
            // 
            this.Fproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Fproducto.Location = new System.Drawing.Point(529, 62);
            this.Fproducto.Name = "Fproducto";
            this.Fproducto.Size = new System.Drawing.Size(307, 35);
            this.Fproducto.TabIndex = 15;
            this.Fproducto.TextChanged += new System.EventHandler(this.Fproducto_TextChanged);
            this.Fproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Fproducto_KeyPress);
            // 
            // BagregarCompra
            // 
            this.BagregarCompra.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BagregarCompra.Location = new System.Drawing.Point(197, 282);
            this.BagregarCompra.Name = "BagregarCompra";
            this.BagregarCompra.Size = new System.Drawing.Size(179, 50);
            this.BagregarCompra.TabIndex = 3;
            this.BagregarCompra.Text = "Agregar";
            this.BagregarCompra.UseVisualStyleBackColor = true;
            this.BagregarCompra.Click += new System.EventHandler(this.BagregarCompra_Click);
            // 
            // TBsubtotal
            // 
            this.TBsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBsubtotal.Location = new System.Drawing.Point(578, 203);
            this.TBsubtotal.Name = "TBsubtotal";
            this.TBsubtotal.ReadOnly = true;
            this.TBsubtotal.Size = new System.Drawing.Size(298, 32);
            this.TBsubtotal.TabIndex = 14;
            // 
            // BcancelarCompra
            // 
            this.BcancelarCompra.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.BcancelarCompra.Location = new System.Drawing.Point(462, 282);
            this.BcancelarCompra.Name = "BcancelarCompra";
            this.BcancelarCompra.Size = new System.Drawing.Size(148, 50);
            this.BcancelarCompra.TabIndex = 2;
            this.BcancelarCompra.Text = "Cancelar";
            this.BcancelarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BcancelarCompra.UseVisualStyleBackColor = true;
            this.BcancelarCompra.Click += new System.EventHandler(this.BcancelarCompra_Click);
            // 
            // Bcompra
            // 
            this.Bcompra.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.Bcompra.Location = new System.Drawing.Point(824, 282);
            this.Bcompra.Name = "Bcompra";
            this.Bcompra.Size = new System.Drawing.Size(132, 81);
            this.Bcompra.TabIndex = 1;
            this.Bcompra.Text = "Finalizar Compra";
            this.Bcompra.UseVisualStyleBackColor = true;
            this.Bcompra.Click += new System.EventHandler(this.Bcompra_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(388, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Subtotal";
            // 
            // TBprecioProd
            // 
            this.TBprecioProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBprecioProd.Location = new System.Drawing.Point(578, 135);
            this.TBprecioProd.Name = "TBprecioProd";
            this.TBprecioProd.ReadOnly = true;
            this.TBprecioProd.Size = new System.Drawing.Size(298, 32);
            this.TBprecioProd.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Precio Unitario";
            // 
            // Lventa
            // 
            this.Lventa.AutoSize = true;
            this.Lventa.Font = new System.Drawing.Font("Script MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lventa.Location = new System.Drawing.Point(393, 0);
            this.Lventa.Name = "Lventa";
            this.Lventa.Size = new System.Drawing.Size(92, 38);
            this.Lventa.TabIndex = 10;
            this.Lventa.Text = "Venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo";
            // 
            // CtipoProd
            // 
            this.CtipoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtipoProd.FormattingEnabled = true;
            this.CtipoProd.Items.AddRange(new object[] {
            "Regular",
            "Vegano",
            "Sin T.A.C.C"});
            this.CtipoProd.Location = new System.Drawing.Point(96, 63);
            this.CtipoProd.Name = "CtipoProd";
            this.CtipoProd.Size = new System.Drawing.Size(280, 34);
            this.CtipoProd.TabIndex = 7;
            // 
            // Ncant
            // 
            this.Ncant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ncant.Location = new System.Drawing.Point(190, 134);
            this.Ncant.Name = "Ncant";
            this.Ncant.Size = new System.Drawing.Size(77, 30);
            this.Ncant.TabIndex = 5;
            this.Ncant.ValueChanged += new System.EventHandler(this.Ncant_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Producto";
            // 
            // DGcarrito
            // 
            this.DGcarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGcarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGcarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGcarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_venta,
            this.tipo,
            this.prod,
            this.cantidad,
            this.sub,
            this.baja});
            this.DGcarrito.Location = new System.Drawing.Point(29, 436);
            this.DGcarrito.Name = "DGcarrito";
            this.DGcarrito.RowHeadersWidth = 62;
            this.DGcarrito.RowTemplate.Height = 28;
            this.DGcarrito.Size = new System.Drawing.Size(1025, 209);
            this.DGcarrito.TabIndex = 3;
            this.DGcarrito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGcarrito_CellClick);
            // 
            // id_venta
            // 
            this.id_venta.HeaderText = "Venta nro";
            this.id_venta.MinimumWidth = 8;
            this.id_venta.Name = "id_venta";
            this.id_venta.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo de Producto";
            this.tipo.MinimumWidth = 8;
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // prod
            // 
            this.prod.HeaderText = "Producto";
            this.prod.MinimumWidth = 8;
            this.prod.Name = "prod";
            this.prod.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 8;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // sub
            // 
            this.sub.HeaderText = "Subtotal";
            this.sub.MinimumWidth = 8;
            this.sub.Name = "sub";
            this.sub.ReadOnly = true;
            // 
            // baja
            // 
            this.baja.HeaderText = "Eliminar";
            this.baja.MinimumWidth = 8;
            this.baja.Name = "baja";
            this.baja.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.baja.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.baja.Text = "Eliminar";
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
        private System.Windows.Forms.TextBox TBsubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBprecioProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lventa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CtipoProd;
        private System.Windows.Forms.Button BagregarCompra;
        private System.Windows.Forms.DataGridView DGcarrito;
        private System.Windows.Forms.TextBox Fproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub;
        private System.Windows.Forms.DataGridViewButtonColumn baja;
    }
}