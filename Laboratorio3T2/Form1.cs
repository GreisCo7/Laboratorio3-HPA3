using System;
using System.Collections;
using System.Windows.Forms;

namespace Laboratorio3
{
    public partial class Form1 : Form
    {
        ArrayList listaPersonas = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Persona miColaborador1 = new Persona();
            miColaborador1.Id = 1;
            miColaborador1.Nombres = "Arelys Elena";
            miColaborador1.Apellidos = "Coronado Reyes";
            miColaborador1.Correo = "elena.coronado@ejemplo.com";
            miColaborador1.FechaNacimiento = new DateTime(1996, 6, 9);
            miColaborador1.Salario = 1500.00m;


            listaPersonas.Add(miColaborador1);
            dgvdatos.DataSource = listaPersonas;

        }

        private void label4_Click(object sender, EventArgs e)
        { 
        
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            //valida que los espacios no esten vacios y que el ID no se repita

            if (txtID.Text == "")
            {
                errorProvider1.SetError(txtID, "Ingrese un ID");
                txtID.Focus();
                return;
            }
            else { errorProvider1.SetError(txtID, ""); }


            int idIngresado = int.Parse(txtID.Text);
            bool idDuplicado = false;

            foreach (Persona p in listaPersonas)
            {
                if (p.Id == idIngresado)
                {
                    idDuplicado = true;
                    break; 
                }
            }

            if (idDuplicado)
            {
                errorProvider1.SetError(txtID, "Este ID de Empleado ya se encuentra registrado");
                txtID.Focus();
                return; 
            }
            else
            {
                errorProvider1.SetError(txtID, "");
            }


            // 
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Ingrese los nombres del Colaborador");
                txtNombre.Focus();
                return;
            }
            else { errorProvider1.SetError(txtNombre, ""); }

            // 
            if (txtApellido.Text == "")
            {
                errorProvider1.SetError(txtApellido, "Ingrese los apellidos del Colaborador");
                txtApellido.Focus();
                return;
            }
            else { errorProvider1.SetError(txtApellido, ""); }

            // 
            if (Utilidades.EsCorreoValido(txtEmail.Text) == false)
            {
                errorProvider1.SetError(txtEmail, "Ingrese un correo válido");
                txtEmail.Focus();
                return;
            }
            else { errorProvider1.SetError(txtEmail, ""); }

            // 
            decimal salario1;
            if (!decimal.TryParse(txtSalario.Text, out salario1))
            {
                errorProvider1.SetError(txtSalario, "Ingrese un salario válido");
                txtSalario.Focus();
                return;
            }
            else { errorProvider1.SetError(txtSalario, ""); }

            // Si pasa todas las validaciones, se crea el objeto 
            Persona colaborador1 = new Persona();
            colaborador1.Id = int.Parse(txtID.Text);
            colaborador1.Nombres = txtNombre.Text;
            colaborador1.Apellidos = txtApellido.Text;
            colaborador1.Correo = txtEmail.Text;
            colaborador1.Salario = salario1;
            colaborador1.FechaNacimiento = dtpFechaNa.Value;

            listaPersonas.Add(colaborador1);

            dgvdatos.DataSource = null;
            dgvdatos.DataSource = listaPersonas;

            txtID.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSalario.Text = string.Empty;
            dtpFechaNa.Value = DateTime.Now;
        }
    }
}
