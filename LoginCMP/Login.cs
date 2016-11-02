using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCMP
{
    public partial class Login : Form
    {
        int intentos = 0;

        public Login()
        {
            InitializeComponent();
        }

        /*Boton Cancelar te saca de la ventana de Login*/
        private void button2_Click(object sender, EventArgs e)
        {
            /*Cierra la ventana (Form1 = login)*/
            Login.ActiveForm.Dispose();
        }

        /*Propiedades sobre e textBox_2 (Password) */
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            /*Esconde el password con el caracter que se indica*/
            textBox2.PasswordChar = '*';
        }

        /*Boton Iniciar lanza la consola si todo es correcto*/
        private void button1_Click(object sender, EventArgs e)
        {
            String user = textBox1.Text;
            String pass = textBox2.Text;

            if (user.Equals("IsaacMG@") && pass.Equals("!qaz2wsX") && intentos < 3)
            {
                System.Console.WriteLine("CORRECTO...\n#####################################");
                System.Console.WriteLine("USER: "+textBox1.Text+" "+"PASS: "+ textBox2.Text);
                new Thread(new ThreadStart(showForm)).Start();
                Login.ActiveForm.Close();
            }
            else
            {
                /*Solo se permiten tres intentos de ususario o contraseña*/
                intentos++;
                System.Console.WriteLine("ERROR DATOS MAL...\n#####################################");
                System.Console.WriteLine("USER: " + textBox1.Text + " " + "PASS: " + textBox2.Text +"INTENTOS: "+intentos);

                if (user.Equals("IsaacMG@") && !pass.Equals("!qaz2wsX"))
                    MessageBox.Show("Contraseña ** Incorrecta **","ERROR");
                else if (!user.Equals("IsaacMG@") && (pass.Equals("!qaz2wsX")))
                        MessageBox.Show("Nombre de Usuario ** Incorrecto **", "ERROR");
                     else   
                        MessageBox.Show("Nombre de Usuario y Contraseña ** Incorrecto **", "ERROR");
            }

            if (intentos > 2)
            {
                MessageBox.Show("BLOQUEADA 3 INTENTOS");
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                button1.Enabled = false;
            }
        }

        /*Ejecucion del Hilo que se levanta al iniciar la consola*/
        public void showForm()
        {
            ConsolaMp consola = new ConsolaMp();
            consola.ShowDialog();
        }

        /*link para seleccionar el agregar un nuevo usuario*/
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUser registro = new RegistroUser();
            registro.ShowDialog();
            //MessageBox.Show("FORMULARIO DE REGISTRO::^_^^~^******");

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            System.Console.WriteLine("AL ACTIVAR EL CHECK SE DEBE GUARDAR EL USUARIO Y CONTRASEÑA *~*");
        }
    }
}
