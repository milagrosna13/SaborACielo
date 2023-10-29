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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBdet = new System.Windows.Forms.CheckBox();
            this.CBproduc = new System.Windows.Forms.CheckBox();
            this.CBtipo = new System.Windows.Forms.CheckBox();
            this.CtipoProd = new System.Windows.Forms.ComboBox();
            this.CBproducto = new System.Windows.Forms.ComboBox();
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
            this.nomCliente = new System.Windows.Forms.TextBox();
            this.nCliente = new System.Windows.Forms.Label();
            this.TBdnicliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BcancelarCompra = new System.Windows.Forms.Button();
            this.Bcompra = new System.Windows.Forms.Button();
            this.Lcliente = new System.Windows.Forms.Label();
            this.Lventa = new System.Windows.Forms.Label();
            this.DGcarrito = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGprodu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGcarrito)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.DGprodu);
            this.panel1.Controls.Add(this.Lventa);
            this.panel1.Location = new System.Drawing.Point(451, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 651);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBdet);
            this.groupBox1.Controls.Add(this.CBproduc);
            this.groupBox1.Controls.Add(this.BcancelarCompra);
            this.groupBox1.Controls.Add(this.CBtipo);
            this.groupBox1.Controls.Add(this.CtipoProd);
            this.groupBox1.Controls.Add(this.CBproducto);
            this.groupBox1.Controls.Add(this.CBDetalle);
            this.groupBox1.Font = new System.Drawing.Font("Script MT Bold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 174);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por";
            // 
            // CBdet
            // 
            this.CBdet.AutoSize = true;
            this.CBdet.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBdet.Location = new System.Drawing.Point(642, 28);
            this.CBdet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBdet.Name = "CBdet";
            this.CBdet.Size = new System.Drawing.Size(93, 28);
            this.CBdet.TabIndex = 32;
            this.CBdet.Text = "Detalle";
            this.CBdet.UseVisualStyleBackColor = true;
            // 
            // CBproduc
            // 
            this.CBproduc.AutoSize = true;
            this.CBproduc.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBproduc.Location = new System.Drawing.Point(352, 28);
            this.CBproduc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBproduc.Name = "CBproduc";
            this.CBproduc.Size = new System.Drawing.Size(108, 28);
            this.CBproduc.TabIndex = 31;
            this.CBproduc.Text = "Producto";
            this.CBproduc.UseVisualStyleBackColor = true;
            // 
            // CBtipo
            // 
            this.CBtipo.AutoSize = true;
            this.CBtipo.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBtipo.Location = new System.Drawing.Point(16, 28);
            this.CBtipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBtipo.Name = "CBtipo";
            this.CBtipo.Size = new System.Drawing.Size(174, 28);
            this.CBtipo.TabIndex = 30;
            this.CBtipo.Text = "Tipo de Producto";
            this.CBtipo.UseVisualStyleBackColor = true;
            // 
            // CtipoProd
            // 
            this.CtipoProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CtipoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtipoProd.FormattingEnabled = true;
            this.CtipoProd.Location = new System.Drawing.Point(16, 77);
            this.CtipoProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CtipoProd.Name = "CtipoProd";
            this.CtipoProd.Size = new System.Drawing.Size(312, 34);
            this.CtipoProd.TabIndex = 7;
            this.CtipoProd.SelectedIndexChanged += new System.EventHandler(this.CtipoProd_SelectedIndexChanged);
            // 
            // CBproducto
            // 
            this.CBproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBproducto.FormattingEnabled = true;
            this.CBproducto.Location = new System.Drawing.Point(338, 77);
            this.CBproducto.Name = "CBproducto";
            this.CBproducto.Size = new System.Drawing.Size(280, 34);
            this.CBproducto.TabIndex = 27;
            this.CBproducto.SelectedIndexChanged += new System.EventHandler(this.CBproducto_SelectedIndexChanged);
            // 
            // CBDetalle
            // 
            this.CBDetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBDetalle.FormattingEnabled = true;
            this.CBDetalle.Location = new System.Drawing.Point(624, 77);
            this.CBDetalle.Name = "CBDetalle";
            this.CBDetalle.Size = new System.Drawing.Size(280, 34);
            this.CBDetalle.TabIndex = 29;
            this.CBDetalle.SelectedIndexChanged += new System.EventHandler(this.CBDetalle_SelectedIndexChanged);
            // 
            // DGprodu
            // 
            this.DGprodu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGprodu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGprodu.Location = new System.Drawing.Point(4, 247);
            this.DGprodu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGprodu.Name = "DGprodu";
            this.DGprodu.RowHeadersWidth = 62;
            this.DGprodu.RowTemplate.Height = 28;
            this.DGprodu.Size = new System.Drawing.Size(1005, 391);
            this.DGprodu.TabIndex = 33;
            this.DGprodu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGprodu_CellContentClick);
            // 
            // emCliente
            // 
            this.emCliente.Enabled = false;
            this.emCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emCliente.Location = new System.Drawing.Point(120, 368);
            this.emCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emCliente.Name = "emCliente";
            this.emCliente.ReadOnly = true;
            this.emCliente.Size = new System.Drawing.Size(229, 35);
            this.emCliente.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Script MT Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 368);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 27);
            this.label10.TabIndex = 31;
            this.label10.Text = "Email";
            // 
            // Bbuscardni
            // 
            this.Bbuscardni.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bbuscardni.Location = new System.Drawing.Point(349, 48);
            this.Bbuscardni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.tCliente.Location = new System.Drawing.Point(120, 309);
            this.tCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tCliente.Name = "tCliente";
            this.tCliente.ReadOnly = true;
            this.tCliente.Size = new System.Drawing.Size(229, 35);
            this.tCliente.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Script MT Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 309);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 27);
            this.label7.TabIndex = 25;
            this.label7.Text = "Teléfono";
            // 
            // direCliente
            // 
            this.direCliente.Enabled = false;
            this.direCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.direCliente.Location = new System.Drawing.Point(120, 251);
            this.direCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.direCliente.Name = "direCliente";
            this.direCliente.ReadOnly = true;
            this.direCliente.Size = new System.Drawing.Size(229, 35);
            this.direCliente.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Script MT Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 251);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 27);
            this.label8.TabIndex = 23;
            this.label8.Text = "Direccion";
            // 
            // aCliente
            // 
            this.aCliente.Enabled = false;
            this.aCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.aCliente.Location = new System.Drawing.Point(120, 192);
            this.aCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aCliente.Name = "aCliente";
            this.aCliente.ReadOnly = true;
            this.aCliente.Size = new System.Drawing.Size(229, 35);
            this.aCliente.TabIndex = 22;
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Font = new System.Drawing.Font("Script MT Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido.Location = new System.Drawing.Point(25, 192);
            this.Apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(87, 27);
            this.Apellido.TabIndex = 21;
            this.Apellido.Text = "Apellido";
            // 
            // nomCliente
            // 
            this.nomCliente.Enabled = false;
            this.nomCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nomCliente.Location = new System.Drawing.Point(120, 134);
            this.nomCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nomCliente.Name = "nomCliente";
            this.nomCliente.ReadOnly = true;
            this.nomCliente.Size = new System.Drawing.Size(229, 35);
            this.nomCliente.TabIndex = 20;
            // 
            // nCliente
            // 
            this.nCliente.AutoSize = true;
            this.nCliente.Font = new System.Drawing.Font("Script MT Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nCliente.Location = new System.Drawing.Point(25, 134);
            this.nCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nCliente.Name = "nCliente";
            this.nCliente.Size = new System.Drawing.Size(83, 27);
            this.nCliente.TabIndex = 19;
            this.nCliente.Text = "Nombre";
            // 
            // TBdnicliente
            // 
            this.TBdnicliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBdnicliente.Location = new System.Drawing.Point(81, 54);
            this.TBdnicliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBdnicliente.Name = "TBdnicliente";
            this.TBdnicliente.Size = new System.Drawing.Size(246, 35);
            this.TBdnicliente.TabIndex = 18;
            this.TBdnicliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBdnicliente_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Dni";
            // 
            // BcancelarCompra
            // 
            this.BcancelarCompra.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.BcancelarCompra.Location = new System.Drawing.Point(746, 119);
            this.BcancelarCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BcancelarCompra.Name = "BcancelarCompra";
            this.BcancelarCompra.Size = new System.Drawing.Size(148, 49);
            this.BcancelarCompra.TabIndex = 2;
            this.BcancelarCompra.Text = "Cancelar";
            this.BcancelarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BcancelarCompra.UseVisualStyleBackColor = true;
            this.BcancelarCompra.Click += new System.EventHandler(this.BcancelarCompra_Click);
            // 
            // Bcompra
            // 
            this.Bcompra.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.Bcompra.Location = new System.Drawing.Point(132, 553);
            this.Bcompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bcompra.Name = "Bcompra";
            this.Bcompra.Size = new System.Drawing.Size(132, 72);
            this.Bcompra.TabIndex = 1;
            this.Bcompra.Text = "Finalizar Compra";
            this.Bcompra.UseVisualStyleBackColor = true;
            this.Bcompra.Click += new System.EventHandler(this.Bcompra_Click);
            // 
            // Lcliente
            // 
            this.Lcliente.AutoSize = true;
            this.Lcliente.Font = new System.Drawing.Font("Script MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lcliente.Location = new System.Drawing.Point(76, 6);
            this.Lcliente.Name = "Lcliente";
            this.Lcliente.Size = new System.Drawing.Size(227, 38);
            this.Lcliente.TabIndex = 10;
            this.Lcliente.Text = "Datos del cliente";
            // 
            // Lventa
            // 
            this.Lventa.AutoSize = true;
            this.Lventa.Font = new System.Drawing.Font("Script MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lventa.Location = new System.Drawing.Point(421, 11);
            this.Lventa.Name = "Lventa";
            this.Lventa.Size = new System.Drawing.Size(223, 38);
            this.Lventa.TabIndex = 10;
            this.Lventa.Text = "Detalle de venta";
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
            this.DGcarrito.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGcarrito.Location = new System.Drawing.Point(0, 663);
            this.DGcarrito.Name = "DGcarrito";
            this.DGcarrito.RowHeadersWidth = 62;
            this.DGcarrito.RowTemplate.Height = 28;
            this.DGcarrito.Size = new System.Drawing.Size(1476, 534);
            this.DGcarrito.TabIndex = 3;
            this.DGcarrito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGcarrito_CellClick);
            this.DGcarrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGcarrito_CellContentClick);
            this.DGcarrito.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGcarrito_CellValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TBdnicliente);
            this.panel2.Controls.Add(this.Bbuscardni);
            this.panel2.Controls.Add(this.emCliente);
            this.panel2.Controls.Add(this.nCliente);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.Lcliente);
            this.panel2.Controls.Add(this.nomCliente);
            this.panel2.Controls.Add(this.Apellido);
            this.panel2.Controls.Add(this.tCliente);
            this.panel2.Controls.Add(this.aCliente);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.direCliente);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 449);
            this.panel2.TabIndex = 4;
            // 
            // FagregarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(1502, 1038);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DGcarrito);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Bcompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FagregarVenta";
            this.Text = "FagregarVenta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGprodu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGcarrito)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Bcompra;
        private System.Windows.Forms.Button BcancelarCompra;
        private System.Windows.Forms.Label Lventa;
        private System.Windows.Forms.ComboBox CtipoProd;
        private System.Windows.Forms.DataGridView DGcarrito;
        private System.Windows.Forms.TextBox aCliente;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.TextBox nomCliente;
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
        private System.Windows.Forms.ComboBox CBproducto;
        private System.Windows.Forms.TextBox emCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGprodu;
        private System.Windows.Forms.CheckBox CBdet;
        private System.Windows.Forms.CheckBox CBproduc;
        private System.Windows.Forms.CheckBox CBtipo;
        private System.Windows.Forms.Panel panel2;
    }
}