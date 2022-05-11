using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using Aspose.Pdf;
using System.IO;
using Aspose.Pdf.Text;

namespace MAD
{
    public class Conexion
    {
        static string cadena = "server=DESKTOP-J8HH1QA\\SQLSERVER;database=MAD;integrated security=true";
        public SqlConnection conexion = new SqlConnection(cadena);
        public DataSet ds;
        string verificacionUsuario;
        string verificaionPassword;
        string rolUsuarioVerificacion;
        public Conexion()
        {
            conexion.ConnectionString = cadena;
        }

#region Empleados


        public DataTable MostrarDatosAllEmpleados() //Muestra Los empleados en el Menu de Alta Empleados
        {
            abrir();
            string querie = "Select Empleados.CURP,Empleados.RFC,Usuarios.Usuario,Usuarios.rolUsuario from Empleados inner join Usuarios on Usuarios.CURP = Empleados.CURP  ;";
            SqlCommand cmd = new SqlCommand(querie, conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            ad.Fill(table);
            cerrar();
            return table;
        }
        public DataTable InsertarNuevoEmpleado(string Nombre, string CURP, string RFC, string User, string Pass,DateTime dateTime,DateTime rightNow)//Inserta un nuevo empleado 
        {
            // Se cambia a Char pues al momento de mandar la informacion en la base de datos en SQL estan las variables en varchar
            abrir();
            int lenght = RFC.Length;
            char[] rfc = RFC.ToCharArray(0, lenght);
            lenght = CURP.Length;
            char[] curp = CURP.ToCharArray(0, lenght);
            lenght = User.Length;
            char[] usuario = User.ToCharArray(0, lenght);
            lenght = Pass.Length;
            char[] password = Pass.ToCharArray(0, lenght);
            lenght = Nombre.Length;
            char[] nombre = Nombre.ToCharArray(0, lenght);
            char[] roldeUsuario = { 'E', 'm', 'p', 'l', 'e', 'a', 'd', 'o' };
            string querie = "Insert into Empleados (RFC,CURP) VALUES (@rfc,@CURP)";
            SqlCommand command = new SqlCommand(querie, conexion);
            command.Parameters.AddWithValue("@rfc", rfc);
            command.Parameters.AddWithValue("@CURP", curp);
            command.ExecuteNonQuery();
            querie = "Insert into Usuarios (Usuario,pass,rolUsuario,CURP) VALUES(@Usuario,@pass,@rolUsuario,@CURP)";
            command = new SqlCommand(querie, conexion);
            command.Parameters.AddWithValue("@Usuario", usuario);
            command.Parameters.AddWithValue("@pass", password);
            command.Parameters.AddWithValue("@rolUsuario", roldeUsuario);
            command.Parameters.AddWithValue("@CURP", curp);
            command.ExecuteNonQuery();
            querie = "Insert into InfoEmpleados (Usuario,nombreEmpleado,fechaNacimiento,fechaCreacion) values (@Usuario,@nombreEmpleado,@fechaNacimiento,@fechaCreacion)";
            command = new SqlCommand(querie, conexion);
            command.Parameters.AddWithValue("@Usuario", usuario);
            command.Parameters.AddWithValue("@nombreEmpleado", nombre);
            command.Parameters.AddWithValue("@fechaNacimiento", dateTime);
            command.Parameters.AddWithValue("@fechaCreacion", rightNow);
            command.ExecuteNonQuery();
            cerrar();
            return null;
        }

        public List<string> ObtenerInfoEmpleado(string curp)//Esta funcion obtiene el curp del Empleado  a traves del DTG(DataGridView), y hace su busqueda para conseguir la informacion
        {
            abrir();
            int lenght = curp.Length;
            char[] vs = curp.ToCharArray(0, lenght);
            string querie = "Select Empleados.CURP,Empleados.RFC,Usuarios.Usuario,Usuarios.Pass,InfoEmpleados.nombreEmpleado,InfoEmpleados.fechaNacimiento from Empleados inner join Usuarios " +
            "on Usuarios.CURP = Empleados.CURP and Empleados.CURP like @curp inner join InfoEmpleados on Usuarios.Usuario=InfoEmpleados.Usuario";
            SqlCommand cmd = new SqlCommand(querie, conexion);
            cmd.Parameters.AddWithValue("@curp", vs);
            SqlDataReader tabla = cmd.ExecuteReader();
            //cmd.ExecuteNonQuery();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            tabla.Dispose();//Esta funcion Sirve para dejar de usar la tabla para que pueda pasarse la informacion 
            ad.Fill(table);
            List<string> dataTabla = new List<string>();//Aqui es donde se pasara la informacionq que se obtiene del querie xd
            foreach (DataRow dataRow in table.Rows)
            {
                dataTabla.Add(dataRow["CURP"].ToString());//Si pones el dato que estas buscando te lo pone y almacena en orden que lo vayas poniendo 
                dataTabla.Add(dataRow["RFC"].ToString());
                dataTabla.Add(dataRow["Usuario"].ToString());
                dataTabla.Add(dataRow["Pass"].ToString());
                dataTabla.Add(dataRow["nombreEmpleado"].ToString());
                dataTabla.Add(dataRow["fechaNacimiento"].ToString());
            }
            cerrar();

            return dataTabla;//La funcion es de tipo List<string> por que sencillamente no supe como sacar los strings uno por uno 
        }
                    
        public bool VerificarEmpleado(string Nombre, string CURP,string RFC,string Usuario)//Verifica si el empleado que se va a registrar ya existe
        {
            abrir();
            int lenght = RFC.Length;
            char[] rfc = RFC.ToCharArray(0, lenght);
            lenght = CURP.Length;
            char[] curp = CURP.ToCharArray(0, lenght);
            //string querie = "Select * from Empleados where CURP like '"+curp+"' and RFC like '"+rfc+"'";
            string querie = "Select Empleados.RFC, Empleados.CURP, Usuarios.Usuario from Empleados inner join Usuarios" +
                " on Empleados.CURP = @CURP and Empleados.RFC = @RFC and Usuarios.Usuario = @Usuario and Usuarios.CURP = @CURP" ;
            SqlCommand command = new SqlCommand(querie,conexion);
            command.Parameters.AddWithValue("@CURP", CURP);
            command.Parameters.AddWithValue("@RFC", RFC);
            command.Parameters.AddWithValue("@Usuario", Usuario);
            SqlDataReader tabla = command.ExecuteReader();
            if (tabla.Read())
            {
                cerrar();
                return false;
            }
            else {
                cerrar();
                return true;
            }

            //int flag = command.ExecuteNonQuery();//1= Si se elimino =0 No pudo o no se encontro
            //if (flag==1)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

        }

        public bool verificaInformacionUpdte(string CURP,string Usuario,string Nombre,string RFC,string password,DateTime dateTime)//Verifica si la informacion que vamos a updatear que existe
        {
            abrir();
            int lenght = Nombre.Length;
            char[] nombre = Nombre.ToCharArray(0, lenght);
            lenght = RFC.Length;
            char[] rfc = RFC.ToCharArray(0, lenght);
            lenght = password.Length;
            char[] pass = password.ToCharArray(0, lenght);
            lenght = CURP.Length;
            char[] curp = CURP.ToCharArray(0, lenght);
            lenght = Usuario.Length;
            char[] user = Usuario.ToCharArray(0, lenght);
            string query = "Select Empleados.CURP,InfoEmpleados.Usuario,Usuarios.Usuario from Empleados  inner join  InfoEmpleados on Empleados.CURP like @curp   inner Join Usuarios on Usuarios.CURP like @curp";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@curp", curp);
            SqlDataReader tabla = command.ExecuteReader();
            if (tabla.Read())//Nos dice si obtuvimos la informacion del Empleado
            {
                cerrar();
                return true;
            }
            else
            {
                cerrar();
                return false;
            }
        }

        public DataTable UpdateInformacionEmpleado(string Nombre,string password, string RFC,DateTime Nacimiento,string CURP,string Usuario)

        {
            abrir();
            int lenght = Nombre.Length;
            char[] nombre = Nombre.ToCharArray(0, lenght);
            lenght = password.Length;
            char[] pass = password.ToCharArray(0, lenght);
            lenght = RFC.Length;
            char[] rfc = RFC.ToCharArray(0, lenght);
            lenght = CURP.Length;
            char[] curp = CURP.ToCharArray(0, lenght);
            lenght = Usuario.Length;
            char[] usuario = Usuario.ToCharArray(0, lenght);

            string query = "Update Empleados Set RFC=@rfc where CURP=@curp";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@rfc", rfc);
            command.Parameters.AddWithValue("@curp", curp);
            command.ExecuteNonQuery();
            query = "Update Usuarios Set pass=@pass where Usuario=@Usuario";
            command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@pass", pass);
            command.Parameters.AddWithValue("@Usuario", usuario);
            command.ExecuteNonQuery();
            query = "Update InfoEmpleados Set nombreEmpleado=@nombre, fechaNacimiento=@nacimiento where Usuario like @usuario2";
            command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@nacimiento", Nacimiento);
            command.Parameters.AddWithValue("@usuario2", usuario);
            command.ExecuteNonQuery();
            cerrar();
            return null;

        }

        public bool borrarEmpleado(string CURP)//Borras el empleado
        {
            int lenght = CURP.Length;
            char[] curp = CURP.ToCharArray(0, lenght);
            abrir();
            string query = "Select Usuarios.Usuario from Usuarios where CURP like @CURP";//Selecciona el nombre de usuario para borrar todas las tablas relacionados con El empleado
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@CURP", curp);
            SqlDataReader tabla = command.ExecuteReader();
            SqlDataAdapter ad = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            tabla.Dispose();
            ad.Fill(table);
            List<string> informacion = new List<string>();
            string Usuario = null;
            foreach (DataRow dataRow in table.Rows)
            {
                informacion.Add(dataRow["Usuario"].ToString());
                Usuario = dataRow["Usuario"].ToString();
            }
            lenght = Usuario.Length;
            char[] user = Usuario.ToCharArray(0, lenght);
            string querie = "Delete from InfoEmpleados where Usuario like @Usuario";//Ahora se borran las tablas con el nombre del USUARIO y CURP
            SqlCommand cmd = new SqlCommand(querie, conexion);
            cmd.Parameters.AddWithValue("@Usuario", user);
            cmd.ExecuteNonQuery();
            querie = "Delete Usuarios where CURP like @CURP";
            SqlCommand sqlCommand = new SqlCommand(querie, conexion);
            sqlCommand.Parameters.AddWithValue("@CURP", curp);
            sqlCommand.ExecuteNonQuery();
            querie = "Delete from Empleados where CURP like @CURP";
            sqlCommand = new SqlCommand(querie, conexion);
            sqlCommand.Parameters.AddWithValue("@CURP", curp);
            sqlCommand.ExecuteNonQuery();
            cerrar();
            return true;
        }

        public bool inicioSesionEmpleado(string Usuario, string Password)
        {
            abrir();
            int length = Usuario.Length;
            char[] user = Usuario.ToCharArray(0, length);
            length = Password.Length;
            char[] password = Usuario.ToCharArray(0, length);
            string query = "Select Usuarios.Usuario,Usuarios.pass,Usuarios.rolUsuario from Usuarios where Usuarios.Usuario =@Usuario and Usuarios.pass=@pass";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@Usuario", Usuario);
            command.Parameters.AddWithValue("@pass", Password);
            SqlDataReader infoUsuario = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            if (infoUsuario.Read() == true)
            {
                List<string> dataTable = new List<string>();
                dataTable.Add(infoUsuario.GetString(1));
                infoUsuario.Dispose();
                adapter.Fill(table);
                string rolUsuario = "Empleado";
                foreach(DataRow dataRow in table.Rows)
                {
                    verificacionUsuario = dataRow["Usuario"].ToString();
                    verificaionPassword = dataRow["pass"].ToString();
                    rolUsuarioVerificacion = dataRow["rolUsuario"].ToString();
                    dataTable.Add(dataRow["Usuario"].ToString());
                    dataTable.Add(dataRow["Pass"].ToString());
                    dataTable.Add(dataRow["rolUsuario"].ToString());

                }
                if (verificacionUsuario == Usuario)
                {
                    if (verificaionPassword == Password)
                    {
                        if (rolUsuarioVerificacion == rolUsuario)
                        {
                            cerrar();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;

                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                cerrar();
                return false;
            }
              
        }

        #endregion Empleado

        #region Clientes

        public bool inicioSesionClientes(string Usuario,string Password)
        {
            abrir();
            int length = Usuario.Length;
            char[] user = Usuario.ToCharArray(0, length);
            length = Password.Length;
            char[] password = Usuario.ToCharArray(0, length);
            string query = "Select Usuarios.Usuario,Usuarios.pass,Usuarios.rolUsuario from Usuarios where Usuario=@Usuario and pass=@pass";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@Usuario", Usuario);
            command.Parameters.AddWithValue("@pass", Password);
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            if (reader.Read() == true)
            {
                reader.Dispose();
                adapter.Fill(table);
                string rolUsuario = "Cliente";
                foreach (DataRow dataRow in table.Rows)
                {
                    verificacionUsuario = dataRow["Usuario"].ToString();
                    verificaionPassword = dataRow["pass"].ToString();
                    rolUsuarioVerificacion = dataRow["rolUsuario"].ToString();
                }
                if (verificacionUsuario==Usuario)
                {
                    if (verificaionPassword == Password)
                    {
                        if (rolUsuarioVerificacion == rolUsuario) 
                        {
                            cerrar();
                            return true;
                        }
                        else
                        {
                            cerrar();
                            return false;
                        }
                    }
                    else
                    {
                        cerrar();
                        return false;
                    }
                }
                else
                {
                    cerrar();
                    return false;
                }
            }
            else
            {
                cerrar();
                return false;
            }
        }

        public DataTable MostrarDatosAllClientes()
        {
            abrir();
            string rolUsuario = "Cliente";
            string query = "  Select Clientes.CURP,Usuarios.Usuario,Usuarios.rolUsuario from Clientes inner join Usuarios on Usuarios.CURP =  Clientes.CURP and Usuarios.rolUsuario='Cliente'";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cerrar();
            return table;
        }

        public bool verificarCliente(string CURP,string Password,string Usuario)
        {
            abrir();
            int lenght = CURP.Length;
            char[] curp = CURP.ToCharArray(0, lenght);
            lenght = Password.Length;
            char[] password = Password.ToCharArray(0, lenght);
            lenght = Usuario.Length;
            char[] user = Usuario.ToCharArray(0, lenght);
            string query = "Select Clientes.CURP,InfoCliente.sexo,InfoCliente.numCasa,InfoCliente.colonia,InfoCliente.calle,Usuarios.Usuario from Clientes" +
                " inner join InfoCliente on InfoCliente.CURP=Clientes.CURP and Clientes.CURP=@CURP inner join Usuarios on Usuarios.pass=@pass and Usuarios.Usuario=@Usuario ";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@CURP", curp);
            command.Parameters.AddWithValue("@pass", password);
            command.Parameters.AddWithValue("@Usuario", user);
            SqlDataReader tabla = command.ExecuteReader();
            if (tabla.Read())
            {
                cerrar();
                return false;
            }
            else
            {
                cerrar();
                return true;
            }
        }

        public DataTable InsertarNuevoCliente(string Nombre,string CURP,string Email,string Password,string Colonia,string Calle,string numeroCasa,DateTime nacimiento,DateTime rightNow,string Sexo)
        {
            abrir();
            int lenght = Nombre.Length;
            char[] nombre = Nombre.ToCharArray(0, lenght);
            lenght = CURP.Length;
            char[] curp = CURP.ToCharArray(0, lenght);
            lenght = Password.Length;
            char[] pass = Password.ToCharArray(0, lenght);
            lenght = Email.Length;
            char[] usuario = Email.ToCharArray(0, lenght);
            lenght = Colonia.Length;
            char[] colonia = Colonia.ToCharArray(0, lenght);
            lenght = Calle.Length;
            char[] calle = Calle.ToCharArray(0, lenght);
            lenght = numeroCasa.Length;
            char[] numcalle = numeroCasa.ToCharArray(0, lenght);
            lenght = Sexo.Length;
            char[] sexo = Sexo.ToCharArray(0, lenght);
            char[] rolUsuario = { 'C', 'l', 'i', 'e', 'n', 't', 'e' };
            string query = "Insert into Clientes (CURP) VALUES(@CURP)";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@CURP", curp);
            command.ExecuteNonQuery();
            query = "Insert into InfoCliente (CURP,nombreCliente,numCasa,colonia,calle,sexo,fechaNacimiento,fechaCreacion) VALUES" +
                "(@CURP,@nombreCliente,@numCasa,@colonia,@calle,@sexo,@fechaNacimiento,@fechaCreacion)";
            command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@CURP", curp);
            command.Parameters.AddWithValue("@nombreCliente", nombre);
            command.Parameters.AddWithValue("@numCasa", numcalle);
            command.Parameters.AddWithValue("@colonia", colonia);
            command.Parameters.AddWithValue("@calle", calle);
            command.Parameters.AddWithValue("@sexo",sexo);
            command.Parameters.AddWithValue("@fechaNacimiento", nacimiento);
            command.Parameters.AddWithValue("@fechaCreacion", rightNow);
            command.ExecuteNonQuery();
            query = "Insert into Usuarios(Usuario,pass,rolUsuario,CURP) VALUES(@Usuario,@pass,@rolUsuario,@CURP)";
            command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@Usuario", usuario);
            command.Parameters.AddWithValue("@pass", pass);
            command.Parameters.AddWithValue("@rolUsuario", rolUsuario);
            command.Parameters.AddWithValue("@CURP", curp);
            command.ExecuteNonQuery();
            cerrar();
            return null;
        }

        public List<string>ObtenerInfoCliente(string CURP)
        {
            abrir();
            int lenght = CURP.Length;
            char[] curp = CURP.ToCharArray(0, lenght);
            string query = " Select InfoCliente.numCasa,InfoCliente.nombreCliente,InfoCliente.colonia,InfoCliente.calle,InfoCliente.sexo,InfoCliente.nombreCliente,InfoCliente.fechaNacimiento,Usuarios.pass from InfoCliente inner join Usuarios on Usuarios.CURP=@CURP and Usuarios.CURP=InfoCliente.CURP ";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@CURP", curp);
            SqlDataReader tabla = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            tabla.Dispose();
            adapter.Fill(table);
            List<string> dataTabla = new List<string>();
            foreach (DataRow dataRow in table.Rows)
            {
                dataTabla.Add(dataRow["numCasa"].ToString());
                dataTabla.Add(dataRow["colonia"].ToString());
                dataTabla.Add(dataRow["calle"].ToString());
                dataTabla.Add(dataRow["sexo"].ToString());
                dataTabla.Add(dataRow["nombreCliente"].ToString());
                dataTabla.Add(dataRow["fechaNacimiento"].ToString());
                dataTabla.Add(dataRow["pass"].ToString());
            }
            cerrar();
            return dataTabla;
        }

        public bool verificacionInformacionUpdate(string CURP)
        {
            abrir();
            int lenght = CURP.Length;
            char[] curp = CURP.ToCharArray(0, lenght);
            string query = " Select Clientes.CURP,Usuarios.CURP,InfoCliente.CURP from Clientes  inner join Usuarios on Usuarios.CURP=Clientes.CURP inner join InfoCliente on InfoCliente.CURP=Clientes.CURP where Clientes.CURP=@CURP";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@CURP", curp);
            SqlDataReader tabla = command.ExecuteReader();
            if (tabla.Read())
            {
                cerrar();
                return true;
            }
            else
            {
                cerrar();
                return false;
            }
        }

        public DataTable UpdateInformacionCliente(string Nombre, string Password,string NumCasa,string Colonia,string Calle,string Sexo,DateTime Nacimiento,string CURP)
        {
            abrir();
            int lenght = Nombre.Length;
            char[] nombre = Nombre.ToCharArray(0, lenght);
            lenght = Password.Length;
            char[] password = Password.ToCharArray(0, lenght);
            lenght = NumCasa.Length;
            char[] numCasa = NumCasa.ToCharArray(0, lenght);
            lenght = Colonia.Length;
            char[] colonia = Colonia.ToCharArray(0, lenght);
            lenght = Calle.Length;
            char[] calle = Calle.ToCharArray(0, lenght);
            lenght = Sexo.Length;
            char[] sexo = Sexo.ToCharArray(0, lenght);
            lenght = CURP.Length;
            char[] curp = CURP.ToCharArray(0, lenght);
            
            string query = "Update InfoCliente Set nombreCliente=@nombreCliente,numCasa=@numCasa,colonia=@colonia,calle=@calle,sexo=@sexo," +
                "fechaNacimiento=@fechaNacimiento where CURP=@CURP";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@nombreCliente", nombre);
            command.Parameters.AddWithValue("@numCasa", numCasa);
            command.Parameters.AddWithValue("@colonia", colonia);
            command.Parameters.AddWithValue("@calle", calle);
            command.Parameters.AddWithValue("@sexo", sexo);
            command.Parameters.AddWithValue("@fechaNacimiento", Nacimiento);
            command.Parameters.AddWithValue("@CURP", curp);
            command.ExecuteNonQuery();
            query = "Update Usuarios Set pass=@pass where CURP=@CURP2";
            command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@pass", password);
            command.Parameters.AddWithValue("@CURP2", curp);
            command.ExecuteNonQuery();
            cerrar();
            return null;
        }
        public bool borrarCliente(string CURP)
        {
            int lenght = CURP.Length;
            char[] curp = CURP.ToCharArray(0, lenght);
            abrir();
            string query = "Delete from Clientes where CURP=@CURP";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@CURP", curp);
            command.ExecuteNonQuery();
            query = "Delete from Usuarios where CURP=@CURP";
            command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@CURP", curp);
            command.ExecuteNonQuery();
            query = "Delete from InfoCliente where CURP=@CURP";
            command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@CURP", curp);
            command.ExecuteNonQuery();
            cerrar();
            return true;

        }

        #endregion Clientes

        #region Contratos



        public DataTable MostrarAllClientesContratos(string CURP)
        {
            abrir();
            string rolUsuario = "Cliente";
            int lenght = CURP.Length;
            char[] rol = CURP.ToCharArray(0, lenght);
            string query = "Select InfoCliente.nombreCliente,InfoCliente.calle,InfoCliente.colonia,InfoCliente.NumCasa,Usuarios.Usuario,InfoCliente.CURP from InfoCliente inner join Usuarios on Usuarios.CURP=InfoCliente.CURP and InfoCliente.CURP=@CURP";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@CURP", rol);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cerrar();
            return table;
        }

        public bool verificarExistenciaCliente(string CURP)
        {
            abrir();
            int lenght = CURP.Length;
            char[] curp = CURP.ToCharArray(0, lenght);
            string query = "Select Clientes.CURP,Usuarios.CURP,InfoCliente.CURP from Clientes inner join Usuarios on Usuarios.CURP=Clientes.CURP inner join InfoCliente on InfoCliente.CURP=Clientes.CURP where Clientes.CURP=@CURP";
            SqlCommand command = new SqlCommand(query,conexion);
            command.Parameters.AddWithValue("@CURP", curp);
            SqlDataReader tabla = command.ExecuteReader();
            if (tabla.Read())
            {
                cerrar();
                return true;
            }
            else
            {
                cerrar();
                return false;
            }
        }
        public List<string> ObtenerInfoClienteContrato(string CURP)
        {
            abrir();
            int lenght = CURP.Length;
            char[] curp = CURP.ToCharArray(0, lenght);
            string query = "Select InfoCliente.nombreCliente,InfoCliente.calle,InfoCliente.colonia,InfoCliente.NumCasa,Usuarios.Usuario,InfoCliente.CURP from InfoCliente inner join Usuarios on Usuarios.CURP=InfoCliente.CURP and InfoCliente.CURP=@CURP";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@CURP", curp);
            SqlDataReader tabla = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            tabla.Dispose();
            adapter.Fill(table);
            List<string> dataTable = new List<string>();
            foreach(DataRow dataRow in table.Rows)
            {
                dataTable.Add(dataRow["nombreCliente"].ToString());
                dataTable.Add(dataRow["calle"].ToString());
                dataTable.Add(dataRow["colonia"].ToString());
                dataTable.Add(dataRow["NumCasa"].ToString());
                dataTable.Add(dataRow["Usuario"].ToString());
                dataTable.Add(dataRow["CURP"].ToString());
            }
            cerrar();
            return dataTable;
        }

        public int ObtenerLastId()
        {
            abrir();
            string query = "Select numeroContrato from contratos";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader tabla = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            tabla.Dispose();
            adapter.Fill(table);
            int numeroFinal = table.Rows.Count;
            cerrar();
            return numeroFinal;
        }

        public bool checkContrato(string direccionCasa, string entreCalles)//Verifica que no haya un contrato en esta direccion y si no lo haya pues pasa
        {
            abrir();
            int lenght = direccionCasa.Length;
            char[] direccion = direccionCasa.ToCharArray(0, lenght);
            lenght = entreCalles.Length;
            char[] calles = entreCalles.ToCharArray(0, lenght);
            string query = " Select * from contratos where direccionCasa=@direccionCasa and entreCalles=@entreCalles";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@direccionCasa", direccion);
            command.Parameters.AddWithValue("@entreCalles", calles);
            SqlDataReader tabla = command.ExecuteReader();
            if (tabla.Read())
            {
                cerrar();
                return false;
            }
            else
            {
                cerrar();
                return true;
            }
                    
        }

        public DataTable InsertarNuevoContrato(DateTime rightNow,string NumeroServicio,int NumeroContrato,string CURPUser,string DireccionCasa,string EntreCalles,string UserEmpleado)
        {
            abrir();
            int lenght = NumeroServicio.Length;
            char[] numeroServicio = NumeroServicio.ToCharArray(0, lenght);
            lenght = UserEmpleado.Length;
            char[] userempleado = UserEmpleado.ToCharArray(0, lenght);
            lenght = CURPUser.Length;
            char[] curpuser = CURPUser.ToCharArray(0, lenght);
            lenght = DireccionCasa.Length;
            char[] direccion = DireccionCasa.ToCharArray(0, lenght);
            lenght = EntreCalles.Length;
            char[] entreCalles = EntreCalles.ToCharArray(0, lenght);
            string query = "Insert into contratos(fechaCreacion,numeroServicio,numeroContrato,UserEmpleado,CURPCliente,direccionCasa,entreCalles)" +
                "VALUES(@fechaCreacion,@numeroServicio,@numeroContrato,@UserEmpleado,@CURPCliente,@direccionCasa,@entreCalles)";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@fechaCreacion", rightNow);
            command.Parameters.AddWithValue("@numeroServicio", numeroServicio);
            command.Parameters.AddWithValue("@numeroContrato", NumeroContrato);
            command.Parameters.AddWithValue("@UserEmpleado", userempleado);
            command.Parameters.AddWithValue("@CURPCliente", curpuser);
            command.Parameters.AddWithValue("@direccionCasa", direccion);
            command.Parameters.AddWithValue("@entreCalles", entreCalles);
            command.ExecuteNonQuery();
            cerrar();
            return null;
        }

        public DataTable MostrarAllContratos(string CURP) {//Te muestra todos los contratos del Usuario Con el CURP
            abrir();
            int lenght = CURP.Length;
            char[] curp = CURP.ToCharArray(0, lenght);
            string query = " Select * from contratos where CURPCliente=@CURPCliente";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@CURPCliente", curp);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cerrar();
            return table;

        }

        public bool verificarContratoEnMostrarContrato(int numeroMedidor)
        {
            abrir();
            string query = "Select * from contratos where numeroMedidor=@numeroMedidor";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@numeroMedidor", numeroMedidor);
            SqlDataReader tabla = command.ExecuteReader();
            if (tabla.Read())
            {
                cerrar();
                return true;
            }
            else
            {
                cerrar();
                return false;
            }
        }

        public List<string> ObtenerInfoContratosMostrar(int numeroMedidor)//Obtiene la informacion que se va a mostrar
        {
            abrir();
            string query = "Select fechaCreacion,numeroServicio,numeroMedidor,numeroContrato,UserEmpleado,CURPCliente,direccionCasa,entreCalles from contratos where numeroMedidor=@numeroMedidor";
            SqlCommand command = new SqlCommand(query,conexion);
            command.Parameters.AddWithValue("@numeroMedidor", numeroMedidor);
            SqlDataReader tabla = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            tabla.Dispose();
            adapter.Fill(table);
            List<string> dataTable = new List<string>();
            foreach(DataRow dataRow in table.Rows)
            {
                dataTable.Add(dataRow["fechaCreacion"].ToString());
                dataTable.Add(dataRow["numeroServicio"].ToString());
                dataTable.Add(dataRow["numeroMedidor"].ToString());
                dataTable.Add(dataRow["numeroContrato"].ToString());
                dataTable.Add(dataRow["UserEmpleado"].ToString());
                dataTable.Add(dataRow["CURPCliente"].ToString());
                dataTable.Add(dataRow["direccionCasa"].ToString());
                dataTable.Add(dataRow["entreCalles"].ToString());

            }
            cerrar();
            return dataTable;
        }

        public bool borrarContrato(int numeroMedidor)
        {
            abrir();
            string query = "Delete from contratos where numeroMedidor=@numeroMedidor";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@numeroMedidor", numeroMedidor);
            command.ExecuteNonQuery();
            cerrar();
            return true;
        }

        #endregion Contratos

        #region Tarifas
        public DataTable MostrarAllTarifas()
        {
            abrir();
            string query = "Select * from tarifa;";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cerrar();
            return table;
        }

        public bool checkTarifa(string nombreTarifa)//Verifica el nombre de la tarida ya existe
        {
            abrir();
            int leght = nombreTarifa.Length;
            char[] tarifa = nombreTarifa.ToCharArray(0, leght);
            string query = "Select * from tarifa where nombreTarifa=@nombreTarifa";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@nombreTarifa",tarifa);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.Read())
            {
                cerrar();
                return false;
            }
            else
            {
                cerrar();
                return true;
            }
        }

        public DataTable InsertarNuevaTarifa(string NombreTarifa,int PrecioBasico,int PrecioMedio,int PrecioExcedente,string CURPEmpleado)
        {
            abrir();
            int lenght = NombreTarifa.Length;
            char[] nombreTarifa = NombreTarifa.ToCharArray(0, lenght);
            lenght = CURPEmpleado.Length;
            char[] curp = CURPEmpleado.ToCharArray(0, lenght);
            DateTime dateTime = DateTime.Now;
            string query = "Insert into tarifa(nombreTarifa,precioBasico,precioMedio,precioExcedente,fechaCreacion,UsuarioEmpleado)" +
                "VALUES(@nombreTarifa,@precioBasico,@precioMedio,@precioExcedente,@fechaCreacion,@UsuarioEmpleado)";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@nombreTarifa",nombreTarifa);
            command.Parameters.AddWithValue("@precioBasico",PrecioBasico);
            command.Parameters.AddWithValue("@precioMedio",PrecioMedio);
            command.Parameters.AddWithValue("@precioExcedente",PrecioExcedente);
            command.Parameters.AddWithValue("@fechaCreacion", dateTime);
            command.Parameters.AddWithValue("@UsuarioEmpleado",curp);
            command.ExecuteNonQuery();
            cerrar();
            return null;
        }

        public void borrarTarifa(string nombreTarifa)
        {
            abrir();
            int lengh = nombreTarifa.Length;
            char[] tarifa = nombreTarifa.ToCharArray(0, lengh);
            string query = "Delete from tarifa where nombreTarifa=@nombreTarifa";
            SqlCommand command = new SqlCommand(query,conexion);
            command.Parameters.AddWithValue("@nombreTarifa", tarifa);
            command.ExecuteNonQuery();
            cerrar();
        }

        public void mandarAComboBoxConsumo(ComboBox comboBox)
        {
            abrir();
            string query = "Select nombreTarifa from tarifa";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                comboBox.Items.Add(dataReader["nombreTarifa"].ToString());
            }
            dataReader.Close();
        }

        public bool existeAlgunaTarifaParaConsumo()
        {
            abrir();
            string query = "Select nombreTarifa from tarifa ";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.Read())
            {
                cerrar();
                return true;
            }
            else
            {
                cerrar();
                return false;
            }
        }
        #endregion Tarifas

        #region Consumos

        public bool existeAlgunCliente(string CURP)//Busca si existe algun contrato con ese numero de Medidor dice que se busca con el curp pero es con el numero de medidor me dio hueva cambiarlo
        {
            abrir();
            int lenght = CURP.Length;
            int curp =Convert.ToInt32(CURP);
            string query = "Select * from contratos where numeroMedidor=@CURP ";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@CURP", curp);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.Read())
            {
                cerrar();
                return true;
            }
            else
            {
                cerrar();
                return false;
            }
        }
        public bool existeAlgunClienteParaConsumos(string CURP)//busca con el CURP ingresado si existe un Usuario con ese nombre
        {
            abrir();
            int lenght = CURP.Length;
            char[] curp = CURP.ToCharArray(0, lenght);
            string query = "Select * from Usuarios where CURP=@CURP ";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@CURP", curp);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.Read())
            {
                cerrar();
                return true;
            }
            else
            {
                cerrar();
                return false;
            }
        }

        public DataTable MostrarAllContratosConsumo(string CURP)//Busca por el CURP y lo manda al DTG Para que aparezca los Contratos que tiene ese cliente
        {
            abrir();
            int lenght = CURP.Length;
            char[] curp = CURP.ToCharArray(0, lenght);
            string query = " Select * from contratos where CURPCliente=@curpCliente";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@curpCliente", curp);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cerrar();
            return table;
        }
        public List<string> GetInfoClienteParaConsumo(string CURP,string numeroMedidor)//Consigue la informacion que vamos a mandar A Agregar Consumo
        {
            abrir();
            int lenght = CURP.Length;
            char[] curp = CURP.ToCharArray(0, lenght);
            int id = Convert.ToInt32(numeroMedidor);
            string query = "Select contratos.numeroServicio,contratos.CURPCliente,contratos.direccionCasa,contratos.UserEmpleado,contratos.fechaCreacion,Usuarios.Usuario from " +
                "contratos inner join Usuarios on Usuarios.CURP = contratos.CURPCliente and Usuarios.CURP = @curp and contratos.numeroMedidor = @numeroMedidor";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@curp", curp);
            command.Parameters.AddWithValue("@numeroMedidor", id);
            SqlDataReader tabla = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            tabla.Dispose();
            adapter.Fill(table);
            List<string> dataTable = new List<string>();
            foreach (DataRow data in table.Rows)
            {
                dataTable.Add(data["numeroServicio"].ToString());
                dataTable.Add(data["CURPCliente"].ToString());
                dataTable.Add(data["direccionCasa"].ToString());
                dataTable.Add(data["UserEmpleado"].ToString());
                dataTable.Add(data["fechaCreacion"].ToString());
                dataTable.Add(data["Usuario"].ToString());
            }
            cerrar();
            return dataTable;
        }

        public DataTable insertNuevoConsumo(DateTime fechaConsumo,float consumo,int numeroMedidor)//Inserta un nuevo consumo del contrato seleccionado en Añadir contrato
        {
            abrir();
            string query = "Insert into consumo(fechaConsumo,consumo,numeroMedidor) VALUES(@fechaConsumo,@consumo,@numeroMedidor)";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@fechaConsumo", fechaConsumo);
            command.Parameters.AddWithValue("@consumo", consumo);
            command.Parameters.AddWithValue("@numeroMedidor", numeroMedidor);
            command.ExecuteNonQuery();
            cerrar();
            return null;
        }



        public bool checkFechaContrato(DateTime fecha, string numeroMedidor,string numeroServicio)//verifica el Contrato si ya se ingreso en esa fecha
        {
            abrir();
            int numero = Convert.ToInt32(numeroMedidor);
            int servicio = Convert.ToInt32(numeroServicio);
            string query = "Select fechaConsumo from consumo where numeroMedidor=@numeroMedidor";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@numeroMedidor", numero);
            SqlDataReader tabla = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            if (tabla.Read())//Esto quiere decir que en fechaConsumo ya se ingreso un consumo
            {
                tabla.Dispose();
                adapter.Fill(table);
                List<string> fechaConsumo = new List<string>();
                int contador = 0;
                foreach (DataRow dataRow in table.Rows)//Toma todos los consumos que se han hecho ha este numero de medidor
                {
                    fechaConsumo.Add(dataRow["fechaConsumo"].ToString());
                    contador++;
                }
                DateTime fechaFinalConsumo = Convert.ToDateTime(fechaConsumo[contador-1]);
                TimeSpan intervaloDias = fecha - fechaFinalConsumo ;/// verifica el tiempo de diferencia bro checalo
                if(servicio==1){
                    if (intervaloDias.Days < 40 && intervaloDias.Days >= 30)
                    {
                        cerrar();
                        return true;
                    }
                    else
                    {
                        cerrar();
                        return false;
                    }
                }
                else if (servicio == 2)
                {
                    if (intervaloDias.Days < 70 && intervaloDias.Days >= 60)
                    {
                        cerrar();
                        return true;
                    }
                    else
                    {
                        cerrar();
                        return false;
                    }
                }
                else
                {
                    cerrar();
                    return false;
                }
            }
            else//No se ha ingresado un consumo 
            {
                cerrar();
                return true;
            }
        }

        public bool checkMesIngreso(DateTime fechaAVerificar,string servicio)
        {
            abrir();
            int servicioInt = Convert.ToInt32(servicio);
            string query = "Select * from consumo where fechaConsumo=@fechaConsumo";
            SqlCommand command = new SqlCommand(query,conexion);
            command.Parameters.AddWithValue("@fechaConsumo", fechaAVerificar);
            SqlDataReader tabla =command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            if (tabla.Read())
            {
                tabla.Dispose();
                adapter.Fill(table);
                List<string> fechaConsumo = new List<string>();
                int contador = 0;
                foreach (DataColumn dataColumn in table.Columns)//Toma todos los consumos que se han hecho ha este numero de medidor
                {
                    fechaConsumo.Add(dataColumn.ToString());
                    contador++;
                }
                DateTime fechaFinalConsumo = Convert.ToDateTime(fechaConsumo[contador]);
                TimeSpan intervaloDias = fechaFinalConsumo - fechaAVerificar;/// verifica el tiempo de diferencia bro checalo
                if (servicioInt == 1)
                {
                    if (intervaloDias.Days <= 0)//Esto quiere decir que los dias van para atras o sea que ingreso un dia antes de la ultima fecha y eso no se puede pues es un dia antes y deberia ser minimo 30 dias despues
                    {
                        cerrar();
                        return false;
                    }
                    else if (intervaloDias.Days >= 30 && intervaloDias.Days < 40)
                    {
                        cerrar();
                        return true;
                    }
                    else
                    {
                        cerrar();
                        return false;
                    }
                }
                else if (servicioInt==2)
                {
                    if (intervaloDias.Days <= 0)//Esto quiere decir que los dias van para atras o sea que ingreso un dia antes de la ultima fecha y eso no se puede pues es un dia antes y deberia ser minimo 30 dias despues
                    {
                        cerrar();
                        return false;
                    }
                    else if (intervaloDias.Days >= 60 && intervaloDias.Days < 70)
                    {
                        cerrar();
                        return true;
                    }
                    else
                    {
                        cerrar();
                        return false;
                    }
                }
                else
                {
                    cerrar();
                    return false;
                }
            }
            else//No se ha ingresado ningun consumo
            {
                cerrar();
                return true;
            }

        }

        public void agregarConsumo(DateTime fechaConsumo,string consumo,string NombreTarifa,string numeroMedidors)
        {
            Decimal consumoTotal=Convert.ToDecimal(consumo);
            int numeroMedidor = Convert.ToInt32(numeroMedidors);
            abrir();
            SqlCommand command = new SqlCommand("Agregar_Consumo",conexion);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parametro1 = command.Parameters.Add("@fechaConsumo", SqlDbType.DateTime);
            parametro1.Value = fechaConsumo;
            SqlParameter parametro2 = command.Parameters.Add("@consumo", SqlDbType.Decimal);
            parametro2.Value = consumoTotal;
            SqlParameter parametro3 = command.Parameters.Add("@nombreDeTarifa", SqlDbType.VarChar);
            parametro3.Value = NombreTarifa;
            SqlParameter parametro4 = command.Parameters.Add("@numeroMedidor", SqlDbType.Int);
            parametro4.Value = numeroMedidor;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.InsertCommand = command;
            command.ExecuteNonQuery();
            cerrar();
        }

        public List<string> getInfoFormaPago(string numeroMedidor)
        {
            abrir();
            string query = "Select numeroRecibo,consumoTotal,fechaCreacion,nombreDeTarifa from recibos where numeroMedidor=@numeroMedidor";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@numeroMedidor", numeroMedidor);
            SqlDataReader tabla = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            tabla.Dispose();
            adapter.Fill(table);
            List<string> dataTable = new List<string>();
            foreach (DataRow data in table.Rows)
            {
                dataTable.Add(data["numeroRecibo"].ToString());
                dataTable.Add(data["consumoTotal"].ToString());
                dataTable.Add(data["fechaCreacion"].ToString());
                dataTable.Add(data["nombreDeTarifa"].ToString());
            }
            string nombreTarifa = dataTable[3];
            string query2 = "Select precioBasico,precioMedio,precioExcedente from tarifa where nombreTarifa=@nombreTarifa";
            SqlCommand command1 = new SqlCommand(query2, conexion);
            command1.Parameters.AddWithValue("@nombreTarifa", nombreTarifa);
            SqlDataReader dataReader = command1.ExecuteReader();
            SqlDataAdapter sqlData = new SqlDataAdapter(command1);
            DataTable table1 = new DataTable();
            dataReader.Dispose();
            sqlData.Fill(table1);
            foreach (DataRow data1 in table1.Rows)
            {
                dataTable.Add(data1["precioBasico"].ToString());
                dataTable.Add(data1["precioMedio"].ToString());
                dataTable.Add(data1["precioExcedente"].ToString());
            }
            cerrar();
            return dataTable;
        }

        #endregion Consumos

        #region Recibos
        public void agregarRecibo(string numeroServicio,string UserEmpleado,string ConsumoTotal,string nombreTarifa,string numeroMedidor,DateTime fechaCreacion)
        {
            abrir();
            SqlCommand command = new SqlCommand("Generar_Recibo", conexion);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter1 = command.Parameters.Add("@numeroServicio", SqlDbType.Int);
            parameter1.Value = numeroServicio;
            SqlParameter parameter2 = command.Parameters.Add("@UserEmpleado", SqlDbType.VarChar);
            parameter2.Value = UserEmpleado;
            SqlParameter parameter3 = command.Parameters.Add("@consumoTotal", SqlDbType.Decimal);
            parameter3.Value = ConsumoTotal;
            decimal consumoCheck = Convert.ToDecimal(ConsumoTotal);
            SqlParameter parameter4 = command.Parameters.Add("@consumoBasico", SqlDbType.Decimal);
            decimal consumoBasico = consumoCheck / 4;
            parameter4.Value = consumoBasico;
            SqlParameter parameter5 = command.Parameters.Add("@consumoMedio", SqlDbType.Decimal);
            decimal consumoMedio = consumoCheck / 4;
            parameter5.Value = consumoMedio;
            SqlParameter parameter6 = command.Parameters.Add("@consumoExcedente", SqlDbType.Decimal); 
            decimal consumoExcedente = consumoCheck / 2;
            parameter6.Value = consumoExcedente;
            SqlParameter parameter7 = command.Parameters.Add("@nombreDeTarifa", SqlDbType.VarChar);
            parameter7.Value = nombreTarifa;
            SqlParameter parameter8 = command.Parameters.Add("@fechaCreacion", SqlDbType.DateTime);
            parameter8.Value = fechaCreacion;
            SqlParameter parameter9 = command.Parameters.Add("@numeroMedidor", SqlDbType.Int);
            parameter9.Value = numeroMedidor;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.InsertCommand = command;
            command.ExecuteNonQuery();
            cerrar();
        }

        public DataTable mostrarRecibo(string MesInicio,string numeroRecibo)
        {
            abrir();
            int numero = Convert.ToInt32(numeroRecibo);
            int mes = Convert.ToInt32(MesInicio);
            string query = " SELECT fechaCreacion,UserEmpleado,numeroMedidor,consumoTotal from recibos where FORMAT(GETDATE(),'MM')=@mm and numeroMedidor=@numeroRecibo";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@mm",mes);
            command.Parameters.AddWithValue("@numeroRecibo",numero);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cerrar();
            return table;
        }

        public void generarReciboPDF(string MesInicio,string numeroRecibo)
        {
            abrir();
            int numero = Convert.ToInt32(numeroRecibo);
            int mes = Convert.ToInt32(MesInicio);
            string query = "Select * from recibos where FORMAT(GETDATE(),'MM')=@mm and numeroMedidor=@numeroMedidor";
            SqlCommand command= new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@mm",mes);
            command.Parameters.AddWithValue("@numeroMedidor",numero);
            SqlDataReader tabla = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            tabla.Dispose();
            adapter.Fill(table);
            List<string> dataTable = new List<string>();
            foreach (DataRow data in table.Rows){
                dataTable.Add(data["numeroServicio"].ToString());
                dataTable.Add(data["UserEmpleado"].ToString());
                dataTable.Add(data["consumoTotal"].ToString());
                dataTable.Add(data["consumoBasico"].ToString());
                dataTable.Add(data["consumoMedio"].ToString());
                dataTable.Add(data["consumoExcedente"].ToString());
                dataTable.Add(data["nombreDeTarifa"].ToString());
                dataTable.Add(data["fechaCreacion"].ToString());
                dataTable.Add(data["numeroMedidor"].ToString());
            }
            string numeroServicio=null, UserEmpleado, consumoTotal=null, consumoBasico = null, consumoMedio = null, consumoExcedente=null, nombreTarifa, fechaCreacion=null, numeroMedidor=null;
            nombreTarifa = null;
            for (int i = 0; i < dataTable.Count; i++)
            {
                if (i==0)
                {
                    numeroServicio = dataTable[i];
                }
                else if (i == 1)
                {
                    UserEmpleado = dataTable[i];
                }
                else if (i == 2)
                {
                    consumoTotal = dataTable[i];
                }
                else if (i == 3)
                {
                    consumoBasico = dataTable[i];
                }
                else if (i == 4)
                {
                    consumoMedio = dataTable[i];
                }
                else if (i == 5)
                {
                    consumoExcedente = dataTable[i];
                }
                else if (i == 6)
                {
                    nombreTarifa = dataTable[i];
                }
                else if (i == 7)
                {
                    fechaCreacion = dataTable[i];
                }
                else if (i == 8)
                {
                    numeroMedidor = dataTable[i];
                }
            }
            int lenght = nombreTarifa.Length;
            char[] nombreTarifaChar = nombreTarifa.ToCharArray(0, lenght);
            string query2 = "Select * from tarifa where nombreTarifa=@nombreTarifa";
            SqlCommand command1 = new SqlCommand(query2, conexion);
            command1.Parameters.AddWithValue("@nombreTarifa", nombreTarifaChar);
            SqlDataReader dataReader = command1.ExecuteReader();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command1);
            DataTable table1 = new DataTable();
            dataReader.Dispose();
            dataAdapter.Fill(table1);
            List<string> data2 = new List<string>();
            foreach (DataRow data1 in table1.Rows)
            {
                data2.Add(data1["precioBasico"].ToString());
                data2.Add(data1["precioMedio"].ToString());
                data2.Add(data1["precioExcedente"].ToString());
            }
            string precioBasico=null, precioMedio=null, precioExcedente=null;
            for (int i = 0; i < data2.Count; i++)
            {
                if (i==0)
                {
                    precioBasico = data2[i];
                }
                else if (i==1)
                {
                    precioMedio = data2[i];
                }
                else if (i==2)
                {
                    precioExcedente = data2[i];
                }
            }
            decimal consumoTotalf = Convert.ToDecimal(consumoTotal);
            decimal precioBasicof = Convert.ToDecimal(precioBasico);
            decimal precioMediof = Convert.ToDecimal(precioMedio);
            decimal precioExcedentef = Convert.ToDecimal(precioExcedente);
            decimal consumoBasicof=consumoTotalf/4;
            decimal consumoMediof= consumoTotalf/4;
            decimal consumoExcedentef= consumoTotalf/2;
            decimal precioTotal;
            precioBasicof = consumoBasicof * precioBasicof;
            precioMediof = consumoMediof * precioMediof;
            precioExcedentef = consumoExcedentef * precioExcedentef;
            precioTotal = precioBasicof + precioMediof + precioExcedentef;
            double IVA = .16;
            decimal precioIVA = Convert.ToDecimal(IVA);
            decimal precioTotalIVA = precioTotal +(precioTotal *precioIVA);


            int numeromedidorInt = Convert.ToInt32(numeroMedidor);
            string query3 = "Select direccionCasa,CURPCliente from contratos where numeroMedidor=@numeroMedidor";
            SqlCommand command2 = new SqlCommand(query3, conexion);
            command2.Parameters.AddWithValue("@numeroMedidor", numeromedidorInt);
            SqlDataReader sqlDataReader = command2.ExecuteReader();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command2);
            DataTable dataTable1 = new DataTable();
            sqlDataReader.Dispose();
            sqlDataAdapter.Fill(dataTable1);
            List<string> dataTableContratos = new List<string>();
            foreach (DataRow dataRow in dataTable1.Rows)
            {
                dataTableContratos.Add(dataRow["direccionCasa"].ToString());
                dataTableContratos.Add(dataRow["CURPCliente"].ToString());
            }
            string direccionCasa = null,CURPCliente=null;
            direccionCasa=dataTableContratos[0];
            CURPCliente = dataTableContratos[1];

            lenght = CURPCliente.Length;
            char[] curpChar = CURPCliente.ToCharArray(0, lenght);
            string query4 = "Select nombreCliente from InfoCliente where CURP=@CURP";
            SqlCommand sqlCommand = new SqlCommand(query4, conexion);
            sqlCommand.Parameters.AddWithValue("@CURP", curpChar);
            SqlDataReader sqlDataReader1 = sqlCommand.ExecuteReader();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
            DataTable dataTable2 = new DataTable();
            sqlDataReader1.Dispose();
            sqlData.Fill(dataTable2);
            List<string> vs = new List<string>();
            foreach(DataRow row in dataTable2.Rows)
            {
                vs.Add(row["nombreCliente"].ToString());
            }
            string nombreCliente = vs[0];

            cerrar();
            Document document = new Document();
            Page page1 = document.Pages.Add();
            BackgroundArtifact bg = new BackgroundArtifact();
            bg.BackgroundImage = File.OpenRead("CFE.PNG");
            page1.Artifacts.Add(bg);
            //705 X  775 Y
            TextFragment textFragment = new TextFragment(nombreCliente);
            textFragment.Position = new Position(95, 712);
            textFragment.TextState.FontSize = 12;
            textFragment.TextState.Font = FontRepository.FindFont("Arial");
            textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextFragment textFragment2 = new TextFragment(direccionCasa);
            textFragment2.Position = new Position(95, 680);
            textFragment2.TextState.FontSize = 12;
            textFragment2.TextState.Font = FontRepository.FindFont("Arial");
            textFragment2.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextFragment textFragment3 = new TextFragment(numeroServicio);
            textFragment3.Position = new Position(115, 597);
            textFragment3.TextState.FontSize = 12;
            textFragment3.TextState.Font = FontRepository.FindFont("Arial");
            textFragment3.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextFragment textFragment4 = new TextFragment(numeroMedidor);
            textFragment4.Position = new Position(155, 430);
            textFragment4.TextState.FontSize = 12;
            textFragment4.TextState.Font = FontRepository.FindFont("Arial");
            textFragment4.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextBuilder textBuilder = new TextBuilder(page1);
            textBuilder.AppendText(textFragment);
            textBuilder.AppendText(textFragment2);
            textBuilder.AppendText(textFragment3);
            textBuilder.AppendText(textFragment4);

            String pdfName = "Recibo"+numeroMedidor+nombreCliente+"_"+".pdf";
            document.Save(pdfName);

            var fileName = @"Recibo" + numeroMedidor + nombreCliente + "_" + ".pdf";
            Document editPDF = new Document(fileName);
            Page pdfPage = (Page)editPDF.Pages[1];

            TextFragment test = new TextFragment(Convert.ToString(precioTotalIVA));
            test.Position = new Position(440, 705);
            test.TextState.FontSize = 14;
            test.TextState.Font = FontRepository.FindFont("Arial");
            test.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextFragment textFragment5 = new TextFragment(fechaCreacion);
            textFragment5.Position = new Position(140,380 );
            textFragment5.TextState.FontSize = 14;
            textFragment5.TextState.Font = FontRepository.FindFont("Arial");
            textFragment5.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TimeSpan ts = new TimeSpan(2,0,0,0);
            DateTime fechaCorte = Convert.ToDateTime(fechaCreacion);
            fechaCorte = fechaCorte.Date + ts;

            TimeSpan ts1 = new TimeSpan(1,0,0,0);
            DateTime limitePago = Convert.ToDateTime(fechaCreacion);
            limitePago = limitePago.Date + ts1;

            TextFragment textFragment6 = new TextFragment(Convert.ToString(consumoBasicof));
            textFragment6.Position = new Position(380, 300);
            textFragment6.TextState.FontSize = 10;
            textFragment6.TextState.Font = FontRepository.FindFont("Arial");
            textFragment6.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextFragment textFragment7 = new TextFragment(Convert.ToString(consumoMediof));
            textFragment7.Position = new Position(380, 290);
            textFragment7.TextState.FontSize = 10;
            textFragment7.TextState.Font = FontRepository.FindFont("Arial");
            textFragment7.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextFragment textFragment8 = new TextFragment(Convert.ToString(consumoExcedentef));
            textFragment8.Position = new Position(380, 280);
            textFragment8.TextState.FontSize = 10;
            textFragment8.TextState.Font = FontRepository.FindFont("Arial");
            textFragment8.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextBuilder txtBuilderS = new TextBuilder(pdfPage);
            txtBuilderS.AppendText(test);
            txtBuilderS.AppendText(textFragment5);
            txtBuilderS.AppendText(textFragment6);
            txtBuilderS.AppendText(textFragment7);
            txtBuilderS.AppendText(textFragment8);

            editPDF.Save(pdfName);
            var fileName2 = @"Recibo" + numeroMedidor + nombreCliente + "_" + ".pdf";
            Document editPDF2 = new Document(fileName2);
            Page pdfPage2 = (Page)editPDF2.Pages[1];

            TextFragment textFragment9 = new TextFragment(Convert.ToString(consumoTotalf));
            textFragment9.Position = new Position(380, 270);
            textFragment9.TextState.FontSize = 10;
            textFragment9.TextState.Font = FontRepository.FindFont("Arial");
            textFragment9.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextFragment textFragment10 = new TextFragment(Convert.ToString(precioBasicof));
            textFragment10.Position = new Position(420, 300);
            textFragment10.TextState.FontSize = 10;
            textFragment10.TextState.Font = FontRepository.FindFont("Arial");
            textFragment10.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextFragment textFragment11 = new TextFragment(Convert.ToString(precioMediof));
            textFragment11.Position = new Position(420, 290);
            textFragment11.TextState.FontSize = 10;
            textFragment11.TextState.Font = FontRepository.FindFont("Arial");
            textFragment11.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextFragment textFragment12 = new TextFragment(Convert.ToString(precioExcedentef));
            textFragment12.Position = new Position(420, 280);
            textFragment12.TextState.FontSize = 10;
            textFragment12.TextState.Font = FontRepository.FindFont("Arial");
            textFragment12.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);


            TextBuilder txtBuilderS2 = new TextBuilder(pdfPage2);
            txtBuilderS2.AppendText(textFragment9);
            txtBuilderS2.AppendText(textFragment10);
            txtBuilderS2.AppendText(textFragment11);
            txtBuilderS2.AppendText(textFragment12);
            editPDF2.Save(pdfName);


            var fileName3 = @"Recibo" + numeroMedidor + nombreCliente + "_" + ".pdf";
            Document editPDF3 = new Document(fileName3);
            Page pdfPage3 = (Page)editPDF3.Pages[1];
            TextFragment textFragment13 = new TextFragment(Convert.ToString(precioTotal));
            textFragment13.Position = new Position(420, 270);
            textFragment13.TextState.FontSize = 10;
            textFragment13.TextState.Font = FontRepository.FindFont("Arial");
            textFragment13.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextFragment textFragment14 = new TextFragment(Convert.ToString(fechaCorte));
            textFragment14.Position = new Position(115, 530);
            textFragment14.TextState.FontSize = 10;
            textFragment14.TextState.Font = FontRepository.FindFont("Arial");
            textFragment14.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextFragment textFragment15 = new TextFragment(Convert.ToString(limitePago));
            textFragment15.Position = new Position(115, 550);
            textFragment15.TextState.FontSize = 10;
            textFragment15.TextState.Font = FontRepository.FindFont("Arial");
            textFragment15.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextBuilder txtBuilderS3 = new TextBuilder(pdfPage3);
            txtBuilderS3.AppendText(textFragment13);
            txtBuilderS3.AppendText(textFragment14);
            txtBuilderS3.AppendText(textFragment15);
            editPDF3.Save(pdfName);


        }
        #endregion Recibos

        #region Reportes

        public void mostrarReporteGeneral(string CURP,string mes,string ano,string numeroServicio)
        {
            abrir();
            string query = "Select numeroMedidor from contratos where CURPCliente=@CURPCliente";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@CURPCliente", CURP);
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            reader.Dispose();
            adapter.Fill(table);
            string numeroMedidor = null;
            foreach (DataRow dataRow in table.Rows)
            {
                numeroMedidor=dataRow["numeroMedidor"].ToString();
            }
            int mesInt = Convert.ToInt32(mes);
            int anoInt = Convert.ToInt32(ano);
            int numeroSerInt = Convert.ToInt32(numeroServicio);
            int numeroMint = Convert.ToInt32(numeroMedidor);
            string query2 = "Select fechaCreacion,numeroServicio,numeroMedidor,formaPago.pagado,formaPago.adeudo from recibos inner join formaPago on recibos.numeroMedidor=@numeroMedidor and formaPago.numeroRecibo=recibos.numeroRecibo and FORMAT(GETDATE(),'MM')=@mes and FORMAT(GETDATE(),'yyyy')=@ano and recibos.numeroServicio=@numeroServicio";
            SqlCommand command1 = new SqlCommand(query2, conexion);

            command1.Parameters.AddWithValue("@numeroMedidor", numeroMint);
            command1.Parameters.AddWithValue("@mes", mesInt);
            command1.Parameters.AddWithValue("@ano", anoInt);
            command1.Parameters.AddWithValue("@numeroServicio", numeroSerInt);
            SqlDataReader reader1 = command.ExecuteReader();
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            DataTable table1 = new DataTable();
            reader1.Dispose();
            adapter1.Fill(table1);
            List<string> reporteGeneral = new List<string>();
            Document document = new Document();
            Page page1 = document.Pages.Add();
            BackgroundArtifact background = new BackgroundArtifact();
            background.BackgroundImage = File.OpenRead("Reportes.png");
            String pdfName = "Reporte General.pdf";
            page1.Artifacts.Add(background);
            int txtFragmenteX1 = 100, txtFragmentY1 = 740;
            int txtFragmenteX2 = 180, txtFragmentY2 = 740;
            int txtFragmenteX3 = 340, txtFragmentY3 = 740;
            int txtFragmenteX4 = 380, txtFragmentY4 = 740;
            int txtFragmenteX5 = 440, txtFragmentY5 =740;
            short guardado = 0;
            foreach (DataRow dataRow1 in table1.Rows)
            {
                int controladorX = 0, controladorY = 0;
                if (guardado==0)
                {
                    guardado++;
                    TextFragment textFragment = new TextFragment(dataRow1["numeroMedidor"].ToString());
                    textFragment.Position = new Position(txtFragmenteX1, txtFragmentY1);
                    textFragment.TextState.FontSize = 12;
                    textFragment.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment1 = new TextFragment(dataRow1["fechaCreacion"].ToString());
                    textFragment1.Position = new Position(txtFragmenteX2, txtFragmentY2);
                    textFragment1.TextState.FontSize = 12;
                    textFragment1.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment1.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment2 = new TextFragment(dataRow1["numeroServicio"].ToString());
                    textFragment2.Position = new Position(txtFragmenteX3, txtFragmentY3);
                    textFragment2.TextState.FontSize = 12;
                    textFragment2.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment2.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment3 = new TextFragment(dataRow1["pagado"].ToString());
                    textFragment3.Position = new Position(txtFragmenteX4, txtFragmentY4);
                    textFragment3.TextState.FontSize = 12;
                    textFragment3.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment3.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment4 = new TextFragment(dataRow1["adeudo"].ToString());
                    textFragment4.Position = new Position(txtFragmenteX5, txtFragmentY5);
                    textFragment4.TextState.FontSize = 12;
                    textFragment4.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment4.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextBuilder textBuilder = new TextBuilder(page1);
                    textBuilder.AppendText(textFragment);
                    textBuilder.AppendText(textFragment1);
                    textBuilder.AppendText(textFragment2);
                    textBuilder.AppendText(textFragment3);
                    textBuilder.AppendText(textFragment4);

                    document.Save(pdfName);
                }
                else
                {
                    controladorX = 0;
                    controladorY = controladorY - 10;
                    var filename = @"Reporte General.pdf";
                    Document editPDF = new Document(filename);
                    Page pdfPage = (Page)editPDF.Pages[1];

                    TextFragment textFragment = new TextFragment(dataRow1["numeroMedidor"].ToString());
                    textFragment.Position = new Position(txtFragmenteX1+controladorX, txtFragmentY1+controladorY);
                    textFragment.TextState.FontSize = 12;
                    textFragment.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment1 = new TextFragment(dataRow1["fechaCreacion"].ToString());
                    textFragment1.Position = new Position(txtFragmenteX2+controladorX, txtFragmentY2+controladorY);
                    textFragment1.TextState.FontSize = 12;
                    textFragment1.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment1.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment2 = new TextFragment(dataRow1["numeroServicio"].ToString());
                    textFragment2.Position = new Position(txtFragmenteX3+controladorX, txtFragmentY3+controladorY);
                    textFragment2.TextState.FontSize = 12;
                    textFragment2.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment2.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment3 = new TextFragment(dataRow1["pagado"].ToString());
                    textFragment3.Position = new Position(txtFragmenteX4+controladorX, txtFragmentY4+controladorY);
                    textFragment3.TextState.FontSize = 12;
                    textFragment3.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment3.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment4 = new TextFragment(dataRow1["adeudo"].ToString());
                    textFragment4.Position = new Position(txtFragmenteX5+controladorX, txtFragmentY5+controladorY);
                    textFragment4.TextState.FontSize = 12;
                    textFragment4.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment4.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextBuilder textBuilder = new TextBuilder(pdfPage);
                    textBuilder.AppendText(textFragment);
                    textBuilder.AppendText(textFragment1);
                    textBuilder.AppendText(textFragment2);
                    textBuilder.AppendText(textFragment3);
                    textBuilder.AppendText(textFragment4);

                    editPDF.Save(pdfName);
                }
            }
            cerrar();
            
        }

        public void mostrarReporteTarifa(string Ano)
        {
            abrir();
            int anoint = Convert.ToInt32(Ano);
            string query = "Select * from tarifa where FORMAT(GETDATE(),'yyyy')=@ano";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@ano", anoint);
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            reader.Dispose();
            adapter.Fill(table);
            Document document = new Document();
            Page page1 = document.Pages.Add();
            BackgroundArtifact background = new BackgroundArtifact();
            background.BackgroundImage = File.OpenRead("ReporteTarifa.png");
            String pdfName = "Reporte Tarifa.pdf";
            page1.Artifacts.Add(background);
            int txtFragmenteX1 = 100, txtFragmentY1 = 740;
            int txtFragmenteX2 = 320, txtFragmentY2 = 740;
            int txtFragmenteX3 = 340, txtFragmentY3 = 740;
            int txtFragmenteX4 = 380, txtFragmentY4 = 740;
            int txtFragmenteX5 = 440, txtFragmentY5 = 740;
            short guardado = 0;
            foreach (DataRow dataRow1 in table.Rows)
            {
                int controladorX = 0, controladorY = 0;
                if (guardado == 0)
                {
                    guardado++;
                    TextFragment textFragment = new TextFragment(dataRow1["fechaCreacion"].ToString());
                    textFragment.Position = new Position(txtFragmenteX1, txtFragmentY1);
                    textFragment.TextState.FontSize = 12;
                    textFragment.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment1 = new TextFragment(dataRow1["precioBasico"].ToString());
                    textFragment1.Position = new Position(txtFragmenteX2, txtFragmentY2);
                    textFragment1.TextState.FontSize = 12;
                    textFragment1.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment1.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment2 = new TextFragment(dataRow1["precioMedio"].ToString());
                    textFragment2.Position = new Position(txtFragmenteX3, txtFragmentY3);
                    textFragment2.TextState.FontSize = 12;
                    textFragment2.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment2.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment3 = new TextFragment(dataRow1["precioExcedente"].ToString());
                    textFragment3.Position = new Position(txtFragmenteX4, txtFragmentY4);
                    textFragment3.TextState.FontSize = 12;
                    textFragment3.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment3.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment4 = new TextFragment(dataRow1["nombreTarifa"].ToString());
                    textFragment4.Position = new Position(txtFragmenteX5, txtFragmentY5);
                    textFragment4.TextState.FontSize = 12;
                    textFragment4.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment4.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextBuilder textBuilder = new TextBuilder(page1);
                    textBuilder.AppendText(textFragment);
                    textBuilder.AppendText(textFragment1);
                    textBuilder.AppendText(textFragment2);
                    textBuilder.AppendText(textFragment3);
                    textBuilder.AppendText(textFragment4);

                    document.Save(pdfName);
                }
                else
                {
                    controladorX = 0;
                    controladorY = controladorY - 10;
                    var filename = @"Reporte General.pdf";
                    Document editPDF = new Document(filename);
                    Page pdfPage = (Page)editPDF.Pages[1];

                    TextFragment textFragment = new TextFragment(dataRow1["fechaCreacion"].ToString());
                    textFragment.Position = new Position(txtFragmenteX1 + controladorX, txtFragmentY1 + controladorY);
                    textFragment.TextState.FontSize = 12;
                    textFragment.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment1 = new TextFragment(dataRow1["precioBasico"].ToString());
                    textFragment1.Position = new Position(txtFragmenteX2 + controladorX, txtFragmentY2 + controladorY);
                    textFragment1.TextState.FontSize = 12;
                    textFragment1.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment1.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment2 = new TextFragment(dataRow1["precioMedio"].ToString());
                    textFragment2.Position = new Position(txtFragmenteX3 + controladorX, txtFragmentY3 + controladorY);
                    textFragment2.TextState.FontSize = 12;
                    textFragment2.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment2.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment3 = new TextFragment(dataRow1["precioExcedente"].ToString());
                    textFragment3.Position = new Position(txtFragmenteX4 + controladorX, txtFragmentY4 + controladorY);
                    textFragment3.TextState.FontSize = 12;
                    textFragment3.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment3.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment4 = new TextFragment(dataRow1["nombreTarifa"].ToString());
                    textFragment4.Position = new Position(txtFragmenteX5 + controladorX, txtFragmentY5 + controladorY);
                    textFragment4.TextState.FontSize = 12;
                    textFragment4.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment4.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextBuilder textBuilder = new TextBuilder(pdfPage);
                    textBuilder.AppendText(textFragment);
                    textBuilder.AppendText(textFragment1);
                    textBuilder.AppendText(textFragment2);
                    textBuilder.AppendText(textFragment3);
                    textBuilder.AppendText(textFragment4);

                    editPDF.Save(pdfName);
                }
            }

            cerrar();
        }

        public void mostratReporteConsumo(string Ano)
        {
            abrir();
            int anoInt = Convert.ToInt32(Ano);
            string query = "Select * from consumo where FORMAT(GETDATE(),'yyyy')=@ano";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@ano", anoInt);
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            reader.Dispose();
            adapter.Fill(table);
            Document document = new Document();
            Page page1 = document.Pages.Add();
            BackgroundArtifact background = new BackgroundArtifact();
            background.BackgroundImage = File.OpenRead("ReporteConsumo.png");
            String pdfName = "Reporte Consumo.pdf";
            page1.Artifacts.Add(background);
            int txtFragmenteX1 = 80, txtFragmentY1 = 740;
            int txtFragmenteX2 = 300, txtFragmentY2 = 740;
            int txtFragmenteX3 = 400, txtFragmentY3 = 740;
            int txtFragmenteX4 = 380, txtFragmentY4 = 740;
            int txtFragmenteX5 = 440, txtFragmentY5 = 740;
            short guardado = 0;
            foreach (DataRow dataRow1 in table.Rows)
            {
                int controladorX = 0, controladorY = 0;
                if (guardado == 0)
                {
                    guardado++;
                    TextFragment textFragment = new TextFragment(dataRow1["fechaConsumo"].ToString());
                    textFragment.Position = new Position(txtFragmenteX1, txtFragmentY1);
                    textFragment.TextState.FontSize = 12;
                    textFragment.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment1 = new TextFragment(dataRow1["numeroMedidor"].ToString());
                    textFragment1.Position = new Position(txtFragmenteX2, txtFragmentY2);
                    textFragment1.TextState.FontSize = 12;
                    textFragment1.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment1.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment2 = new TextFragment(dataRow1["consumo"].ToString());
                    textFragment2.Position = new Position(txtFragmenteX3, txtFragmentY3);
                    textFragment2.TextState.FontSize = 12;
                    textFragment2.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment2.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);


                    TextBuilder textBuilder = new TextBuilder(page1);
                    textBuilder.AppendText(textFragment);
                    textBuilder.AppendText(textFragment1);
                    textBuilder.AppendText(textFragment2);

                    document.Save(pdfName);
                }
                else
                {
                    controladorX = 0;
                    controladorY = controladorY - 10;
                    var filename = @"Reporte General.pdf";
                    Document editPDF = new Document(filename);
                    Page pdfPage = (Page)editPDF.Pages[1];

                    TextFragment textFragment = new TextFragment(dataRow1["fechaConsumo"].ToString());
                    textFragment.Position = new Position(txtFragmenteX1 + controladorX, txtFragmentY1 + controladorY);
                    textFragment.TextState.FontSize = 12;
                    textFragment.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment1 = new TextFragment(dataRow1["numeroMedidor"].ToString());
                    textFragment1.Position = new Position(txtFragmenteX2 + controladorX, txtFragmentY2 + controladorY);
                    textFragment1.TextState.FontSize = 12;
                    textFragment1.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment1.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment2 = new TextFragment(dataRow1["consumo"].ToString());
                    textFragment2.Position = new Position(txtFragmenteX3 + controladorX, txtFragmentY3 + controladorY);
                    textFragment2.TextState.FontSize = 12;
                    textFragment2.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment2.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
;

                    TextBuilder textBuilder = new TextBuilder(pdfPage);
                    textBuilder.AppendText(textFragment);
                    textBuilder.AppendText(textFragment1);
                    textBuilder.AppendText(textFragment2);

                    editPDF.Save(pdfName);
                }
            }
            cerrar();
        }

        public void generarConsumoHistorico(string Ano,string Medidor,string Servicio)
        {
            abrir();
            int ano = Convert.ToInt32(Ano);
            int medidor = Convert.ToInt32(Medidor);
            int servicio = Convert.ToInt32(Servicio);
            string query = "Select * from recibos inner join formaPago on FORMAT(GETDATE(),'yyyy')=@ano and numeroMedidor=@numeroMedidor and numeroServicio=@numeroServicio and recibos.numeroRecibo=formaPago.numeroRecibo";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@ano", ano);
            command.Parameters.AddWithValue("@numeroMedidor", medidor);
            command.Parameters.AddWithValue("@numeroServicio", servicio);
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            reader.Dispose();
            adapter.Fill(table);
            Document document = new Document();
            Page page1 = document.Pages.Add();
            BackgroundArtifact background = new BackgroundArtifact();
            background.BackgroundImage = File.OpenRead("ConsumoHistorico.png");
            String pdfName = "Consumo Historico.pdf";
            page1.Artifacts.Add(background);
            int txtFragmenteX1 = 80, txtFragmentY1 = 740;
            int txtFragmenteX2 = 300, txtFragmentY2 = 740;
            int txtFragmenteX3 = 400, txtFragmentY3 = 740;
            int txtFragmenteX4 = 440, txtFragmentY4 = 740;
            int txtFragmenteX5 = 440, txtFragmentY5 = 740;
            short guardado = 0;
            foreach (DataRow dataRow in table.Rows)
            {
                int controladorX = 0, controladorY = 0;
                if (guardado == 0)
                {
                    guardado++;
                    TextFragment textFragment = new TextFragment(dataRow["fechaCreacion"].ToString());
                    textFragment.Position = new Position(txtFragmenteX1, txtFragmentY1);
                    textFragment.TextState.FontSize = 12;
                    textFragment.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment1 = new TextFragment(dataRow["consumoTotal"].ToString());
                    textFragment1.Position = new Position(txtFragmenteX2, txtFragmentY2);
                    textFragment1.TextState.FontSize = 12;
                    textFragment1.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment1.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment2 = new TextFragment(dataRow["pagado"].ToString());
                    textFragment2.Position = new Position(txtFragmenteX3, txtFragmentY3);
                    textFragment2.TextState.FontSize = 12;
                    textFragment2.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment2.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);


                    TextFragment textFragment3 = new TextFragment(dataRow["adeudo"].ToString());
                    textFragment3.Position = new Position(txtFragmenteX4, txtFragmentY4);
                    textFragment3.TextState.FontSize = 12;
                    textFragment3.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment3.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);


                    TextBuilder textBuilder = new TextBuilder(page1);
                    textBuilder.AppendText(textFragment);
                    textBuilder.AppendText(textFragment1);
                    textBuilder.AppendText(textFragment2);
                    textBuilder.AppendText(textFragment3);

                    document.Save(pdfName);
                }
                else
                {
                    controladorX = 0;
                    controladorY = controladorY - 10;
                    var filename = @"Reporte General.pdf";
                    Document editPDF = new Document(filename);
                    Page pdfPage = (Page)editPDF.Pages[1];

                    TextFragment textFragment = new TextFragment(dataRow["fechaCreacion"].ToString());
                    textFragment.Position = new Position(txtFragmenteX1 + controladorX, txtFragmentY1 + controladorY);
                    textFragment.TextState.FontSize = 12;
                    textFragment.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment1 = new TextFragment(dataRow["consumoTotal"].ToString());
                    textFragment1.Position = new Position(txtFragmenteX2 + controladorX, txtFragmentY2 + controladorY);
                    textFragment1.TextState.FontSize = 12;
                    textFragment1.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment1.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment2 = new TextFragment(dataRow["pagado"].ToString());
                    textFragment2.Position = new Position(txtFragmenteX3 + controladorX, txtFragmentY3 + controladorY);
                    textFragment2.TextState.FontSize = 12;
                    textFragment2.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment2.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    TextFragment textFragment3 = new TextFragment(dataRow["adeudo"].ToString());
                    textFragment3.Position = new Position(txtFragmenteX4+controladorX, txtFragmentY4+controladorY);
                    textFragment3.TextState.FontSize = 12;
                    textFragment3.TextState.Font = FontRepository.FindFont("Arial");
                    textFragment3.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);


                    TextBuilder textBuilder = new TextBuilder(pdfPage);
                    textBuilder.AppendText(textFragment);
                    textBuilder.AppendText(textFragment1);
                    textBuilder.AppendText(textFragment2);
                    textBuilder.AppendText(textFragment3);

                    editPDF.Save(pdfName);
                }
            }
            cerrar();
        }


        #endregion Reportes

        #region formaPago
        public bool verificarFormaPagotabla(string numeroRecibo)//Si ya  existe alguna forma de pago
        {
            abrir();
            int numero = Convert.ToInt32(numeroRecibo);

            string query = " select * from formaPago where numeroRecibo=@numeroRecibo";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@numeroRecibo", numero);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                cerrar();
                return true;
            }
            else
            {
                cerrar();
                return false;
            }
        }

        public List<string> getInfoFormaPagoExistente(string numeroRecibo)
        {
            abrir();
            string query = "Select debito,credito,efectivo,adeudo,pagado,numeroRecibo from formaPago where numeroRecibo=@numeroRecibo";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@numeroRecibo", numeroRecibo);
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            reader.Dispose();
            adapter.Fill(table);
            List<string> info = new List<string>();
            foreach (DataRow data in table.Rows)
            {
                info.Add(data["debito"].ToString());
                info.Add(data["credito"].ToString());
                info.Add(data["efectivo"].ToString());
                info.Add(data["adeudo"].ToString());
                info.Add(data["pagado"].ToString());
                info.Add(data["numeroRecibo"].ToString());
            }
            cerrar();
            return info;
        }

        public DataTable insertarFormaPago(string debito,string credito,string efectivo,string adeudo,string pagado,string numeroRecibo)
        {
            abrir();
            string query = "Insert into formaPago(debito,credito,efectivo,adeudo,pagado,numeroRecibo)VALUES(@debito,@credito,@efectivo,@adeudo,@pagado,@numeroRecibo)";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@debito", debito);
            command.Parameters.AddWithValue("@credito", credito);
            command.Parameters.AddWithValue("@efectivo", efectivo);
            command.Parameters.AddWithValue("@adeudo", adeudo);
            command.Parameters.AddWithValue("@pagado", pagado);
            command.Parameters.AddWithValue("@numeroRecibo", numeroRecibo);
            command.ExecuteNonQuery();
            cerrar();
            return null;
        }

        public DataTable updateFormaPago(string debito, string credito, string efectivo, string adeudo, string pagado, string numeroRecibo)
        {
            abrir();
            string query = "Update formaPago set debito=@debito,credito=@credito,efectivo=@efectivo,adeudo=@adeudo,pagado=@pagado where numeroRecibo=@numeroRecibo";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@debito", debito);
            command.Parameters.AddWithValue("@credito", credito);
            command.Parameters.AddWithValue("@efectivo", efectivo);
            command.Parameters.AddWithValue("@adeudo", adeudo);
            command.Parameters.AddWithValue("@pagado", pagado);
            command.Parameters.AddWithValue("@numeroRecibo", numeroRecibo);
            command.ExecuteNonQuery();
            cerrar();
            return null;
        }

        #endregion formaPago

        public void abrir()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion Abierta");
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error al abrir  " + Ex.Message);
            }
        }
        public void cerrar()
        {
            conexion.Close();
        }
    }
}
