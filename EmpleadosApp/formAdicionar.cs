using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleadosApp
{
    public partial class FormAdicionar : Form
    {
        public FormAdicionar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado nuevoEmpleado = new Empleado();

                nuevoEmpleado.NombreCompleto = txtNombre.Text;
                nuevoEmpleado.DNI = txtDNI.Text;
                nuevoEmpleado.Edad = int.Parse(txtEdad.Text);
                nuevoEmpleado.Casado = verificarCasado(rb1);
                nuevoEmpleado.Salario = decimal.Parse(txtSalario.Text);

                FuncionesSQL adicionar = new FuncionesSQL();

                adicionar.AdcEmpleado(nuevoEmpleado);
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }

        }

        private bool verificarCasado (RadioButton rb)
        {
            if (rb.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void formAdicionar_Load(object sender, EventArgs e)
        {

        }
    }
}
