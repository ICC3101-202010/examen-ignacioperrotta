using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Examen
{
    static class Archivos
    {
        private static List<Equipo> equipos = new List<Equipo>();
        private static List<Jugadores> jugadores = new List<Jugadores>();
        private static List<Entrenador> entrenadores = new List<Entrenador>();
        private static List<Medico> medicos = new List<Medico>();

        public static List<Equipo> Equipos
        {
            get => equipos; set => equipos = value;
        }
        public static List<Jugadores> Jugadores
        {
            get => jugadores; set => jugadores = value;
        }
        public static List<Entrenador> Entrenadores
        {
            get => entrenadores; set => entrenadores = value;
        }
        public static List<Medico> Medicos
        {
            get => medicos; set => medicos = value;
        }
    }
}
