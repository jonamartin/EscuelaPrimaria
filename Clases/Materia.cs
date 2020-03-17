using System;
using System.Collections.Generic;
using Nueva_carpeta;

public class Materia 
{
    string nombre;

    public Materia()
    {
        
    }
    public Materia(string nombre)
    {
        this.nombre = nombre;
    }
    public int evaluar()
    {
        Random not = new Random();
        int nota = not.Next(1,10);
        return nota;
    }
}