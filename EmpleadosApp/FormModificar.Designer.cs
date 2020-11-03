namespace EmpleadosApp
{
    partial class FormModificar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvModificar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Datos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre Completo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "DNI";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Edad";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Casado";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Salario";
            this.label8.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 277);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(292, 277);
            this.txtDNI.MaxLength = 13;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(142, 20);
            this.txtDNI.TabIndex = 2;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(50, 316);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(56, 20);
            this.txtEdad.TabIndex = 3;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(292, 316);
            this.txtSalario.MaxLength = 10;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(142, 20);
            this.txtSalario.TabIndex = 6;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(161, 317);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(36, 17);
            this.rb1.TabIndex = 4;
            this.rb1.TabStop = true;
            this.rb1.Text = "Sí";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(203, 317);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(39, 17);
            this.rb2.TabIndex = 5;
            this.rb2.TabStop = true;
            this.rb2.Text = "No";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(450, 277);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(91, 27);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(450, 309);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 27);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvModificar
            // 
            this.dgvModificar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificar.Location = new System.Drawing.Point(15, 25);
            this.dgvModificar.Name = "dgvModificar";
            this.dgvModificar.ReadOnly = true;
            this.dgvModificar.Size = new System.Drawing.Size(526, 246);
            this.dgvModificar.TabIndex = 7;
            this.dgvModificar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModificar_CellContentClick);
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 351);
            this.Controls.Add(this.dgvModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormModificar";
            this.Text = "Modificar Datos";
            this.Load += new System.EventHandler(this.FormModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvModificar;
    }
}