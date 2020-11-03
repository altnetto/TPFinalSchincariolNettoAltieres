using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace EmpleadosApp
{ 
    class FuncionesSQL
    {
        public List<Empleado> listarEmpleados()
        {
            List<Empleado> lista = new List<Empleado>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            conexion.ConnectionString = "data source=.\\SQLEXPRESS; initial catalog=EMPLEADOS_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from dbo.Empleados";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Empleado aux = new Empleado();
                aux.ID = lector.GetInt32(0);
                aux.NombreCompleto = lector.GetString(1);
                aux.DNI = lector.GetString(2);
                aux.Edad = lector.GetInt32(3);
                aux.Casado = lector.GetBoolean(4);
                aux.Salario = lector.GetDecimal(5);

                lista.Add(aux);
            }
            conexion.Close();

            return lista;
        }

        public void AdcEmpleado(Empleado adc)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            conexion.ConnectionString = "data source=.\\SQLEXPRESS; initial catalog=EMPLEADOS_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;

            string commandText = "INSERT INTO dbo.Empleados (NombreCompleto, DNI, Edad, Casado, Salario) " +
                                    "Values (@Nombre,@DNI,@Edad,@Casado,@Salario)";

            comando.CommandText = commandText;

            comando.Parameters.Add("@Nombre", SqlDbType.VarChar);
            comando.Parameters["@Nombre"].Value = adc.NombreCompleto;

            comando.Parameters.Add("@DNI", SqlDbType.VarChar);
            comando.Parameters["@DNI"].Value = adc.DNI;


            comando.Parameters.Add("@Edad", SqlDbType.Int);
            comando.Parameters["@Edad"].Value = adc.Edad;


            comando.Parameters.Add("@Casado", SqlDbType.Bit);
            comando.Parameters["@Casado"].Value = adc.Casado;


            comando.Parameters.Add("@Salario", SqlDbType.Decimal);
            comando.Parameters["@Salario"].Value = adc.Salario;

            comando.Connection = conexion;
            conexion.Open();

            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public List<Empleado> buscarEmpleados(string Nombre)
        {
            List<Empleado> lista = new List<Empleado>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            conexion.ConnectionString = "data source=.\\SQLEXPRESS; initial catalog=EMPLEADOS_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from dbo.Empleados where NombreCompleto Like '" + Nombre + "%'";

            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Empleado aux = new Empleado();
                aux.ID = lector.GetInt32(0);
                aux.NombreCompleto = lector.GetString(1);
                aux.DNI = lector.GetString(2);
                aux.Edad = lector.GetInt32(3);
                aux.Casado = lector.GetBoolean(4);
                aux.Salario = lector.GetDecimal(5);

                lista.Add(aux);
            }
            conexion.Close();

            return lista;
        }

        public List<Empleado> eliminarEmpleado(int Id)
        {
            List<Empleado> lista = new List<Empleado>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            conexion.ConnectionString = "data source=.\\SQLEXPRESS; initial catalog=EMPLEADOS_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = $"DELETE from dbo.Empleados where ID = {Id}";

            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Empleado aux = new Empleado();
                aux.ID = lector.GetInt32(0);
                aux.NombreCompleto = lector.GetString(1);
                aux.DNI = lector.GetString(2);
                aux.Edad = lector.GetInt32(3);
                aux.Casado = lector.GetBoolean(4);
                aux.Salario = lector.GetDecimal(5);

                lista.Add(aux);
            }
            conexion.Close();

            return lista;
        }

        public void modificarEmpleado(DataGridView dgv, Empleado empleado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            conexion.ConnectionString = "data source=.\\SQLEXPRESS; initial catalog=EMPLEADOS_DB; integrated security=sspi";
            comando.CommandType = CommandType.Text;
            string commandText = "UPDATE dbo.Empleados SET NombreCompleto = @Nombre, " +
                                 "DNI = @DNI, " +
                                 "Edad = @Edad, " +
                                 "Casado = @Casado, " +
                                 "Salario = @Salario " +
                                 "WHERE ID = @Id";

            comando.CommandText = commandText;

            comando.Parameters.Add("@Nombre", SqlDbType.VarChar);
            comando.Parameters["@Nombre"].Value = empleado.NombreCompleto;

            comando.Parameters.Add("@DNI", SqlDbType.VarChar);
            comando.Parameters["@DNI"].Value = empleado.DNI;


            comando.Parameters.Add("@Edad", SqlDbType.Int);
            comando.Parameters["@Edad"].Value = empleado.Edad;


            comando.Parameters.Add("@Casado", SqlDbType.Bit);
            comando.Parameters["@Casado"].Value = empleado.Casado;


            comando.Parameters.Add("@Salario", SqlDbType.Decimal);
            comando.Parameters["@Salario"].Value = empleado.Salario;

            comando.Parameters.Add("@Id", SqlDbType.Int);
            comando.Parameters["@Id"].Value = empleado.ID;

            comando.Connection = conexion;
            conexion.Open();

            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public Empleado SelectInfo(DataGridView dgv)
        {
            Empleado aux = new Empleado();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            var Id = PegarId(dgv);

            conexion.ConnectionString = "data source=.\\SQLEXPRESS; initial catalog=EMPLEADOS_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = $"SELECT * FROM dbo.Empleados where ID = {Id}";

            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                aux.ID = lector.GetInt32(0);
                aux.NombreCompleto = lector.GetString(1);
                aux.DNI = lector.GetString(2);
                aux.Edad = lector.GetInt32(3);
                aux.Casado = lector.GetBoolean(4);
                aux.Salario = lector.GetDecimal(5);
            }
            conexion.Close();

            return aux;

        }

        public int PegarId(DataGridView dgv)
        {
            return Convert.ToInt32(dgv.SelectedCells[0].OwningRow.Cells[0].Value);
        }

        public void OcultarId(DataGridView dgv)
        {
            dgv.Columns["ID"].Visible = false;
        }

    }
}
