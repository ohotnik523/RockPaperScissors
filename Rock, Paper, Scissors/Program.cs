using Rock__Paper__Scissors;

string tempPlayerInput;
string playerInput;
string botInput;
int randomInt;
int qntOfGames;
string[] arr = new string[3] { "ROCK", "PAPER", "SCISSORS" };
bool playAgain = true;
Random r = new Random();

int scorePlayer = 0;
int scoreBot = 0;
Console.WriteLine("Till what score will you play?");
qntOfGames = Int32.Parse(Console.ReadLine());
while (playAgain == true)
{
    scorePlayer = 0;
    scoreBot = 0;

    while (scorePlayer < qntOfGames && scoreBot < qntOfGames)
    {
        Console.Write("Choose between Rock, Paper or Scissors:  ");
        tempPlayerInput = Console.ReadLine();
        playerInput = Utils.FormatterAndChecker(arr, tempPlayerInput);


        randomInt = r.Next(1, 4);

        switch (randomInt)
        {
            case 1:
                botInput = "ROCK";

                Console.WriteLine("Computer chose Rock");
                if (playerInput == "ROCK")
                {
                    Console.WriteLine("DRAW\n\n");
                }
                else if (playerInput == "PAPER")
                {

                    Console.WriteLine("PLAYER WINS!!\n\n");
                    scorePlayer++;
                }
                else if (playerInput == "SCISSORS")
                {

                    Console.WriteLine("COMPUTER WINS\n\n");
                    scoreBot++;
                }


                break;
            case 2:
                botInput = "PAPER";
                Console.WriteLine("Computer chose Paper");
                if (playerInput == "ROCK")
                {

                    Console.WriteLine("COMPUTER WINS\n\n");
                    scoreBot++;
                }
                else if (playerInput == "PAPER")
                {

                    Console.WriteLine("DRAW\n\n");

                }
                else if (playerInput == "SCISSORS")
                {
                    Console.WriteLine("PLAYER WINS!!\n\n");
                    scorePlayer++;
                }

                break;
            case 3:
                botInput = "SCISSORS";
                Console.WriteLine("Computer chose Scissors");
                if (playerInput == "ROCK")
                {

                    Console.WriteLine("PLAYER WINS!!\n\n");
                    scorePlayer++;
                }
                else if (playerInput == "PAPER")
                {

                    Console.WriteLine("COMPUTER WINS\n\n");
                    scoreBot++;

                }
                else if (playerInput == "SCISSORS")
                {

                    Console.WriteLine("DRAW\n\n");

                }



                break;
            default:
                Console.WriteLine("Please Choose Between Rock, Paper or Scissors");
                break;

        }

        Console.WriteLine("Player Score: " + scorePlayer);
        Console.WriteLine("Bot Score: " + scoreBot);
        if (scorePlayer == qntOfGames)
        {
            Console.WriteLine("Player Won the Game!!!!!!!");
        }
        else if (scoreBot == qntOfGames)
        {
            Console.WriteLine("\r\n\r\n\r\n\r\nBot Won the Game!!!!!!!");

        }
    }
    Console.WriteLine("Do you want to play again?(y/n)");
    string loop = Console.ReadLine();
    if (loop == "y")
    {
        playAgain = true;
    }
    else if (loop == "n")
    {
        playAgain = false;
    }
}
