using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      // Entrada de datos por consola
      // Nota: El valor ingresado no se almacena en una variable, por lo que no se puede utilizar posteriormente.
      Console.WriteLine("Por favor, ingresa tu nombre (only read):");
      Console.ReadLine();

      // Almacenar el valor ingresado en una variable
      // Nota: Los valores ingresados por consola son siempre de tipo string.
      Console.WriteLine("Por favor, ingresa tu nombre:");
      string nombreUsuario = Console.ReadLine();

      Console.WriteLine("Por favor, ingrese su anio de nacimiento:");
      string anioNacimientoUsuario = Console.ReadLine();

      int anioActual = 2026;
      int anioNacimiento = int.Parse(anioNacimientoUsuario);
      int edadusuario = anioActual - anioNacimiento;

      // Mostrando el valor almacenado en las variables
      Console.WriteLine("El nombre del usuario es: "+ nombreUsuario);
      Console.WriteLine("La edad del usuario es: " + edadusuario);





    }
  }
}