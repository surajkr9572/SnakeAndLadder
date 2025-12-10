namespace SnakeandLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UC1 Start at position 0
            int position = 0;
            Console.WriteLine("UC4 Player starts at position: " + position);

            // UC3 Options array
            string[] options = { "No Play", "Ladder", "Snake" };
            Random rand = new Random();

            // UC6: Count number of dice rolls
            int diceCount = 0;

            // UC4 Repeat until position reaches 100
            while (position < 100)
            {
                diceCount++;   // Count every dice roll (UC6)

                // UC2 Roll dice
                int dice = rand.Next(1, 7);

                // UC3 Pick random option
                int opt = rand.Next(0, 3); // 0 = No Play, 1 = Ladder, 2 = Snake
                string chosen = options[opt];

                Console.WriteLine($"\nRoll #{diceCount}: Dice = {dice}, Option = {chosen}");

                if (chosen == "No Play")
                {
                    Console.WriteLine($"Roll #{diceCount}: No Play -> Stay at {position}");
                }
                else if (chosen == "Ladder")
                {
                    //UC5 exact 100 rule
                    if (position + dice <= 100)
                    {
                        position += dice;
                        Console.WriteLine($"Roll #{diceCount}: Ladder -> Move to {position}");
                    }
                    else
                    {
                        Console.WriteLine($"Roll #{diceCount}: Ladder but exceed 100 -> Stay at {position}");
                    }
                }
                else // Snake
                {
                    position -= dice;
                    if (position < 0) position = 0;
                    Console.WriteLine($"Roll #{diceCount}: Snake -> Move to {position}");
                }
            }

            Console.WriteLine($"\nPlayer reached 100! Game over.");
            Console.WriteLine($"Total dice rolls (UC6): {diceCount}");
        }
    }
}
