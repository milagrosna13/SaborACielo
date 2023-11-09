namespace SaborAcielo
{
    partial class Fproducto
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
            this.DGlistaProductos = new System.Windows.Forms.DataGridView();
            this.GBfiltroProductos = new System.Windows.Forms.GroupBox();
            this.CBtipo = new System.Windows.Forms.CheckBox();
            this.CBnombre = new System.Windows.Forms.CheckBox();
            this.DTfechaIng = new System.Windows.Forms.DateTimePicker();
            this.CBfecha = new System.Windows.Forms.CheckBox();
            this.CfiltroTipo = new System.Windows.Forms.ComboBox();
            this.CnombreProd = new System.Windows.Forms.ComboBox();
            this.BbuscarProducto = new System.Windows.Forms.Button();
            this.CBtodosProductos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaProductos)).BeginInit();
            this.GBfiltroProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGlistaProductos
            // 
            this.DGlistaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGlistaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGlistaProductos.BackgroundColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGlistaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGlistaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGlistaProductos.Location = new System.Drawing.Point(29, 169);
            this.DGlistaProductos.Margin = new System.Windows.Forms.Padding(2);
            this.DGlistaProductos.Name = "DGlistaProductos";
            this.DGlistaProductos.RowHeadersWidth = 62;
            this.DGlistaProductos.RowTemplate.Height = 28;
            this.DGlistaProductos.Size = new System.Drawing.Size(747, 270);
            this.DGlistaProductos.TabIndex = 7;
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
            this.GBfiltroProductos.Location = new System.Drawing.Point(29, 12);
            this.GBfiltroProductos.Name = "GBfiltroProductos";
            this.GBfiltroProductos.Size = new System.Drawing.Size(747, 152);
            this.GBfiltroProductos.TabIndex = 8;
            this.GBfiltroProductos.TabStop = false;
            this.GBfiltroProductos.Text = "Filtrar por";
            // 
            // CBtipo
            // 
            this.CBtipo.AutoSize = true;
            this.CBtipo.Location = new System.Drawing.Point(374, 30);
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
            this.CBnombre.Location = new System.Drawing.Point(178, 30);
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
            this.DTfechaIng.Location = new System.Drawing.Point(588, 58);
            this.DTfechaIng.Name = "DTfechaIng";
            this.DTfechaIng.Size = new System.Drawing.Size(108, 27);
            this.DTfechaIng.TabIndex = 23;
            // 
            // CBfecha
            // 
            this.CBfecha.AutoSize = true;
            this.CBfecha.Location = new System.Drawing.Point(566, 30);
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
            this.CfiltroTipo.Location = new System.Drawing.Point(374, 58);
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
            this.CnombreProd.Location = new System.Drawing.Point(185, 58);
            this.CnombreProd.Margin = new System.Windows.Forms.Padding(2);
            this.CnombreProd.Name = "CnombreProd";
            this.CnombreProd.Size = new System.Drawing.Size(159, 27);
            this.CnombreProd.TabIndex = 20;
            this.CnombreProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CnombreProd_KeyPress);
            // 
            // BbuscarProducto
            // 
            this.BbuscarProducto.Location = new System.Drawing.Point(344, 106);
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
            this.CBtodosProductos.Location = new System.Drawing.Point(17, 58);
            this.CBtodosProductos.Name = "CBtodosProductos";
            this.CBtodosProductos.Size = new System.Drawing.Size(154, 23);
            this.CBtodosProductos.TabIndex = 2;
            this.CBtodosProductos.Text = "Todos los productos";
            this.CBtodosProductos.UseVisualStyleBackColor = true;
            this.CBtodosProductos.CheckedChanged += new System.EventHandler(this.CBtodosProductos_CheckedChanged);
            // 
            // Fproducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GBfiltroProductos);
            this.Controls.Add(this.DGlistaProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fproducto";
            this.Text = "Lista de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaProductos)).EndInit();
            this.GBfiltroProductos.ResumeLayout(false);
            this.GBfiltroProductos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGlistaProductos;
        private System.Windows.Forms.GroupBox GBfiltroProductos;
        private System.Windows.Forms.CheckBox CBtipo;
        private System.Windows.Forms.CheckBox CBnombre;
        private System.Windows.Forms.DateTimePicker DTfechaIng;
        private System.Windows.Forms.CheckBox CBfecha;
        private System.Windows.Forms.ComboBox CfiltroTipo;
        private System.Windows.Forms.ComboBox CnombreProd;
        private System.Windows.Forms.Button BbuscarProducto;
        private System.Windows.Forms.CheckBox CBtodosProductos;
    }
}