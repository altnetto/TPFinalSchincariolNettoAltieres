namespace EmpleadosApp
{
    partial class FormAdicionar
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Completo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 61);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(130, 113);
            this.txtDNI.MaxLength = 15;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(197, 20);
            this.txtDNI.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Edad";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(130, 170);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(81, 20);
            this.txtEdad.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Casado?";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Salario";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(130, 302);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(81, 20);
            this.txtSalario.TabIndex = 5;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(130, 236);
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
            this.rb2.Location = new System.Drawing.Point(172, 236);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(39, 17);
            this.rb2.TabIndex = 4;
            this.rb2.TabStop = true;
            this.rb2.Text = "No";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(15, 350);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(117, 41);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(210, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 41);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // formAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 424);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formAdicionar";
            this.Text = "Adicionar Empleado";
            this.Load += new System.EventHandler(this.formAdicionar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnCancelar;
    }
}