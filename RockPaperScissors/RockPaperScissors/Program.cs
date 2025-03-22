namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            String usr_choice = "";
            int usr_score = 0;
            int computer_score = 0;
            bool is_playing_game = true;

            while (is_playing_game)
            {
                // Prompt user for entering a choice
                while (usr_choice == "")
                {
                    Console.Write("Enter ROCK/PAPER/SCISSORS: ");
                    usr_choice = Console.ReadLine();

                    usr_choice = usr_choice.ToLower();

                    if (!(usr_choice == "rock" || usr_choice == "paper" || usr_choice == "scissors"))
                    {
                        usr_choice = "";
                    }
                }

                // Generate Computer Choice
                int computer_choice = random.Next(1, 4);
                String computer_choice_string = "";
                switch (computer_choice)
                {
                    case 1:
                        computer_choice_string = "rock";
                        break;
                    case 2:
                        computer_choice_string = "paper";
                        break;
                    case 3:
                        computer_choice_string = "scissors";
                        break;
                }

                // Game Logic
                switch (usr_choice)
                {
                    case "rock":
                        switch (computer_choice_string)
                        {
                            case "rock":
                                Console.WriteLine("Player: Rock\nComputer: Rock\nWinner: Tie");
                                break;
                            case "paper":
                                Console.WriteLine("Player: Rock\nComputer: Paper\nWinner: Computer");
                                computer_score++;
                                break;
                            case "scissors":
                                Console.WriteLine("Player: Rock\nComputer: Scissors\nWinner: Player");
                                usr_score++;
                                break;
                        }
                        break;
                    case "paper":
                        switch (computer_choice_string)
                        {
                            case "rock":
                                Console.WriteLine("Player: Paper\nComputer: Rock\nWinner: Player");
                                usr_score++;
                                break;
                            case "paper":
                                Console.WriteLine("Player: Paper\nComputer: Paper\nWinner: Tie");
                                break;
                            case "scissors":
                                Console.WriteLine("Player: Paper\nComputer: Scissors\nWinner: Computer");
                                computer_score++;
                                break;
                        }
                        break;
                    case "scissors":
                        switch (computer_choice_string)
                        {
                            case "rock":
                                Console.WriteLine("Player: Scissors\nComputer: Rock\nWinner: Computer");
                                computer_score++;
                                break;
                            case "paper":
                                Console.WriteLine("Player: Scissors\nComputer: Paper\nWinner: Player");
                                usr_score++;
                                break;
                            case "scissors":
                                Console.WriteLine("Player: Scissors\nComputer: Scissors\nWinner: Tie");
                                break;
                        }
                        break;
                }

                // Ask if user wants to play again
                String play_again = "";
                while (play_again == "")
                {
                    Console.Write("\nWould you like to play again Y/n?: ");
                    play_again = Console.ReadLine();

                    play_again = play_again.ToLower();

                    if (!(play_again == "y" || play_again == "n"))
                    {
                        play_again = "";
                    }
                }

                if (play_again == "y")
                {
                    is_playing_game = true;
                    usr_choice = "";    // Reset user choice
                } else if (play_again == "n")
                {
                    is_playing_game = false;

                    Console.WriteLine("\nPlayer Score: " + usr_score + "\nComputer Score: " + computer_score);  // Display Score
                }
           
            }

            Console.WriteLine("Program over. Enter any key to exit the program.");
            Console.ReadKey();
        }
    }
}
