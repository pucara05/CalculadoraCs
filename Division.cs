/*



*/


public class Division : Calculadora
{
    public override double Operacion(double operando1, double operando2)
    {
        if (operando2 != 0)
        {
            return operando1 / operando2;
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
            return double.NaN; // Devolvemos NaN (Not a Number) para indicar un resultado no válido.
        }
    }


    public double Operacion(double operando1, double operando2, double operando3)
    {
        if (operando2 != 0 && operando3 != 0)
        {
            return operando1 / operando2 / operando3;
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
            return double.NaN;
        }
    }
}