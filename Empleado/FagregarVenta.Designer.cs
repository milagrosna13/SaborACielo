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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CtipoProd = new System.Windows.Forms.ComboBox();
            this.CBproducto = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CBDetalle = new System.Windows.Forms.ComboBox();
            this.DGprodu = new System.Windows.Forms.DataGridView();
            this.emCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Bbuscardni = new System.Windows.Forms.Button();
            this.tCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.direCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.aCliente = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nCliente = new System.Windows.Forms.Label();
            this.TBdnicliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BagregarCompra = new System.Windows.Forms.Button();
            this.BcancelarCompra = new System.Windows.Forms.Button();
            this.Bcompra = new System.Windows.Forms.Button();
            this.Lcliente = new System.Windows.Forms.Label();
            this.Lventa = new System.Windows.Forms.Label();
            this.DGcarrito = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGprodu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGcarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.DGprodu);
            this.panel1.Controls.Add(this.emCliente);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Bbuscardni);
            this.panel1.Controls.Add(this.tCliente);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.direCliente);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.aCliente);
            this.panel1.Controls.Add(this.Apellido);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.nCliente);
            this.panel1.Controls.Add(this.TBdnicliente);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BagregarCompra);
            this.panel1.Controls.Add(this.BcancelarCompra);
            this.panel1.Controls.Add(this.Bcompra);
            this.panel1.Controls.Add(this.Lcliente);
            this.panel1.Controls.Add(this.Lventa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1359, 433);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CtipoProd);
            this.groupBox1.Controls.Add(this.CBproducto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CBDetalle);
            this.groupBox1.Location = new System.Drawing.Point(509, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 120);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Producto";
            // 
            // CtipoProd
            // 
            this.CtipoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtipoProd.FormattingEnabled = true;
            this.CtipoProd.Items.AddRange(new object[] {
            "Regular",
            "Vegano",
            "Sin T.A.C.C"});
            this.CtipoProd.Location = new System.Drawing.Point(13, 65);
            this.CtipoProd.Name = "CtipoProd";
            this.CtipoProd.Size = new System.Drawing.Size(202, 34);
            this.CtipoProd.TabIndex = 7;
            this.CtipoProd.TextChanged += new System.EventHandler(this.CtipoProd_TextChanged);
            // 
            // CBproducto
            // 
            this.CBproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBproducto.FormattingEnabled = true;
            this.CBproducto.Location = new System.Drawing.Point(228, 65);
            this.CBproducto.Name = "CBproducto";
            this.CBproducto.Size = new System.Drawing.Size(280, 34);
            this.CBproducto.TabIndex = 27;
            this.CBproducto.TextChanged += new System.EventHandler(this.CBproducto_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(552, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 29);
            this.label9.TabIndex = 28;
            this.label9.Text = "Detalle";
            // 
            // CBDetalle
            // 
            this.CBDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBDetalle.FormattingEnabled = true;
            this.CBDetalle.Location = new System.Drawing.Point(514, 65);
            this.CBDetalle.Name = "CBDetalle";
            this.CBDetalle.Size = new System.Drawing.Size(280, 34);
            this.CBDetalle.TabIndex = 29;
            this.CBDetalle.TextChanged += new System.EventHandler(this.CBDetalle_TextChanged);
            // 
            // DGprodu
            // 
            this.DGprodu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGprodu.Location = new System.Drawing.Point(499, 177);
            this.DGprodu.Name = "DGprodu";
            this.DGprodu.RowHeadersWidth = 62;
            this.DGprodu.RowTemplate.Height = 28;
            this.DGprodu.Size = new System.Drawing.Size(848, 150);
            this.DGprodu.TabIndex = 33;
            // 
            // emCliente
            // 
            this.emCliente.Enabled = false;
            this.emCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emCliente.Location = new System.Drawing.Point(140, 365);
            this.emCliente.Name = "emCliente";
            this.emCliente.ReadOnly = true;
            this.emCliente.Size = new System.Drawing.Size(246, 35);
            this.emCliente.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 29);
            this.label10.TabIndex = 31;
            this.label10.Text = "Email";
            // 
            // Bbuscardni
            // 
            this.Bbuscardni.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bbuscardni.Location = new System.Drawing.Point(408, 62);
            this.Bbuscardni.Name = "Bbuscardni";
            this.Bbuscardni.Size = new System.Drawing.Size(57, 46);
            this.Bbuscardni.TabIndex = 30;
            this.Bbuscardni.Text = "ok";
            this.Bbuscardni.UseVisualStyleBackColor = true;
            this.Bbuscardni.Click += new System.EventHandler(this.Bbuscardni_Click);
            // 
            // tCliente
            // 
            this.tCliente.Enabled = false;
            this.tCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tCliente.Location = new System.Drawing.Point(140, 308);
            this.tCliente.Name = "tCliente";
            this.tCliente.ReadOnly = true;
            this.tCliente.Size = new System.Drawing.Size(246, 35);
            this.tCliente.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 29);
            this.label7.TabIndex = 25;
            this.label7.Text = "Teléfono";
            // 
            // direCliente
            // 
            this.direCliente.Enabled = false;
            this.direCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.direCliente.Location = new System.Drawing.Point(140, 246);
            this.direCliente.Name = "direCliente";
            this.direCliente.ReadOnly = true;
            this.direCliente.Size = new System.Drawing.Size(246, 35);
            this.direCliente.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "Direccion";
            // 
            // aCliente
            // 
            this.aCliente.Enabled = false;
            this.aCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.aCliente.Location = new System.Drawing.Point(140, 186);
            this.aCliente.Name = "aCliente";
            this.aCliente.ReadOnly = true;
            this.aCliente.Size = new System.Drawing.Size(246, 35);
            this.aCliente.TabIndex = 22;
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido.Location = new System.Drawing.Point(29, 186);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(98, 29);
            this.Apellido.TabIndex = 21;
            this.Apellido.Text = "Apellido";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(140, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(246, 35);
            this.textBox1.TabIndex = 20;
            // 
            // nCliente
            // 
            this.nCliente.AutoSize = true;
            this.nCliente.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nCliente.Location = new System.Drawing.Point(29, 126);
            this.nCliente.Name = "nCliente";
            this.nCliente.Size = new System.Drawing.Size(91, 29);
            this.nCliente.TabIndex = 19;
            this.nCliente.Text = "Nombre";
            // 
            // TBdnicliente
            // 
            this.TBdnicliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBdnicliente.Location = new System.Drawing.Point(140, 62);
            this.TBdnicliente.Name = "TBdnicliente";
            this.TBdnicliente.Size = new System.Drawing.Size(246, 35);
            this.TBdnicliente.TabIndex = 18;
            this.TBdnicliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBdnicliente_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Dni";
            // 
            // BagregarCompra
            // 
            this.BagregarCompra.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BagregarCompra.Location = new System.Drawing.Point(712, 365);
            this.BagregarCompra.Name = "BagregarCompra";
            this.BagregarCompra.Size = new System.Drawing.Size(179, 50);
            this.BagregarCompra.TabIndex = 3;
            this.BagregarCompra.Text = "Agregar";
            this.BagregarCompra.UseVisualStyleBackColor = true;
            this.BagregarCompra.Click += new System.EventHandler(this.BagregarCompra_Click);
            // 
            // BcancelarCompra
            // 
            this.BcancelarCompra.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.BcancelarCompra.Location = new System.Drawing.Point(897, 365);
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
            this.Bcompra.Location = new System.Drawing.Point(1185, 364);
            this.Bcompra.Name = "Bcompra";
            this.Bcompra.Size = new System.Drawing.Size(132, 66);
            this.Bcompra.TabIndex = 1;
            this.Bcompra.Text = "Finalizar Compra";
            this.Bcompra.UseVisualStyleBackColor = true;
            this.Bcompra.Click += new System.EventHandler(this.Bcompra_Click);
            // 
            // Lcliente
            // 
            this.Lcliente.AutoSize = true;
            this.Lcliente.Font = new System.Drawing.Font("Script MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lcliente.Location = new System.Drawing.Point(91, 9);
            this.Lcliente.Name = "Lcliente";
            this.Lcliente.Size = new System.Drawing.Size(227, 38);
            this.Lcliente.TabIndex = 10;
            this.Lcliente.Text = "Datos del cliente";
            // 
            // Lventa
            // 
            this.Lventa.AutoSize = true;
            this.Lventa.Font = new System.Drawing.Font("Script MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lventa.Location = new System.Drawing.Point(923, 9);
            this.Lventa.Name = "Lventa";
            this.Lventa.Size = new System.Drawing.Size(223, 38);
            this.Lventa.TabIndex = 10;
            this.Lventa.Text = "Detalle de venta";
            // 
            // DGcarrito
            // 
            this.DGcarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGcarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGcarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGcarrito.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGcarrito.Location = new System.Drawing.Point(0, 433);
            this.DGcarrito.Name = "DGcarrito";
            this.DGcarrito.RowHeadersWidth = 62;
            this.DGcarrito.RowTemplate.Height = 28;
            this.DGcarrito.Size = new System.Drawing.Size(1359, 296);
            this.DGcarrito.TabIndex = 3;
            this.DGcarrito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGcarrito_CellClick);
            // 
            // FagregarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(1385, 675);
            this.Controls.Add(this.DGcarrito);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FagregarVenta";
            this.Text = "FagregarVenta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGprodu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGcarrito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Bcompra;
        private System.Windows.Forms.Button BcancelarCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lventa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CtipoProd;
        private System.Windows.Forms.Button BagregarCompra;
        private System.Windows.Forms.DataGridView DGcarrito;
        private System.Windows.Forms.TextBox aCliente;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nCliente;
        private System.Windows.Forms.TextBox TBdnicliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lcliente;
        private System.Windows.Forms.TextBox tCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox direCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Bbuscardni;
        private System.Windows.Forms.ComboBox CBDetalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CBproducto;
        private System.Windows.Forms.TextBox emCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGprodu;
    }
}