using System;

namespace Boleta_de_calificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
           Libreta Libreta = new Libreta("notas.txt");

           int opcion = 0;
           while (opcion ! =9) {
               System.Console.WriteLine("");
               System.Console.WriteLine("1) Capturar nombre del alumno");
               System.Console.WriteLine("2) Borrar información de alumnos");
               System.Console.WriteLine("3) Capturar materias");
               System.Console.WriteLine("4) Borrar información de las materias");
               System.Console.WriteLine("9) Salir");
               System.Console.WriteLine("Seleccione una opcion");

               opcion = Convert.ToInt32(Console.ReadLine());

               switch(opcion) {
                   case 1:
                   Libreta.Capturarnombredelalumno();
                   break;
                
                   case 2:
                   Libreta.Borrarinformacióndealumnos();
                   break;

                   case 3:
                   Libreta.Capturarmaterias();
                   break;

                   case 4:
                   Libreta.Borrarinformacióndealumnos();
                   break;
               }

           }

        }
    }
}
