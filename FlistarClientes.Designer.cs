namespace SaborAcielo
{
    partial class FlistarClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGlistaCliente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBtodosClientes = new System.Windows.Forms.CheckBox();
            this.dni_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direc_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBapeCliente = new System.Windows.Forms.CheckBox();
            this.CBnomCliente = new System.Windows.Forms.CheckBox();
            this.CBdni = new System.Windows.Forms.CheckBox();
            this.Tape_cliente = new System.Windows.Forms.TextBox();
            this.Tnom_cliente = new System.Windows.Forms.TextBox();
            this.Tdni_cliente = new System.Windows.Forms.TextBox();
            this.BbuscarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGlistaCliente
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGlistaCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGlistaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGlistaCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGlistaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGlistaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dni_cliente,
            this.nombre_cliente,
            this.apellido_cliente,
            this.email_cliente,
            this.direc_cliente,
            this.tel_cliente,
            this.fecha_registro});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGlistaCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGlistaCliente.Location = new System.Drawing.Point(12, 349);
            this.DGlistaCliente.Name = "DGlistaCliente";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGlistaCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGlistaCliente.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGlistaCliente.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGlistaCliente.RowTemplate.Height = 28;
            this.DGlistaCliente.Size = new System.Drawing.Size(1078, 314);
            this.DGlistaCliente.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.BbuscarCliente);
            this.groupBox1.Controls.Add(this.Tdni_cliente);
            this.groupBox1.Controls.Add(this.Tnom_cliente);
            this.groupBox1.Controls.Add(this.Tape_cliente);
            this.groupBox1.Controls.Add(this.CBdni);
            this.groupBox1.Controls.Add(this.CBnomCliente);
            this.groupBox1.Controls.Add(this.CBapeCliente);
            this.groupBox1.Controls.Add(this.CBtodosClientes);
            this.groupBox1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(99, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por";
            // 
            // CBtodosClientes
            // 
            this.CBtodosClientes.AutoSize = true;
            this.CBtodosClientes.Location = new System.Drawing.Point(590, 70);
            this.CBtodosClientes.Name = "CBtodosClientes";
            this.CBtodosClientes.Size = new System.Drawing.Size(210, 33);
            this.CBtodosClientes.TabIndex = 0;
            this.CBtodosClientes.Text = "Todos los clientes";
            this.CBtodosClientes.UseVisualStyleBackColor = true;
            // 
            // dni_cliente
            // 
            this.dni_cliente.HeaderText = "Dni";
            this.dni_cliente.MinimumWidth = 8;
            this.dni_cliente.Name = "dni_cliente";
            this.dni_cliente.Width = 150;
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.HeaderText = "Nombre";
            this.nombre_cliente.MinimumWidth = 8;
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.Width = 150;
            // 
            // apellido_cliente
            // 
            this.apellido_cliente.HeaderText = "Apellido";
            this.apellido_cliente.MinimumWidth = 8;
            this.apellido_cliente.Name = "apellido_cliente";
            this.apellido_cliente.Width = 150;
            // 
            // email_cliente
            // 
            this.email_cliente.HeaderText = "Email";
            this.email_cliente.MinimumWidth = 8;
            this.email_cliente.Name = "email_cliente";
            this.email_cliente.Width = 150;
            // 
            // direc_cliente
            // 
            this.direc_cliente.HeaderText = "Direccion";
            this.direc_cliente.MinimumWidth = 8;
            this.direc_cliente.Name = "direc_cliente";
            this.direc_cliente.Width = 150;
            // 
            // tel_cliente
            // 
            this.tel_cliente.HeaderText = "Telefono";
            this.tel_cliente.MinimumWidth = 8;
            this.tel_cliente.Name = "tel_cliente";
            this.tel_cliente.Width = 150;
            // 
            // fecha_registro
            // 
            this.fecha_registro.HeaderText = "Fecha de registro";
            this.fecha_registro.MinimumWidth = 8;
            this.fecha_registro.Name = "fecha_registro";
            this.fecha_registro.Width = 150;
            // 
            // CBapeCliente
            // 
            this.CBapeCliente.AutoSize = true;
            this.CBapeCliente.Location = new System.Drawing.Point(6, 52);
            this.CBapeCliente.Name = "CBapeCliente";
            this.CBapeCliente.Size = new System.Drawing.Size(124, 33);
            this.CBapeCliente.TabIndex = 1;
            this.CBapeCliente.Text = "Apellido";
            this.CBapeCliente.UseVisualStyleBackColor = true;
            // 
            // CBnomCliente
            // 
            this.CBnomCliente.AutoSize = true;
            this.CBnomCliente.Location = new System.Drawing.Point(6, 108);
            this.CBnomCliente.Name = "CBnomCliente";
            this.CBnomCliente.Size = new System.Drawing.Size(117, 33);
            this.CBnomCliente.TabIndex = 2;
            this.CBnomCliente.Text = "Nombre";
            this.CBnomCliente.UseVisualStyleBackColor = true;
            // 
            // CBdni
            // 
            this.CBdni.AutoSize = true;
            this.CBdni.Location = new System.Drawing.Point(6, 167);
            this.CBdni.Name = "CBdni";
            this.CBdni.Size = new System.Drawing.Size(92, 33);
            this.CBdni.TabIndex = 3;
            this.CBdni.Text = "DNI";
            this.CBdni.UseVisualStyleBackColor = true;
            // 
            // Tape_cliente
            // 
            this.Tape_cliente.Location = new System.Drawing.Point(197, 49);
            this.Tape_cliente.Name = "Tape_cliente";
            this.Tape_cliente.ReadOnly = true;
            this.Tape_cliente.Size = new System.Drawing.Size(336, 36);
            this.Tape_cliente.TabIndex = 4;
            // 
            // Tnom_cliente
            // 
            this.Tnom_cliente.Location = new System.Drawing.Point(197, 105);
            this.Tnom_cliente.Name = "Tnom_cliente";
            this.Tnom_cliente.ReadOnly = true;
            this.Tnom_cliente.Size = new System.Drawing.Size(336, 36);
            this.Tnom_cliente.TabIndex = 5;
            // 
            // Tdni_cliente
            // 
            this.Tdni_cliente.Location = new System.Drawing.Point(197, 166);
            this.Tdni_cliente.Name = "Tdni_cliente";
            this.Tdni_cliente.ReadOnly = true;
            this.Tdni_cliente.Size = new System.Drawing.Size(336, 36);
            this.Tdni_cliente.TabIndex = 6;
            // 
            // BbuscarCliente
            // 
            this.BbuscarCliente.Location = new System.Drawing.Point(677, 150);
            this.BbuscarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BbuscarCliente.Name = "BbuscarCliente";
            this.BbuscarCliente.Size = new System.Drawing.Size(123, 50);
            this.BbuscarCliente.TabIndex = 10;
            this.BbuscarCliente.Text = "Buscar";
            this.BbuscarCliente.UseVisualStyleBackColor = true;
            // 
            // FlistarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(1082, 675);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGlistaCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlistarClientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGlistaCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CBtodosClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn direc_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_registro;
        private System.Windows.Forms.TextBox Tdni_cliente;
        private System.Windows.Forms.TextBox Tnom_cliente;
        private System.Windows.Forms.TextBox Tape_cliente;
        private System.Windows.Forms.CheckBox CBdni;
        private System.Windows.Forms.CheckBox CBnomCliente;
        private System.Windows.Forms.CheckBox CBapeCliente;
        private System.Windows.Forms.Button BbuscarCliente;
    }
}