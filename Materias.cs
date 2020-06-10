using System;
using System.IO;

namespace Notas 
{
    class Materias {
        string nombreArchivo ="";

        public Materias(string nombreArchivo) {
            this.nombreArchivo =  nombreArchivo;
        }

        public void Agregarmaterias() {
           System.Console.WriteLine("Agregar materias");
           string materias = Console.ReadLine();
        }
    }
}
