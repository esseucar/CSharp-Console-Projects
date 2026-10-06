namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number= new Random().Next(1,101);
            int GuessRigth = 10;
            int userNumber = int.Parse(Console.ReadLine());
            while (userNumber!= number)
            {
                if (Math.Abs(userNumber - number) < 10)
                {
                    Console.WriteLine("So close, try again");
                }
                else
                {
                    Console.WriteLine("Far,try again");
                }
                userNumber = int.Parse(Console.ReadLine());
                GuessRigth--;
                if (GuessRigth < 1)
                {
                    Console.WriteLine("Your guess right is over");
                    break;
                }
                if (number == userNumber)
                { 
                    Console.WriteLine("Congrats!");
                }
            }
            

           Console.ReadLine(); 
        }
    }
}
