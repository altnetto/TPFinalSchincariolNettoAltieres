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
            cargar();
        }

        private void cargar()
        {
            FuncionesSQL conexion = new FuncionesSQL();
            dgvEmpleado.DataSource = conexion.listarEmpleados();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            formAdicionar pantallaAdicional = new formAdicionar();
            pantallaAdicional.ShowDialog();

            FuncionesSQL conexion = new FuncionesSQL();
            dgvEmpleado.DataSource = conexion.listarEmpleados();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            formBuscar pantallaBuscar = new formBuscar();
            pantallaBuscar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FuncionesSQL eliminar = new FuncionesSQL();

            

        }
    }
}
