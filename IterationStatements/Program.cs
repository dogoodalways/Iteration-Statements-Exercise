using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000






        //public static void PrintThousand()
        //{
        //    for (int i = 1000; i >= -1000; i--)
        //    {
        //        Console.WriteLine(i);   
        //    }
        //}
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        //public static void Three()
        //{
        //    for (int k = 3; k <= 999; k += 3)
        //    {
        //        Console.WriteLine(k);
        //    }
        //}

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        //public static bool Same(int a, int b)
        //{
        //    var check = (a == b) ? true: false;
        //    return check;

        //}
        //Write a method to check whether a given number is even or odd
        //public static string NumberType (int a)
        //{
        //    var number = (a%2 == 0) ? "Even" : "Odd";
        //    return number;
        //}
        //Write a method to check whether a given number is positive or negative
        //public static string Positive(int x) 
        //{
        //    var numberKind = (x >= 1) ? "Positive" : "Negative";

        //    return numberKind;
        //} 
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        //public static string EligibleVote()
        //{
        //    Console.WriteLine("How old are you?");
        //    var answer = int.Parse(Console.ReadLine());
        //    var status =  (answer) >= 21 ? "Can Vote!" : "Can't Vote";
        //    return status;

        //}
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        //public static string Range()
        //{
        //    Console.WriteLine(" Please write a number.");
        //    var number = int.Parse(Console.ReadLine());
        //    var fit = (number >= -10 && number <= 10) ? "You chose a good number" : "Try another number";

        //    return fit;
        //}
        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void Multiply()
        {
            int number, multiplier;
            Console.WriteLine("Please chose a number");
            number = int.Parse(Console.ReadLine());
            
            for(multiplier = 1; multiplier<= 12; multiplier++) 
            {
                Console.WriteLine($"{number} * {multiplier} = {number * multiplier}");
            }

           
        } 
       
               
            
              


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //PrintThousand();
            //Three();
            //Console.WriteLine(Same(1, 2));
            //Console.WriteLine(NumberType(6));
            //Console.WriteLine(Positive(-10));
            //Console.WriteLine(Range());
            Multiply();
        }
    }
}
