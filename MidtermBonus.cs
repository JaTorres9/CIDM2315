using System;

class HumanPlayer
{
    private int points;

    public HumanPlayer(int initial)
    {
        points = initial;
    }

    public int GetPoints()
    {
        return points;
    }

    public void WinRound()
    {
        points += 5;
    }

    public void LoseRound()
    {
        points -= 5;
    }

    public string HumanDecision()
    {
        Console.WriteLine("Enter your decision (Rock, Paper, or Scissors): ");
        return Console.ReadLine();
    }
}

class ComputerPlayer
{
    public string ComputerDecision()
    {
        string[] choices = { "Rock", "Paper", "Scissors" };
        Random rnd = new Random();
        int index = rnd.Next(choices.Length);
        return choices[index];
    }
}

class RockPaperScissors
{
    static void Main(string[] args)
    {
        HumanPlayer human = new HumanPlayer(5);
        ComputerPlayer computer = new ComputerPlayer();
        bool gameOver = false;

        while (!gameOver)
        {
            Console.WriteLine($"Your points: {human.GetPoints()}");
            string humanDecision = human.HumanDecision();
            string computerDecision = computer.ComputerDecision();

            Console.WriteLine($"Computer chose: {computerDecision}");

            if (humanDecision == computerDecision)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((humanDecision == "Rock" && computerDecision == "Scissors") ||
                     (humanDecision == "Paper" && computerDecision == "Rock") ||
                     (humanDecision == "Scissors" && computerDecision == "Paper"))
            {
                human.WinRound();
                Console.WriteLine("You win this round!");
            }
            else
            {
                human.LoseRound();
                Console.WriteLine("You lose this round!");
            }

            if (human.GetPoints() <= 0)
            {
                Console.WriteLine("Game over! You have run out of points.");
                gameOver = true;
            }
            else
            {
                Console.WriteLine("Do you want to play again? (yes/no)");
                string playAgain = Console.ReadLine();
                if (playAgain.ToLower() != "yes")
                {
                    gameOver = true;
                }
            }
        }
    }
}
