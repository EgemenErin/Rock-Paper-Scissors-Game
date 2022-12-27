using System.Reflection.Emit;

namespace Rock_Paper_Scissors_Game;
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int min = 1;
        int max = 4;
        bool play = true;
        string player;
        string computer;
        Console.WriteLine("");
        Console.WriteLine("Welcome to Rock Paper Scissors!");
        Console.WriteLine("");
        Console.WriteLine("The game has started!");
        Console.WriteLine("");
        Console.WriteLine("What is your guess?");
        Console.WriteLine("");
        while (play)
        {
            player = "";
            computer = "";
            while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            {
                Console.WriteLine("Input One Of ROCK, PAPER, SCISSORS: ");
                player = Console.ReadLine();
                player = player.ToUpper();
            }

            switch(random.Next(min,max))
            {
                case 1:
                    computer = "ROCK";
                    break;
                case 2:
                    computer = "PAPER";
                    break;
                case 3:
                    computer = "SCISSORS";
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("Player: " + player);
            Console.WriteLine("Computer: " + computer);
            Console.WriteLine("");

            switch (player)
            {
                case "ROCK":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("ITS A DRAW!");
                        break;
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("COMPUTER WINS!");
                        break;
                    }
                    else if (computer == "SCISSORS")
                    {
                        Console.WriteLine("PLAYER WINS!");
                        break;
                    }
                    break;
                case "SCISSORS":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("COMPUTER WINS!");
                        break;
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("PLAYER WINS!");
                        break;
                    }
                    else if (computer == "SCISSORS")
                    {
                        Console.WriteLine("ITS A DRAW!");
                        break;
                    }
                    break;
                case "PAPER":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("PLAYER WINS");
                        break;
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("ITS A DRAW!");
                        break;
                    }
                    else if (computer == "SCISSORS")
                    {
                        Console.WriteLine("COMPUTER WINS!");
                        break;
                    }
                    break;
            }
            Console.WriteLine("Would you like to play again? (Y/N)");
            string answer = Console.ReadLine();
            answer = answer.ToUpper();
            if (answer == "Y")
            {
                play = true;
            }
            else
            {
                Console.WriteLine("Thanks for playing!!");
                play = false;
                return;
            }


        }

    }
}

