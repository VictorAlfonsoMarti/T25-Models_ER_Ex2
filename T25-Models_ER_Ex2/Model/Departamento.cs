using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T25_Models_ER_Ex2.Model
{
    public class Departamento
    {
        // ATRIBUTOS, GETTERS Y SETTERS
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int? Presupuesto { get; set; }

        public ICollection<Empleado> Empleados { get; set; }

        //CONSTRUCTOR
        public Departamento()
        {
            Empleados = new HashSet<Empleado>();
        }
    }
}
