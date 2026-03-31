namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1, die2;
            die1 = new Die();
            die2 = new Die();
            string choice;
            int bet, account;
            account = 100;
            Console.WriteLine("Hello, welcome to my dice rolling casino!");
            Console.WriteLine("You will start with $100, and these are the gambling options");
            Console.WriteLine();
            Console.WriteLine("1: Roll doubles: Win double your bet");
            Console.WriteLine("2: Roll not doubles: Win half your bet");
            Console.WriteLine("3: Roll an even sum: Win your bet");
            Console.WriteLine("4: Roll an odd sum: Win your bet");
            Console.WriteLine("Roll Anything else/incorrect: Loose your bet");
            Console.WriteLine("Choose your option:");
            Console.WriteLine();
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Roll doubles, good luck!");
                Console.WriteLine("How much would you like to bet?");
                bet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Click ENTER to roll your die");
                Console.ReadLine();
                die1.RollDie();
                die1.DrawRoll();
                die2.RollDie();
                die2.DrawRoll();
                if (die1.Roll == die2.Roll)
                {
                    Console.WriteLine("Congrats! You won your bet!");
                    account = account + (bet * 2);
                    Console.WriteLine("Your account is now at " + account);
                }
                else
                {
                    Console.WriteLine("Sorry, You lost! Try again!");
                    account = account - bet;
                    Console.WriteLine("Your account is now at " + account);
                }
                Console.WriteLine();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Roll not doubles, good luck!");
                Console.WriteLine("How much would you like to bet?");
                bet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Click ENTER to roll your die");
                Console.ReadLine();
                die1.RollDie();
                die1.DrawRoll();
                die2.RollDie();
                die2.DrawRoll();
                if (die1.Roll == die2.Roll)
                {
                    Console.WriteLine("Sorry, You lost! Try again!");
                    account = account - bet;
                    Console.WriteLine("Your account is now at " + account);
                }
                else
                {
                    Console.WriteLine("Congrats! You won your bet!");
                    account = account + (bet / 2);
                    Console.WriteLine("Your account is now at " + account);
                }
            }
            else if (choice == "3")
            {
                Console.WriteLine("Roll an even sum, good luck!");
                Console.WriteLine("How much would you like to bet?");
                bet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Click ENTER to roll your die");
                Console.ReadLine();
                die1.RollDie();
                die1.DrawRoll();
                die2.RollDie();
                die2.DrawRoll();
                if (die1.Roll + die2.Roll == 2)
                {
                    Console.WriteLine("Congrats! You won your bet!");
                    account = account + bet;
                    Console.WriteLine("Your account is now at " + account);
                }
                else if (die1.Roll + die2.Roll == 4)
                {
                    Console.WriteLine("Congrats! You won your bet!");
                    account = account + bet;
                    Console.WriteLine("Your account is now at " + account);
                }
                else if (die1.Roll + die2.Roll == 6)
                {
                    Console.WriteLine("Congrats! You won your bet!");
                    account = account + bet;
                    Console.WriteLine("Your account is now at " + account);
                }
                else if (die1.Roll + die2.Roll == 8)
                {
                    Console.WriteLine("Congrats! You won your bet!");
                    account = account + bet;
                    Console.WriteLine("Your account is now at " + account);
                }
                else if (die1.Roll + die2.Roll == 10)
                {
                    Console.WriteLine("Congrats! You won your bet!");
                    account = account + bet;
                    Console.WriteLine("Your account is now at " + account);
                }
                else if (die1.Roll + die2.Roll == 12)
                {
                    Console.WriteLine("Congrats! You won your bet!");
                    account = account + bet;
                    Console.WriteLine("Your account is now at " + account);
                }
                else
                {
                    Console.WriteLine("Sorry, You lost! Try again!");
                    account = account - bet;
                    Console.WriteLine("Your account is now at " + account);
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine("Roll an odd sum, good luck!");
                Console.WriteLine("How much would you like to bet?");
                bet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Click ENTER to roll your die");
                Console.ReadLine();
                die1.RollDie();
                die1.DrawRoll();
                die2.RollDie();
                die2.DrawRoll();
                if (die1.Roll + die2.Roll == 1)
                {
                    Console.WriteLine("Congrats! You won your bet!");
                    account = account + bet;
                    Console.WriteLine("Your account is now at " + account);
                }
                else if (die1.Roll + die2.Roll == 3)
                {
                    Console.WriteLine("Congrats! You won your bet!");
                    account = account + bet;
                    Console.WriteLine("Your account is now at " + account);
                }
                else if (die1.Roll + die2.Roll == 5)
                {
                    Console.WriteLine("Congrats! You won your bet!");
                    account = account + bet;
                    Console.WriteLine("Your account is now at " + account);
                }
                else if (die1.Roll + die2.Roll == 7)
                {
                    Console.WriteLine("Congrats! You won your bet!");
                    account = account + bet;
                    Console.WriteLine("Your account is now at " + account);
                }
                else if (die1.Roll + die2.Roll == 9)
                {
                    Console.WriteLine("Congrats! You won your bet!");
                    account = account + bet;
                    Console.WriteLine("Your account is now at " + account);
                }
                else if (die1.Roll + die2.Roll == 11)
                {
                    Console.WriteLine("Congrats! You won your bet!");
                    account = account + bet;
                    Console.WriteLine("Your account is now at " + account);
                }
                else
                {
                    Console.WriteLine("Sorry, You lost! Try again!");
                    account = account - bet;
                    Console.WriteLine("Your account is now at " + account);
                }
            }
            else
            {
                Console.WriteLine("Not an option");
            }
            Console.WriteLine();
            while (true)
            {
                Console.Write("Type 'exit' to quit or any other key to keep playing: ");
                if (Console.ReadLine().ToLower() == "exit")
                {
                    break;
                }
            }
        }
    }
}


