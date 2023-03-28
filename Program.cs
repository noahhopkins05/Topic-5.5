using static System.Formats.Asn1.AsnWriter;

namespace Topic_5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double wallet = 100.00;
            double bet = 0;
            int i = 1;
            string input;
            Die die1 = new Die();
            Die die2 = new Die();

            while (i == 1)
            {
                Console.WriteLine("You have " + wallet + "$");
                Console.WriteLine("Type 'exit' to exit");
                Console.WriteLine("How much would you like to bet?");
                input = Console.ReadLine();
              
                if (Double.TryParse(input, out bet))
                {
                    if (bet > wallet || bet < 0)
                    {
                        Console.WriteLine("Invalid bet. Try again");
                    }
                    else
                    {
                        wallet = wallet - bet;
                        int dieNum1 = die1.RollDie();
                        int dieNum2 = die2.RollDie();
                        die1.DrawRoll();
                        die2.DrawRoll();
                        if (dieNum1 == dieNum2)
                        {
                            Console.WriteLine("You won!");
                            bet = bet * 2;
                            wallet = wallet + bet;
                            bet = 0;
                            wallet = Math.Round(wallet, 2);
                        }
                        else if (die1 != die2)
                        {
                            Console.WriteLine("You lost : (");
                            bet = bet / 2;
                            wallet = wallet + bet;
                            wallet = Math.Round(wallet, 2);
                        }
                    }
                }
                else if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Thank you for playing you ended up with " + wallet + "$");
                    i = 0;
                }

            }
            
        }
    }
}