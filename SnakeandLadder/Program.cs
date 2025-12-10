namespace SnakeandLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UC1 Start positions
            int player1 = 0;
            int player2 = 0;

            Console.WriteLine("UC7 Game Started!");
            Console.WriteLine("Player 1 starts at 0");
            Console.WriteLine("Player 2 starts at 0");

            // UC3 Options
            string[] options = { "No Play", "Ladder", "Snake" };
            Random rand = new Random();

            // UC6 Dice count
            int dicecount = 0;

            // Track turns (Player1 starts first)
            bool isPlayer1Turn = true;

            // UC7 Play until someone reaches exactly 100
            while (player1 < 100 && player2 < 100)
            {
                dicecount++;

                int dice = rand.Next(1, 7);
                int opt = rand.Next(0, 3);
                string chosen = options[opt];

                string currentPlayer = isPlayer1Turn ? "Player 1" : "Player 2";
                int position = isPlayer1Turn ? player1 : player2;

                Console.WriteLine($"\n{currentPlayer} -> Roll#{dicecount}: Dice={dice}, Option={chosen}");

                if (chosen == "No Play")
                {
                    Console.WriteLine($"{currentPlayer} stays at {position}");
                }
                else if (chosen == "Ladder")
                {
                    if (position + dice <= 100)
                    {
                        position += dice;
                        Console.WriteLine($"{currentPlayer} climbs Ladder -> Moves to {position}");
                    }
                    else
                    {
                        Console.WriteLine($"{currentPlayer} roll exceeds 100 -> stays at {position}");
                    }

                    // Update player's position
                    if (isPlayer1Turn) player1 = position;
                    else player2 = position;

                    // IMPORTANT: Ladder → extra turn → do NOT switch player
                    continue;
                }
                else // Snake
                {
                    position -= dice;
                    if (position < 0) position = 0;
                    Console.WriteLine($"{currentPlayer} bitten by Snake -> Moves to {position}");
                }

                // Update position after NoPlay/Snake
                if (isPlayer1Turn) player1 = position;
                else player2 = position;

                // Switch turn
                isPlayer1Turn = !isPlayer1Turn;
            }

            Console.WriteLine("\n-------------------------------");
            Console.WriteLine($"Total Dice Rolled: {dicecount}");

            if (player1 == 100)
                Console.WriteLine(" Player 1 Wins the Game!");
            else
                Console.WriteLine(" Player 2 Wins the Game!");
        }
    }
}
