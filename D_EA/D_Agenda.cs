using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using E_EA;
using System.Data;

namespace D_EA
{
    public class D_Agenda
    {
        SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public SqlConnection AbrirConexion()
        {
            if (conectar.State == ConnectionState.Closed)
                conectar.Open();
            return conectar;
        }
        public SqlConnection CerrarConexion()
        {
            if (conectar.State == ConnectionState.Open)
                conectar.Close();
            return conectar;
        }

        public List<E_Agenda> ListarAgenda(string buscar) 
        {
            SqlDataReader leerR;
            SqlCommand cmd = new SqlCommand("SP_READ", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            conectar.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);
            leerR = cmd.ExecuteReader();

            List<E_Agenda> list = new List<E_Agenda>();
            while (leerR.Read())
            {
                list.Add(new E_Agenda { 
                    ID = leerR.GetInt32(0),
                    Nombre = leerR.GetString(1),
                    Apellido = leerR.GetString(2),
                    Genero = leerR.GetString(3),
                    Correo = leerR.GetString(4)
                   


                });
            }
            conectar.Close();
            leerR.Close();
            return list;
        }

        public DataTable Showlist() 
        {
            SqlDataReader leer;
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = AbrirConexion();
            cmd.CommandText = "Select * From People";
            cmd.CommandType = CommandType.Text;
            leer = cmd.ExecuteReader();
            dataTable.Load(leer);
            conectar.Close();
            return dataTable;
        }

        public void insertA(E_Agenda e_Agenda)
        {
            SqlCommand cmd = new SqlCommand("SP_CREATE", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            AbrirConexion();

            cmd.Parameters.AddWithValue("@Nombre", e_Agenda.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", e_Agenda.Apellido);
            cmd.Parameters.AddWithValue("@Mail", e_Agenda.Correo);
            cmd.Parameters.AddWithValue("@GENERO", e_Agenda.Genero);

            cmd.ExecuteNonQuery();
            CerrarConexion();
        }


        public void updateA(E_Agenda e_Agenda)
        {
            SqlCommand cmd = new SqlCommand("SP_UPDATE", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            conectar.Open();

            cmd.Parameters.AddWithValue("@ID", e_Agenda.ID);
            cmd.Parameters.AddWithValue("@Nombre", e_Agenda.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", e_Agenda.Apellido);
            cmd.Parameters.AddWithValue("@GENERO", e_Agenda.Genero);
            cmd.Parameters.AddWithValue("@Mail", e_Agenda.Correo);

            cmd.ExecuteNonQuery();
            conectar.Close();
        }

        public void deleteA(E_Agenda e_Agenda)
        {
            SqlCommand cmd = new SqlCommand("SP_Delete", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            conectar.Open();

            cmd.Parameters.AddWithValue("@ID", e_Agenda.ID);

            cmd.ExecuteNonQuery();
            conectar.Close();
        }

    }
}
