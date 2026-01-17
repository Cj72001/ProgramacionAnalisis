using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
        {
            // Operadores aritméticos
            int a = 10;
            int b = 3;
            
            Console.WriteLine("Suma: " + (a + b));          // 13
            Console.WriteLine("Resta: " + (a - b));         // 7
            Console.WriteLine("Multiplicación: " + (a * b)); // 30
            Console.WriteLine("División: " + (a / b));      // 3
            Console.WriteLine("Módulo: " + (a % b));        // 1
            Console.WriteLine();

            // Operadores de asignación
            int c = 5;

            // Operadores de comparación
            Console.WriteLine("Igualdad: " + (a == b));          // False
            Console.WriteLine("Desigualdad: " + (a != b));       // True
            Console.WriteLine("Mayor que: " + (a > b));         // True
            Console.WriteLine("Menor que: " + (a < b));         // False
            Console.WriteLine("Mayor o igual que: " + (a >= b)); // True
            Console.WriteLine("Menor o igual que: " + (a <= b)); // False
            Console.WriteLine();

            // Ejemplo práctico
            int d = 3; 

            bool esIgual = (b == d);
            Console.WriteLine("esIgual: " + esIgual); 

            // Ejemplo práctico 2
            int edadMinima = 18;

            Console.WriteLine("Ingresar edad:");
            int edadUsuario = int.Parse(Console.ReadLine());

            bool esMayorDeEdad = (edadUsuario >= edadMinima);

            Console.WriteLine("¿Es mayor de edad?: " + esMayorDeEdad);

            // Operadores lógicos
            Console.WriteLine("Operador AND: " + ( (5==5) && (5 >= 1) ) ); // True (&& ambos operadores tienen que devolver verdaderas para que && devuelva true y viceversa)
            Console.WriteLine("Operador OR: " + ( (5==5) || (5 == 1) ) );  // True (|| al menos un operador tiene que devolver verdadera para || devuelva true)
            Console.WriteLine("Operador NOT: " + (! (5==5) ));            // False

            // Ejemplo práctico 3
            int edadMaximaJubilacionHombre = 60;
            int edadMaximaJubilacionMujer = 55;

            char generoMasculino = 'M';
            char generoFemenino = 'F';

            Console.WriteLine("Ingresar edad:");
            int edadPersona1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar género (M/F):");
            char generoPersona = Char.Parse(Console.ReadLine());

            bool esHombre = (generoPersona == generoMasculino);
            bool seJubilaHombre = edadPersona1 >= edadMaximaJubilacionHombre;

            bool esMujer = (generoPersona == generoFemenino);
            bool seJubilaMujer = edadPersona1 >= edadMaximaJubilacionMujer;

            bool seJubila = ( (esHombre && seJubilaHombre) || (esMujer && seJubilaMujer) );   

            Console.WriteLine("¿Se jubila?: " + seJubila);

            Console.WriteLine("----------------------------------------------------------------------------------");

            // Ejercicio practico final
            // Hacer un programa que diga si una persona puede subirse a una montaña rusa.
            // La persona debe tener al menos 12 años, medir más de 1.40 metros y no tener enfermedades del corazón.

            int edadApta = 12;
            double estaturaApta = 1.40;
            string padeceEnfermedad = "Si";
            string noPadeceEnfermedad = "No";
            
            Console.WriteLine("Ingresar edad:");
            int edadPersona = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingresar estatura:");
            double estaturaPersona = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Padece del corazon:");
            string padecimiento = Console.ReadLine();
            
            bool edadOptima = (edadPersona>=edadApta);
            bool estaturaOptima = (estaturaPersona > estaturaApta);
            bool Fisico = (edadOptima && estaturaOptima);
            bool siPadece = (padecimiento == padeceEnfermedad);
            bool noPadece = (padecimiento == noPadeceEnfermedad);
            
            bool seSube = (Fisico && noPadece);
            
            Console.WriteLine("¿Se sube?: " + seSube);



        }
  }
}