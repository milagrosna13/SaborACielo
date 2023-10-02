namespace SaborAcielo
{
    partial class FagregarCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PagregarCliente = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.RBhombre = new System.Windows.Forms.RadioButton();
            this.RBmujer = new System.Windows.Forms.RadioButton();
            this.TBdireCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBtelCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBdniCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBapeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBnomCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BcancelCliente = new System.Windows.Forms.Button();
            this.BguardarCliente = new System.Windows.Forms.Button();
            this.DGclientes = new System.Windows.Forms.DataGridView();
            this.nombre_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direc_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baja_cliente = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PagregarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // PagregarCliente
            // 
            this.PagregarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PagregarCliente.AutoScroll = true;
            this.PagregarCliente.BackColor = System.Drawing.Color.RosyBrown;
            this.PagregarCliente.Controls.Add(this.label6);
            this.PagregarCliente.Controls.Add(this.RBhombre);
            this.PagregarCliente.Controls.Add(this.RBmujer);
            this.PagregarCliente.Controls.Add(this.TBdireCliente);
            this.PagregarCliente.Controls.Add(this.label5);
            this.PagregarCliente.Controls.Add(this.TBtelCliente);
            this.PagregarCliente.Controls.Add(this.label4);
            this.PagregarCliente.Controls.Add(this.TBdniCliente);
            this.PagregarCliente.Controls.Add(this.label3);
            this.PagregarCliente.Controls.Add(this.TBapeCliente);
            this.PagregarCliente.Controls.Add(this.label2);
            this.PagregarCliente.Controls.Add(this.TBnomCliente);
            this.PagregarCliente.Controls.Add(this.label1);
            this.PagregarCliente.Controls.Add(this.BcancelCliente);
            this.PagregarCliente.Controls.Add(this.BguardarCliente);
            this.PagregarCliente.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PagregarCliente.Location = new System.Drawing.Point(86, 32);
            this.PagregarCliente.Name = "PagregarCliente";
            this.PagregarCliente.Size = new System.Drawing.Size(902, 385);
            this.PagregarCliente.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(508, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sexo";
            // 
            // RBhombre
            // 
            this.RBhombre.AutoSize = true;
            this.RBhombre.Checked = true;
            this.RBhombre.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.RBhombre.Location = new System.Drawing.Point(626, 94);
            this.RBhombre.Name = "RBhombre";
            this.RBhombre.Size = new System.Drawing.Size(116, 33);
            this.RBhombre.TabIndex = 13;
            this.RBhombre.TabStop = true;
            this.RBhombre.Text = "Hombre";
            this.RBhombre.UseVisualStyleBackColor = true;
            // 
            // RBmujer
            // 
            this.RBmujer.AutoSize = true;
            this.RBmujer.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.RBmujer.Location = new System.Drawing.Point(756, 94);
            this.RBmujer.Name = "RBmujer";
            this.RBmujer.Size = new System.Drawing.Size(102, 33);
            this.RBmujer.TabIndex = 12;
            this.RBmujer.TabStop = true;
            this.RBmujer.Text = "Mujer";
            this.RBmujer.UseVisualStyleBackColor = true;
            // 
            // TBdireCliente
            // 
            this.TBdireCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBdireCliente.Location = new System.Drawing.Point(164, 223);
            this.TBdireCliente.Name = "TBdireCliente";
            this.TBdireCliente.Size = new System.Drawing.Size(390, 35);
            this.TBdireCliente.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Direccion";
            // 
            // TBtelCliente
            // 
            this.TBtelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBtelCliente.Location = new System.Drawing.Point(166, 157);
            this.TBtelCliente.Name = "TBtelCliente";
            this.TBtelCliente.Size = new System.Drawing.Size(265, 35);
            this.TBtelCliente.TabIndex = 9;
            this.TBtelCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBtelCliente_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dni";
            // 
            // TBdniCliente
            // 
            this.TBdniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBdniCliente.Location = new System.Drawing.Point(166, 85);
            this.TBdniCliente.Name = "TBdniCliente";
            this.TBdniCliente.Size = new System.Drawing.Size(265, 35);
            this.TBdniCliente.TabIndex = 7;
            this.TBdniCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBdniCliente_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefono";
            // 
            // TBapeCliente
            // 
            this.TBapeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBapeCliente.Location = new System.Drawing.Point(621, 12);
            this.TBapeCliente.Name = "TBapeCliente";
            this.TBapeCliente.Size = new System.Drawing.Size(265, 35);
            this.TBapeCliente.TabIndex = 5;
            this.TBapeCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBapeCliente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(472, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
            // 
            // TBnomCliente
            // 
            this.TBnomCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBnomCliente.Location = new System.Drawing.Point(166, 15);
            this.TBnomCliente.Name = "TBnomCliente";
            this.TBnomCliente.Size = new System.Drawing.Size(265, 35);
            this.TBnomCliente.TabIndex = 3;
            this.TBnomCliente.TextChanged += new System.EventHandler(this.TBnomCliente_TextChanged);
            this.TBnomCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBnomCliente_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // BcancelCliente
            // 
            this.BcancelCliente.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BcancelCliente.Image = global::SaborAcielo.Properties.Resources.cruz;
            this.BcancelCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BcancelCliente.Location = new System.Drawing.Point(436, 322);
            this.BcancelCliente.Name = "BcancelCliente";
            this.BcancelCliente.Size = new System.Drawing.Size(170, 49);
            this.BcancelCliente.TabIndex = 1;
            this.BcancelCliente.Text = "Cancelar";
            this.BcancelCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BcancelCliente.UseVisualStyleBackColor = true;
            this.BcancelCliente.Click += new System.EventHandler(this.BcancelCliente_Click);
            // 
            // BguardarCliente
            // 
            this.BguardarCliente.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BguardarCliente.Location = new System.Drawing.Point(183, 322);
            this.BguardarCliente.Name = "BguardarCliente";
            this.BguardarCliente.Size = new System.Drawing.Size(172, 49);
            this.BguardarCliente.TabIndex = 0;
            this.BguardarCliente.Text = "Guardar";
            this.BguardarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BguardarCliente.UseVisualStyleBackColor = true;
            this.BguardarCliente.Click += new System.EventHandler(this.BguardarCliente_Click);
            // 
            // DGclientes
            // 
            this.DGclientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGclientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGclientes.BackgroundColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGclientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre_cliente,
            this.apellido_cliente,
            this.dni_cliente,
            this.sexo_cliente,
            this.tel_cliente,
            this.direc_cliente,
            this.estado_cliente,
            this.baja_cliente});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGclientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGclientes.Location = new System.Drawing.Point(31, 455);
            this.DGclientes.Name = "DGclientes";
            this.DGclientes.RowHeadersWidth = 62;
            this.DGclientes.RowTemplate.Height = 28;
            this.DGclientes.Size = new System.Drawing.Size(1048, 208);
            this.DGclientes.TabIndex = 1;
            this.DGclientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGclientes_CellClick);
            this.DGclientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGclientes_CellFormatting);
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.HeaderText = "Nombre";
            this.nombre_cliente.MinimumWidth = 8;
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.ReadOnly = true;
            // 
            // apellido_cliente
            // 
            this.apellido_cliente.HeaderText = "Apellido";
            this.apellido_cliente.MinimumWidth = 8;
            this.apellido_cliente.Name = "apellido_cliente";
            this.apellido_cliente.ReadOnly = true;
            // 
            // dni_cliente
            // 
            this.dni_cliente.HeaderText = "DNI";
            this.dni_cliente.MinimumWidth = 8;
            this.dni_cliente.Name = "dni_cliente";
            this.dni_cliente.ReadOnly = true;
            // 
            // sexo_cliente
            // 
            this.sexo_cliente.HeaderText = "Sexo";
            this.sexo_cliente.MinimumWidth = 8;
            this.sexo_cliente.Name = "sexo_cliente";
            this.sexo_cliente.ReadOnly = true;
            // 
            // tel_cliente
            // 
            this.tel_cliente.HeaderText = "Teléfono";
            this.tel_cliente.MinimumWidth = 8;
            this.tel_cliente.Name = "tel_cliente";
            this.tel_cliente.ReadOnly = true;
            // 
            // direc_cliente
            // 
            this.direc_cliente.HeaderText = "Dirección";
            this.direc_cliente.MinimumWidth = 8;
            this.direc_cliente.Name = "direc_cliente";
            this.direc_cliente.ReadOnly = true;
            // 
            // estado_cliente
            // 
            this.estado_cliente.HeaderText = "Estado";
            this.estado_cliente.MinimumWidth = 8;
            this.estado_cliente.Name = "estado_cliente";
            // 
            // baja_cliente
            // 
            this.baja_cliente.HeaderText = "Eliminar";
            this.baja_cliente.MinimumWidth = 8;
            this.baja_cliente.Name = "baja_cliente";
            // 
            // FagregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(1082, 675);
            this.Controls.Add(this.DGclientes);
            this.Controls.Add(this.PagregarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FagregarCliente";
            this.Text = "Agregar Cliente";
            this.PagregarCliente.ResumeLayout(false);
            this.PagregarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGclientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PagregarCliente;
        private System.Windows.Forms.DataGridView DGclientes;
        private System.Windows.Forms.TextBox TBnomCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BcancelCliente;
        private System.Windows.Forms.Button BguardarCliente;
        private System.Windows.Forms.TextBox TBdireCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBtelCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBdniCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBapeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RBhombre;
        private System.Windows.Forms.RadioButton RBmujer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn direc_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_cliente;
        private System.Windows.Forms.DataGridViewButtonColumn baja_cliente;
    }
}