using System.Runtime.CompilerServices;

namespace Topic_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            int yearBorn;
            Console.WriteLine("Hello! What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            yearBorn = 2023 - age;
            Console.WriteLine("You were born in " + yearBorn + " (Not counting your birth month)");
            Console.WriteLine();


            int total = 0;
            Console.WriteLine("Write 3 Intergers,");
            total += Convert.ToInt32(Console.ReadLine());
            total += Convert.ToInt32(Console.ReadLine());
            total += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Adding all the numbers get you to: " + total);
            Console.WriteLine();

            double distance1 = 0;
            double distance2 = 0;
            double distance3 = 0;
            double averageDistance = 0;
            Console.Write("What's the distance to London. (km) : ");
            distance1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("What's the distance to Grand Bend. (km) : ");
            distance2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("What's the distance to Toronto. (km) : ");
            distance2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            averageDistance = (distance1 + distance2 + distance3) / 3;
            Console.WriteLine("The average distance from each location is " + Math.Round(averageDistance,2) + "km");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("|\\");
            Console.WriteLine("| \\");
            Console.WriteLine("|  \\");
            Console.WriteLine("|   \\");
            Console.WriteLine("|    \\");
            Console.WriteLine("|     \\");
            Console.WriteLine("|      \\");
            Console.WriteLine("|       \\");
            Console.WriteLine("|        \\");
            Console.WriteLine("|         \\");
            Console.WriteLine("|          \\");
            Console.WriteLine("|           \\");
            Console.WriteLine("|            \\");
            Console.WriteLine("|             \\");
            Console.WriteLine("|              \\");
            Console.WriteLine("|_______________\\");
            Console.WriteLine();
            Console.Write("What is the length of the adjacent (inches): ");
            double adj = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the length of the opposite (inches): ");
            double opp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double hyp = Math.Sqrt(adj * adj + opp * opp);
            Console.WriteLine("The hypotenus is " + Math.Round(hyp,2) + " inches");

        }
    }
}