using System;

namespace Anteckningar
{
    class Program
    {
        static void Main(string[] args)
        {
            Football theBall = new Football();
            Football otherBall = new Football();


            theBall.x = 100;

            System.Console.WriteLine(otherBall.x);

            Console.ReadLine();
        }
    }
}
