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
    public partial class formBuscar : Form
    {
        public formBuscar()
        {
            InitializeComponent();
        }

        private void formBuscar_Load(object sender, EventArgs e)
        {
  
            FuncionesSQL buscar = new FuncionesSQL();
            dgvBuscar.DataSource = buscar.buscarEmpleados(txtBusca.Text);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FuncionesSQL buscar = new FuncionesSQL();
            dgvBuscar.DataSource = buscar.buscarEmpleados(txtBusca.Text);

        }

        private void dgvBuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
