using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEjxresolver1
{
    internal class clsEspecialidad
    {
        public string Especialidad { get; set; }
        public int CodEspecialidad { get; set; }

        public string obtenerDatosEsp()
        {
            return Especialidad + CodEspecialidad;
        }
    }
}
