using System;

namespace variablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCupsOfCoffee = 3;
            string fullName = "Megan Lukes";
            var today = DateTime.Now;
            var currentMonth = today.Month;
            var currentDay = today.Day;
            var currentYear = today.Year;

            Console.WriteLine($"I am known as {fullName}, today is {currentMonth}/{currentDay}/{currentYear}, and I only need {numberOfCupsOfCoffee} cups of coffee to rule the world!");
            Console.Write("Tell me your name, mortal.   ");
            string userName = Console.ReadLine();
            string alice = "Alice";
            if (alice.Equals(userName))
            {
                Console.Write("My mortal enemy's name is Alice, you must be her follower! But before I send you to the dungeon,");
            }
            else
            {
                Console.Write($"Well, {userName}, bow down before me or be annihilated! Now,");
            }
            Console.Write(" my consort needs to practice arithmetic. Pick a number.   ");
            string firstNumberAsString = Console.ReadLine();

            Console.Write("Pick another number.   ");
            string secondNumberAsString = Console.ReadLine();
            double firstOperand = double.Parse(firstNumberAsString);
            double secondOperand = double.Parse(secondNumberAsString);
            var sum = firstOperand + secondOperand;
            var difference = firstOperand - secondOperand;
            var product = firstOperand + secondOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = firstOperand % secondOperand;
            Console.WriteLine("");
            Console.WriteLine($"My consort claims that if you combine {firstOperand} and {secondOperand}, you get {sum}.");
            Console.WriteLine($"The difference between {secondOperand} and {firstOperand} is {difference}.");
            Console.WriteLine($"If you multiply {firstOperand} and {secondOperand} you get {sum}.");
            Console.WriteLine($"If you divide {firstOperand} by {secondOperand} you get {quotient}.");
            Console.WriteLine($"If you take the remainder of {firstOperand} and {secondOperand} you get {remainder}.");
            Console.WriteLine("If I find out he is mistaken he will be off to the dungeon, along with the followers of Alice!");
        }
    }
}
