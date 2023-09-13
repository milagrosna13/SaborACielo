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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GBfiltroUsuarios = new System.Windows.Forms.GroupBox();
            this.TBapellidoUsuario = new System.Windows.Forms.TextBox();
            this.TBnombreUsuario = new System.Windows.Forms.TextBox();
            this.CBtodosUsuarios = new System.Windows.Forms.CheckBox();
            this.Ltipousuario = new System.Windows.Forms.Label();
            this.Lnombre = new System.Windows.Forms.Label();
            this.Ldni = new System.Windows.Forms.Label();
            this.Lapellido = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TBdni = new System.Windows.Forms.TextBox();
            this.BbuscarUsuario = new System.Windows.Forms.Button();
            this.DGlistaUsuarios = new System.Windows.Forms.DataGridView();
            this.GBfiltroUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // GBfiltroUsuarios
            // 
            this.GBfiltroUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.GBfiltroUsuarios.Controls.Add(this.BbuscarUsuario);
            this.GBfiltroUsuarios.Controls.Add(this.TBdni);
            this.GBfiltroUsuarios.Controls.Add(this.comboBox1);
            this.GBfiltroUsuarios.Controls.Add(this.Lapellido);
            this.GBfiltroUsuarios.Controls.Add(this.Ldni);
            this.GBfiltroUsuarios.Controls.Add(this.TBapellidoUsuario);
            this.GBfiltroUsuarios.Controls.Add(this.TBnombreUsuario);
            this.GBfiltroUsuarios.Controls.Add(this.CBtodosUsuarios);
            this.GBfiltroUsuarios.Controls.Add(this.Ltipousuario);
            this.GBfiltroUsuarios.Controls.Add(this.Lnombre);
            this.GBfiltroUsuarios.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBfiltroUsuarios.Location = new System.Drawing.Point(39, 21);
            this.GBfiltroUsuarios.Name = "GBfiltroUsuarios";
            this.GBfiltroUsuarios.Size = new System.Drawing.Size(714, 100);
            this.GBfiltroUsuarios.TabIndex = 2;
            this.GBfiltroUsuarios.TabStop = false;
            this.GBfiltroUsuarios.Text = "Filtrar por";
            // 
            // TBapellidoUsuario
            // 
            this.TBapellidoUsuario.Location = new System.Drawing.Point(458, 57);
            this.TBapellidoUsuario.Name = "TBapellidoUsuario";
            this.TBapellidoUsuario.Size = new System.Drawing.Size(100, 27);
            this.TBapellidoUsuario.TabIndex = 4;
            // 
            // TBnombreUsuario
            // 
            this.TBnombreUsuario.Location = new System.Drawing.Point(326, 57);
            this.TBnombreUsuario.Name = "TBnombreUsuario";
            this.TBnombreUsuario.Size = new System.Drawing.Size(100, 27);
            this.TBnombreUsuario.TabIndex = 3;
            // 
            // CBtodosUsuarios
            // 
            this.CBtodosUsuarios.AutoSize = true;
            this.CBtodosUsuarios.Location = new System.Drawing.Point(20, 26);
            this.CBtodosUsuarios.Name = "CBtodosUsuarios";
            this.CBtodosUsuarios.Size = new System.Drawing.Size(146, 23);
            this.CBtodosUsuarios.TabIndex = 2;
            this.CBtodosUsuarios.Text = "Todos los usuarios";
            this.CBtodosUsuarios.UseVisualStyleBackColor = true;
            // 
            // Ltipousuario
            // 
            this.Ltipousuario.AutoSize = true;
            this.Ltipousuario.Location = new System.Drawing.Point(598, 20);
            this.Ltipousuario.Name = "Ltipousuario";
            this.Ltipousuario.Size = new System.Drawing.Size(109, 19);
            this.Ltipousuario.TabIndex = 1;
            this.Ltipousuario.Text = "Tipo de usuario";
            // 
            // Lnombre
            // 
            this.Lnombre.AutoSize = true;
            this.Lnombre.Location = new System.Drawing.Point(322, 20);
            this.Lnombre.Name = "Lnombre";
            this.Lnombre.Size = new System.Drawing.Size(61, 19);
            this.Lnombre.TabIndex = 0;
            this.Lnombre.Text = "Nombre";
            // 
            // Ldni
            // 
            this.Ldni.AutoSize = true;
            this.Ldni.Location = new System.Drawing.Point(191, 20);
            this.Ldni.Name = "Ldni";
            this.Ldni.Size = new System.Drawing.Size(45, 19);
            this.Ldni.TabIndex = 5;
            this.Ldni.Text = "DNI";
            // 
            // Lapellido
            // 
            this.Lapellido.AutoSize = true;
            this.Lapellido.Location = new System.Drawing.Point(454, 20);
            this.Lapellido.Name = "Lapellido";
            this.Lapellido.Size = new System.Drawing.Size(64, 19);
            this.Lapellido.TabIndex = 6;
            this.Lapellido.Text = "Apellido";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(586, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 7;
            // 
            // TBdni
            // 
            this.TBdni.Location = new System.Drawing.Point(195, 57);
            this.TBdni.Name = "TBdni";
            this.TBdni.Size = new System.Drawing.Size(100, 27);
            this.TBdni.TabIndex = 8;
            // 
            // BbuscarUsuario
            // 
            this.BbuscarUsuario.Location = new System.Drawing.Point(46, 57);
            this.BbuscarUsuario.Name = "BbuscarUsuario";
            this.BbuscarUsuario.Size = new System.Drawing.Size(75, 27);
            this.BbuscarUsuario.TabIndex = 9;
            this.BbuscarUsuario.Text = "Buscar";
            this.BbuscarUsuario.UseVisualStyleBackColor = true;
            // 
            // DGlistaUsuarios
            // 
            this.DGlistaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGlistaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGlistaUsuarios.BackgroundColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGlistaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGlistaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGlistaUsuarios.Location = new System.Drawing.Point(27, 152);
            this.DGlistaUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.DGlistaUsuarios.Name = "DGlistaUsuarios";
            this.DGlistaUsuarios.RowHeadersWidth = 62;
            this.DGlistaUsuarios.RowTemplate.Height = 28;
            this.DGlistaUsuarios.Size = new System.Drawing.Size(747, 301);
            this.DGlistaUsuarios.TabIndex = 5;
            // 
            // FlistaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGlistaUsuarios);
            this.Controls.Add(this.GBfiltroUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlistaUsuarios";
            this.Text = "Lista de usuarios";
            this.GBfiltroUsuarios.ResumeLayout(false);
            this.GBfiltroUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBfiltroUsuarios;
        private System.Windows.Forms.TextBox TBapellidoUsuario;
        private System.Windows.Forms.TextBox TBnombreUsuario;
        private System.Windows.Forms.CheckBox CBtodosUsuarios;
        private System.Windows.Forms.Label Ltipousuario;
        private System.Windows.Forms.Label Lnombre;
        private System.Windows.Forms.Label Ldni;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Lapellido;
        private System.Windows.Forms.TextBox TBdni;
        private System.Windows.Forms.Button BbuscarUsuario;
        private System.Windows.Forms.DataGridView DGlistaUsuarios;
    }
}