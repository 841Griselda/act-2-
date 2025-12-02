using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACTIVIDAD_2
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }
            private void btnOperaciones_Click(object sender, EventArgs e)
        {
            OPERACIONES_BASICAS op = new OPERACIONES_BASICAS();
            op.Show();
            this.Hide();  // opcional
        }

        

        private void sALUDOToolStripMenuItem_Click(object sender, EventArgs e)
        { }
private void btnSaludo_Click(object sender, EventArgs e)
        {
            Saludo saludo = new Saludo();
            saludo.Show();
            this.Hide();
        }

        private void dATOSPERSONALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DATOS_PERSONALES datos = new DATOS_PERSONALES();
            datos.Show();
            this.Hide();

        }
    }
}


