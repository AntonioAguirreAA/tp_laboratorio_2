using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace BaseDeDatos
{
    public class ADO
    {
        private static string conexion = @"Server=localhost;Database=TP4Aguirre;Trusted_Connection=True;";
        private static SqlConnection connection;
        private static SqlCommand command;

        public static List<Dispositivo> GetAllDocumentos()
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM dbo.Dispositivos", connection))
                {
                    try
                    {
                        List<Dispositivo> listaDispositivos = new List<Dispositivo>();
                        cmd.CommandType = CommandType.Text;
                        connection.Open();
                        using (SqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                switch (dataReader["TipoDeDocumento"].ToString())
                                {
                                    case "Computadora":
                                        Computadora computadora = new Computadora
                                        {
                                            Id = Convert.ToInt32(dataReader["id"]),
                                            NombreDuenio = dataReader["nombreDuenio"].ToString(),
                                            Observacion = dataReader["observacion"].ToString(),
                                            Precio = Convert.ToInt32(dataReader["precio"]),
                                            Ingreso = Convert.ToDateTime(dataReader["ingreso"]),
                                            ArregloEstimado = Convert.ToDateTime(dataReader["arregloEstimado"]),
                                            ArregloFinalizado = Convert.ToDateTime(dataReader["arregloFinalizado"]),
                                            Estado = (Entidades.Estado)Enum.Parse(typeof(Entidades.Estado), dataReader["estado"].ToString()),
                                        };
                                        listaDispositivos.Add(computadora);
                                        break;
                                    case "Celular":
                                        Celular celular = new Celular
                                        {
                                            Id = Convert.ToInt32(dataReader["id"]),
                                            NombreDuenio = dataReader["nombreDuenio"].ToString(),
                                            Observacion = dataReader["observacion"].ToString(),
                                            Precio = Convert.ToInt32(dataReader["precio"]),
                                            Ingreso = Convert.ToDateTime(dataReader["ingreso"]),
                                            ArregloEstimado = Convert.ToDateTime(dataReader["arregloEstimado"]),
                                            ArregloFinalizado = Convert.ToDateTime(dataReader["arregloFinalizado"]),
                                            Estado = (Entidades.Estado)Enum.Parse(typeof(Entidades.Estado), dataReader["estado"].ToString()),
                                            Marca = (Entidades.Marca)Enum.Parse(typeof(Entidades.Marca), dataReader["marca"].ToString()),
                                        };
                                        listaDispositivos.Add(celular);
                                        break;
                                }
                            }
                        }
                        return listaDispositivos;
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }
    }
}
