using System;
using System.Collections.Generic;

namespace Nueva_carpeta
{
    class Program
    {
        static void Main(string[] args)
        {
            Materia Ma = new Materia("Matematica");
            Materia Le = new Materia("Lengua");
            Materia Mu = new Materia("Musica");
            Materia EF =new Materia("Educacion fisica");
            List<Grado> grados = new List<Grado>();
          for (int i = 1; i <= 7; i++)
          {
              grados.Add(new Grado(i));
          }

            foreach(Grado gra in grados) {
                foreach(Alumno alu in gra.Alumnos)
                {
                    Console.WriteLine("Notas de Matematicas");
                    foreach(int nota in alu.notasMa){
                        Console.WriteLine(nota);
                    }
                    Console.WriteLine("Notas de Lengua");
                    foreach(int nota in alu.notasLe){
                        Console.WriteLine(nota);
                    }
                    Console.WriteLine("Notas de Musica");
                    foreach(int nota in alu.notasMu){
                        Console.WriteLine(nota);
                    }
                    Console.WriteLine("Notas de Educacion Fisica");
                    foreach(int nota in alu.notasEF){
                        Console.WriteLine(nota);
                    }
                    
                }
            }

        }
    }
}
