using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*Boton Cancelar te saca de la ventana de Login*/
        private void button2_Click(object sender, EventArgs e)
        {
            /*Cierra la ventana (Form)*/
            Form1.ActiveForm.Dispose();
        }

        /*Propiedades sobre e textBox_2 (Password) */
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            /*Esconde el password con el caracter que se indica*/
            textBox2.PasswordChar = '$';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = textBox1.Text;
            String pass = textBox2.Text;

            ConsolaMp consola = new ConsolaMp();

            if (user.Equals("IsaacMG@") && pass.Equals("!qaz2wsX"))
            {
                System.Console.WriteLine("CORRECTO...\n#####################################");
                System.Console.WriteLine("USER: "+textBox1.Text+" "+"PASS: "+ textBox2.Text);
                consola.ShowDialog();
            }
            else
            {
                System.Console.WriteLine("ERROR DATOS MAL...\n#####################################");
                System.Console.WriteLine("USER: " + textBox1.Text + " " + "PASS: " + textBox2.Text);
            }

        }
    }
}
