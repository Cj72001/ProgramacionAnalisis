using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
        // Estructura de declaración de variables
        // TipoDeDato NombreVariable;

        // Estructura de declaración e inicializacion de variables
        // TipoDeDato NombreVariable = ValorQueAlmacenaLaVariable;

        // Tipos de variables en C#
        // Entero (int)
        int numeroEntero1 = 0;
        int numeroEntero2 = 1;
        int numeroEntero3 = 2;
        int numeroEntero4 = -3;
      
        // Decimal (float, double, decimal)
        float numeroDecimal1 = 0.5f; // (float) se utiliza para representar números con decimales de precisión simple
        double numeroDecimal2 = 0.0d; // (double) es el tipo de dato decimal por defecto en C#
        decimal numeroDecimal3 = 0.0m; // (decimal) es utilizado principalmente para valores monetarios

        // Carácter (char)
        char caracter1 = 'A';

        // Cadena de texto (string)
        string cadenaTexto1 = "Hola, Mundo!";

        // Booleano (bool)
        bool booleano1 = true;
        bool booleano2 = false;

        // Mostrar los valores de las variables en la consola
        Console.WriteLine("Valor del entero 1: " + numeroEntero1);
        Console.WriteLine("Valor de la suma de entero 1 y entero 2: " + (numeroEntero1 + numeroEntero2));
        Console.WriteLine("Valor del float: " + numeroDecimal1);
        Console.WriteLine("Valor del char: " + caracter1);
        Console.WriteLine("Valor del string: " + cadenaTexto1);
        Console.WriteLine("Valor del booleano 1: " + booleano1);
        Console.WriteLine("Valor del booleano 2: " + booleano2);

        // Reasignación de valores a las variables
        // nombreVariable = NuevoValor;
        numeroEntero1 = 10;
        string cadenaTexto2 = "Valor del entero 1:";
        Console.WriteLine(cadenaTexto2 + numeroEntero1);

    }
  }
}