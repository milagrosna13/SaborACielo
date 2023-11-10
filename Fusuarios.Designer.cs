namespace SaborAcielo
{
    partial class Fusuarios
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
            this.DGusuarios = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.GBfiltroUsuarios = new System.Windows.Forms.GroupBox();
            this.CBinactivos = new System.Windows.Forms.CheckBox();
            this.CBactivos = new System.Windows.Forms.CheckBox();
            this.CBoxTipo = new System.Windows.Forms.ComboBox();
            this.CBtipo = new System.Windows.Forms.CheckBox();
            this.LBdni = new System.Windows.Forms.ListBox();
            this.TBoxDni = new System.Windows.Forms.TextBox();
            this.ComboBoxNombre = new System.Windows.Forms.ComboBox();
            this.CBnombre = new System.Windows.Forms.CheckBox();
            this.CBdni = new System.Windows.Forms.CheckBox();
            this.BbuscarUsuario = new System.Windows.Forms.Button();
            this.CBtodosUsuarios = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGusuarios)).BeginInit();
            this.GBfiltroUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGusuarios
            // 
            this.DGusuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGusuarios.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.DGusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGusuarios.Location = new System.Drawing.Point(83, 321);
            this.DGusuarios.Name = "DGusuarios";
            this.DGusuarios.Size = new System.Drawing.Size(723, 221);
            this.DGusuarios.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 30F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(270, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuarios del Sistema";
            // 
            // GBfiltroUsuarios
            // 
            this.GBfiltroUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.GBfiltroUsuarios.Controls.Add(this.CBinactivos);
            this.GBfiltroUsuarios.Controls.Add(this.CBactivos);
            this.GBfiltroUsuarios.Controls.Add(this.CBoxTipo);
            this.GBfiltroUsuarios.Controls.Add(this.CBtipo);
            this.GBfiltroUsuarios.Controls.Add(this.LBdni);
            this.GBfiltroUsuarios.Controls.Add(this.TBoxDni);
            this.GBfiltroUsuarios.Controls.Add(this.ComboBoxNombre);
            this.GBfiltroUsuarios.Controls.Add(this.CBnombre);
            this.GBfiltroUsuarios.Controls.Add(this.CBdni);
            this.GBfiltroUsuarios.Controls.Add(this.BbuscarUsuario);
            this.GBfiltroUsuarios.Controls.Add(this.CBtodosUsuarios);
            this.GBfiltroUsuarios.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBfiltroUsuarios.Location = new System.Drawing.Point(53, 123);
            this.GBfiltroUsuarios.Name = "GBfiltroUsuarios";
            this.GBfiltroUsuarios.Size = new System.Drawing.Size(777, 166);
            this.GBfiltroUsuarios.TabIndex = 6;
            this.GBfiltroUsuarios.TabStop = false;
            this.GBfiltroUsuarios.Text = "Filtrar por";
            // 
            // CBinactivos
            // 
            this.CBinactivos.AutoSize = true;
            this.CBinactivos.Location = new System.Drawing.Point(304, 26);
            this.CBinactivos.Name = "CBinactivos";
            this.CBinactivos.Size = new System.Drawing.Size(88, 23);
            this.CBinactivos.TabIndex = 38;
            this.CBinactivos.Text = "Inactivos";
            this.CBinactivos.UseVisualStyleBackColor = true;
            // 
            // CBactivos
            // 
            this.CBactivos.AutoSize = true;
            this.CBactivos.Location = new System.Drawing.Point(225, 26);
            this.CBactivos.Name = "CBactivos";
            this.CBactivos.Size = new System.Drawing.Size(73, 23);
            this.CBactivos.TabIndex = 37;
            this.CBactivos.Text = "Activos";
            this.CBactivos.UseVisualStyleBackColor = true;
            // 
            // CBoxTipo
            // 
            this.CBoxTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxTipo.FormattingEnabled = true;
            this.CBoxTipo.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Empleado"});
            this.CBoxTipo.Location = new System.Drawing.Point(579, 64);
            this.CBoxTipo.Name = "CBoxTipo";
            this.CBoxTipo.Size = new System.Drawing.Size(121, 27);
            this.CBoxTipo.TabIndex = 36;
            // 
            // CBtipo
            // 
            this.CBtipo.AutoSize = true;
            this.CBtipo.Location = new System.Drawing.Point(463, 68);
            this.CBtipo.Name = "CBtipo";
            this.CBtipo.Size = new System.Drawing.Size(110, 23);
            this.CBtipo.TabIndex = 35;
            this.CBtipo.Text = "Tipo usuario";
            this.CBtipo.UseVisualStyleBackColor = true;
            // 
            // LBdni
            // 
            this.LBdni.FormattingEnabled = true;
            this.LBdni.ItemHeight = 19;
            this.LBdni.Location = new System.Drawing.Point(119, 93);
            this.LBdni.Name = "LBdni";
            this.LBdni.Size = new System.Drawing.Size(120, 42);
            this.LBdni.TabIndex = 34;
            this.LBdni.Visible = false;
            this.LBdni.SelectedIndexChanged += new System.EventHandler(this.LBdni_SelectedIndexChanged);
            // 
            // TBoxDni
            // 
            this.TBoxDni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TBoxDni.Location = new System.Drawing.Point(119, 68);
            this.TBoxDni.Name = "TBoxDni";
            this.TBoxDni.Size = new System.Drawing.Size(120, 27);
            this.TBoxDni.TabIndex = 33;
            this.TBoxDni.TextChanged += new System.EventHandler(this.TBoxDni_TextChanged);
            this.TBoxDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBoxDni_KeyPress);
            // 
            // ComboBoxNombre
            // 
            this.ComboBoxNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ComboBoxNombre.FormattingEnabled = true;
            this.ComboBoxNombre.Location = new System.Drawing.Point(331, 66);
            this.ComboBoxNombre.Name = "ComboBoxNombre";
            this.ComboBoxNombre.Size = new System.Drawing.Size(121, 27);
            this.ComboBoxNombre.TabIndex = 32;
            // 
            // CBnombre
            // 
            this.CBnombre.AutoSize = true;
            this.CBnombre.Location = new System.Drawing.Point(245, 68);
            this.CBnombre.Name = "CBnombre";
            this.CBnombre.Size = new System.Drawing.Size(80, 23);
            this.CBnombre.TabIndex = 28;
            this.CBnombre.Text = "Nombre";
            this.CBnombre.UseVisualStyleBackColor = true;
            // 
            // CBdni
            // 
            this.CBdni.AutoSize = true;
            this.CBdni.Location = new System.Drawing.Point(48, 72);
            this.CBdni.Name = "CBdni";
            this.CBdni.Size = new System.Drawing.Size(64, 23);
            this.CBdni.TabIndex = 26;
            this.CBdni.Text = "DNI";
            this.CBdni.UseVisualStyleBackColor = true;
            // 
            // BbuscarUsuario
            // 
            this.BbuscarUsuario.Location = new System.Drawing.Point(345, 120);
            this.BbuscarUsuario.Name = "BbuscarUsuario";
            this.BbuscarUsuario.Size = new System.Drawing.Size(75, 27);
            this.BbuscarUsuario.TabIndex = 9;
            this.BbuscarUsuario.Text = "Buscar";
            this.BbuscarUsuario.UseVisualStyleBackColor = true;
            this.BbuscarUsuario.Click += new System.EventHandler(this.BbuscarUsuario_Click);
            // 
            // CBtodosUsuarios
            // 
            this.CBtodosUsuarios.AutoSize = true;
            this.CBtodosUsuarios.Location = new System.Drawing.Point(50, 26);
            this.CBtodosUsuarios.Name = "CBtodosUsuarios";
            this.CBtodosUsuarios.Size = new System.Drawing.Size(160, 23);
            this.CBtodosUsuarios.TabIndex = 2;
            this.CBtodosUsuarios.Text = "Todos los empleados";
            this.CBtodosUsuarios.UseVisualStyleBackColor = true;
            this.CBtodosUsuarios.CheckedChanged += new System.EventHandler(this.CBtodosUsuarios_CheckedChanged);
            // 
            // Fusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(911, 554);
            this.Controls.Add(this.GBfiltroUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGusuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fusuarios";
            this.Text = "Fusuarios";
            ((System.ComponentModel.ISupportInitialize)(this.DGusuarios)).EndInit();
            this.GBfiltroUsuarios.ResumeLayout(false);
            this.GBfiltroUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGusuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GBfiltroUsuarios;
        private System.Windows.Forms.ListBox LBdni;
        private System.Windows.Forms.TextBox TBoxDni;
        private System.Windows.Forms.ComboBox ComboBoxNombre;
        private System.Windows.Forms.CheckBox CBnombre;
        private System.Windows.Forms.CheckBox CBdni;
        private System.Windows.Forms.Button BbuscarUsuario;
        private System.Windows.Forms.CheckBox CBtodosUsuarios;
        private System.Windows.Forms.ComboBox CBoxTipo;
        private System.Windows.Forms.CheckBox CBtipo;
        private System.Windows.Forms.CheckBox CBinactivos;
        private System.Windows.Forms.CheckBox CBactivos;
    }
}