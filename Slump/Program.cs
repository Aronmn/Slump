using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slump
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1

            Console.WriteLine("Programmet slumpar fram 10 tal mellan 1-20");
            Random slump = new Random();
            var sum = 0;
            for (int i = 0; i < 10; i++) 
            {
                int tal = slump.Next(21);
                Console.WriteLine(tal + " ");
                sum = sum + tal;
            }
            Console.WriteLine("Medelvärdet är " + (sum/10));

            //Övning 2

            Console.WriteLine("Programmet slumpar fram 20 tal mellan 15-30 och beräknar medianvärdet");
            Random slump1 = new Random();
            int[] tal1 = new int[20];

            for (int i = 0; i < 20; i++)
            {
                tal1[i] = slump1.Next(15, 31);
                Console.Write(tal1[i] + " ");
            }

            Console.WriteLine("Medianen är ");
            Array.Sort(tal1);

            for (int i = 0; i < 20; i++)
            {
                 Console.Write(tal1[i] + " ");
                
            }
            Console.Write((tal1[9] + tal1[10])/2);

        }
    }
}
