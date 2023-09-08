namespace SaborAcielo
{
    partial class FinicioEmpleado
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Bcliente = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BagregarC = new System.Windows.Forms.Button();
            this.BeditarC = new System.Windows.Forms.Button();
            this.BverC = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Bproducto = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.Bventa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.Bventa);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.Bproducto);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Bcliente);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 756);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 90);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Bcliente
            // 
            this.Bcliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bcliente.Font = new System.Drawing.Font("Script MT Bold", 13F, System.Drawing.FontStyle.Bold);
            this.Bcliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bcliente.Location = new System.Drawing.Point(0, 90);
            this.Bcliente.Name = "Bcliente";
            this.Bcliente.Size = new System.Drawing.Size(332, 52);
            this.Bcliente.TabIndex = 1;
            this.Bcliente.Text = "Clientes";
            this.Bcliente.UseVisualStyleBackColor = true;
            this.Bcliente.Click += new System.EventHandler(this.Bcliente_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BverC);
            this.panel3.Controls.Add(this.BeditarC);
            this.panel3.Controls.Add(this.BagregarC);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Script MT Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 152);
            this.panel3.TabIndex = 2;
            // 
            // BagregarC
            // 
            this.BagregarC.Dock = System.Windows.Forms.DockStyle.Top;
            this.BagregarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BagregarC.Location = new System.Drawing.Point(0, 0);
            this.BagregarC.Name = "BagregarC";
            this.BagregarC.Size = new System.Drawing.Size(332, 52);
            this.BagregarC.TabIndex = 2;
            this.BagregarC.Text = "Agregar cliente";
            this.BagregarC.UseVisualStyleBackColor = true;
            this.BagregarC.Click += new System.EventHandler(this.BagregarC_Click);
            // 
            // BeditarC
            // 
            this.BeditarC.Dock = System.Windows.Forms.DockStyle.Top;
            this.BeditarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BeditarC.Location = new System.Drawing.Point(0, 52);
            this.BeditarC.Name = "BeditarC";
            this.BeditarC.Size = new System.Drawing.Size(332, 52);
            this.BeditarC.TabIndex = 3;
            this.BeditarC.Text = "Editar cliente";
            this.BeditarC.UseVisualStyleBackColor = true;
            // 
            // BverC
            // 
            this.BverC.Dock = System.Windows.Forms.DockStyle.Top;
            this.BverC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BverC.Location = new System.Drawing.Point(0, 104);
            this.BverC.Name = "BverC";
            this.BverC.Size = new System.Drawing.Size(332, 48);
            this.BverC.TabIndex = 4;
            this.BverC.Text = "Listar clientes";
            this.BverC.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Script MT Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 346);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(332, 152);
            this.panel4.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 104);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(332, 48);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 52);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(332, 52);
            this.button6.TabIndex = 3;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(332, 52);
            this.button7.TabIndex = 2;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Bproducto
            // 
            this.Bproducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bproducto.Font = new System.Drawing.Font("Script MT Bold", 13F, System.Drawing.FontStyle.Bold);
            this.Bproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bproducto.Location = new System.Drawing.Point(0, 294);
            this.Bproducto.Name = "Bproducto";
            this.Bproducto.Size = new System.Drawing.Size(332, 52);
            this.Bproducto.TabIndex = 3;
            this.Bproducto.Text = "Productos";
            this.Bproducto.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button9);
            this.panel5.Controls.Add(this.button10);
            this.panel5.Controls.Add(this.button11);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Script MT Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(0, 550);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(332, 152);
            this.panel5.TabIndex = 6;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(0, 104);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(332, 48);
            this.button9.TabIndex = 4;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(0, 52);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(332, 52);
            this.button10.TabIndex = 3;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(0, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(332, 52);
            this.button11.TabIndex = 2;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // Bventa
            // 
            this.Bventa.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bventa.Font = new System.Drawing.Font("Script MT Bold", 13F, System.Drawing.FontStyle.Bold);
            this.Bventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bventa.Location = new System.Drawing.Point(0, 498);
            this.Bventa.Name = "Bventa";
            this.Bventa.Size = new System.Drawing.Size(332, 52);
            this.Bventa.TabIndex = 5;
            this.Bventa.Text = "Ventas";
            this.Bventa.UseVisualStyleBackColor = true;
            // 
            // FinicioEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 756);
            this.Controls.Add(this.panel1);
            this.Name = "FinicioEmpleado";
            this.Text = "FinicioEmpleado";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BverC;
        private System.Windows.Forms.Button BeditarC;
        private System.Windows.Forms.Button BagregarC;
        private System.Windows.Forms.Button Bcliente;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button Bventa;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Bproducto;
    }
}