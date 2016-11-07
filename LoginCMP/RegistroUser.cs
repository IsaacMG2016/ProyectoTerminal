using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;

namespace LoginCMP
{
    public partial class RegistroUser : Form
    {

        NpgsqlDataAdapter dadapter;
        DataSet dset;
        BindingSource bs;
        NpgsqlDataAdapter dadapter2;
        DataSet dsTiendas;


        public RegistroUser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroUser.ActiveForm.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*';
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.PasswordChar = '*';
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.PasswordChar = '*';
        }

        private void guardar()
        {
            String ssql;
            ssql = "insert into \"user\"(id_user,nombre,apellido,user_name,pass,confirm,clave)";
            ssql += " values(@id_user,@nombre,@apellido,@user_name,@pass,@confirm,@clave)";

            string connstring = ConfigurationManager.ConnectionStrings["My conexion"].ConnectionString;
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand(ssql, conn);

            comm.Parameters.Add("@id_user", NpgsqlTypes.NpgsqlDbType.Integer);
            comm.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar);
            comm.Parameters.Add("@apellido", NpgsqlTypes.NpgsqlDbType.Varchar);
            comm.Parameters.Add("@user_name", NpgsqlTypes.NpgsqlDbType.Varchar);
            comm.Parameters.Add("@pass", NpgsqlTypes.NpgsqlDbType.Varchar);
            comm.Parameters.Add("@confirm", NpgsqlTypes.NpgsqlDbType.Varchar);
            comm.Parameters.Add("@clave", NpgsqlTypes.NpgsqlDbType.Varchar);


            comm.Parameters["@id_user"].Value = 3;
            comm.Parameters["@nombre"].Value = textBox1.Text;
            comm.Parameters["@apellido"].Value = textBox2.Text;
            comm.Parameters["@user_name"].Value = textBox3.Text;
            comm.Parameters["@pass"].Value = textBox4.Text;
            comm.Parameters["@confirm"].Value = textBox5.Text;
            comm.Parameters["@clave"].Value = textBox6.Text;


            int filas = comm.ExecuteNonQuery();
            System.Console.WriteLine("filas "+ filas);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("NOMBRE: " + textBox1.Text);
            System.Console.WriteLine("APELLIDO: " + textBox2.Text);
            System.Console.WriteLine("NOM_USER: " + textBox3.Text);
            System.Console.WriteLine("PASS: " + textBox4.Text);
            System.Console.WriteLine("CONFIRM: " + textBox5.Text);
            System.Console.WriteLine("CLAVE_ADMIN: " + textBox6.Text);

            if(!textBox1.Text.Equals("") && !textBox2.Text.Equals("") && !textBox3.Text.Equals("") && !textBox4.Text.Equals("") && !textBox5.Text.Equals("") && textBox6.Text.Equals("qwerty"))
            {
                guardar();
                System.Console.WriteLine("DENTRO DEL IF");
                RegistroUser.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("ERROR ! *~*", "CAMPOS INCOMPLETOS..");
            }
        }

        //private void guardaUsuario()
        //{
        //    String ssql;

        //    string connstring = ConfigurationManager.ConnectionStrings["My conexion"].ConnectionString;
        //    // creamos la conexion 
        //    NpgsqlConnection conn = new NpgsqlConnection(connstring);
        //    conn.Open(); // LA ABRIMOS

        //    //todo el nombre de las columnas 
        //    ssql = "insert into USUARIO(ID_USUARIO,NOMBRE,APELLIDO,NOMBRE_USUARIO,CONTRASENA,CONFIRMACION)";
        //    // son parametros 
        //    ssql += " values(@ID_USUARIO,@NOMBRE,@APELLIDO,@NOMBRE_USUARIO,@CONTRASENA,@CONFIRMACION)";
            
        //    //objeto le pasamos conexion 
        //    NpgsqlCommand comm = new NpgsqlCommand(ssql, conn);

        //    comm.CommandType = CommandType.StoredProcedure;

        //    // tipo de los campos del string  
        //    comm.Parameters.Add("@ID_USUARIO", NpgsqlTypes.NpgsqlDbType.Integer);
        //    comm.Parameters.Add("@NOMBRE", NpgsqlTypes.NpgsqlDbType.Varchar);
        //    comm.Parameters.Add("@APELLIDO", NpgsqlTypes.NpgsqlDbType.Varchar);
        //    comm.Parameters.Add("@NOMBRE_USUARIO", NpgsqlTypes.NpgsqlDbType.Varchar);
        //    comm.Parameters.Add("@CONTRASENA", NpgsqlTypes.NpgsqlDbType.Varchar);
        //    comm.Parameters.Add("@CONFIRMACION", NpgsqlTypes.NpgsqlDbType.Varchar);

        //    // valores de datos
        //    comm.Parameters["@ID_USUARIO"].Value = 1;
        //    comm.Parameters["@NOMBRE"].Value = textBox1.Text;
        //    comm.Parameters["@APELLIDO"].Value = textBox2.Text;
        //    comm.Parameters["@NOMBRE_USUARIO"].Value = textBox3.Text;
        //    comm.Parameters["@CONTRASENA"].Value = textBox4.Text;
        //    comm.Parameters["@CONFIRMACION"].Value = textBox5.Text;

        //    comm.ExecuteNonQuery();
        //}
    }
}
