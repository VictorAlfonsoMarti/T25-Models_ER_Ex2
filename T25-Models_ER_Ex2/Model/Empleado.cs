using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T25_Models_ER_Ex2.Model
{
    public class Empleado
    {
        // ATRIBUTOS, GETTERS Y SETTERS
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Departamento { get; set; }

        public Departamento Departamentos { get; set; }
    }
}
