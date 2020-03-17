using System;
using System.Collections.Generic;
using Nueva_carpeta;

class Alumno
{
    public List<int> notasMa {get; set;} = new List<int>();
    public List<int> notasLe {get; set;} = new List<int>();
    public List<int> notasEF {get; set;} = new List<int>();
    public List<int> notasMu {get; set;} = new List<int>();
    public Alumno ()
    {
        Materia eval = new Materia();
        for (int i=0; i<3; i++)
        {
            notasEF.Add(eval.evaluar());
            notasLe.Add(eval.evaluar());
            notasMu.Add(eval.evaluar());
            notasMa.Add(eval.evaluar());
        }
    }
}