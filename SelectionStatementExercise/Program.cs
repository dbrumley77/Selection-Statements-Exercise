namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Excercise1(); 


        }

        public static void Excercise1()
        {


            int favNumber = 260;
            Console.WriteLine("Please guess my favorite number between 1 and 1000: ");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favNumber)

            {
                Console.WriteLine("To Low");
            }

            else if (userGuess > favNumber)

            {
                Console.WriteLine("To High");
            }

            else

            {
                Console.WriteLine("Just Right!");
            }

    
        }

    




    }


}

 