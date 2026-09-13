using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio3T3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            frmVentanaTexto ventanaTexto = Application.OpenForms.OfType<frmVentanaTexto>().FirstOrDefault();

            if (ventanaTexto != null)
            {
                ventanaTexto.BringToFront();
                ventanaTexto.Focus();
            }
            else
            {
                ventanaTexto = new frmVentanaTexto();
                ventanaTexto.MdiParent = this;
                ventanaTexto.Show();
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
