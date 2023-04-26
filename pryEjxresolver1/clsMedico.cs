using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEjxresolver1
{
    internal class clsMedico
    {
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string EspecialidadMedico { get; set; }

        public string obtenerDatos()
        {
            return "Matricula: " + Matricula + "Nombre: " + Nombre + "Especialidad: " + EspecialidadMedico;
        }

    }

}
