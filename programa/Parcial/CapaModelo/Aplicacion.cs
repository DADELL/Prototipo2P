using System;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Aplicacion
    {
        //Funcion para insertar------------
        Conexion cn = new Conexion();

        public void insertarAplicacion(String nombre, String informe)
        {


            //cadena a insertar
            string cadena = "INSERT INTO APLICACION (nombre_aplicacion, informe_aplicacion) VALUES('" + nombre + "','" + informe + "');";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();



        }
    }
}
