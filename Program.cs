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

        }
    }
}
