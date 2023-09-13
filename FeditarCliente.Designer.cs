namespace SaborAcielo
{
    partial class FeditarCliente
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
            this.DGclientes = new System.Windows.Forms.DataGridView();
            this.nombre_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direc_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baja_cliente = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PeditarCliente = new System.Windows.Forms.Panel();
            this.bagregar = new System.Windows.Forms.Button();
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
            this.BeditarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGclientes)).BeginInit();
            this.PeditarCliente.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
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
            this.baja_cliente});
            this.DGclientes.Location = new System.Drawing.Point(-19, 315);
            this.DGclientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGclientes.Name = "DGclientes";
            this.DGclientes.RowHeadersWidth = 62;
            this.DGclientes.RowTemplate.Height = 28;
            this.DGclientes.Size = new System.Drawing.Size(687, 135);
            this.DGclientes.TabIndex = 3;
            this.DGclientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGclientes_CellContentDoubleClick);
            // 
            // nombre_cliente
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_cliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.nombre_cliente.HeaderText = "Nombre";
            this.nombre_cliente.MinimumWidth = 8;
            this.nombre_cliente.Name = "nombre_cliente";
            // 
            // apellido_cliente
            // 
            this.apellido_cliente.HeaderText = "Apellido";
            this.apellido_cliente.MinimumWidth = 8;
            this.apellido_cliente.Name = "apellido_cliente";
            // 
            // dni_cliente
            // 
            this.dni_cliente.HeaderText = "DNI";
            this.dni_cliente.MinimumWidth = 8;
            this.dni_cliente.Name = "dni_cliente";
            // 
            // sexo_cliente
            // 
            this.sexo_cliente.HeaderText = "Sexo";
            this.sexo_cliente.MinimumWidth = 8;
            this.sexo_cliente.Name = "sexo_cliente";
            // 
            // tel_cliente
            // 
            this.tel_cliente.HeaderText = "Teléfono";
            this.tel_cliente.MinimumWidth = 8;
            this.tel_cliente.Name = "tel_cliente";
            // 
            // direc_cliente
            // 
            this.direc_cliente.HeaderText = "Dirección";
            this.direc_cliente.MinimumWidth = 8;
            this.direc_cliente.Name = "direc_cliente";
            // 
            // baja_cliente
            // 
            this.baja_cliente.HeaderText = "Eliminar";
            this.baja_cliente.MinimumWidth = 8;
            this.baja_cliente.Name = "baja_cliente";
            // 
            // PeditarCliente
            // 
            this.PeditarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PeditarCliente.AutoScroll = true;
            this.PeditarCliente.BackColor = System.Drawing.Color.RosyBrown;
            this.PeditarCliente.Controls.Add(this.bagregar);
            this.PeditarCliente.Controls.Add(this.label6);
            this.PeditarCliente.Controls.Add(this.RBhombre);
            this.PeditarCliente.Controls.Add(this.RBmujer);
            this.PeditarCliente.Controls.Add(this.TBdireCliente);
            this.PeditarCliente.Controls.Add(this.label5);
            this.PeditarCliente.Controls.Add(this.TBtelCliente);
            this.PeditarCliente.Controls.Add(this.label4);
            this.PeditarCliente.Controls.Add(this.TBdniCliente);
            this.PeditarCliente.Controls.Add(this.label3);
            this.PeditarCliente.Controls.Add(this.TBapeCliente);
            this.PeditarCliente.Controls.Add(this.label2);
            this.PeditarCliente.Controls.Add(this.TBnomCliente);
            this.PeditarCliente.Controls.Add(this.label1);
            this.PeditarCliente.Controls.Add(this.BcancelCliente);
            this.PeditarCliente.Controls.Add(this.BeditarCliente);
            this.PeditarCliente.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeditarCliente.Location = new System.Drawing.Point(30, 31);
            this.PeditarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PeditarCliente.Name = "PeditarCliente";
            this.PeditarCliente.Size = new System.Drawing.Size(601, 250);
            this.PeditarCliente.TabIndex = 2;
            // 
            // bagregar
            // 
            this.bagregar.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagregar.Location = new System.Drawing.Point(0, 209);
            this.bagregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bagregar.Name = "bagregar";
            this.bagregar.Size = new System.Drawing.Size(115, 32);
            this.bagregar.TabIndex = 15;
            this.bagregar.Text = "agregar";
            this.bagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bagregar.UseVisualStyleBackColor = true;
            this.bagregar.Click += new System.EventHandler(this.bagregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(339, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sexo";
            // 
            // RBhombre
            // 
            this.RBhombre.AutoSize = true;
            this.RBhombre.Checked = true;
            this.RBhombre.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.RBhombre.Location = new System.Drawing.Point(417, 61);
            this.RBhombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RBhombre.Name = "RBhombre";
            this.RBhombre.Size = new System.Drawing.Size(79, 23);
            this.RBhombre.TabIndex = 13;
            this.RBhombre.TabStop = true;
            this.RBhombre.Text = "Hombre";
            this.RBhombre.UseVisualStyleBackColor = true;
            // 
            // RBmujer
            // 
            this.RBmujer.AutoSize = true;
            this.RBmujer.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.RBmujer.Location = new System.Drawing.Point(504, 61);
            this.RBmujer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RBmujer.Name = "RBmujer";
            this.RBmujer.Size = new System.Drawing.Size(69, 23);
            this.RBmujer.TabIndex = 12;
            this.RBmujer.TabStop = true;
            this.RBmujer.Text = "Mujer";
            this.RBmujer.UseVisualStyleBackColor = true;
            // 
            // TBdireCliente
            // 
            this.TBdireCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBdireCliente.Location = new System.Drawing.Point(109, 145);
            this.TBdireCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBdireCliente.Name = "TBdireCliente";
            this.TBdireCliente.Size = new System.Drawing.Size(261, 26);
            this.TBdireCliente.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Direccion";
            // 
            // TBtelCliente
            // 
            this.TBtelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBtelCliente.Location = new System.Drawing.Point(111, 102);
            this.TBtelCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBtelCliente.Name = "TBtelCliente";
            this.TBtelCliente.Size = new System.Drawing.Size(178, 26);
            this.TBtelCliente.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dni";
            // 
            // TBdniCliente
            // 
            this.TBdniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBdniCliente.Location = new System.Drawing.Point(111, 55);
            this.TBdniCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBdniCliente.Name = "TBdniCliente";
            this.TBdniCliente.Size = new System.Drawing.Size(178, 26);
            this.TBdniCliente.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefono";
            // 
            // TBapeCliente
            // 
            this.TBapeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBapeCliente.Location = new System.Drawing.Point(414, 8);
            this.TBapeCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBapeCliente.Name = "TBapeCliente";
            this.TBapeCliente.Size = new System.Drawing.Size(178, 26);
            this.TBapeCliente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
            // 
            // TBnomCliente
            // 
            this.TBnomCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBnomCliente.Location = new System.Drawing.Point(111, 10);
            this.TBnomCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBnomCliente.Name = "TBnomCliente";
            this.TBnomCliente.Size = new System.Drawing.Size(178, 26);
            this.TBnomCliente.TabIndex = 3;
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
            // BcancelCliente
            // 
            this.BcancelCliente.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BcancelCliente.Image = global::SaborAcielo.Properties.Resources.cruz;
            this.BcancelCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BcancelCliente.Location = new System.Drawing.Point(291, 209);
            this.BcancelCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BcancelCliente.Name = "BcancelCliente";
            this.BcancelCliente.Size = new System.Drawing.Size(113, 32);
            this.BcancelCliente.TabIndex = 1;
            this.BcancelCliente.Text = "Cancelar";
            this.BcancelCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BcancelCliente.UseVisualStyleBackColor = true;
            // 
            // BeditarCliente
            // 
            this.BeditarCliente.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeditarCliente.Location = new System.Drawing.Point(122, 209);
            this.BeditarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BeditarCliente.Name = "BeditarCliente";
            this.BeditarCliente.Size = new System.Drawing.Size(115, 32);
            this.BeditarCliente.TabIndex = 0;
            this.BeditarCliente.Text = "Modificar";
            this.BeditarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BeditarCliente.UseVisualStyleBackColor = true;
            this.BeditarCliente.Click += new System.EventHandler(this.BeditarCliente_Click);
            // 
            // FeditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(679, 480);
            this.Controls.Add(this.DGclientes);
            this.Controls.Add(this.PeditarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FeditarCliente";
            this.Text = "FeditarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.DGclientes)).EndInit();
            this.PeditarCliente.ResumeLayout(false);
            this.PeditarCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGclientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn direc_cliente;
        private System.Windows.Forms.DataGridViewButtonColumn baja_cliente;
        private System.Windows.Forms.Panel PeditarCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RBhombre;
        private System.Windows.Forms.RadioButton RBmujer;
        private System.Windows.Forms.TextBox TBdireCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBtelCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBdniCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBapeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBnomCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BcancelCliente;
        private System.Windows.Forms.Button BeditarCliente;
        private System.Windows.Forms.Button bagregar;
    }
}