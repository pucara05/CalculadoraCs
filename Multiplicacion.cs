/*
Paso 2: Crear Clases Derivadas
A continuación, crea clases derivadas para cada una de las operaciones: suma, resta, multiplicación y división. 
Estas clases heredarán de la clase Calculadora y sobrescribirán el método Operacion.

*/


public class Multiplicacion : Calculadora
{
    public override double Operacion(double operando1, double operando2)
    {
        return operando1 * operando2;
    }

     public double Operacion(double operando1, double operando2, double operando3)
    {
        return operando1 * operando2 * operando3;
    }
    
}
