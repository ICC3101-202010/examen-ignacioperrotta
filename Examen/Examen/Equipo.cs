using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Examen
{
    public class Equipo
    {
        private string nombre;
        private string tipoEquipo;
        private List<Jugadores> jugadores = new List<Jugadores>();
        private Entrenador entrenador;
        private Medico medico;
        public Equipo(string nombre, string tipoEquipo, List<Jugadores> jugadores, Entrenador entrenador, Medico medico)
        {
            this.Nombre = nombre;
            this.TipoEquipo = tipoEquipo;
            this.Jugadores = jugadores;
            this.Entrenador = entrenador;
            this.Medico = medico;
        }
        public Equipo() { }
        public List<Jugadores> Jugadores
        {
            get => jugadores; set => jugadores = value;
        }
        public string Nombre
        {
            get => nombre; set => nombre = value;
        }
        public string TipoEquipo
        {
            get => tipoEquipo; set => tipoEquipo = value;
        }

        public Entrenador Entrenador
        {
            get => entrenador; set => entrenador = value;
        }
        public Medico Medico
        {
            get => medico; set => medico = value;
        }
        public void CrearJugador()
        {
            Console.Write("Ingresa el nombre del Jugador que desea crear: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingresa el numero de camiseta del jugador: ");
            int numeroCamiseta = Int32.Parse(Console.ReadLine());
            string description = null;
            foreach (Jugadores jugadores1 in Archivos.Jugadores)
            {
                if (jugadores1.Nombre != nombre)
                {
                    Console.Write("Ingrese la Edad del jugador: ");
                    int EdadJugador = Int32.Parse(Console.ReadLine());
                    Console.Write("Ingrese la Nacionalidad del jugador: ");
                    string NacionJugador = Console.ReadLine();
                    Console.Write("Ingrese el sueldo del jugador: ");
                    int SueldoJugador = Int32.Parse(Console.ReadLine());
                    Console.Write("Ingrese los puntos de ataque del jugador: ");
                    int PuntosAtaqueJugador = Int32.Parse(Console.ReadLine());
                    Console.Write("Ingrese los puntos de defensa del jugador: ");
                    int PuntosDefensaJugador = Int32.Parse(Console.ReadLine());
                    Jugadores jugadores = new Jugadores(nombre, EdadJugador, NacionJugador, SueldoJugador, PuntosAtaqueJugador, PuntosDefensaJugador, numeroCamiseta, "Jugador");
                    Jugadores.Add(jugadores);
                }
            }
            if (description == null)
            {
                Console.WriteLine("El Jugador ya existe");
            }
        }
        public void CrearArquero()
        {
            Console.Write("Ingresa el nombre del Arquero que desea crear: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingresa el numero de camiseta del Arquero: ");
            int numeroCamiseta = Int32.Parse(Console.ReadLine());
            string description = null;
            foreach (Jugadores jugadores1 in Archivos.Jugadores)
            {
                if (jugadores1.Nombre != nombre)
                {
                    Console.Write("Ingrese la Edad del jugador: ");
                    int EdadJugador = Int32.Parse(Console.ReadLine());
                    Console.Write("Ingrese la Nacionalidad del jugador: ");
                    string NacionJugador = Console.ReadLine();
                    Console.Write("Ingrese el sueldo del jugador: ");
                    int SueldoJugador = Int32.Parse(Console.ReadLine());
                    Console.Write("Ingrese los puntos de ataque del jugador: ");
                    int PuntosAtaqueJugador = Int32.Parse(Console.ReadLine());
                    Console.Write("Ingrese los puntos de defensa del jugador: ");
                    int PuntosDefensaJugador = Int32.Parse(Console.ReadLine());
                    Jugadores jugadores = new Jugadores(nombre, EdadJugador, NacionJugador, SueldoJugador, PuntosAtaqueJugador, PuntosDefensaJugador, numeroCamiseta, "Arquero");
                    Archivos.Jugadores.Add(jugadores);
                }
            }
            if (description == null)
            {
                Console.WriteLine("El Arquero ya existe");
            }
        }
        public void CrearEquipo()
        {
            Console.Write("Ingrese el Nombre del Equipo: ");
            string NombreEquipo = Console.ReadLine();
            Console.WriteLine("Seleccione que tipo de Equipo desea crear: ");
            Console.WriteLine("1) Nacional");
            Console.WriteLine("2) De Liga");
            string option = Console.ReadLine();
            List<Jugadores> jugadores = new List<Jugadores>();
            if (option == "1")
            {
                string TipoEquipoCreado = "Nacional";
                Console.WriteLine("Debe agregar 2 Arqueros");
                int contador = 0;
                Console.Write("Ingrese la Nacionalidad del " + Convert.ToString(contador + 1) + " Arquero: ");
                string NacionJugador = Console.ReadLine();
                while (contador < 2)
                {
                    try
                    {
                        Console.Write("Ingresa el nombre del " + Convert.ToString(contador + 1) + " Arquero: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingresa el numero de camiseta del " + Convert.ToString(contador + 1) + " Arquero: ");
                        int numeroCamiseta = Int32.Parse(Console.ReadLine());
                        Console.Write("Ingrese la Edad del " + Convert.ToString(contador + 1) + " Arquero: ");
                        int EdadJugador = Int32.Parse(Console.ReadLine());
                        Console.Write("Ingrese el sueldo del " + Convert.ToString(contador + 1) + " Arquero: ");
                        int SueldoJugador = Int32.Parse(Console.ReadLine());
                        Console.Write("Ingrese los puntos de ataque del " + Convert.ToString(contador + 1) + " Arquero: ");
                        int PuntosAtaqueJugador = Int32.Parse(Console.ReadLine());
                        Console.Write("Ingrese los puntos de defensa del " + Convert.ToString(contador + 1) + " Arquero: ");
                        int PuntosDefensaJugador = Int32.Parse(Console.ReadLine());
                        Jugadores Arquero = new Jugadores(nombre, EdadJugador, NacionJugador, SueldoJugador, PuntosAtaqueJugador, PuntosDefensaJugador, numeroCamiseta, "Arquero");
                        jugadores.Add(Arquero);
                        contador++;
                    }
                    catch
                    {
                        Console.WriteLine("Criterios ingresados no válidos");
                    }
                }
                int contador2 = 0;
                Console.WriteLine("Debe agregar 13 Jugadores en cancha");
                Console.WriteLine("");
                while (contador2 < 13)
                {
                    try
                    {
                        Console.Write("Ingresa el nombre del " + Convert.ToString(contador2 + 1) + " Jugador: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingresa el numero de camiseta del " + Convert.ToString(contador2 + 1) + " Jugador: ");
                        int numeroCamiseta = Int32.Parse(Console.ReadLine());
                        Console.Write("Ingrese la Edad del " + Convert.ToString(contador2 + 1) + " Jugador: ");
                        int EdadJugador = Int32.Parse(Console.ReadLine());
                        Console.Write("Ingrese el sueldo del " + Convert.ToString(contador2 + 1) + " Jugador: ");
                        int SueldoJugador = Int32.Parse(Console.ReadLine());
                        Console.Write("Ingrese los puntos de ataque del " + Convert.ToString(contador2 + 1) + " Jugador: ");
                        int PuntosAtaqueJugador = Int32.Parse(Console.ReadLine());
                        Console.Write("Ingrese los puntos de defensa del " + Convert.ToString(contador2 + 1) + " Jugador: ");
                        int PuntosDefensaJugador = Int32.Parse(Console.ReadLine());
                        Jugadores Jugador = new Jugadores(nombre, EdadJugador, NacionJugador, SueldoJugador, PuntosAtaqueJugador, PuntosDefensaJugador, numeroCamiseta, "Jugador");
                        jugadores.Add(Jugador);
                        contador2++;
                    }
                    catch
                    {
                        Console.WriteLine("Criterios ingresados no válidos");
                    }
                }
                Console.Write("Ingresa el nombre del Entrenador: ");
                string nombreEntrenador = Console.ReadLine();
                Console.Write("Ingrese la Edad del Entrenador: ");
                int EdadEntrenador = Int32.Parse(Console.ReadLine());
                Console.Write("Ingrese la Nacionalidad del Entrenador: ");
                string NacionalidadEntrenador = Console.ReadLine();
                Console.Write("Ingrese el sueldo del Entrenador: ");
                int SueldoEntrenador = Int32.Parse(Console.ReadLine());
                Console.Write("Ingrese los puntos de Táctica del Entrenador: ");
                int PuntosTactica = Int32.Parse(Console.ReadLine());
                Entrenador entrenador = new Entrenador(nombreEntrenador, EdadEntrenador, NacionalidadEntrenador, SueldoEntrenador, PuntosTactica);
                Console.Write("Ingresa el nombre del Médico: ");
                string nombreMedico = Console.ReadLine();
                Console.Write("Ingrese la Edad del Medico: ");
                int EdadMedico = Int32.Parse(Console.ReadLine());
                Console.Write("Ingrese la Nacionalidad del Medico: ");
                string NacionalidadMedico = Console.ReadLine();
                Console.Write("Ingrese el sueldo del Medico: ");
                int SueldoMedico = Int32.Parse(Console.ReadLine());
                Console.Write("Ingrese los puntos de Experiencia del Medico: ");
                int PuntosExperiencia = Int32.Parse(Console.ReadLine());
                Medico medico = new Medico(nombreMedico, EdadMedico, NacionalidadMedico, SueldoMedico, PuntosExperiencia);
                Equipo equipo = new Equipo(NombreEquipo, TipoEquipoCreado, jugadores, entrenador, medico);
                Archivos.Equipos.Add(equipo);
            }
            if (option == "2")
            {
                string TipoEquipoCreado2 = "De Liga";
                Console.WriteLine("Debe agregar 2 Arqueros");
                int contador3 = 0;
                while (contador3 < 2)
                {
                    try
                    {
                        Console.Write("Ingresa el nombre del " + Convert.ToString(contador3 + 1) + " Arquero: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingresa el numero de camiseta del " + Convert.ToString(contador3 + 1) + " Arquero: ");
                        int numeroCamiseta = Int32.Parse(Console.ReadLine());
                        Console.Write("Ingrese la Nacionalidad del " + Convert.ToString(contador3 + 1) + " Arquero: ");
                        string NacionJugador2 = Console.ReadLine();
                        Console.Write("Ingrese la Edad del " + Convert.ToString(contador3 + 1) + " Arquero: ");
                        int EdadJugador = Int32.Parse(Console.ReadLine());
                        Console.Write("Ingrese el sueldo del " + Convert.ToString(contador3 + 1) + " Arquero: ");
                        int SueldoJugador = Int32.Parse(Console.ReadLine());
                        Console.Write("Ingrese los puntos de ataque del " + Convert.ToString(contador3 + 1) + " Arquero: ");
                        int PuntosAtaqueJugador = Int32.Parse(Console.ReadLine());
                        Console.Write("Ingrese los puntos de defensa del " + Convert.ToString(contador3 + 1) + " Arquero: ");
                        int PuntosDefensaJugador = Int32.Parse(Console.ReadLine());
                        Jugadores Arquero = new Jugadores(nombre, EdadJugador, NacionJugador2, SueldoJugador, PuntosAtaqueJugador, PuntosDefensaJugador, numeroCamiseta, "Arquero");
                        jugadores.Add(Arquero);
                        contador3++;
                    }
                    catch
                    {
                        Console.WriteLine("Criterios ingresados no válidos");
                    }
                }
                int contador4 = 0;
                Console.WriteLine("Debe agregar 13 Jugadores");
                Console.WriteLine("");
                while (contador4 < 13)
                {
                    try
                    {
                        Console.Write("Ingresa el nombre del " + Convert.ToString(contador4 + 1) + " Jugador: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingresa el numero de camiseta del " + Convert.ToString(contador4 + 1) + " Jugador: ");
                        int numeroCamiseta = Int32.Parse(Console.ReadLine());
                        Console.Write("Ingrese la Edad del " + Convert.ToString(contador4 + 1) + " Jugador: ");
                        int EdadJugador = Int32.Parse(Console.ReadLine());
                        Console.Write("Ingrese la Nacionalidad del " + Convert.ToString(contador4 + 1) + " Jugador: ");
                        string NacionJugador2 = Console.ReadLine();
                        Console.Write("Ingrese el sueldo del " + Convert.ToString(contador4 + 1) + " Jugador: ");
                        int SueldoJugador = Int32.Parse(Console.ReadLine());
                        Console.Write("Ingrese los puntos de ataque del " + Convert.ToString(contador4 + 1) + " Jugador: ");
                        int PuntosAtaqueJugador = Int32.Parse(Console.ReadLine());
                        Console.Write("Ingrese los puntos de defensa del " + Convert.ToString(contador4 + 1) + " Jugador: ");
                        int PuntosDefensaJugador = Int32.Parse(Console.ReadLine());
                        Jugadores Jugador = new Jugadores(nombre, EdadJugador, NacionJugador2, SueldoJugador, PuntosAtaqueJugador, PuntosDefensaJugador, numeroCamiseta, "Jugador");
                        jugadores.Add(Jugador);
                        contador4++;
                    }
                    catch
                    {
                        Console.WriteLine("Criterios ingresados no válidos");
                    }
                }
                Console.Write("Ingresa el nombre del Entrenador: ");
                string nombreEntrenador2 = Console.ReadLine();
                Console.Write("Ingrese la Edad del Entrenador: ");
                int EdadEntrenador2 = Int32.Parse(Console.ReadLine());
                Console.Write("Ingrese la Nacionalidad del Entrenador: ");
                string NacionalidadEntrenador2 = Console.ReadLine();
                Console.Write("Ingrese el sueldo del Entrenador: ");
                int SueldoEntrenador2 = Int32.Parse(Console.ReadLine());
                Console.Write("Ingrese los puntos de Táctica del Entrenador: ");
                int PuntosTactica2 = Int32.Parse(Console.ReadLine());
                Entrenador entrenador2 = new Entrenador(nombreEntrenador2, EdadEntrenador2, NacionalidadEntrenador2, SueldoEntrenador2, PuntosTactica2);
                Console.Write("Ingresa el nombre del Médico: ");
                string nombreMedico2 = Console.ReadLine();
                Console.Write("Ingrese la Edad del Medico: ");
                int EdadMedico2 = Int32.Parse(Console.ReadLine());
                Console.Write("Ingrese la Nacionalidad del Medico: ");
                string NacionalidadMedico2 = Console.ReadLine();
                Console.Write("Ingrese el sueldo del Medico: ");
                int SueldoMedico2 = Int32.Parse(Console.ReadLine());
                Console.Write("Ingrese los puntos de Experiencia del Medico: ");
                int PuntosExperiencia2 = Int32.Parse(Console.ReadLine());
                Medico medico2 = new Medico(nombreMedico2, EdadMedico2, NacionalidadMedico2, SueldoMedico2, PuntosExperiencia2);
                Equipo equipo2 = new Equipo(NombreEquipo, TipoEquipoCreado2, jugadores, entrenador2, medico2);
                Archivos.Equipos.Add(equipo2);
                Console.WriteLine("Equipo Agregado Correctamente");
            }
            else
            {
                Console.WriteLine("Criterio ingresado no válido");
            }
        }
        public void VerEquipos()
        {
            int numeroEquipos = Archivos.Equipos.Count();
            if (numeroEquipos == 0)
            {
                Console.WriteLine("No hay equipos creados, por favor cree uno");
                Console.WriteLine("");
            }
            else
            {
                foreach (Equipo equipo in Archivos.Equipos)
                {
                    Console.WriteLine(equipo.Nombre + "," + equipo.TipoEquipo + "," + equipo.entrenador.Nombre + "," + equipo.medico.Nombre);
                }
            }
        }
        public void JugadoresEquipo()
        {
            int numeroEquipos = Archivos.Equipos.Count();
            if (numeroEquipos == 0)
            {
                Console.WriteLine("No hay equipos creados, por favor cree uno");
                Console.WriteLine("");
            }
            else
            {
                int contador = 0;
                foreach (Equipo equipo in Archivos.Equipos)
                {
                    Console.WriteLine(Convert.ToString(contador + 1) + "- " + equipo.Nombre);
                    contador++;
                }
                Console.Write("Indique el nuemero del equipo que desea ver: ");
                int opcion = Int32.Parse(Console.ReadLine());
                foreach (Jugadores jugadores in Archivos.Equipos[opcion - 1].jugadores)
                {
                    Console.WriteLine(jugadores.Nombre + "," + jugadores.Edad + "," + jugadores.Nacion + "," + jugadores.Sueldo + "," + jugadores.PuntosAtaque + "," + jugadores.PuntosDefensa + "," + jugadores.NumeroCamiseta + "," + jugadores.TipoJugador);
                }
            }
        }
        public void EditarEquipo()
        {

        }
    }
}