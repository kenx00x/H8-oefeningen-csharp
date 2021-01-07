using System;

namespace Vraag_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vragen = {"Hoe oud ben je?","Wat is je postcode?","Hoeveel broers heb je?","Hoeveel zussen heb je","Wanneer ben je geboren?","Hoeveel is 3+5"};
            int[] antwoorden = new int[vragen.Length];
            for (int i = 0; i < vragen.Length; i++)
            {
                Console.WriteLine(vragen[i]);
                antwoorden[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Je antwoorden:");
            for (int i = 0; i < vragen.Length; i++)
            {
                Console.WriteLine($"{vragen[i]}: {antwoorden[i]}");
            }
        }
    }
}