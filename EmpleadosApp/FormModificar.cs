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
    public partial class FormModificar : Form
    {
        public FormModificar()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvModificar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            limparCelulas();
            
            FuncionesSQL modificar = new FuncionesSQL();
            Empleado info = modificar.SelectInfo(dgvModificar);

            txtNombre.Text = info.NombreCompleto.ToString();
            txtDNI.Text = info.DNI.ToString();
            txtEdad.Text = info.Edad.ToString();

            if (info.Casado == true)
            {
                rb1.Checked = true;
            }
            else
            {
                rb2.Checked = true;
            }

            txtSalario.Text = info.Salario.ToString();

        }

        private void limparCelulas()
        {
            txtNombre.Text = null;
            txtDNI.Text = null;
            txtEdad.Text = null;
            txtSalario.Text = null;
            rb1.Checked = false;
            rb2.Checked = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado empleado = new Empleado();
                empleado.NombreCompleto = txtNombre.Text;
                empleado.DNI = txtDNI.Text;
                empleado.Edad = int.Parse(txtEdad.Text);

                if (rb1.Checked == true)
                {
                    empleado.Casado = true;
                }
                else
                {
                    empleado.Casado = false;
                }

                empleado.Salario = decimal.Parse(txtSalario.Text);

                FuncionesSQL modificar = new FuncionesSQL();

                empleado.ID = modificar.PegarId(dgvModificar);

                modificar.modificarEmpleado(dgvModificar, empleado);
                Cargar();
                limparCelulas();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        private void Cargar()
        {
            FuncionesSQL conexion = new FuncionesSQL();
            dgvModificar.DataSource = conexion.listarEmpleados();
            conexion.OcultarId(dgvModificar);
        }

    }
}
