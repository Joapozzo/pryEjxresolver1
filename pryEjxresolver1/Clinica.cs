using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEjxresolver1
{
    public partial class frmClinica : Form
    {

        List<clsEspecialidad> listEspecialidad = new List<clsEspecialidad>();
        List<clsMedico> listMedico = new List<clsMedico>();

        void limpiarDatos()
        {
            txtAgregarEspecialidad.Text = "";
            txtMatricula.Text = "";
            txtNombre.Text = "";
            cmbEspecialiadMedico.SelectedIndex = -1;
        }
        public frmClinica()
        {
            InitializeComponent();
        }

        int indice = 0;

        private void btnRegistrarEspecialidad_Click(object sender, EventArgs e)
        {

            clsEspecialidad objEspecialidad = new clsEspecialidad();

            objEspecialidad.Especialidad = txtAgregarEspecialidad.Text;
            objEspecialidad.CodEspecialidad = indice++;
            listEspecialidad.Add(objEspecialidad);

            cmbEspecialiadMedico.Items.Add(objEspecialidad.Especialidad);
            cmbEspecialidadConsulta.Items.Add(objEspecialidad.Especialidad);

            MessageBox.Show(objEspecialidad.obtenerDatosEsp());
        }

        private void btnRegistrarMedico_Click(object sender, EventArgs e)
        {
            clsMedico objMedico = new clsMedico();
            objMedico.Matricula = int.Parse(txtMatricula.Text);
            objMedico.Nombre = txtNombre.Text;
            objMedico.EspecialidadMedico = cmbEspecialiadMedico.Text;
            listMedico.Add(objMedico);

            MessageBox.Show(objMedico.obtenerDatos());

        }

        private void lblConsultarEspecialidad_Click(object sender, EventArgs e)
        {
            foreach (clsEspecialidad campo in listEspecialidad)
            {
                if (cmbEspecialidadConsulta.SelectedIndex == int.Parse(campo.Especialidad))
                {
                    foreach (clsMedico campo2 in listMedico)
                    {
                        lstConsulta.Items.Add(campo2);
                    }
                }
            }
        }

    }
}
