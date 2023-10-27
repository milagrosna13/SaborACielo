namespace SaborAcielo
{
    partial class FlistaProductosAdmin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlistaProductosAdmin));
            this.DGlistaProductos = new System.Windows.Forms.DataGridView();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GBfiltroProductos = new System.Windows.Forms.GroupBox();
            this.CBtipo = new System.Windows.Forms.CheckBox();
            this.CBnombre = new System.Windows.Forms.CheckBox();
            this.DTfechaIng = new System.Windows.Forms.DateTimePicker();
            this.CBfecha = new System.Windows.Forms.CheckBox();
            this.CfiltroTipo = new System.Windows.Forms.ComboBox();
            this.CnombreProd = new System.Windows.Forms.ComboBox();
            this.BbuscarProducto = new System.Windows.Forms.Button();
            this.CBtodosProductos = new System.Windows.Forms.CheckBox();
            this.PagregarProdu = new System.Windows.Forms.Panel();
            this.BcancelarEditar = new System.Windows.Forms.Button();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TBdetalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CtipoProd = new System.Windows.Forms.ComboBox();
            this.BeditarProd = new System.Windows.Forms.Button();
            this.BexaminarImProdu = new System.Windows.Forms.Button();
            this.PBproducto = new System.Windows.Forms.PictureBox();
            this.BagregarProdu = new System.Windows.Forms.Button();
            this.TBcantidadProdu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBprecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBnomProdu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BcancelProdu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.GBfiltroProductos.SuspendLayout();
            this.PagregarProdu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBproducto)).BeginInit();
            this.SuspendLayout();
            // 
            // DGlistaProductos
            // 
            this.DGlistaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGlistaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGlistaProductos.BackgroundColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGlistaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGlistaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGlistaProductos.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGlistaProductos.Location = new System.Drawing.Point(38, 347);
            this.DGlistaProductos.Margin = new System.Windows.Forms.Padding(2);
            this.DGlistaProductos.Name = "DGlistaProductos";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGlistaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGlistaProductos.RowHeadersWidth = 62;
            this.DGlistaProductos.RowTemplate.Height = 28;
            this.DGlistaProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGlistaProductos.Size = new System.Drawing.Size(747, 154);
            this.DGlistaProductos.TabIndex = 6;
            this.DGlistaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGlistaProductos_CellContentClick);
            this.DGlistaProductos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGlistaProductos_CellFormatting);
            // 
            // GBfiltroProductos
            // 
            this.GBfiltroProductos.BackColor = System.Drawing.Color.Transparent;
            this.GBfiltroProductos.Controls.Add(this.CBtipo);
            this.GBfiltroProductos.Controls.Add(this.CBnombre);
            this.GBfiltroProductos.Controls.Add(this.DTfechaIng);
            this.GBfiltroProductos.Controls.Add(this.CBfecha);
            this.GBfiltroProductos.Controls.Add(this.CfiltroTipo);
            this.GBfiltroProductos.Controls.Add(this.CnombreProd);
            this.GBfiltroProductos.Controls.Add(this.BbuscarProducto);
            this.GBfiltroProductos.Controls.Add(this.CBtodosProductos);
            this.GBfiltroProductos.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.GBfiltroProductos.Location = new System.Drawing.Point(19, 15);
            this.GBfiltroProductos.Name = "GBfiltroProductos";
            this.GBfiltroProductos.Size = new System.Drawing.Size(209, 312);
            this.GBfiltroProductos.TabIndex = 5;
            this.GBfiltroProductos.TabStop = false;
            this.GBfiltroProductos.Text = "Filtrar por";
            // 
            // CBtipo
            // 
            this.CBtipo.AutoSize = true;
            this.CBtipo.Location = new System.Drawing.Point(19, 106);
            this.CBtipo.Name = "CBtipo";
            this.CBtipo.Size = new System.Drawing.Size(59, 23);
            this.CBtipo.TabIndex = 25;
            this.CBtipo.Text = "Tipo";
            this.CBtipo.UseVisualStyleBackColor = true;
            this.CBtipo.CheckedChanged += new System.EventHandler(this.CBtipo_CheckedChanged);
            // 
            // CBnombre
            // 
            this.CBnombre.AutoSize = true;
            this.CBnombre.Location = new System.Drawing.Point(19, 53);
            this.CBnombre.Name = "CBnombre";
            this.CBnombre.Size = new System.Drawing.Size(80, 23);
            this.CBnombre.TabIndex = 24;
            this.CBnombre.Text = "Nombre";
            this.CBnombre.UseVisualStyleBackColor = true;
            this.CBnombre.CheckedChanged += new System.EventHandler(this.CBnombre_CheckedChanged);
            // 
            // DTfechaIng
            // 
            this.DTfechaIng.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTfechaIng.Location = new System.Drawing.Point(26, 198);
            this.DTfechaIng.Name = "DTfechaIng";
            this.DTfechaIng.Size = new System.Drawing.Size(108, 27);
            this.DTfechaIng.TabIndex = 23;
            // 
            // CBfecha
            // 
            this.CBfecha.AutoSize = true;
            this.CBfecha.Location = new System.Drawing.Point(19, 169);
            this.CBfecha.Name = "CBfecha";
            this.CBfecha.Size = new System.Drawing.Size(157, 23);
            this.CBfecha.TabIndex = 22;
            this.CBfecha.Text = "Por fecha de ingreso";
            this.CBfecha.UseVisualStyleBackColor = true;
            // 
            // CfiltroTipo
            // 
            this.CfiltroTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CfiltroTipo.Enabled = false;
            this.CfiltroTipo.FormattingEnabled = true;
            this.CfiltroTipo.Location = new System.Drawing.Point(26, 132);
            this.CfiltroTipo.Margin = new System.Windows.Forms.Padding(2);
            this.CfiltroTipo.Name = "CfiltroTipo";
            this.CfiltroTipo.Size = new System.Drawing.Size(159, 27);
            this.CfiltroTipo.TabIndex = 21;
            // 
            // CnombreProd
            // 
            this.CnombreProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CnombreProd.Enabled = false;
            this.CnombreProd.FormattingEnabled = true;
            this.CnombreProd.Location = new System.Drawing.Point(26, 81);
            this.CnombreProd.Margin = new System.Windows.Forms.Padding(2);
            this.CnombreProd.Name = "CnombreProd";
            this.CnombreProd.Size = new System.Drawing.Size(159, 27);
            this.CnombreProd.TabIndex = 20;
            // 
            // BbuscarProducto
            // 
            this.BbuscarProducto.Location = new System.Drawing.Point(59, 265);
            this.BbuscarProducto.Name = "BbuscarProducto";
            this.BbuscarProducto.Size = new System.Drawing.Size(75, 30);
            this.BbuscarProducto.TabIndex = 5;
            this.BbuscarProducto.Text = "Buscar";
            this.BbuscarProducto.UseVisualStyleBackColor = true;
            this.BbuscarProducto.Click += new System.EventHandler(this.BbuscarProducto_Click);
            // 
            // CBtodosProductos
            // 
            this.CBtodosProductos.AutoSize = true;
            this.CBtodosProductos.Location = new System.Drawing.Point(19, 26);
            this.CBtodosProductos.Name = "CBtodosProductos";
            this.CBtodosProductos.Size = new System.Drawing.Size(154, 23);
            this.CBtodosProductos.TabIndex = 2;
            this.CBtodosProductos.Text = "Todos los productos";
            this.CBtodosProductos.UseVisualStyleBackColor = true;
            // 
            // PagregarProdu
            // 
            this.PagregarProdu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PagregarProdu.AutoScroll = true;
            this.PagregarProdu.BackColor = System.Drawing.Color.RosyBrown;
            this.PagregarProdu.Controls.Add(this.BcancelarEditar);
            this.PagregarProdu.Controls.Add(this.dtFecha);
            this.PagregarProdu.Controls.Add(this.label6);
            this.PagregarProdu.Controls.Add(this.TBdetalle);
            this.PagregarProdu.Controls.Add(this.label2);
            this.PagregarProdu.Controls.Add(this.CtipoProd);
            this.PagregarProdu.Controls.Add(this.BeditarProd);
            this.PagregarProdu.Controls.Add(this.BexaminarImProdu);
            this.PagregarProdu.Controls.Add(this.PBproducto);
            this.PagregarProdu.Controls.Add(this.BagregarProdu);
            this.PagregarProdu.Controls.Add(this.TBcantidadProdu);
            this.PagregarProdu.Controls.Add(this.label5);
            this.PagregarProdu.Controls.Add(this.TBprecio);
            this.PagregarProdu.Controls.Add(this.label4);
            this.PagregarProdu.Controls.Add(this.label3);
            this.PagregarProdu.Controls.Add(this.TBnomProdu);
            this.PagregarProdu.Controls.Add(this.label1);
            this.PagregarProdu.Controls.Add(this.BcancelProdu);
            this.PagregarProdu.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PagregarProdu.Location = new System.Drawing.Point(242, 15);
            this.PagregarProdu.Margin = new System.Windows.Forms.Padding(2);
            this.PagregarProdu.Name = "PagregarProdu";
            this.PagregarProdu.Size = new System.Drawing.Size(547, 312);
            this.PagregarProdu.TabIndex = 7;
            // 
            // BcancelarEditar
            // 
            this.BcancelarEditar.BackColor = System.Drawing.Color.Snow;
            this.BcancelarEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BcancelarEditar.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.BcancelarEditar.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BcancelarEditar.Image = ((System.Drawing.Image)(resources.GetObject("BcancelarEditar.Image")));
            this.BcancelarEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BcancelarEditar.Location = new System.Drawing.Point(349, 265);
            this.BcancelarEditar.Margin = new System.Windows.Forms.Padding(2);
            this.BcancelarEditar.Name = "BcancelarEditar";
            this.BcancelarEditar.Size = new System.Drawing.Size(120, 32);
            this.BcancelarEditar.TabIndex = 24;
            this.BcancelarEditar.Text = "Cancelar";
            this.BcancelarEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BcancelarEditar.UseVisualStyleBackColor = false;
            this.BcancelarEditar.Click += new System.EventHandler(this.BcancelarEditar_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(327, 221);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(107, 24);
            this.dtFecha.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(217, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Fecha ingreso";
            // 
            // TBdetalle
            // 
            this.TBdetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBdetalle.Location = new System.Drawing.Point(111, 103);
            this.TBdetalle.Margin = new System.Windows.Forms.Padding(2);
            this.TBdetalle.Multiline = true;
            this.TBdetalle.Name = "TBdetalle";
            this.TBdetalle.Size = new System.Drawing.Size(228, 70);
            this.TBdetalle.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Detalle";
            // 
            // CtipoProd
            // 
            this.CtipoProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CtipoProd.FormattingEnabled = true;
            this.CtipoProd.Items.AddRange(new object[] {
            "Regular",
            "Vegano",
            "Sin T.A.C.C"});
            this.CtipoProd.Location = new System.Drawing.Point(111, 57);
            this.CtipoProd.Margin = new System.Windows.Forms.Padding(2);
            this.CtipoProd.Name = "CtipoProd";
            this.CtipoProd.Size = new System.Drawing.Size(225, 23);
            this.CtipoProd.TabIndex = 19;
            // 
            // BeditarProd
            // 
            this.BeditarProd.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeditarProd.Image = ((System.Drawing.Image)(resources.GetObject("BeditarProd.Image")));
            this.BeditarProd.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BeditarProd.Location = new System.Drawing.Point(71, 265);
            this.BeditarProd.Margin = new System.Windows.Forms.Padding(2);
            this.BeditarProd.Name = "BeditarProd";
            this.BeditarProd.Size = new System.Drawing.Size(125, 32);
            this.BeditarProd.TabIndex = 18;
            this.BeditarProd.Text = "Modificar";
            this.BeditarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BeditarProd.UseVisualStyleBackColor = true;
            this.BeditarProd.Click += new System.EventHandler(this.BeditarProd_Click);
            // 
            // BexaminarImProdu
            // 
            this.BexaminarImProdu.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.BexaminarImProdu.Location = new System.Drawing.Point(413, 169);
            this.BexaminarImProdu.Name = "BexaminarImProdu";
            this.BexaminarImProdu.Size = new System.Drawing.Size(95, 27);
            this.BexaminarImProdu.TabIndex = 17;
            this.BexaminarImProdu.Text = "Examinar";
            this.BexaminarImProdu.UseVisualStyleBackColor = true;
            this.BexaminarImProdu.Click += new System.EventHandler(this.BexaminarImProdu_Click_1);
            // 
            // PBproducto
            // 
            this.PBproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBproducto.Image = global::SaborAcielo.Properties.Resources.ProductosInicio;
            this.PBproducto.Location = new System.Drawing.Point(392, 14);
            this.PBproducto.Name = "PBproducto";
            this.PBproducto.Size = new System.Drawing.Size(135, 135);
            this.PBproducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBproducto.TabIndex = 16;
            this.PBproducto.TabStop = false;
            // 
            // BagregarProdu
            // 
            this.BagregarProdu.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BagregarProdu.Image = ((System.Drawing.Image)(resources.GetObject("BagregarProdu.Image")));
            this.BagregarProdu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BagregarProdu.Location = new System.Drawing.Point(71, 265);
            this.BagregarProdu.Margin = new System.Windows.Forms.Padding(2);
            this.BagregarProdu.Name = "BagregarProdu";
            this.BagregarProdu.Size = new System.Drawing.Size(115, 32);
            this.BagregarProdu.TabIndex = 15;
            this.BagregarProdu.Text = "Agregar";
            this.BagregarProdu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BagregarProdu.UseVisualStyleBackColor = true;
            this.BagregarProdu.Click += new System.EventHandler(this.BagregarProdu_Click_1);
            // 
            // TBcantidadProdu
            // 
            this.TBcantidadProdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBcantidadProdu.Location = new System.Drawing.Point(111, 218);
            this.TBcantidadProdu.Margin = new System.Windows.Forms.Padding(2);
            this.TBcantidadProdu.Name = "TBcantidadProdu";
            this.TBcantidadProdu.Size = new System.Drawing.Size(62, 26);
            this.TBcantidadProdu.TabIndex = 11;
            this.TBcantidadProdu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBcantidadProdu_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stock";
            // 
            // TBprecio
            // 
            this.TBprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBprecio.Location = new System.Drawing.Point(111, 177);
            this.TBprecio.Margin = new System.Windows.Forms.Padding(2);
            this.TBprecio.Name = "TBprecio";
            this.TBprecio.Size = new System.Drawing.Size(229, 26);
            this.TBprecio.TabIndex = 9;
            this.TBprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBprecio_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio";
            // 
            // TBnomProdu
            // 
            this.TBnomProdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBnomProdu.Location = new System.Drawing.Point(111, 10);
            this.TBnomProdu.Margin = new System.Windows.Forms.Padding(2);
            this.TBnomProdu.Name = "TBnomProdu";
            this.TBnomProdu.Size = new System.Drawing.Size(229, 26);
            this.TBnomProdu.TabIndex = 3;
            this.TBnomProdu.TextChanged += new System.EventHandler(this.TBnomProdu_TextChanged);
            this.TBnomProdu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBnomProdu_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // BcancelProdu
            // 
            this.BcancelProdu.BackColor = System.Drawing.Color.Snow;
            this.BcancelProdu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BcancelProdu.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.BcancelProdu.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BcancelProdu.Image = ((System.Drawing.Image)(resources.GetObject("BcancelProdu.Image")));
            this.BcancelProdu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BcancelProdu.Location = new System.Drawing.Point(349, 265);
            this.BcancelProdu.Margin = new System.Windows.Forms.Padding(2);
            this.BcancelProdu.Name = "BcancelProdu";
            this.BcancelProdu.Size = new System.Drawing.Size(120, 32);
            this.BcancelProdu.TabIndex = 1;
            this.BcancelProdu.Text = "Cancelar";
            this.BcancelProdu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BcancelProdu.UseVisualStyleBackColor = false;
            this.BcancelProdu.Click += new System.EventHandler(this.BcancelProdu_Click);
            // 
            // FlistaProductosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.PagregarProdu);
            this.Controls.Add(this.DGlistaProductos);
            this.Controls.Add(this.GBfiltroProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlistaProductosAdmin";
            this.Text = "Lista de Productos";
            this.Load += new System.EventHandler(this.FlistaProductosAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.GBfiltroProductos.ResumeLayout(false);
            this.GBfiltroProductos.PerformLayout();
            this.PagregarProdu.ResumeLayout(false);
            this.PagregarProdu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBproducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGlistaProductos;
        private System.Windows.Forms.GroupBox GBfiltroProductos;
        private System.Windows.Forms.CheckBox CBtodosProductos;
        private System.Windows.Forms.Panel PagregarProdu;
        private System.Windows.Forms.Button BagregarProdu;
        private System.Windows.Forms.TextBox TBcantidadProdu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBprecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBnomProdu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BcancelProdu;
        private System.Windows.Forms.Button BexaminarImProdu;
        private System.Windows.Forms.PictureBox PBproducto;
        private System.Windows.Forms.Button BbuscarProducto;
        private System.Windows.Forms.Button BeditarProd;
        private System.Windows.Forms.ComboBox CtipoProd;
        private System.Windows.Forms.TextBox TBdetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CfiltroTipo;
        private System.Windows.Forms.ComboBox CnombreProd;
        private System.Windows.Forms.DateTimePicker dtFecha;
       // private SaborAcieloDataSet1 saborAcieloDataSet1;
        private System.Windows.Forms.BindingSource productoBindingSource;
        //private SaborAcieloDataSet1TableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagenDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipoProduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BcancelarEditar;
        private System.Windows.Forms.CheckBox CBfecha;
        private System.Windows.Forms.DateTimePicker DTfechaIng;
        private System.Windows.Forms.CheckBox CBtipo;
        private System.Windows.Forms.CheckBox CBnombre;
    }
}