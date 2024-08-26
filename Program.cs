using System;

namespace Csharp
{
    internal class Domingo()
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*******MAIN******");
            //Ejercicio1();
            Ejercicio2();
            //Ejercicio3();
            //Ejercicio4();
            //Ejercicio5_1();
            //Ejercicio6();
        }
        public static void Ejercicio1()
        {
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Hola Mundo");
        }

        public static void Ejercicio2()
        {
            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("Escriba su nombre: ");
            var name = Console.ReadLine();
            Console.WriteLine("Escriba su apellido: ");
            var lastname = Console.ReadLine();
            Console.WriteLine("Escriba su edad: ");
            var age = Console.ReadLine();
            Console.WriteLine("Escriba su pais: ");
            var country = Console.ReadLine();


            Console.WriteLine("Mi nombre completo es " + name + " " + lastname);
            Console.WriteLine("Tengo " + age + " y nací en " + country);
        }

        public static void Ejercicio3()
        {
            Console.WriteLine("Ejercicio 3");
            Console.WriteLine("Escriba su nombre: ");
            var name = Console.ReadLine();
            Console.WriteLine("Escriba su apellido: ");
            var lastname = Console.ReadLine();
            Console.WriteLine("Escriba su edad: ");
            var age = Console.ReadLine();
            Console.WriteLine("Escriba su carrera: ");
            var carreer= Console.ReadLine();

            Console.WriteLine("Mi nombre completo es " + name + " " + lastname + " tengo "+age+ " años y estudio " +carreer);
            Console.WriteLine("Nombre: " + name);
            Console.WriteLine("Apellido: " + lastname);
            Console.WriteLine("Edad: " + age);
            Console.WriteLine("Carrera: " + carreer);
        }

        public static void Ejercicio4()
        {
            Console.WriteLine("Ejercicio 4");
            Console.WriteLine("Escriba la cantidad de materias de la Carrera de Lic. en Sistemas de información de las Organizaciones: ");
            var totalAmount = Console.ReadLine();
            Console.WriteLine("Escriba la cantidad de materias aprobadas: ");
            var totalApproved = Console.ReadLine();

            var classesLefts = int.Parse(totalAmount) - int.Parse(totalApproved);

            Console.WriteLine("Faltan " + classesLefts + " clases para aprobar");
            
        }

        public static void Ejercicio5()
        {
            Console.WriteLine("Ejercicio 5");
            Console.WriteLine("Ingresa el nùmero 1/4:");
            var firstNumber = Console.ReadLine();
            Console.WriteLine("Ingresa el nùmero 2/4:");
            var secondNumber = Console.ReadLine();
            Console.WriteLine("Ingresa el nùmero 3/4:");
            var thirdNumber = Console.ReadLine();
            Console.WriteLine("Ingresa el nùmero 4/4:");
            var fourthNumber = Console.ReadLine();

            //Console.WriteLine("Los nùmeros ingresados son: ");
            Console.WriteLine("Los nùmeros ingresados en orden inverso son: "
                + fourthNumber + " "+ thirdNumber + " "+ secondNumber + " "+ firstNumber );
        }

        public static void Ejercicio5_1()
        {
            Console.WriteLine("Ejercicio 5_1");
            Console.WriteLine("Ingresa la cantidad de números:");
            var amountOfNumbers = int.Parse(Console.ReadLine());
            
            int[] arrayNumbers  = new int[amountOfNumbers];

            for (int i = 0; i < amountOfNumbers; i++)
            {
                Console.WriteLine("Ingrese siguiente número: ");
                arrayNumbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Los nùmeros ingresados en orden inverso son:");
            for (int j = amountOfNumbers; j > 0; j--)
            {
                Console.WriteLine(arrayNumbers[j-1]);
            }


        }

        public static void Ejercicio6()
        {
            Console.WriteLine("Ejercicio 6");
        }

    }
}





