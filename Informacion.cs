using System;
using System.IO;

namespace Libreta 
{
    class Informacion {
        string nombreArchivo = "";

        public Informacion(string nombreArchivo) {
            System.Console.WriteLine("Agregar nombre completo");
            string nota = System.Console.ReadLine;

            bool append = true;
            using (var file = new StreamWriter(this.nombreArchivo, append)) {
                 file.WriteLine(nota);
            }
            System.Console.WriteLine("Nombre agregada");
        }
    public void Borrarnotas() {
        System.Console.WriteLine("Borrar Nombre");
            bool append = false;
            using (var file = new StreamWriter(this.nombreArchivo, append)) {
                file.WriteLine("");
            }
            System.Console.WriteLine("Nombre borrado");
       }
    }
}