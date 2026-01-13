using System;
using System.Diagnostics.Contracts;

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
        string cadenaTexto2 = "Valor del entero 1: ";
        Console.WriteLine(cadenaTexto2 + numeroEntero1);

        // Aumentando el valor de una variable
        numeroEntero1 = numeroEntero1 + 15; 

        cadenaTexto2 = cadenaTexto2 + " :";
        Console.WriteLine(cadenaTexto2 + numeroEntero1);

        // optimizando impresiones:
        string cadenaDeTexto3 = "Valor de la variable de tipo ";
        string cadenaDeTexto4 = cadenaDeTexto3 + "entero 1: ";
        string cadenaDeTexto5 = cadenaDeTexto3 + "entero 1 mas entero 2: ";
        string cadenaDeTexto6 = cadenaDeTexto3 + "float: ";
        string cadenaDeTexto7 = cadenaDeTexto3 + "char: ";
        string cadenaDeTexto8 = cadenaDeTexto3 + "string: ";
        string cadenaDeTexto9 = cadenaDeTexto3 + "booleano 1: ";
        string cadenaDeTexto10 = cadenaDeTexto3 + "booleano 2: ";

        Console.WriteLine(cadenaDeTexto4 + numeroEntero1);
        Console.WriteLine(cadenaDeTexto5 + (numeroEntero1 + numeroEntero2));
        Console.WriteLine(cadenaDeTexto6 + numeroDecimal1);
        Console.WriteLine(cadenaDeTexto7 + caracter1);
        Console.WriteLine(cadenaDeTexto8 + cadenaTexto1);
        Console.WriteLine(cadenaDeTexto9 + booleano1);
        Console.WriteLine(cadenaDeTexto10 + booleano2);

        // Constantes
        const int edadMinima = 18;

        Console.WriteLine("La edad mínima es: " + edadMinima);

        // ----------------------------------------------------------------------------------------------------
        // Casting (Conversiones entre tipos de datos)
        int numeroEnteroCasting = 100;

        // Conversion implicita 
        double numeroDecimalCasting = numeroEnteroCasting; // De int a double

        Console.WriteLine("Valor del double despues del casting implicita: " + numeroDecimalCasting);

        // Conversion explicita
        double numeroDecimalCasting2 = 9.78;
        int numeroEnteroCasting2 = (int)numeroDecimalCasting2; // De double a int

        Console.WriteLine("Valor del int despues del casting explicita: " + numeroEnteroCasting2);

        // Conversion usando metodos de la clase Convert
        string numeroCadena = "123";
        int numeroEnteroParseado1 = Convert.ToInt32(numeroCadena); // De string a int
        int numeroEnteroParseado2 = int.Parse(numeroCadena); // De string a int

        string numeroCadenaDecimal = "123.45";
        double numeroDecimalParseado = Convert.ToDouble(numeroCadenaDecimal); // De string a double
        double numeroDecimalParseado2 = double.Parse(numeroCadenaDecimal); // De string a double

        Console.WriteLine("Valor del int despues de Convert.ToInt32: " + numeroEnteroParseado1);
        Console.WriteLine("Valor del int despues de int.Parse: " + numeroEnteroParseado2);
        Console.WriteLine("Valor del double despues de Convert.ToDouble: " + numeroDecimalParseado);
        Console.WriteLine("Valor del double despues de double.Parse: " + numeroDecimalParseado2);


    }
  }
}