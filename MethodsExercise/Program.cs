namespace MethodsExercise
{
    using System.Collections.Generic;
    using System.Security.Cryptography.X509Certificates;

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey, how old are you");
            var ageInput = Console.ReadLine();
            if (int.TryParse(ageInput, out int age)) {
                Console.WriteLine("that must mean that you were born in " + (2023-age));
            }
            else
            {
                Console.WriteLine("you were supposed to type an integer");
            }

            Console.WriteLine("Heres a Mad-Lib for you");
            Console.WriteLine("Give me a noun");
            var noun = Console.ReadLine();
            Console.WriteLine("Give me a color");
            var color = Console.ReadLine();
            Console.WriteLine("Give me a noun");
            var nounTwo = Console.ReadLine();
            Console.WriteLine("Give me a number");
            var count = Console.ReadLine();
            Console.WriteLine("Give me a noun");
            var nounThree = Console.ReadLine(); 
            Console.WriteLine($"The {noun} walked over the {color} {nounTwo} while eating {count} {nounThree}s");

            Console.WriteLine("\n\nOk, that MadLibs is done, now I'll let you test me on some math");
            Console.WriteLine("Give me an operator (please give + or *)");
            var operators = Console.ReadLine();
            Console.WriteLine("Now how many numbers will I calculate");
            var numNumbers = Console.ReadLine();
            int counter;
            char opp;
            try{
                counter = int.Parse(numNumbers);
            }
            catch(Exception){
                counter = 0;
            }

            try
            {
                opp = char.Parse(operators);
            }
            catch (Exception)
            {
                opp = '+';
            }

            int[] numVals = new int[counter];
            for(int i = 0; i<counter; i++)
            {
                Console.WriteLine("give me an integer");
                numVals[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The answer is: " + DoMathOpp(opp, numVals));


            
            }
        static int DoMathOpp(char opps, params int[] nums)
        {
            int totalNum = nums[0];
            if (opps == '+') {
                for (int num = 1; num < nums.Length; num++) {
                    totalNum += nums[num];
                }
            }
            if(opps == '*')
            {
                for (int num = 1; num < nums.Length; num++){
                    totalNum *= nums[num];
                }
            }
            return totalNum;
        }

    }
}
