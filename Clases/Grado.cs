using System;
using System.Collections.Generic;
using Nueva_carpeta;

class Grado : Program
{
    public Grado(int grado)
    {
        List<Alumno> Alumnos = new List<Alumno>();
        for (int i = 0; i<20; i++)
        {
            Alumnos.Add(new Alumno());
        }
    }
}