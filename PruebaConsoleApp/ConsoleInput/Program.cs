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
      string anioNacimientoInput = Console.ReadLine();

      int anioActual = 2026;
      int anioNacimientoParse = int.Parse(anioNacimientoInput);
      int edadusuario = anioActual - anioNacimientoParse;

      // Mostrando el valor almacenado en las variables
      Console.WriteLine("El nombre del usuario es: "+ nombreUsuario);
      Console.WriteLine("La edad del usuario es: " + edadusuario);
      
      // Ejercicio:
        // Pedir al usuario que ingrese Nombre, anio, dia y mes de nacimiento (formato numerico)
        // e imprime nombre, edad, calculo dia, calculo mes
        // Ej:
        // Omar, 24, 0, 0 
        // Quiere decir que si los dos ultimos numero son 0, tiene el anio cumplido, sino el primer numero es el anio a cumplir
        
        Console.WriteLine("----Ejercicio de consola----");
        const int anioActualConst = 2026;
        const int diaActualConst = 13;
        const int mesActualConst = 01;
        
        Console.WriteLine("Por favor, ingresa tu nombre:");
        string nombreUsuarioInput = Console.ReadLine();
        
        Console.WriteLine("Por favor ingrese su anio de nacimiento");
        string anioNacimientoUsuarioInput = Console.ReadLine();
        int anioNacimientoParse2 = int.Parse(anioNacimientoUsuarioInput);
        int edadUsuario = anioActualConst - anioNacimientoParse2;
        
        Console.WriteLine("Por favor ingrese su dia de nacimiento");
        string diaNacimientoUsuarioInput = Console.ReadLine();
        int diaNacimientoParse = int.Parse(diaNacimientoUsuarioInput);
        int diaUsuarioRestante = diaActualConst - diaNacimientoParse;
        
        Console.WriteLine("Por favor ingrese su mes de nacimiento");
        string mesNacimientoUsuarioInput = Console.ReadLine();
        int mesNacimientoParse = int.Parse(mesNacimientoUsuarioInput);
        int mesUsuarioRestante = mesActualConst - mesNacimientoParse;
        
        
        Console.WriteLine("Respuesta: "+nombreUsuarioInput+","+ edadUsuario+","+diaUsuarioRestante+","+mesUsuarioRestante);




    }
  }
}