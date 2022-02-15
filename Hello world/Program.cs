using System;

namespace Hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] cars=new string[4];
            int i = 0, aantal,som=0;
            

            Console.Write("Dit programma leest en print elementen van een array \n");
            Console.Write("______________________________________________________\n\n");
            Console.Write("Hoeveel merken wil je ingeven? ");

            aantal=Convert.ToInt32(Console.ReadLine());

            int[] cars=new int[aantal];
            int[] cars2 = new int[aantal];

            Console.Write("Lees "+ aantal + " automerken in: \n");
            
            for(i=0; i<aantal; i++)
            {
                Console.Write("element -" + i + ": ");
                cars[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nDe elementen in de array zijn: ");
            for (i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.WriteLine("\nEn dan nu de array in de omgekeerde volgorde: \n");
            for (i=aantal-1; i>=0 ;i-- )
            {
                Console.WriteLine(cars[i]);
               
            }

            Console.WriteLine("\ndan nu de som: ");
            for (i = 0; i < aantal; i++)
            {
                som += cars[i];           
            }
            Console.WriteLine(som);

            Console.WriteLine("\ncopy van cars1 naar cars2: \n");
            for(i=0;i<aantal;i++)
            {
                cars2[i] = cars[i];
                Console.WriteLine(cars2[i]);
            }
        }
    }
}
