using System;

namespace CSharp_Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string inkPen = "Pilot";
            int penNumber = 2;
            char penLetter = 'G';
            bool havePen = true;
            double penDiameter = 0.07;
            decimal penDepletion = 50.00m;

            Console.WriteLine($"It is {havePen} that I have a pen on my desk. It is an {penDiameter}mm {inkPen} {penLetter} - {penNumber}, and it is about {penDepletion}% empty.");


        }
    }
}
