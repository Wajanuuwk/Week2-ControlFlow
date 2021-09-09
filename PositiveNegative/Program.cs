using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kasutajal palub sisestada numbrit - 10 kuni 10
            //programm kontrollib numbrit
            //kui number on positiivne, konsool kuvab "positive"
            //kui number on negatiivne, konsool kuvab "negative"
            //kui number on 0, siis konsool kuvab "null"
            
            Console.WriteLine("Sisesta number -10 kuni 10");

            int number = Convert.ToInt32(Console.ReadLine());


            if (number < 0)
            {
               Console.WriteLine("negatiivne.");
            }
            
            else if (number > 0)
            {
               Console.WriteLine("positiivne");
            }
            else
            {
               Console.WriteLine("null");
            }


        }
    }
}
