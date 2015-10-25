using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace SistVotoElectronico {

    class AccesoDatos
    {



        public OleDbConnection conexion;
        public OleDbCommand comando;
        public OleDbDataReader lector;
        public string cadenaConexion;

        public OleDbDataReader pLector
        {
            set { lector = value; }
            get { return lector; }
        }

        public string pCadenaConexion
        {
            set { cadenaConexion = value; }
            get { return cadenaConexion; }
        }

        public AccesoDatos(string cadenaConexion)
        {
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
        }

        //metodo conectar db
        public void conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
//            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Integrador\\GIT\\SistVotoElectronico\\VotoElectronico.mdb");
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Tecnicatura Programacion\\GIT\\SistVotoElectronico\\VotoElectronico.mdb");

        }

        //metodo desconectar db
        public void desconectar()
        {
            conexion.Close();
        }

        ////metodo leer tabla Select *
        //public void leerTabla(string tabla)
        //{
        //    conectar();
        //    comando.CommandText = "SELECT * FROM" + tabla;
        //    lector = comando.ExecuteReader();
        //}

        //metodo consultar tabla
        
        public DataTable consultarTabla(string tabla)
        
        {
            DataTable dt = new DataTable();
            conectar();
            comando.CommandText = "SELECT * FROM " + tabla;
            dt.Load(comando.ExecuteReader());
            desconectar();

            return dt;
        
        }



    }

}

