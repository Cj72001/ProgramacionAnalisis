using System;

// Las llaves {} marcan el comienzo y el final de un bloque de código.
namespace HelloWorld
{
  class Program
  {
    //  Todo lo que contenga el metodo "Main" se ejecuta en consola 
    //  al correr la console app
    static void Main(string[] args)
    {
      // Usando metodo que imprime en consola en la misma linea(Write)
      Console.Write("Usando metodo que imprime en consola en la misma linea(Write): ");
      Console.Write("Hello World! ");
      Console.Write("Hello World! ");


      // Usando metodo que imprime en consola (WriteLine) y hace un salto de linea (al final)
      Console.WriteLine("");
      Console.WriteLine("-------------------------");
      Console.WriteLine("Usando metodo que imprime en consola en la siguiente linea(WriteLine): ");
      Console.WriteLine("Hello World!");

      // Cada instruccion de C# termina con un punto y coma ;
      // Puedes usar '+' para concatenar textos y variables
      Console.WriteLine("Hello World!" + " Bye World!");
      Console.WriteLine("Hello World!");

      // Imprime el resultado de la suma
      Console.WriteLine("Resultado de suma: " + (1+2) ); 


    }
  }
}