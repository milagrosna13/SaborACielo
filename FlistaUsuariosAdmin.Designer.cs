namespace SaborAcielo
{
    partial class FlistaUsuariosAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GBfiltroUsuarios = new System.Windows.Forms.GroupBox();
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
            this.CBtodosUsuarios = new System.Windows.Forms.CheckBox();
            this.PagregarProdu = new System.Windows.Forms.Panel();
            this.CBeditarContrasenia = new System.Windows.Forms.CheckBox();
            this.CBtipoEditar = new System.Windows.Forms.ComboBox();
            this.BcancelarEditar = new System.Windows.Forms.Button();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.BexaminarImUs = new System.Windows.Forms.Button();
            this.PBusuario = new System.Windows.Forms.PictureBox();
            this.TBusuario = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.Label();
            this.TBcontrasenia = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.Label();
            this.CBasignaUsuario = new System.Windows.Forms.CheckBox();
            this.BagregarUs = new System.Windows.Forms.Button();
            this.TBemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBtelefono = new System.Windows.Forms.TextBox();
            this.Ltel = new System.Windows.Forms.Label();
            this.TBdireccion = new System.Windows.Forms.TextBox();
            this.Ldireccion = new System.Windows.Forms.Label();
            this.CBusuarioTipo = new System.Windows.Forms.ComboBox();
            this.BeditarUs = new System.Windows.Forms.Button();
            this.LusuarioTipo = new System.Windows.Forms.Label();
            this.TBapeUsuario = new System.Windows.Forms.TextBox();
            this.LnombreUsuario = new System.Windows.Forms.Label();
            this.TBnomUsuario = new System.Windows.Forms.TextBox();
            this.LapellidoUsuario = new System.Windows.Forms.Label();
            this.TBdniUsuario = new System.Windows.Forms.TextBox();
            this.LdniUsuario = new System.Windows.Forms.Label();
            this.BcancelUs = new System.Windows.Forms.Button();
            this.DGlistaUsuarios = new System.Windows.Forms.DataGridView();
            this.CBeditarUs = new System.Windows.Forms.CheckBox();
            this.GBfiltroUsuarios.SuspendLayout();
            this.PagregarProdu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBusuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // GBfiltroUsuarios
            // 
            this.GBfiltroUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.GBfiltroUsuarios.Controls.Add(this.LBdni);
            this.GBfiltroUsuarios.Controls.Add(this.TBoxDni);
            this.GBfiltroUsuarios.Controls.Add(this.ComboBoxNombre);
            this.GBfiltroUsuarios.Controls.Add(this.CBoxApellido);
            this.GBfiltroUsuarios.Controls.Add(this.CBnombre);
            this.GBfiltroUsuarios.Controls.Add(this.CBapellido);
            this.GBfiltroUsuarios.Controls.Add(this.CBdni);
            this.GBfiltroUsuarios.Controls.Add(this.DTfechaIng);
            this.GBfiltroUsuarios.Controls.Add(this.CBfecha);
            this.GBfiltroUsuarios.Controls.Add(this.BbuscarUsuario);
            this.GBfiltroUsuarios.Controls.Add(this.CBtodosUsuarios);
            this.GBfiltroUsuarios.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBfiltroUsuarios.Location = new System.Drawing.Point(12, 12);
            this.GBfiltroUsuarios.Name = "GBfiltroUsuarios";
            this.GBfiltroUsuarios.Size = new System.Drawing.Size(253, 318);
            this.GBfiltroUsuarios.TabIndex = 3;
            this.GBfiltroUsuarios.TabStop = false;
            this.GBfiltroUsuarios.Text = "Filtrar por";
            // 
            // LBdni
            // 
            this.LBdni.FormattingEnabled = true;
            this.LBdni.ItemHeight = 19;
            this.LBdni.Location = new System.Drawing.Point(121, 80);
            this.LBdni.Name = "LBdni";
            this.LBdni.Size = new System.Drawing.Size(120, 42);
            this.LBdni.TabIndex = 34;
            this.LBdni.Visible = false;
            this.LBdni.SelectedIndexChanged += new System.EventHandler(this.LBdni_SelectedIndexChanged);
            // 
            // TBoxDni
            // 
            this.TBoxDni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TBoxDni.Location = new System.Drawing.Point(121, 55);
            this.TBoxDni.Name = "TBoxDni";
            this.TBoxDni.Size = new System.Drawing.Size(120, 27);
            this.TBoxDni.TabIndex = 33;
            this.TBoxDni.TextChanged += new System.EventHandler(this.TBoxDni_TextChanged);
            // 
            // ComboBoxNombre
            // 
            this.ComboBoxNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ComboBoxNombre.FormattingEnabled = true;
            this.ComboBoxNombre.Location = new System.Drawing.Point(120, 128);
            this.ComboBoxNombre.Name = "ComboBoxNombre";
            this.ComboBoxNombre.Size = new System.Drawing.Size(121, 27);
            this.ComboBoxNombre.TabIndex = 32;
            // 
            // CBoxApellido
            // 
            this.CBoxApellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBoxApellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CBoxApellido.FormattingEnabled = true;
            this.CBoxApellido.Location = new System.Drawing.Point(120, 161);
            this.CBoxApellido.Name = "CBoxApellido";
            this.CBoxApellido.Size = new System.Drawing.Size(121, 27);
            this.CBoxApellido.TabIndex = 31;
            // 
            // CBnombre
            // 
            this.CBnombre.AutoSize = true;
            this.CBnombre.Location = new System.Drawing.Point(17, 101);
            this.CBnombre.Name = "CBnombre";
            this.CBnombre.Size = new System.Drawing.Size(80, 23);
            this.CBnombre.TabIndex = 28;
            this.CBnombre.Text = "Nombre";
            this.CBnombre.UseVisualStyleBackColor = true;
            // 
            // CBapellido
            // 
            this.CBapellido.AutoSize = true;
            this.CBapellido.Location = new System.Drawing.Point(17, 135);
            this.CBapellido.Name = "CBapellido";
            this.CBapellido.Size = new System.Drawing.Size(83, 23);
            this.CBapellido.TabIndex = 27;
            this.CBapellido.Text = "Apellido";
            this.CBapellido.UseVisualStyleBackColor = true;
            // 
            // CBdni
            // 
            this.CBdni.AutoSize = true;
            this.CBdni.Location = new System.Drawing.Point(19, 66);
            this.CBdni.Name = "CBdni";
            this.CBdni.Size = new System.Drawing.Size(64, 23);
            this.CBdni.TabIndex = 26;
            this.CBdni.Text = "DNI";
            this.CBdni.UseVisualStyleBackColor = true;
            // 
            // DTfechaIng
            // 
            this.DTfechaIng.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTfechaIng.Location = new System.Drawing.Point(71, 213);
            this.DTfechaIng.Name = "DTfechaIng";
            this.DTfechaIng.Size = new System.Drawing.Size(108, 27);
            this.DTfechaIng.TabIndex = 25;
            // 
            // CBfecha
            // 
            this.CBfecha.AutoSize = true;
            this.CBfecha.Location = new System.Drawing.Point(49, 184);
            this.CBfecha.Name = "CBfecha";
            this.CBfecha.Size = new System.Drawing.Size(157, 23);
            this.CBfecha.TabIndex = 24;
            this.CBfecha.Text = "Por fecha de ingreso";
            this.CBfecha.UseVisualStyleBackColor = true;
            // 
            // BbuscarUsuario
            // 
            this.BbuscarUsuario.Location = new System.Drawing.Point(83, 258);
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
            this.CBtodosUsuarios.Size = new System.Drawing.Size(146, 23);
            this.CBtodosUsuarios.TabIndex = 2;
            this.CBtodosUsuarios.Text = "Todos los usuarios";
            this.CBtodosUsuarios.UseVisualStyleBackColor = true;
            // 
            // PagregarProdu
            // 
            this.PagregarProdu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PagregarProdu.AutoScroll = true;
            this.PagregarProdu.BackColor = System.Drawing.Color.RosyBrown;
            this.PagregarProdu.Controls.Add(this.CBeditarUs);
            this.PagregarProdu.Controls.Add(this.CBeditarContrasenia);
            this.PagregarProdu.Controls.Add(this.CBtipoEditar);
            this.PagregarProdu.Controls.Add(this.BcancelarEditar);
            this.PagregarProdu.Controls.Add(this.dtFecha);
            this.PagregarProdu.Controls.Add(this.label6);
            this.PagregarProdu.Controls.Add(this.BexaminarImUs);
            this.PagregarProdu.Controls.Add(this.PBusuario);
            this.PagregarProdu.Controls.Add(this.TBusuario);
            this.PagregarProdu.Controls.Add(this.usuario);
            this.PagregarProdu.Controls.Add(this.TBcontrasenia);
            this.PagregarProdu.Controls.Add(this.contraseña);
            this.PagregarProdu.Controls.Add(this.CBasignaUsuario);
            this.PagregarProdu.Controls.Add(this.BagregarUs);
            this.PagregarProdu.Controls.Add(this.TBemail);
            this.PagregarProdu.Controls.Add(this.label1);
            this.PagregarProdu.Controls.Add(this.TBtelefono);
            this.PagregarProdu.Controls.Add(this.Ltel);
            this.PagregarProdu.Controls.Add(this.TBdireccion);
            this.PagregarProdu.Controls.Add(this.Ldireccion);
            this.PagregarProdu.Controls.Add(this.CBusuarioTipo);
            this.PagregarProdu.Controls.Add(this.BeditarUs);
            this.PagregarProdu.Controls.Add(this.LusuarioTipo);
            this.PagregarProdu.Controls.Add(this.TBapeUsuario);
            this.PagregarProdu.Controls.Add(this.LnombreUsuario);
            this.PagregarProdu.Controls.Add(this.TBnomUsuario);
            this.PagregarProdu.Controls.Add(this.LapellidoUsuario);
            this.PagregarProdu.Controls.Add(this.TBdniUsuario);
            this.PagregarProdu.Controls.Add(this.LdniUsuario);
            this.PagregarProdu.Controls.Add(this.BcancelUs);
            this.PagregarProdu.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PagregarProdu.Location = new System.Drawing.Point(270, 12);
            this.PagregarProdu.Margin = new System.Windows.Forms.Padding(2);
            this.PagregarProdu.Name = "PagregarProdu";
            this.PagregarProdu.Size = new System.Drawing.Size(780, 318);
            this.PagregarProdu.TabIndex = 8;
            // 
            // CBeditarContrasenia
            // 
            this.CBeditarContrasenia.AutoSize = true;
            this.CBeditarContrasenia.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.CBeditarContrasenia.Location = new System.Drawing.Point(498, 152);
            this.CBeditarContrasenia.Name = "CBeditarContrasenia";
            this.CBeditarContrasenia.Size = new System.Drawing.Size(140, 23);
            this.CBeditarContrasenia.TabIndex = 37;
            this.CBeditarContrasenia.Text = "Editar Contraseña";
            this.CBeditarContrasenia.UseVisualStyleBackColor = true;
            this.CBeditarContrasenia.CheckedChanged += new System.EventHandler(this.CBeditarContrasenia_CheckedChanged);
            // 
            // CBtipoEditar
            // 
            this.CBtipoEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBtipoEditar.Enabled = false;
            this.CBtipoEditar.FormattingEnabled = true;
            this.CBtipoEditar.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Empleado"});
            this.CBtipoEditar.Location = new System.Drawing.Point(621, 76);
            this.CBtipoEditar.Name = "CBtipoEditar";
            this.CBtipoEditar.Size = new System.Drawing.Size(148, 23);
            this.CBtipoEditar.TabIndex = 36;
            // 
            // BcancelarEditar
            // 
            this.BcancelarEditar.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BcancelarEditar.Image = global::SaborAcielo.Properties.Resources.cancelar2;
            this.BcancelarEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BcancelarEditar.Location = new System.Drawing.Point(576, 272);
            this.BcancelarEditar.Margin = new System.Windows.Forms.Padding(2);
            this.BcancelarEditar.Name = "BcancelarEditar";
            this.BcancelarEditar.Size = new System.Drawing.Size(119, 32);
            this.BcancelarEditar.TabIndex = 35;
            this.BcancelarEditar.Text = "Cancelar";
            this.BcancelarEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BcancelarEditar.UseVisualStyleBackColor = true;
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(124, 262);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(107, 24);
            this.dtFecha.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "Fecha ingreso";
            // 
            // BexaminarImUs
            // 
            this.BexaminarImUs.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.BexaminarImUs.Location = new System.Drawing.Point(366, 160);
            this.BexaminarImUs.Name = "BexaminarImUs";
            this.BexaminarImUs.Size = new System.Drawing.Size(95, 27);
            this.BexaminarImUs.TabIndex = 32;
            this.BexaminarImUs.Text = "Examinar";
            this.BexaminarImUs.UseVisualStyleBackColor = true;
            this.BexaminarImUs.Click += new System.EventHandler(this.BexaminarImUs_Click_1);
            // 
            // PBusuario
            // 
            this.PBusuario.ErrorImage = null;
            this.PBusuario.Image = global::SaborAcielo.Properties.Resources.EmpleadosInicio;
            this.PBusuario.InitialImage = null;
            this.PBusuario.Location = new System.Drawing.Point(350, 25);
            this.PBusuario.Name = "PBusuario";
            this.PBusuario.Size = new System.Drawing.Size(123, 110);
            this.PBusuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBusuario.TabIndex = 31;
            this.PBusuario.TabStop = false;
            // 
            // TBusuario
            // 
            this.TBusuario.Enabled = false;
            this.TBusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBusuario.Location = new System.Drawing.Point(621, 112);
            this.TBusuario.Margin = new System.Windows.Forms.Padding(2);
            this.TBusuario.Name = "TBusuario";
            this.TBusuario.Size = new System.Drawing.Size(137, 26);
            this.TBusuario.TabIndex = 30;
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(532, 116);
            this.usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(60, 19);
            this.usuario.TabIndex = 29;
            this.usuario.Text = "Usuario";
            // 
            // TBcontrasenia
            // 
            this.TBcontrasenia.Enabled = false;
            this.TBcontrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBcontrasenia.Location = new System.Drawing.Point(621, 178);
            this.TBcontrasenia.Margin = new System.Windows.Forms.Padding(2);
            this.TBcontrasenia.Name = "TBcontrasenia";
            this.TBcontrasenia.Size = new System.Drawing.Size(139, 26);
            this.TBcontrasenia.TabIndex = 28;
            // 
            // contraseña
            // 
            this.contraseña.AutoSize = true;
            this.contraseña.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.Location = new System.Drawing.Point(526, 182);
            this.contraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(79, 19);
            this.contraseña.TabIndex = 27;
            this.contraseña.Text = "Contraseña";
            // 
            // CBasignaUsuario
            // 
            this.CBasignaUsuario.AutoSize = true;
            this.CBasignaUsuario.Font = new System.Drawing.Font("Sans Serif Collection", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBasignaUsuario.Location = new System.Drawing.Point(508, 20);
            this.CBasignaUsuario.Name = "CBasignaUsuario";
            this.CBasignaUsuario.Size = new System.Drawing.Size(250, 31);
            this.CBasignaUsuario.TabIndex = 26;
            this.CBasignaUsuario.Text = "USUARIO DEL SISTEMA";
            this.CBasignaUsuario.UseVisualStyleBackColor = true;
            this.CBasignaUsuario.CheckedChanged += new System.EventHandler(this.CBasignaUsuario_CheckedChanged);
            // 
            // BagregarUs
            // 
            this.BagregarUs.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BagregarUs.Image = global::SaborAcielo.Properties.Resources.add_button;
            this.BagregarUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BagregarUs.Location = new System.Drawing.Point(385, 236);
            this.BagregarUs.Margin = new System.Windows.Forms.Padding(2);
            this.BagregarUs.Name = "BagregarUs";
            this.BagregarUs.Size = new System.Drawing.Size(115, 32);
            this.BagregarUs.TabIndex = 25;
            this.BagregarUs.Text = "Agregar";
            this.BagregarUs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BagregarUs.UseVisualStyleBackColor = true;
            this.BagregarUs.Click += new System.EventHandler(this.BagregarUs_Click);
            // 
            // TBemail
            // 
            this.TBemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBemail.Location = new System.Drawing.Point(103, 137);
            this.TBemail.Margin = new System.Windows.Forms.Padding(2);
            this.TBemail.Name = "TBemail";
            this.TBemail.Size = new System.Drawing.Size(212, 26);
            this.TBemail.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Email";
            // 
            // TBtelefono
            // 
            this.TBtelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBtelefono.Location = new System.Drawing.Point(103, 212);
            this.TBtelefono.Margin = new System.Windows.Forms.Padding(2);
            this.TBtelefono.Name = "TBtelefono";
            this.TBtelefono.Size = new System.Drawing.Size(212, 26);
            this.TBtelefono.TabIndex = 22;
            this.TBtelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBtelefono_TextChanged);
            // 
            // Ltel
            // 
            this.Ltel.AutoSize = true;
            this.Ltel.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltel.Location = new System.Drawing.Point(14, 219);
            this.Ltel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ltel.Name = "Ltel";
            this.Ltel.Size = new System.Drawing.Size(65, 19);
            this.Ltel.TabIndex = 21;
            this.Ltel.Text = "Telefono";
            // 
            // TBdireccion
            // 
            this.TBdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBdireccion.Location = new System.Drawing.Point(103, 173);
            this.TBdireccion.Margin = new System.Windows.Forms.Padding(2);
            this.TBdireccion.Name = "TBdireccion";
            this.TBdireccion.Size = new System.Drawing.Size(212, 26);
            this.TBdireccion.TabIndex = 20;
            this.TBdireccion.TextChanged += new System.EventHandler(this.TBdireccion_TextChanged);
            // 
            // Ldireccion
            // 
            this.Ldireccion.AutoSize = true;
            this.Ldireccion.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ldireccion.Location = new System.Drawing.Point(11, 178);
            this.Ldireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ldireccion.Name = "Ldireccion";
            this.Ldireccion.Size = new System.Drawing.Size(68, 19);
            this.Ldireccion.TabIndex = 19;
            this.Ldireccion.Text = "Dirección";
            // 
            // CBusuarioTipo
            // 
            this.CBusuarioTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBusuarioTipo.Enabled = false;
            this.CBusuarioTipo.FormattingEnabled = true;
            this.CBusuarioTipo.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Empleado"});
            this.CBusuarioTipo.Location = new System.Drawing.Point(621, 76);
            this.CBusuarioTipo.Name = "CBusuarioTipo";
            this.CBusuarioTipo.Size = new System.Drawing.Size(148, 23);
            this.CBusuarioTipo.TabIndex = 18;
            // 
            // BeditarUs
            // 
            this.BeditarUs.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeditarUs.Image = global::SaborAcielo.Properties.Resources.editar;
            this.BeditarUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BeditarUs.Location = new System.Drawing.Point(385, 272);
            this.BeditarUs.Margin = new System.Windows.Forms.Padding(2);
            this.BeditarUs.Name = "BeditarUs";
            this.BeditarUs.Size = new System.Drawing.Size(115, 32);
            this.BeditarUs.TabIndex = 15;
            this.BeditarUs.Text = "Editar";
            this.BeditarUs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BeditarUs.UseVisualStyleBackColor = true;
            this.BeditarUs.Click += new System.EventHandler(this.BeditarUs_Click);
            // 
            // LusuarioTipo
            // 
            this.LusuarioTipo.AutoSize = true;
            this.LusuarioTipo.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LusuarioTipo.Location = new System.Drawing.Point(494, 76);
            this.LusuarioTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LusuarioTipo.Name = "LusuarioTipo";
            this.LusuarioTipo.Size = new System.Drawing.Size(109, 19);
            this.LusuarioTipo.TabIndex = 10;
            this.LusuarioTipo.Text = "Tipo de usuario";
            // 
            // TBapeUsuario
            // 
            this.TBapeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBapeUsuario.Location = new System.Drawing.Point(101, 89);
            this.TBapeUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TBapeUsuario.Name = "TBapeUsuario";
            this.TBapeUsuario.Size = new System.Drawing.Size(190, 26);
            this.TBapeUsuario.TabIndex = 9;
            this.TBapeUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBapeUsuario_TextChanged);
            // 
            // LnombreUsuario
            // 
            this.LnombreUsuario.AutoSize = true;
            this.LnombreUsuario.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnombreUsuario.Location = new System.Drawing.Point(11, 53);
            this.LnombreUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LnombreUsuario.Name = "LnombreUsuario";
            this.LnombreUsuario.Size = new System.Drawing.Size(61, 19);
            this.LnombreUsuario.TabIndex = 8;
            this.LnombreUsuario.Text = "Nombre";
            // 
            // TBnomUsuario
            // 
            this.TBnomUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBnomUsuario.Location = new System.Drawing.Point(101, 49);
            this.TBnomUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TBnomUsuario.Name = "TBnomUsuario";
            this.TBnomUsuario.Size = new System.Drawing.Size(192, 26);
            this.TBnomUsuario.TabIndex = 7;
            this.TBnomUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBnomUsuario_TextChanged);
            // 
            // LapellidoUsuario
            // 
            this.LapellidoUsuario.AutoSize = true;
            this.LapellidoUsuario.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LapellidoUsuario.Location = new System.Drawing.Point(11, 96);
            this.LapellidoUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LapellidoUsuario.Name = "LapellidoUsuario";
            this.LapellidoUsuario.Size = new System.Drawing.Size(64, 19);
            this.LapellidoUsuario.TabIndex = 6;
            this.LapellidoUsuario.Text = "Apellido";
            // 
            // TBdniUsuario
            // 
            this.TBdniUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBdniUsuario.Location = new System.Drawing.Point(101, 15);
            this.TBdniUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TBdniUsuario.Name = "TBdniUsuario";
            this.TBdniUsuario.Size = new System.Drawing.Size(192, 26);
            this.TBdniUsuario.TabIndex = 3;
            this.TBdniUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBdniUsuario_TextChanged);
            // 
            // LdniUsuario
            // 
            this.LdniUsuario.AutoSize = true;
            this.LdniUsuario.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LdniUsuario.Location = new System.Drawing.Point(9, 15);
            this.LdniUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LdniUsuario.Name = "LdniUsuario";
            this.LdniUsuario.Size = new System.Drawing.Size(45, 19);
            this.LdniUsuario.TabIndex = 2;
            this.LdniUsuario.Text = "DNI";
            // 
            // BcancelUs
            // 
            this.BcancelUs.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BcancelUs.Image = global::SaborAcielo.Properties.Resources.cancelar2;
            this.BcancelUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BcancelUs.Location = new System.Drawing.Point(576, 272);
            this.BcancelUs.Margin = new System.Windows.Forms.Padding(2);
            this.BcancelUs.Name = "BcancelUs";
            this.BcancelUs.Size = new System.Drawing.Size(119, 32);
            this.BcancelUs.TabIndex = 1;
            this.BcancelUs.Text = "Cancelar";
            this.BcancelUs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BcancelUs.UseVisualStyleBackColor = true;
            this.BcancelUs.Click += new System.EventHandler(this.BcancelProdu_Click);
            // 
            // DGlistaUsuarios
            // 
            this.DGlistaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGlistaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGlistaUsuarios.BackgroundColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGlistaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGlistaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGlistaUsuarios.Location = new System.Drawing.Point(12, 348);
            this.DGlistaUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.DGlistaUsuarios.Name = "DGlistaUsuarios";
            this.DGlistaUsuarios.RowHeadersWidth = 62;
            this.DGlistaUsuarios.RowTemplate.Height = 28;
            this.DGlistaUsuarios.Size = new System.Drawing.Size(971, 153);
            this.DGlistaUsuarios.TabIndex = 9;
            this.DGlistaUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGlistaUsuarios_CellContentClick);
            // 
            // CBeditarUs
            // 
            this.CBeditarUs.AutoSize = true;
            this.CBeditarUs.Font = new System.Drawing.Font("Sans Serif Collection", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBeditarUs.Location = new System.Drawing.Point(508, 42);
            this.CBeditarUs.Name = "CBeditarUs";
            this.CBeditarUs.Size = new System.Drawing.Size(157, 31);
            this.CBeditarUs.TabIndex = 38;
            this.CBeditarUs.Text = "Editar Usuario";
            this.CBeditarUs.UseVisualStyleBackColor = true;
            this.CBeditarUs.CheckedChanged += new System.EventHandler(this.CBeditarUs_CheckedChanged);
            // 
            // FlistaUsuariosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(1061, 512);
            this.Controls.Add(this.DGlistaUsuarios);
            this.Controls.Add(this.PagregarProdu);
            this.Controls.Add(this.GBfiltroUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlistaUsuariosAdmin";
            this.Text = "Lista de usuarios";
            this.GBfiltroUsuarios.ResumeLayout(false);
            this.GBfiltroUsuarios.PerformLayout();
            this.PagregarProdu.ResumeLayout(false);
            this.PagregarProdu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBusuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBfiltroUsuarios;
        private System.Windows.Forms.Button BbuscarUsuario;
        private System.Windows.Forms.CheckBox CBtodosUsuarios;
        private System.Windows.Forms.Panel PagregarProdu;
        private System.Windows.Forms.Button BeditarUs;
        private System.Windows.Forms.Label LusuarioTipo;
        private System.Windows.Forms.TextBox TBapeUsuario;
        private System.Windows.Forms.Label LnombreUsuario;
        private System.Windows.Forms.TextBox TBnomUsuario;
        private System.Windows.Forms.Label LapellidoUsuario;
        private System.Windows.Forms.TextBox TBdniUsuario;
        private System.Windows.Forms.Label LdniUsuario;
        private System.Windows.Forms.Button BcancelUs;
        private System.Windows.Forms.DataGridView DGlistaUsuarios;
        private System.Windows.Forms.ComboBox CBusuarioTipo;
        private System.Windows.Forms.TextBox TBtelefono;
        private System.Windows.Forms.Label Ltel;
        private System.Windows.Forms.TextBox TBdireccion;
        private System.Windows.Forms.Label Ldireccion;
        private System.Windows.Forms.TextBox TBemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BagregarUs;
        private System.Windows.Forms.TextBox TBusuario;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.TextBox TBcontrasenia;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.CheckBox CBasignaUsuario;
        private System.Windows.Forms.PictureBox PBusuario;
        private System.Windows.Forms.Button BexaminarImUs;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BcancelarEditar;
        private System.Windows.Forms.ComboBox CBtipoEditar;
        private System.Windows.Forms.DateTimePicker DTfechaIng;
        private System.Windows.Forms.CheckBox CBfecha;
        private System.Windows.Forms.CheckBox CBnombre;
        private System.Windows.Forms.CheckBox CBapellido;
        private System.Windows.Forms.CheckBox CBdni;
        private System.Windows.Forms.ComboBox ComboBoxNombre;
        private System.Windows.Forms.ComboBox CBoxApellido;
        private System.Windows.Forms.ListBox LBdni;
        private System.Windows.Forms.TextBox TBoxDni;
        private System.Windows.Forms.CheckBox CBeditarContrasenia;
        private System.Windows.Forms.CheckBox CBeditarUs;
    }
}