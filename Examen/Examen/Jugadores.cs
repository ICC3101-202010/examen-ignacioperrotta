using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Examen
{
    public class Jugadores : Person
    {
        protected int puntosAtaque;
        protected int puntosDefensa;
        protected int numeroCamiseta;
        protected string tipoJugador;
        public Jugadores(string nombre, int edad, string nacion, int sueldo, int puntosAtaque, int puntosDefensa, int numeroCamiseta, string tipoJugador) : base(nombre, edad, nacion, sueldo)
        {
            this.PuntosAtaque = puntosAtaque;
            this.PuntosDefensa = puntosDefensa;
            this.NumeroCamiseta = numeroCamiseta;
            this.TipoJugador = tipoJugador;
        }
        public int PuntosAtaque
        {
            get => puntosAtaque; set => puntosAtaque = value;
        }
        public int PuntosDefensa
        {
            get => puntosDefensa; set => puntosDefensa = value;
        }
        public int NumeroCamiseta
        {
            get => numeroCamiseta; set => numeroCamiseta = value;
        }
        public string TipoJugador
        {
            get => tipoJugador; set => tipoJugador = value;
        }
        public void InfoJugador()
        {
            Console.WriteLine(Nombre, Edad, Nacion, Sueldo, PuntosAtaque, PuntosDefensa, NumeroCamiseta, TipoJugador);
        }
    }
}
