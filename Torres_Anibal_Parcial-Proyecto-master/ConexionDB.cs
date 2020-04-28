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
        SqlConnection miConexion = new SqlConnection();
        SqlCommand comandosSQL = new SqlCommand();
        SqlDataAdapter miAdaptadorDatos = new SqlDataAdapter();

        DataSet ds = new DataSet();

        public ConexionDB()
        {
            String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SistemaDB.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadena;
            miConexion.Open();
        }
        public DataSet Obtener_datos()
        {
            ds.Clear();
            comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select * from usuarios";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "usuarios");

            comandosSQL.CommandText = "select * from empleados";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "empleados");

            comandosSQL.CommandText = "select * from proveedores";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "proveedores");

            comandosSQL.CommandText = "select * from productos";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "productos");

            comandosSQL.CommandText = "select * from categorias";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "categorias");

            comandosSQL.CommandText = "select * from Ventas";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Ventas");

            return ds;
        }
        public void Mantenimiento_usuarios(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "Nuevo")
            {
                sql = "INSERT INTO usuarios (codigo,nombre,apellido,direccion,dui,telefono) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'," +
                    "'" + datos[6] + "'"  +
                    ")";
            }
            else if (accion == "Modificar")
            {
                sql = "UPDATE usuarios SET " +
                    "codigo          = '" + datos[1] + "'," +
                    "nombre          = '" + datos[2] + "'," +
                    "apellido        = '" + datos[3] + "'," +
                    "direccion       = '" + datos[4] + "'," +
                    "dui             = '" + datos[5] + "'," +
                    "telefono        = '" + datos[6] + "' " +
                    "WHERE idusuario = '" + datos[0] + "'";
            }
            else if (accion == "Eliminar")
            {
                sql = "DELETE usuarios FROM usuarios WHERE idusuario='" + datos[0] + "'";
            }
            ProcesarSQL(sql);
        }
        public void Mantenimiento_empleados(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "Nuevo")
            {
                    sql = "INSERT INTO empleados (codigo,nombre,apellido,direccion,dui,telefono,salario) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'," +
                    "'" + datos[6] + "'," +
                    "'" + datos[7] + "'" +
                    ")";
            }
            else if (accion == "Modificar")
            {
                sql = "UPDATE empleados SET " +
                    "codigo          = '" + datos[1] + "'," +
                    "nombre          = '" + datos[2] + "'," +
                    "apellido        = '" + datos[3] + "'," +
                    "direccion       = '" + datos[4] + "'," +
                    "dui             = '" + datos[5] + "'," +
                    "telefono        = '" + datos[6] + "'," +
                    "salario         = '" + datos[6] + "' " +
                    "WHERE idempleado='"  + datos[0] + "'";
            }
            else if (accion == "Eliminar")
            {
                sql = "DELETE empleados FROM empleados WHERE idempleado='" + datos[0] + "'";
            }
            ProcesarSQL(sql);
        }
        public void Mantenimiento_proveedores(string[] datos, string accion)
        {
            string sql = "";
            if (accion == "Nuevo")
            {
                sql = "insert into proveedores(codigo,nombrep,nombrec,cargoc,direccion,telefono,email) values(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'," +
                    "'" + datos[6] + "'," +
                    "'" + datos[7] + "'"  +
                    ")";
            }
            else if (accion == "Modificar")
            {
                sql = "update proveedores set  " +
                    "codigo =                   '" + datos[1] + "'," +
                    "nombrep =         '" + datos[2] + "'," +
                    "nombrec =          '" + datos[3] + "'," +
                    "cargoc=            '" + datos[4] + "'," +
                    "direccion=                 '" + datos[5] + "'," +
                    "telefono=                  '" + datos[6] + "'," +
                    "email=                     '" + datos[7] + "'" +
                    "where idproveedor =        '" + datos[0] + "'";
            }
            else if (accion == "Eliminar")
            {
                sql = "delete proveedores from proveedores where idproveedor='" + datos[0] + "'";
            }
            ProcesarSQL(sql);
        }
        public void Mantenimiento_productos_categorias(string[] datos, string accion)
        {
            string sql = "";
            if (accion=="Nuevo")
            {
                sql = "insert into productos(idcategoria,codigo,nombre,descripcion,precio) values(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'" +
                    ")";
            }
            else if (accion=="Modificar")
            {
                sql = "update productos set  " +
                   "idcategoria =        '" + datos[1] + "'," +
                   "codigo =             '" + datos[2] + "'," +
                   "nombre=             '" + datos[3] + "'," +
                   "descripcion=         '" + datos[4] + "'," +
                   "precio=              '" + datos[5] + "'"  +
                   "where idproducto =   '" + datos[0] + "'";
            }
            else
            {
                sql = "delete productos from productos where idproducto='" + datos[0] + "'";

            }ProcesarSQL(sql);
        }

        public void mantenimiento_ventas(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "Nuevo")
            {
                sql = "INSERT INTO Ventas (codigo,nombre,descripcion,precio,nombrec,telefono) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'," +
                    "'" + datos[6] + "'" +
                    ")";
            }
            else if (accion == "Modificar")
            {
                sql = "UPDATE Ventas SET " +
                    "codigo         = '" + datos[1] + "'," +
                    "nombre         = '" + datos[2] + "'," +
                    "descripcion      = '" + datos[3] + "'," +
                    "precio            = '" + datos[4] + "'," +
                    "nombrec          = '" + datos[5] + "'," +
                    "telefono            = '" + datos[6] + "'" +
                    "WHERE IdVentas = '" + datos[0] + "'";
            }
            else if (accion == "Eliminar")
            {
                sql = "DELETE Ventas FROM Ventas WHERE IdVentas='" + datos[0] + "'";
            }

            ProcesarSQL(sql);
        }

        void ProcesarSQL(String sql)
        {
            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();
        }
    }
}       