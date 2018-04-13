using System;
using System.Collections.Generic;

using static System.Console;

namespace ProyectoFinalOYM
{
    class Program
    {
        private static string usuario;
        private static string clave;
        private static bool usuarioChecked, claveChecked = false;

        private static List<string> usuarios = new List<string>()
        { "jhernandez", "larias", "ddejesus", "ysosa", "fcaraballo", "jpaula" };

        private static List<string> claves = new List<string>()
        { "1111", "2222", "3333", "4444", "5555", "6666" };


        static void Main(string[] args)
        {
            WriteLine("Grupo: NombreCreativoEnPascalCase.\n");
            WriteLine("Integrantes:\n");
            WriteLine("07-SISN-1-128	Yoscar Daniel Sosa Gálvez.");
            WriteLine("09-SISN-1-093	Luis Alfredo Arias Thorman.");
            WriteLine("11-MISN-1-071	David de Jesús Moreno Mejía.");
            WriteLine("12-EISN-1-321	Freddy Erinson Caraballo rosario.");
            WriteLine("13-MIST-1-053	Joelvin Paula Rosario.");
            WriteLine("12-EISM-1-104	José Fco. Hernández González.\n");
            Write("Pulse una tecla para continuar >");

            ReadKey();
            Clear();


            WriteLine("                         INGRESE USUARIO Y CLAVE");
            Write("Usuario >");
            usuario = ReadLine();

            Write("Clave >");
            clave = ReadLine();
            Clear();

            // Los siguientes foreach validan usuario y contraseña ingresados.

            foreach (var u in usuarios)
            {
                if (u == usuario)
                {
                    usuarioChecked = true;
                }
            }

            foreach (var c in claves)
            {
                if (c == clave)
                {
                    claveChecked = true;
                }
            }

            // Codigo que se ejecutará una vez se haya cumplido con la validacion.

            if (usuarioChecked && claveChecked)
            {
                switch (usuario)
                {
                    case "jhernandez":
                        WriteLine("Información de José Hernandez\n");
                        WriteLine("Sector laboral: Privado.\nEdad: 24.\nOcupación: Jardinero.\nSalario: RD$ 12 mil.");                        

                        Salir();
                        break;
                    case "ddejesus":
                        WriteLine("Información de David De Jesús\n");
                        WriteLine("Sector laboral: Gobierno.\nEdad: 22.\nOcupación: Programador.\nSalario: RD$ 45 mil.");

                        Salir();
                        break;
                    case "ysosa":
                        WriteLine("Información de Yoscar Sosa\n");
                        WriteLine("Sector laboral: Privado.\nEdad: 25.\nOcupación: Supervisor.\nSalario: RD$ 40 mil.");

                        Salir();
                        break;
                    case "larias":
                        WriteLine("Información de Luis Arias\n");
                        WriteLine("Sector laboral: Gobierno.\nEdad: 28.\nOcupación: Analista de datos.\nSalario: RD$ 85 mil.");

                        Salir();
                        break;
                    case "fcaraballo":
                        WriteLine("Información de Freddy Caraballo\n");
                        WriteLine("Sector laboral: Privado.\nEdad: 20.\nOcupación: Programador.\nSalario: RD$ 30 mil.");

                        Salir();
                        break;
                    case "jpaula":
                        WriteLine("Información de Joelvin Paula\n");
                        WriteLine("Sector laboral: Privado.\nEdad: 22.\nOcupación: Operador.\nSalario: RD$ 33 mil.");

                        Salir();
                        break;
                }
            }
            else
            {
                WriteLine("ERROR DE CREDENCIALES :(");
                Salir();
            }

        }

        private static void Salir()
        {
            Write("\nPulsa una tecla para salir >");
            ReadKey();
            Environment.Exit(0);
        }

    }
}
