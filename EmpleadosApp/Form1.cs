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
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            FuncionesSQL conexion = new FuncionesSQL();
            dgvEmpleado.DataSource = conexion.listarEmpleados();
            dgvEmpleado.Columns["ID"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAdicionar pantallaAdicional = new FormAdicionar();
            pantallaAdicional.ShowDialog();

            Cargar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            new formBuscar().ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var funcionesSQL = new FuncionesSQL();
            var id = funcionesSQL.PegarId(dgvEmpleado);

            funcionesSQL.eliminarEmpleado(id);
            funcionesSQL.listarEmpleados();

            Cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            new FormModificar().ShowDialog();

            Cargar();
        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
