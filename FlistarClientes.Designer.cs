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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGlistaCliente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tdni_cliente = new System.Windows.Forms.TextBox();
            this.Tnom_cliente = new System.Windows.Forms.TextBox();
            this.Tape_cliente = new System.Windows.Forms.TextBox();
            this.CBdni = new System.Windows.Forms.CheckBox();
            this.CBnomCliente = new System.Windows.Forms.CheckBox();
            this.CBapeCliente = new System.Windows.Forms.CheckBox();
            this.CBtodosClientes = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGlistaCliente
            // 
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGlistaCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.DGlistaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGlistaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGlistaCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.DGlistaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGlistaCliente.DefaultCellStyle = dataGridViewCellStyle18;
            this.DGlistaCliente.Location = new System.Drawing.Point(14, 349);
            this.DGlistaCliente.Name = "DGlistaCliente";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGlistaCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.DGlistaCliente.RowHeadersWidth = 62;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGlistaCliente.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.DGlistaCliente.RowTemplate.Height = 28;
            this.DGlistaCliente.Size = new System.Drawing.Size(1056, 314);
            this.DGlistaCliente.TabIndex = 0;
            this.DGlistaCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGlistaCliente_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            // Tdni_cliente
            // 
            this.Tdni_cliente.Enabled = false;
            this.Tdni_cliente.Location = new System.Drawing.Point(197, 166);
            this.Tdni_cliente.Name = "Tdni_cliente";
            this.Tdni_cliente.Size = new System.Drawing.Size(336, 36);
            this.Tdni_cliente.TabIndex = 6;
            this.Tdni_cliente.TextChanged += new System.EventHandler(this.Tdni_cliente_TextChanged);
            // 
            // Tnom_cliente
            // 
            this.Tnom_cliente.Enabled = false;
            this.Tnom_cliente.Location = new System.Drawing.Point(197, 105);
            this.Tnom_cliente.Name = "Tnom_cliente";
            this.Tnom_cliente.Size = new System.Drawing.Size(336, 36);
            this.Tnom_cliente.TabIndex = 5;
            this.Tnom_cliente.TextChanged += new System.EventHandler(this.Tnom_cliente_TextChanged);
            // 
            // Tape_cliente
            // 
            this.Tape_cliente.Enabled = false;
            this.Tape_cliente.Location = new System.Drawing.Point(197, 51);
            this.Tape_cliente.Name = "Tape_cliente";
            this.Tape_cliente.Size = new System.Drawing.Size(336, 36);
            this.Tape_cliente.TabIndex = 4;
            this.Tape_cliente.TextChanged += new System.EventHandler(this.Tape_cliente_TextChanged);
            // 
            // CBdni
            // 
            this.CBdni.AutoSize = true;
            this.CBdni.Location = new System.Drawing.Point(6, 167);
            this.CBdni.Name = "CBdni";
            this.CBdni.Size = new System.Drawing.Size(74, 33);
            this.CBdni.TabIndex = 3;
            this.CBdni.Text = "Dni";
            this.CBdni.UseVisualStyleBackColor = true;
            this.CBdni.CheckedChanged += new System.EventHandler(this.CBdni_CheckedChanged);
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
            this.CBnomCliente.CheckedChanged += new System.EventHandler(this.CBnomCliente_CheckedChanged);
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
            this.CBapeCliente.CheckedChanged += new System.EventHandler(this.CBapeCliente_CheckedChanged);
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
            this.CBtodosClientes.CheckedChanged += new System.EventHandler(this.CBtodosClientes_CheckedChanged);
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
        private System.Windows.Forms.TextBox Tdni_cliente;
        private System.Windows.Forms.TextBox Tnom_cliente;
        private System.Windows.Forms.TextBox Tape_cliente;
        private System.Windows.Forms.CheckBox CBdni;
        private System.Windows.Forms.CheckBox CBnomCliente;
        private System.Windows.Forms.CheckBox CBapeCliente;
    }
}