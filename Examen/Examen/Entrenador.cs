using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Examen
{
    public class Entrenador : Person
    {
        protected int puntosTactica;
        public Entrenador(string nombre, int edad, string nacion, int sueldo, int puntosTactica) : base(nombre, edad, nacion, sueldo)
        {
            this.PuntosTactica = puntosTactica;
        }
        public int PuntosTactica
        {
            get => puntosTactica; set => puntosTactica = value;
        }
        public void CambiarJugador()
        {
            //not yet
        }
    }
}