namespace SaborAcielo
{
    partial class FlistarVentas
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
            this.DGventas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Pventas = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBfecha = new System.Windows.Forms.CheckBox();
            this.CBcliente = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGventas)).BeginInit();
            this.Pventas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGventas
            // 
            this.DGventas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGventas.Location = new System.Drawing.Point(27, 313);
            this.DGventas.Name = "DGventas";
            this.DGventas.RowHeadersWidth = 62;
            this.DGventas.RowTemplate.Height = 28;
            this.DGventas.Size = new System.Drawing.Size(995, 346);
            this.DGventas.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empleado";
            // 
            // Pventas
            // 
            this.Pventas.BackColor = System.Drawing.Color.RosyBrown;
            this.Pventas.Controls.Add(this.groupBox1);
            this.Pventas.Controls.Add(this.label3);
            this.Pventas.Controls.Add(this.label2);
            this.Pventas.Font = new System.Drawing.Font("Script MT Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pventas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pventas.Location = new System.Drawing.Point(84, 50);
            this.Pventas.Name = "Pventas";
            this.Pventas.Size = new System.Drawing.Size(851, 250);
            this.Pventas.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hasta";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(547, 36);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(154, 34);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Desde";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(289, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 34);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lista de ventas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBcliente);
            this.groupBox1.Controls.Add(this.CBfecha);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(35, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 162);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por";
            // 
            // CBfecha
            // 
            this.CBfecha.AutoSize = true;
            this.CBfecha.Location = new System.Drawing.Point(28, 39);
            this.CBfecha.Name = "CBfecha";
            this.CBfecha.Size = new System.Drawing.Size(89, 31);
            this.CBfecha.TabIndex = 8;
            this.CBfecha.Text = "Fecha";
            this.CBfecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBfecha.UseVisualStyleBackColor = true;
            // 
            // CBcliente
            // 
            this.CBcliente.AutoSize = true;
            this.CBcliente.Location = new System.Drawing.Point(28, 104);
            this.CBcliente.Name = "CBcliente";
            this.CBcliente.Size = new System.Drawing.Size(95, 31);
            this.CBcliente.TabIndex = 9;
            this.CBcliente.Text = "Cliente";
            this.CBcliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBcliente.UseVisualStyleBackColor = true;
            // 
            // FlistarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaborAcielo.Properties.Resources.fondoSACinicio;
            this.ClientSize = new System.Drawing.Size(1099, 671);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pventas);
            this.Controls.Add(this.DGventas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlistarVentas";
            this.Text = "FlistarVentas";
            ((System.ComponentModel.ISupportInitialize)(this.DGventas)).EndInit();
            this.Pventas.ResumeLayout(false);
            this.Pventas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGventas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Pventas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CBfecha;
        private System.Windows.Forms.CheckBox CBcliente;
    }
}