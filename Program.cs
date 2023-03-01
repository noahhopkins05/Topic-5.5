namespace Topic_5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double wallet, bet;
            wallet = 100.00;
            Console.WriteLine("How much would you like to bet?");
            bet = Console.Read();


            Die die1 = new Die();
           die1.DrawRoll();
        }
    }
}