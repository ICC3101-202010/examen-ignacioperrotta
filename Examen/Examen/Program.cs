using System;

namespace Examen
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int u = 1;
            while (u != 0)
            {
                Console.WriteLine("Bienvenido");
                Console.WriteLine("Seleecione que opción desea realizar");
                Console.WriteLine("(1) Crear Equipo");
                Console.WriteLine("(2) Ver Equipos");
                Console.WriteLine("(3) Ver Jugadores de Equipo");
                Console.WriteLine("(4) Salir");
                string input_usuario;
                input_usuario = Console.ReadLine();
                Equipo equipo = new Equipo();
                while (input_usuario == "1" || input_usuario == "2" || input_usuario == "3" || input_usuario == "4")
                {
                    if (input_usuario == "1")
                    {
                        equipo.CrearEquipo();
                        break;
                    }
                    else if (input_usuario == "2")
                    {
                        equipo.VerEquipos();
                        break;
                    }
                    else if (input_usuario == "3")
                    {
                        equipo.JugadoresEquipo();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Criterio ingresado no válido");
                    }
                }
            }
        }
    }
}
