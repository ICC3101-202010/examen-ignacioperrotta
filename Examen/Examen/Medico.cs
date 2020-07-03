using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Examen
{
    public class Medico : Person
    {
        protected int puntosExperiencia;
        public Medico(string nombre, int edad, string nacion, int sueldo, int puntosExperiencia) : base(nombre, edad, nacion, sueldo)
        {
            this.PuntosExperiencia = puntosExperiencia;
        }
        public int PuntosExperiencia
        {
            get => puntosExperiencia; set => puntosExperiencia = value;
        }
        public void Evaluar()
        {
            //not yet
        }
        public void Curar()
        {
            //not yet
        }
    }
}
