namespace SaborAcielo
{
    partial class FlistaUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GBfiltroUsuarios = new System.Windows.Forms.GroupBox();
            this.CtipoUS = new System.Windows.Forms.CheckBox();
            this.Tdni_us = new System.Windows.Forms.TextBox();
            this.Tnom_us = new System.Windows.Forms.TextBox();
            this.Tape_us = new System.Windows.Forms.TextBox();
            this.CBdniUS = new System.Windows.Forms.CheckBox();
            this.CBnomUs = new System.Windows.Forms.CheckBox();
            this.CBapeUs = new System.Windows.Forms.CheckBox();
            this.BbuscarUsuario = new System.Windows.Forms.Button();
            this.CBtipoUs = new System.Windows.Forms.ComboBox();
            this.CBtodosUsuarios = new System.Windows.Forms.CheckBox();
            this.DGlistaUsuarios = new System.Windows.Forms.DataGridView();
            this.us_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.us_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.us_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.us_fechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_ingeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBfiltroUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // GBfiltroUsuarios
            // 
            this.GBfiltroUsuarios.BackColor = System.Drawing.Color.RosyBrown;
            this.GBfiltroUsuarios.Controls.Add(this.CtipoUS);
            this.GBfiltroUsuarios.Controls.Add(this.Tdni_us);
            this.GBfiltroUsuarios.Controls.Add(this.Tnom_us);
            this.GBfiltroUsuarios.Controls.Add(this.Tape_us);
            this.GBfiltroUsuarios.Controls.Add(this.CBdniUS);
            this.GBfiltroUsuarios.Controls.Add(this.CBnomUs);
            this.GBfiltroUsuarios.Controls.Add(this.CBapeUs);
            this.GBfiltroUsuarios.Controls.Add(this.BbuscarUsuario);
            this.GBfiltroUsuarios.Controls.Add(this.CBtipoUs);
            this.GBfiltroUsuarios.Controls.Add(this.CBtodosUsuarios);
            this.GBfiltroUsuarios.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBfiltroUsuarios.Location = new System.Drawing.Point(58, 32);
            this.GBfiltroUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GBfiltroUsuarios.Name = "GBfiltroUsuarios";
            this.GBfiltroUsuarios.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GBfiltroUsuarios.Size = new System.Drawing.Size(1027, 284);
            this.GBfiltroUsuarios.TabIndex = 2;
            this.GBfiltroUsuarios.TabStop = false;
            this.GBfiltroUsuarios.Text = "Filtrar por";
            // 
            // CtipoUS
            // 
            this.CtipoUS.AutoSize = true;
            this.CtipoUS.Location = new System.Drawing.Point(45, 200);
            this.CtipoUS.Name = "CtipoUS";
            this.CtipoUS.Size = new System.Drawing.Size(200, 33);
            this.CtipoUS.TabIndex = 16;
            this.CtipoUS.Text = "Tipo de Usuario";
            this.CtipoUS.UseVisualStyleBackColor = true;
            // 
            // Tdni_us
            // 
            this.Tdni_us.Location = new System.Drawing.Point(290, 149);
            this.Tdni_us.Name = "Tdni_us";
            this.Tdni_us.ReadOnly = true;
            this.Tdni_us.Size = new System.Drawing.Size(336, 36);
            this.Tdni_us.TabIndex = 15;
            // 
            // Tnom_us
            // 
            this.Tnom_us.Location = new System.Drawing.Point(290, 101);
            this.Tnom_us.Name = "Tnom_us";
            this.Tnom_us.ReadOnly = true;
            this.Tnom_us.Size = new System.Drawing.Size(336, 36);
            this.Tnom_us.TabIndex = 14;
            // 
            // Tape_us
            // 
            this.Tape_us.Location = new System.Drawing.Point(290, 56);
            this.Tape_us.Name = "Tape_us";
            this.Tape_us.ReadOnly = true;
            this.Tape_us.Size = new System.Drawing.Size(336, 36);
            this.Tape_us.TabIndex = 13;
            // 
            // CBdniUS
            // 
            this.CBdniUS.AutoSize = true;
            this.CBdniUS.Location = new System.Drawing.Point(45, 149);
            this.CBdniUS.Name = "CBdniUS";
            this.CBdniUS.Size = new System.Drawing.Size(92, 33);
            this.CBdniUS.TabIndex = 12;
            this.CBdniUS.Text = "DNI";
            this.CBdniUS.UseVisualStyleBackColor = true;
            this.CBdniUS.CheckedChanged += new System.EventHandler(this.CBdniUS_CheckedChanged);
            // 
            // CBnomUs
            // 
            this.CBnomUs.AutoSize = true;
            this.CBnomUs.Location = new System.Drawing.Point(45, 103);
            this.CBnomUs.Name = "CBnomUs";
            this.CBnomUs.Size = new System.Drawing.Size(117, 33);
            this.CBnomUs.TabIndex = 11;
            this.CBnomUs.Text = "Nombre";
            this.CBnomUs.UseVisualStyleBackColor = true;
            this.CBnomUs.CheckedChanged += new System.EventHandler(this.CBnomUs_CheckedChanged);
            // 
            // CBapeUs
            // 
            this.CBapeUs.AutoSize = true;
            this.CBapeUs.Location = new System.Drawing.Point(45, 58);
            this.CBapeUs.Name = "CBapeUs";
            this.CBapeUs.Size = new System.Drawing.Size(124, 33);
            this.CBapeUs.TabIndex = 10;
            this.CBapeUs.Text = "Apellido";
            this.CBapeUs.UseVisualStyleBackColor = true;
            this.CBapeUs.CheckedChanged += new System.EventHandler(this.CBapeUs_CheckedChanged);
            // 
            // BbuscarUsuario
            // 
            this.BbuscarUsuario.Location = new System.Drawing.Point(823, 179);
            this.BbuscarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BbuscarUsuario.Name = "BbuscarUsuario";
            this.BbuscarUsuario.Size = new System.Drawing.Size(112, 42);
            this.BbuscarUsuario.TabIndex = 9;
            this.BbuscarUsuario.Text = "Buscar";
            this.BbuscarUsuario.UseVisualStyleBackColor = true;
            // 
            // CBtipoUs
            // 
            this.CBtipoUs.FormattingEnabled = true;
            this.CBtipoUs.Location = new System.Drawing.Point(290, 200);
            this.CBtipoUs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBtipoUs.Name = "CBtipoUs";
            this.CBtipoUs.Size = new System.Drawing.Size(336, 37);
            this.CBtipoUs.TabIndex = 7;
            // 
            // CBtodosUsuarios
            // 
            this.CBtodosUsuarios.AutoSize = true;
            this.CBtodosUsuarios.Location = new System.Drawing.Point(772, 84);
            this.CBtodosUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBtodosUsuarios.Name = "CBtodosUsuarios";
            this.CBtodosUsuarios.Size = new System.Drawing.Size(226, 33);
            this.CBtodosUsuarios.TabIndex = 2;
            this.CBtodosUsuarios.Text = "Todos los usuarios";
            this.CBtodosUsuarios.UseVisualStyleBackColor = true;
            // 
            // DGlistaUsuarios
            // 
            this.DGlistaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGlistaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGlistaUsuarios.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGlistaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGlistaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGlistaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.us_apellido,
            this.us_nombre,
            this.us_dni,
            this.us_fechaNac,
            this.email,
            this.direccion,
            this.tel,
            this.fecha_ingeso,
            this.perfil,
            this.estado});
            this.DGlistaUsuarios.Location = new System.Drawing.Point(40, 350);
            this.DGlistaUsuarios.Name = "DGlistaUsuarios";
            this.DGlistaUsuarios.RowHeadersWidth = 62;
            this.DGlistaUsuarios.RowTemplate.Height = 28;
            this.DGlistaUsuarios.Size = new System.Drawing.Size(1120, 347);
            this.DGlistaUsuarios.TabIndex = 5;
            // 
            // us_apellido
            // 
            this.us_apellido.HeaderText = "Apellido";
            this.us_apellido.MinimumWidth = 8;
            this.us_apellido.Name = "us_apellido";
            // 
            // us_nombre
            // 
            this.us_nombre.HeaderText = "Nombre";
            this.us_nombre.MinimumWidth = 8;
            this.us_nombre.Name = "us_nombre";
            // 
            // us_dni
            // 
            this.us_dni.HeaderText = "Dni";
            this.us_dni.MinimumWidth = 8;
            this.us_dni.Name = "us_dni";
            // 
            // us_fechaNac
            // 
            this.us_fechaNac.HeaderText = "Fecha de Nacimiento";
            this.us_fechaNac.MinimumWidth = 8;
            this.us_fechaNac.Name = "us_fechaNac";
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.MinimumWidth = 8;
            this.direccion.Name = "direccion";
            // 
            // tel
            // 
            this.tel.HeaderText = "Telefono";
            this.tel.MinimumWidth = 8;
            this.tel.Name = "tel";
            // 
            // fecha_ingeso
            // 
            this.fecha_ingeso.HeaderText = "Fecha de Ingreso";
            this.fecha_ingeso.MinimumWidth = 8;
            this.fecha_ingeso.Name = "fecha_ingeso";
            // 
            // perfil
            // 
            this.perfil.HeaderText = "Tipo de Usuario";
            this.perfil.MinimumWidth = 8;
            this.perfil.Name = "perfil";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 8;
            this.estado.Name = "estado";
            // 
            // FlistaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.DGlistaUsuarios);
            this.Controls.Add(this.GBfiltroUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FlistaUsuarios";
            this.Text = "Lista de usuarios";
            this.GBfiltroUsuarios.ResumeLayout(false);
            this.GBfiltroUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBfiltroUsuarios;
        private System.Windows.Forms.CheckBox CBtodosUsuarios;
        private System.Windows.Forms.ComboBox CBtipoUs;
        private System.Windows.Forms.Button BbuscarUsuario;
        private System.Windows.Forms.DataGridView DGlistaUsuarios;
        private System.Windows.Forms.CheckBox CtipoUS;
        private System.Windows.Forms.TextBox Tdni_us;
        private System.Windows.Forms.TextBox Tnom_us;
        private System.Windows.Forms.TextBox Tape_us;
        private System.Windows.Forms.CheckBox CBdniUS;
        private System.Windows.Forms.CheckBox CBnomUs;
        private System.Windows.Forms.CheckBox CBapeUs;
        private System.Windows.Forms.DataGridViewTextBoxColumn us_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn us_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn us_dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn us_fechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_ingeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}