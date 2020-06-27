using System;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace RPSGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Title = "Rock, Paper, Scissors!";
            int cpuResponse = rnd.Next(1, 4);
            int winCount = 0;
            int loseCount = 0;
            int tieCount = 0;
            int gamesPlayed = 0;
            int score;
            int rocksPlayed = 0;
            int paperPlayed = 0;
            int scissorsPlayed = 0;
            int timesConfused = 0;
            int manualPlaying = 0;
            int loopLength = 3;
            int tempGamesPlayed = 0; //Basically just a counter for the amount of games played to keep track for the loop
            string loopLengthText;
            string userResponse = "r";
            string[] possibleAutoAnswers = {"r", "p", "s",};
            Console.WriteLine("Welcome to Rock, Paper, Scissors! I'm sure you already know how to play, type \"stats\" for your.. well.. you know.\nYou can also type \"play for me\" if you're lazy.");
            Console.Write("Choose Rock (R), Paper (P) or Scissors (S): ");
            while (true)
            {   if (manualPlaying == 0)
                {
                    userResponse = Console.ReadLine().ToLower();
                } else //Game playing itself loop
                {
                    do
                    {
                        userResponse = possibleAutoAnswers[rnd.Next(0, 3)];
                        //Thread.Sleep(15); Looks cooler with a bit of delay but speed is key
                    } while (loopLength < tempGamesPlayed);
                }
                cpuResponse = rnd.Next(1, 4);
                gamesPlayed = winCount + loseCount + tieCount;
                score = winCount - loseCount;
                //help i'm yandere dev else if else if else if else if else if else if else if else if else if
                if (userResponse == "r" || userResponse == "rock")
                {
                    switch (cpuResponse)
                    {
                        case 1:
                            Console.WriteLine("The computer chose ROCK! TIE!");
                            rocksPlayed++;
                            tieCount++;
                            break;
                        case 2:
                            Console.WriteLine("The computer chose PAPER! YOU LOSE!");
                            rocksPlayed++;
                            loseCount++;
                            break;
                        case 3:
                            Console.WriteLine("The computer chose SCISSORS! YOU WIN!");
                            rocksPlayed++;
                            winCount++;
                            break;
                    }
                }
                else if (userResponse == "p" || userResponse == "paper")
                {
                    switch (cpuResponse)
                    {
                        case 1:
                            Console.WriteLine("The computer chose ROCK! YOU WIN!");
                            paperPlayed++;
                            winCount++;
                            break;
                        case 2:
                            Console.WriteLine("The computer chose PAPER! TIE!");
                            paperPlayed++;
                            tieCount++;
                            break;
                        case 3:
                            Console.WriteLine("The computer chose SCISSORS! YOU LOSE!");
                            paperPlayed++;
                            loseCount++;
                            break;
                    }
                }
                else if (userResponse == "s" || userResponse == "scissors")
                {
                    switch (cpuResponse)
                    {
                        case 1:
                            Console.WriteLine("The computer chose ROCK! YOU LOSE!");
                            scissorsPlayed++;
                            loseCount++;
                            break;
                        case 2:
                            Console.WriteLine("The computer chose PAPER! YOU WIN!");
                            scissorsPlayed++;
                            winCount++;
                            break;
                        case 3:
                            Console.WriteLine("The computer chose SCISSORS! TIE!");
                            scissorsPlayed++;
                            tieCount++;
                            break;
                    }
                }
                else if (userResponse == "stats")
                {
                    Console.WriteLine($"---------------------------");
                    //Wins
                    if (winCount == 1)
                    {
                        Console.WriteLine($"You have only {winCount} win");
                    }
                    else if (winCount == 69 || winCount == 420)
                    {
                        Console.WriteLine($"You have {winCount} wins (nice)");
                    }
                    else
                    {
                        Console.WriteLine($"You have {winCount} wins");
                    }
                    //Losses
                    if (loseCount == 1)
                    {
                        Console.WriteLine($"You have only {loseCount} loss");
                    }
                    else if (loseCount == 69 || loseCount == 420)
                    {
                        Console.WriteLine($"You have {loseCount} losses (nice)");
                    }
                    else
                    {
                        Console.WriteLine($"You have {loseCount} losses");
                    }
                    //Ties
                    if (tieCount == 1)
                    {
                        Console.WriteLine($"You have only {tieCount} tie");
                    }
                    else if (tieCount == 69 || tieCount == 420)
                    {
                        Console.WriteLine($"You have {tieCount} ties (nice)");
                    }
                    else
                    {
                        Console.WriteLine($"You have {tieCount} ties");
                    }
                    //Amount of times rock has been played
                    if (rocksPlayed == 1)
                    {
                        Console.WriteLine($"You have played Rock only {rocksPlayed} time");
                    }
                    else if (rocksPlayed == 69 || rocksPlayed == 420)
                    {
                        Console.WriteLine($"You have played Rock {rocksPlayed} times (nice)");
                    }
                    else
                    {
                        Console.WriteLine($"You have played Rock {rocksPlayed} times");
                    }
                    //Amount of times paper has been played
                    if (paperPlayed == 1)
                    {
                        Console.WriteLine($"You have played Paper only {paperPlayed} time");
                    }
                    else if (paperPlayed == 69 || paperPlayed == 420)
                    {
                        Console.WriteLine($"You have played Paper {paperPlayed} times (nice)");
                    }
                    else
                    {
                        Console.WriteLine($"You have played Paper {paperPlayed} times");
                    }
                    //Amount of times scissors has been played
                    if (scissorsPlayed == 1)
                    {
                        Console.WriteLine($"You have played Scissors only {scissorsPlayed} time");
                    }
                    else if (scissorsPlayed == 69 || scissorsPlayed == 420)
                    {
                        Console.WriteLine($"You have played Scissors {scissorsPlayed} times (nice)");
                    }
                    else
                    {
                        Console.WriteLine($"You have played Scissors {scissorsPlayed} times");
                    }
                    //Amount of times user didn't enter a valid string
                    if (timesConfused == 1)
                    {
                        Console.WriteLine($"You got confused {timesConfused} time");
                    }
                    else if (timesConfused == 69 || timesConfused == 420)
                    {
                        Console.WriteLine($"You got confused {timesConfused} times (nice)");
                    }
                    else
                    {
                        Console.WriteLine($"You got confused {timesConfused} times");
                    }
                    //Score = wins - losses
                    if (score < 0)
                    {
                        Console.WriteLine($"Your score is {score} (dang you suck at this)");
                    }
                    else if (score == 69 || score == 420)
                    {
                        Console.WriteLine($"Your score is {score} (nice)");
                    }
                    else
                    {
                        Console.WriteLine($"Your score is {score}");
                    }
                    //Total amount of games played, doesn't include times confused.
                    if (gamesPlayed == 1)
                    {
                        Console.WriteLine($"You have played {gamesPlayed} game in total");
                    }
                    else if (gamesPlayed == 69 || gamesPlayed == 420)
                    {
                        Console.WriteLine($"You have played {gamesPlayed} games in total (nice)");
                    }
                    else
                    {
                        Console.WriteLine($"You have played {gamesPlayed} games in total");
                    }
                    Console.WriteLine($"---------------------------");
                }
                else if (userResponse == "play for me")
                { try
                    {
                        Console.WriteLine("How many times?");
                        loopLengthText = Console.ReadLine();
                        loopLength = Int32.Parse(loopLengthText) + tempGamesPlayed;
                        manualPlaying = 1;
                    }
                  catch
                    {
                        Console.WriteLine("Buddy that wasn't a number, are you stupid?");
                    }
                }
                else
                {
                    Console.WriteLine("You didn't enter Rock, paper, or scissors.");
                    timesConfused++;
                }
                tempGamesPlayed++;
                if (manualPlaying == 0)
                {
                    NewMessage();
                }
                if (tempGamesPlayed > loopLength && manualPlaying == 1)
                {
                    manualPlaying = 0;
                    NewMessage();
                }
            }


        }
        static void NewMessage() {
            Console.Write("Go Again: ");
        }
    }
}
