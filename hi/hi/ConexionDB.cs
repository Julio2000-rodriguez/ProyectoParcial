using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Torres_Anibal_Parcial
{
    class ConexionDB
    {
        SqlConnection Conexion = new SqlConnection();
        SqlCommand comandosSQL = new SqlCommand();
        SqlDataAdapter miAdaptadorDatos = new SqlDataAdapter();

        DataSet bs = new DataSet();

        public ConexionDB()
        {
            string cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_sistema_peliculas.mdf;Integrated Security=True";
            Conexion.ConnectionString = cadena;
            Conexion.Open();
        }
        public DataSet Obtener_datos()
        {
            bs.Clear();
            comandosSQL.Connection = Conexion;

            comandosSQL.CommandText = "select * from clientes";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(bs, "clientes");

            comandosSQL.CommandText = "select * from peliculas";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(bs,"peliculas");

            comandosSQL.CommandText = "select * from alquiler";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(bs, "alquiler");

            comandosSQL.CommandText = "select clientes.nombre, alquiler.Idalquiler, alquiler.fechaprestamo,  alquiler.fechadevolucion,  alquiler.valor from alquiler inner join clientes on(clientes.idcliente=alquiler.idcliente)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(bs, "alquiler_clientes");

            comandosSQL.CommandText = "select peliculas.descripcion, alquiler.Idalquiler, alquiler.fechaprestamo,  alquiler.fechadevolucion,  alquiler.valor from alquiler inner join peliculas on(peliculas.idpelicula=alquiler.idpelicula)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(bs, "alquiler_peliculas");

            return bs;
        }

        public void movimiento_clientes(string[] datos , string accion)
        {
            string sql = "";
            if (accion == "Nuevo")
            {
                sql = "INSERT INTO clientes(nombre,direccion,telefono,dui) values (" +
                    "'"+ datos[1]+"',"+
                    "'"+ datos[2]+"',"+
                    "'"+ datos[3]+"',"+
                    "'"+ datos[4]+"'" +
                    ")";
            }
            else if (accion == "Modificar")
            {
                sql = "UPDATE clientes SET " +
                    "nombre ='"             + datos[1] + "'," +
                    "direccion='"           + datos[2] + "'," +
                    "telefono='"            + datos[3] + "'," +
                    "dui='"                 + datos[4] + "'" +
                    "where idcliente ='"    + datos[0] + "'";
            }
            else if (accion== "Eliminar")
            {
                sql = "DELETE clientes FROM clientes WHERE idcliente='" + datos[0] + "'";
            } 
            procesarSQL(sql);
        }

        public void movimiento_peliculas(string[] datos, string accion)
        {
            string sql = "";
            if (accion == "Nuevo")
            {
                sql = "INSERT INTO peliculas(descripcion,sinopsis,genero,duracion) values (" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'" +
                    ")";
            }
            else if (accion == "Modificar")
            {
                sql = "UPDATE peliculas SET " +
                    "descripcion ='" + datos[1] + "'," +
                    "sinopsis='" + datos[2] + "'," +
                    "genero='" + datos[3] + "'," +
                    "duracion='" + datos[4] + "'" +
                    "where idpelicula ='" + datos[0] + "'";
            }
            else if (accion == "Eliminar")
            {
                sql = "DELETE peliculas FROM peliculas WHERE idpelicula='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }
        public void movimiento_alquiler(string[] datos, string accion)
        {
            string sql = "";
            if (accion == "Nuevo")
            {
                sql = "INSERT INTO alquiler(idcliente,idpelicula,fechaprestamo,fechadevolucion,valor) values (" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'" +
                    ")";
            }
            else if (accion == "Modificar")
            {
                sql = "UPDATE alquiler SET " +
                    "idcliente ='" + datos[1] + "'," +
                    "idpelicula='" + datos[2] + "'," +
                    "fechaprestamo='" + datos[3] + "'," +
                    "fechadevolucion='" + datos[4] + "'," +
                    "valor='" + datos[5] + "'" +
                    "where Idalquiler ='" + datos[0] + "'";
            }
            else if (accion == "Eliminar")
            {
                sql = "DELETE alquiler FROM alquiler WHERE Idalquiler='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }
        void procesarSQL(string sql)
        {
            comandosSQL.Connection = Conexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();
        }
    }

}
