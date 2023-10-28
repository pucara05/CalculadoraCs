// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*Paso 1: Crear la Clase Base
Primero, crea una clase base llamada Calculadora que tenga un método llamado Operacion. Este método servirá 
como un esquema para las operaciones específicas que implementarás en las clases derivadas.

*/

public class Calculadora
{
    public virtual double Operacion(double operando1, double operando2)
    {
        return 0; // Este valor no tiene significado aquí, pero lo sobrescribiremos en las clases derivadas.
    }
}


