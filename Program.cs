/*
Método Principal
Para probar tu implementación, puedes usar un archivo de programa separado con el método Main.
 Puedes crear un archivo llamado Program.cs y agregar el siguiente código:

*/
using System;

class Program   //class Program: Esto define una nueva clase llamada Program. En C#, la ejecución del programa comienza en el método llamado Main de una clase.
{
    static void Main()//static void Main(): Este es el punto de entrada de tu programa. Es el primer método que se ejecuta cuando el programa se inicia.
    // static significa que el método pertenece a la clase Program en lugar de a una instancia específica de esa clase. void indica que el método no devuelve ningún valor.
    {
        /*
        Console.WriteLine("Ingrese el primer operando:");: 
        Este comando imprime el texto entre comillas en la consola, pidiendo al usuario que ingrese el primer número.
        */
        Console.WriteLine("Ingrese el primer operando:");
        double operando1 = Convert.ToDouble(Console.ReadLine());
        /*
        double operando1 = Convert.ToDouble(Console.ReadLine());: Aquí estamos obteniendo una entrada del usuario a través de Console.ReadLine(), 
        que obtiene una cadena de texto. Luego, Convert.ToDouble(...) convierte esa cadena en un número de tipo double y lo asigna a la variable operando1.

        */

        Console.WriteLine("Ingrese el segundo operando:");
        double operando2 = Convert.ToDouble(Console.ReadLine());//El proceso se repite para operando2 y operacion.

        Console.WriteLine("Ingrese la operación (+, -, *, /):");
        string operacion = Console.ReadLine();

        Calculadora calculadora = null;  //Calculadora calculadora;: Esto declara una variable de tipo Calculadora. 
        //Calculadora es la clase base que utilizamos para realizar operaciones.

/*
El siguiente bloque de código utiliza un switch para determinar qué tipo de operación realizar en función de la entrada del usuario (operacion).
 Dependiendo del caso, se crea una instancia de la clase correspondiente (Suma, Resta, etc.) y se asigna a la variable calculadora.
*/
        switch (operacion)
        {
            case "+":
                calculadora = new Suma();
                break;
            case "-":
                calculadora = new Resta();
                break;
            case "*":
                calculadora = new Multiplicacion();
                break;
            case "/":
                calculadora = new Division();
                break;
            default:
                Console.WriteLine("Operación no válida.");
                return;
        }
        //double resultado = calculadora.Operacion(operando1, operando2);: Aquí llamamos al método Operacion de la calculadora seleccionada, 
        //pasando los operandos como argumentos. El resultado de la operación se guarda en la variable resultado.

         double resultado = 0;
        /*
        Console.WriteLine($"El resultado de {operando1} {operacion} {operando2} es {resultado}");: Finalmente,
         se imprime el resultado en la consola utilizando una interpolación de cadenas para combinar los valores de las variables con texto.

        */
        

      if (calculadora != null)
        {
            if (calculadora is Suma && operacion == "+")
            {
                Suma suma = (Suma)calculadora;
                Console.WriteLine("Ingrese el tercer operando:");
                double operando3 = Convert.ToDouble(Console.ReadLine());
                resultado = suma.Operacion(operando1, operando2, operando3);
            }
            else if (calculadora is Resta && operacion == "-")
            {
                Resta resta = (Resta)calculadora;
                Console.WriteLine("Ingrese el tercer operando:");
                double operando3 = Convert.ToDouble(Console.ReadLine());
                resultado = resta.Operacion(operando1, operando2, operando3);
            }
            else if (calculadora is Multiplicacion && operacion == "*")
            {
                Multiplicacion multiplicacion = (Multiplicacion)calculadora;
                Console.WriteLine("Ingrese el tercer operando:");
                double operando3 = Convert.ToDouble(Console.ReadLine());
                resultado = multiplicacion.Operacion(operando1, operando2, operando3);
            }
            else if (calculadora is Division && operacion == "/")
            {
                Division division = (Division)calculadora;
                Console.WriteLine("Ingrese el tercer operando:");
                double operando3 = Convert.ToDouble(Console.ReadLine());
                resultado = division.Operacion(operando1, operando2, operando3);
            }
            else
            {
                Console.WriteLine("Operación no válida para tres operandos.");
            }
        }

        Console.WriteLine($"El resultado de {operando1} {operacion} {operando2} es {resultado}");
    }
    }

/*
En resumen, este programa le pide al usuario que ingrese dos operandos y la operación que desea realizar. Luego, utiliza un objeto 
Calculadora (que puede ser de cualquier tipo derivado, como Suma, Resta, etc.) para realizar la operación y mostrar el resultado en la consola.

*/



//**********************************************************************************************************************************************


   





