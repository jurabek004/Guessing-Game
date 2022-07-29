namespace FindGuessingNumber;

class Program
{
    static void Main(string[] args)
    {
        // Find Guess Number 
        Random rm = new Random();
        Console.WriteLine("Welcome to Guessing number game");
        Console.WriteLine("Now you should find guess number");
        int n;
        Console.Write("Enter the max range of guessing number : ");
        n = Convert.ToInt32(Console.ReadLine());
        int guessNum = rm.Next(0,n);
        int a, count = 0;

        Console.Write("Enter your number : ");
        a = Convert.ToInt32(Console.ReadLine());
        count++;
        if(guessNum == a)
            Console.WriteLine($"Congrats, you win in {count} attempt");
        else
        {
            while (true)
            {
                if (guessNum > a)
                {
                    Console.WriteLine("Your number is less");
                    Console.Write("Please, Enter your number again: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    count++;
                }
                else if (guessNum < a)
                {
                    Console.WriteLine("Your number is more");
                    Console.Write("Please, Enter your number again: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    count++;
                }
                else
                {
                    Console.WriteLine($"Congrats, you win in {count} attempt");
                    break;
                }


            }
        }
        
    }
}
