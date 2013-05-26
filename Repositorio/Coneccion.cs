using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;

using MySql.Data.MySqlClient;
namespace Repositorio
{
    public class coneccion
    {
        internal IDbConnection crear()
        {

            try
            {
                string TipoBase = archivos.nombremotorbase();
                if (TipoBase == "Mysql")
                {
                    MySqlConnection con = new MySqlConnection();
                    
                    con.ConnectionString = archivos.stringdeconeccionmysql();
                    con.Open();
                    return con;
                }
                else
                {
                    if (TipoBase == "sql")
                    {
                        SqlConnection con = new SqlConnection();
                        
                        con.ConnectionString = archivos.stringdeconeccionsql();
                        con.Open();
                        return con;

                    }
                    else
                    {
                        System.Data.Odbc.OdbcConnection con = new System.Data.Odbc.OdbcConnection();
                        
                        con.ConnectionString = archivos.stringdeconeccionodbc();
                        con.Open();
                        return con;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        internal DataTable TraerDataTable(string odbc, IDbConnection con)
        {
            string TipoBase = archivos.nombremotorbase();
            if (TipoBase == "Mysql")
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = odbc;
                comando.Connection = con as MySqlConnection;
                MySqlDataReader reader = comando.ExecuteReader();
                DataTable Tabla = new DataTable();
                Tabla.Load(reader);
                return Tabla;
            }
            else
            {
                if (TipoBase == "sql")
                {
                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = odbc;
                    comando.Connection = con as SqlConnection;
                    SqlDataReader reader = comando.ExecuteReader();
                    DataTable Tabla = new DataTable();
                    Tabla.Load(reader);
                    return Tabla;
                }
                else
                {
                    System.Data.Odbc.OdbcCommand comando = new System.Data.Odbc.OdbcCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = odbc;
                    comando.Connection = con as System.Data.Odbc.OdbcConnection;
                    System.Data.Odbc.OdbcDataReader reader = comando.ExecuteReader();
                    DataTable Tabla = new DataTable();
                    Tabla.Load(reader);
                    return Tabla;
                }
            }

        }
        internal DataTable TraerDataTableSp(string nombre, IDbConnection con, params System.Object[] parametros)
        {
            string TipoBase = archivos.nombremotorbase();
            if (TipoBase == "Mysql")
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = nombre;
                comando.Connection = con as MySqlConnection;
                MySqlCommandBuilder.DeriveParameters(comando);
                
                int limite = comando.Parameters.Count;
                try
                {
                    for (int i = 0; i < limite; i++)
                    {
                        comando.Parameters[i].Value = parametros[i];
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }


                DataTable Tabla = new DataTable();
                Tabla.Load(comando.ExecuteReader());
                return Tabla;
            }
            else
            {
                if (TipoBase == "sql")
                {
                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = nombre;
                    comando.Connection = con as SqlConnection;
                    SqlCommandBuilder.DeriveParameters(comando);

                    int limite = comando.Parameters.Count;
                    try
                    {
                        for (int i = 1; i < limite; i++)
                        {
                            comando.Parameters[i].Value = parametros[i - 1];
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }


                    DataTable Tabla = new DataTable();
                    Tabla.Load(comando.ExecuteReader());
                    return Tabla;
                }
                else
                {
                    System.Data.Odbc.OdbcCommand comando = new System.Data.Odbc.OdbcCommand();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = nombre;
                    comando.Connection = con as System.Data.Odbc.OdbcConnection;
                    System.Data.Odbc.OdbcCommandBuilder.DeriveParameters(comando);
                    int limite = comando.Parameters.Count;
                    try
                    {
                        for (int i = 1; i < limite; i++)
                        {
                            comando.Parameters[i].Value = parametros[i - 1];
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    DataTable Tabla = new DataTable();
                    Tabla.Load(comando.ExecuteReader());
                    return Tabla;
                }
            }

        }
        internal void ejec_afectando_filasSp(string nombre, IDbConnection con, params System.Object[] parametros)
        {
            string TipoBase = archivos.nombremotorbase();
            if (TipoBase == "Mysql")
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = nombre;
                comando.Connection = con as MySqlConnection;
                MySqlCommandBuilder.DeriveParameters(comando);

                int limite = comando.Parameters.Count;
                try
                {
                    for (int i = 0; i < limite; i++)
                    {
                        comando.Parameters[i].Value = parametros[i];
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                comando.ExecuteNonQuery();

        
            }
            else
            {
                if (TipoBase == "sql")
                {
                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = nombre;
                    comando.Connection = con as SqlConnection;
                    SqlCommandBuilder.DeriveParameters(comando);

                    int limite = comando.Parameters.Count;
                    try
                    {
                        for (int i = 1; i < limite; i++)
                        {
                            comando.Parameters[i].Value = parametros[i - 1];
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }



                    comando.ExecuteNonQuery();
                    
                }
                else
                {
                    System.Data.Odbc.OdbcCommand comando = new System.Data.Odbc.OdbcCommand();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = nombre;
                    comando.Connection = con as System.Data.Odbc.OdbcConnection;
                    System.Data.Odbc.OdbcCommandBuilder.DeriveParameters(comando);
                    int limite = comando.Parameters.Count;
                    try
                    {
                        for (int i = 1; i < limite; i++)
                        {
                            comando.Parameters[i].Value = parametros[i - 1];
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    comando.ExecuteNonQuery();
                }
            }

        }
        internal object TraerValorSp(string nombre, IDbConnection con, params System.Object[] parametros)
        {
            string TipoBase = archivos.nombremotorbase();
            if (TipoBase == "Mysql")
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = nombre;
                comando.Connection = con as MySqlConnection;
                MySqlCommandBuilder.DeriveParameters(comando);

                int limite = comando.Parameters.Count;
                try
                {
                    for (int i = 0; i < limite; i++)
                    {
                        comando.Parameters[i].Value = parametros[i];
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return comando.ExecuteScalar();


            }
            else
            {
                if (TipoBase == "sql")
                {
                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = nombre;
                    comando.Connection = con as SqlConnection;
                    SqlCommandBuilder.DeriveParameters(comando);

                    int limite = comando.Parameters.Count;
                    try
                    {
                        for (int i = 1; i < limite; i++)
                        {
                            comando.Parameters[i].Value = parametros[i - 1];
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }



                    return comando.ExecuteScalar();

                }
                else
                {
                    System.Data.Odbc.OdbcCommand comando = new System.Data.Odbc.OdbcCommand();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = nombre;
                    comando.Connection = con as System.Data.Odbc.OdbcConnection;
                    System.Data.Odbc.OdbcCommandBuilder.DeriveParameters(comando);
                    int limite = comando.Parameters.Count;
                    try
                    {
                        for (int i = 1; i < limite; i++)
                        {
                            comando.Parameters[i].Value = parametros[i - 1];
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    return comando.ExecuteScalar();
                }
            }

        }
        internal object TraerValor(string odbc, IDbConnection con)
        {
            string TipoBase = archivos.nombremotorbase();
            if (TipoBase == "Mysql")
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = odbc;
                comando.Connection = con as MySqlConnection;
                return comando.ExecuteScalar();

            }
            else
            {
                if (TipoBase == "sql")
                {
                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = odbc;
                    comando.Connection = con as SqlConnection;
                    return comando.ExecuteScalar();

                }
                else
                {
                    System.Data.Odbc.OdbcCommand comando = new System.Data.Odbc.OdbcCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = odbc;
                    comando.Connection = con as System.Data.Odbc.OdbcConnection;
                    return comando.ExecuteScalar();
                }
            }

        }
        internal void ejec_afectando_filas(string odbc, IDbConnection con)
        {
            string TipoBase = archivos.nombremotorbase();
            if (TipoBase == "Mysql")
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = odbc;
                comando.Connection = con as MySqlConnection;
                comando.ExecuteNonQuery();

            }
            else
            {
                if (TipoBase == "sql")
                {
                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = odbc;
                    comando.Connection = con as SqlConnection;
                    comando.ExecuteNonQuery();

                }
                else
                {
                    System.Data.Odbc.OdbcCommand comando = new System.Data.Odbc.OdbcCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = odbc;
                    comando.Connection = con as System.Data.Odbc.OdbcConnection;
                    comando.ExecuteNonQuery();
                }
            }

        }
        internal void cerrar(IDbConnection con)
        {
            con.Close();
        }
    }
}