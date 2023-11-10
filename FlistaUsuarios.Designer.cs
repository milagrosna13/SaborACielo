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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGlistaUsuarios = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBdni = new System.Windows.Forms.ListBox();
            this.TBoxDni = new System.Windows.Forms.TextBox();
            this.ComboBoxNombre = new System.Windows.Forms.ComboBox();
            this.CBoxApellido = new System.Windows.Forms.ComboBox();
            this.CBnombre = new System.Windows.Forms.CheckBox();
            this.CBapellido = new System.Windows.Forms.CheckBox();
            this.CBdni = new System.Windows.Forms.CheckBox();
            this.DTfechaIng = new System.Windows.Forms.DateTimePicker();
            this.CBfecha = new System.Windows.Forms.CheckBox();
            this.BbuscarUsuario = new System.Windows.Forms.Button();
            this.CBtodosEmp = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGlistaUsuarios
            // 
            this.DGlistaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGlistaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGlistaUsuarios.BackgroundColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGlistaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGlistaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGlistaUsuarios.Location = new System.Drawing.Point(25, 225);
            this.DGlistaUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.DGlistaUsuarios.Name = "DGlistaUsuarios";
            this.DGlistaUsuarios.RowHeadersWidth = 62;
            this.DGlistaUsuarios.RowTemplate.Height = 28;
            this.DGlistaUsuarios.Size = new System.Drawing.Size(879, 223);
            this.DGlistaUsuarios.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.LBdni);
            this.groupBox1.Controls.Add(this.TBoxDni);
            this.groupBox1.Controls.Add(this.ComboBoxNombre);
            this.groupBox1.Controls.Add(this.CBoxApellido);
            this.groupBox1.Controls.Add(this.CBnombre);
            this.groupBox1.Controls.Add(this.CBapellido);
            this.groupBox1.Controls.Add(this.CBdni);
            this.groupBox1.Controls.Add(this.DTfechaIng);
            this.groupBox1.Controls.Add(this.CBfecha);
            this.groupBox1.Controls.Add(this.BbuscarUsuario);
            this.groupBox1.Controls.Add(this.CBtodosEmp);
            this.groupBox1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(859, 173);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por";
            // 
            // LBdni
            // 
            this.LBdni.FormattingEnabled = true;
            this.LBdni.ItemHeight = 19;
            this.LBdni.Location = new System.Drawing.Point(87, 87);
            this.LBdni.Name = "LBdni";
            this.LBdni.Size = new System.Drawing.Size(120, 42);
            this.LBdni.TabIndex = 34;
            this.LBdni.Visible = false;
            this.LBdni.SelectedIndexChanged += new System.EventHandler(this.LBdni_SelectedIndexChanged);
            // 
            // TBoxDni
            // 
            this.TBoxDni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TBoxDni.Location = new System.Drawing.Point(87, 71);
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
            this.ComboBoxNombre.Location = new System.Drawing.Point(316, 63);
            this.ComboBoxNombre.Name = "ComboBoxNombre";
            this.ComboBoxNombre.Size = new System.Drawing.Size(121, 27);
            this.ComboBoxNombre.TabIndex = 32;
            this.ComboBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxNombre_KeyPress);
            // 
            // CBoxApellido
            // 
            this.CBoxApellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBoxApellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CBoxApellido.FormattingEnabled = true;
            this.CBoxApellido.Location = new System.Drawing.Point(544, 63);
            this.CBoxApellido.Name = "CBoxApellido";
            this.CBoxApellido.Size = new System.Drawing.Size(121, 27);
            this.CBoxApellido.TabIndex = 31;
            this.CBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CBoxApellido_KeyPress);
            // 
            // CBnombre
            // 
            this.CBnombre.AutoSize = true;
            this.CBnombre.Location = new System.Drawing.Point(230, 67);
            this.CBnombre.Name = "CBnombre";
            this.CBnombre.Size = new System.Drawing.Size(80, 23);
            this.CBnombre.TabIndex = 28;
            this.CBnombre.Text = "Nombre";
            this.CBnombre.UseVisualStyleBackColor = true;
            // 
            // CBapellido
            // 
            this.CBapellido.AutoSize = true;
            this.CBapellido.Location = new System.Drawing.Point(455, 67);
            this.CBapellido.Name = "CBapellido";
            this.CBapellido.Size = new System.Drawing.Size(83, 23);
            this.CBapellido.TabIndex = 27;
            this.CBapellido.Text = "Apellido";
            this.CBapellido.UseVisualStyleBackColor = true;
            // 
            // CBdni
            // 
            this.CBdni.AutoSize = true;
            this.CBdni.Location = new System.Drawing.Point(17, 67);
            this.CBdni.Name = "CBdni";
            this.CBdni.Size = new System.Drawing.Size(64, 23);
            this.CBdni.TabIndex = 26;
            this.CBdni.Text = "DNI";
            this.CBdni.UseVisualStyleBackColor = true;
            // 
            // DTfechaIng
            // 
            this.DTfechaIng.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTfechaIng.Location = new System.Drawing.Point(727, 63);
            this.DTfechaIng.Name = "DTfechaIng";
            this.DTfechaIng.Size = new System.Drawing.Size(108, 27);
            this.DTfechaIng.TabIndex = 25;
            this.DTfechaIng.ValueChanged += new System.EventHandler(this.dateTimePickerFechaIngreso_ValueChanged);
            // 
            // CBfecha
            // 
            this.CBfecha.AutoSize = true;
            this.CBfecha.Location = new System.Drawing.Point(678, 39);
            this.CBfecha.Name = "CBfecha";
            this.CBfecha.Size = new System.Drawing.Size(157, 23);
            this.CBfecha.TabIndex = 24;
            this.CBfecha.Text = "Por fecha de ingreso";
            this.CBfecha.UseVisualStyleBackColor = true;
            // 
            // BbuscarUsuario
            // 
            this.BbuscarUsuario.Location = new System.Drawing.Point(386, 140);
            this.BbuscarUsuario.Name = "BbuscarUsuario";
            this.BbuscarUsuario.Size = new System.Drawing.Size(75, 27);
            this.BbuscarUsuario.TabIndex = 9;
            this.BbuscarUsuario.Text = "Buscar";
            this.BbuscarUsuario.UseVisualStyleBackColor = true;
            this.BbuscarUsuario.Click += new System.EventHandler(this.BbuscarUsuario_Click);
            // 
            // CBtodosEmp
            // 
            this.CBtodosEmp.AutoSize = true;
            this.CBtodosEmp.Location = new System.Drawing.Point(17, 39);
            this.CBtodosEmp.Name = "CBtodosEmp";
            this.CBtodosEmp.Size = new System.Drawing.Size(160, 23);
            this.CBtodosEmp.TabIndex = 2;
            this.CBtodosEmp.Text = "Todos los empleados";
            this.CBtodosEmp.UseVisualStyleBackColor = true;
            this.CBtodosEmp.CheckedChanged += new System.EventHandler(this.CBtodosEmp_CheckedChanged);
            // 
            // FlistaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGlistaUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlistaUsuarios";
            this.Text = "Lista de usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGlistaUsuarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LBdni;
        private System.Windows.Forms.TextBox TBoxDni;
        private System.Windows.Forms.ComboBox ComboBoxNombre;
        private System.Windows.Forms.ComboBox CBoxApellido;
        private System.Windows.Forms.CheckBox CBnombre;
        private System.Windows.Forms.CheckBox CBapellido;
        private System.Windows.Forms.CheckBox CBdni;
        private System.Windows.Forms.DateTimePicker DTfechaIng;
        private System.Windows.Forms.CheckBox CBfecha;
        private System.Windows.Forms.Button BbuscarUsuario;
        private System.Windows.Forms.CheckBox CBtodosEmp;
    }
}