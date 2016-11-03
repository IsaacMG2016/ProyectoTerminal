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
    /*
     Ventana Principal de la Consola
     Revisar porque no se guardan los cambios
     de forma Local.
     */
    public partial class ConsolaMp : Form
    {
        public ConsolaMp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsolaMp.ActiveForm.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AGUEVO JAJAJA", "*******");
        }
    }
}
