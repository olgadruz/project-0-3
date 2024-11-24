namespace Greenville_Idol_3;

class Program
{
    static void Main(string[] args)
    {
        for (; ; )
        {
            Console.WriteLine("************************************");
            Console.WriteLine("*  The stars shine in Greenville.  *");
            Console.WriteLine("************************************");
            Console.WriteLine("");
            Console.WriteLine("Please Enter the following number below from the following menu:");
            Console.WriteLine("");
            Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
            Console.WriteLine("2. Exit");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                string previous = Console.ReadLine();
                string[] split1 = previous.Split(" ");
                int previous_year = Convert.ToInt32(split1[0]);
                string current = Console.ReadLine();
                string[] split2 = current.Split(" ");
                int current_year = Convert.ToInt32(split2[0]);
                int revenue = current_year * 25;
                if (current_year > 30 || previous_year > 30)
                {
                    Console.WriteLine("Write a number from 0 to 30");
                    continue;
                }
                else
                {
                    Console.WriteLine("Last year's competition had " + previous_year + " contestants, and this year's has " + current_year + " contestants");
                    Console.Write("Revenue expected this year is ");
                    Console.WriteLine(revenue.ToString("C0"));
                    if (previous_year * 2 <= current_year)
                    {
                        Console.WriteLine("The competition is more than twice as big this year!");
                    }
                    else if (previous_year * 2 > current_year && current_year > previous_year)
                    {
                        Console.WriteLine("The competition is bigger than ever!");
                    }
                    else
                    {
                        Console.WriteLine("A tighter race this year! Come out and cast your vote!");
                    }
                }
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
        Console.ReadKey();
    }
}
