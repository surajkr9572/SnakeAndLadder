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
            //UC6
            int dicecount = 0;
            // UC4 Repeat until position reaches 100
            while (position < 100)
            {
                dicecount++; //UC6
                // UC2 Roll dice
                int dice = rand.Next(1, 7);

                // UC3 Pick random option
                int opt = rand.Next(0, 3); // 0 = No Play, 1 = Ladder, 2 = Snake
                string chosen = options[opt];

                Console.WriteLine($"\nDice = {dice}, Option = {chosen}");

                if (chosen == "No Play")
                {
                    Console.WriteLine($"Roll#{dicecount}: Dice={dice}, Option={chosen} -> Stay at {position}");
                }
                else if (chosen == "Ladder")
                {
                    if (position + dice <= 100)
                    {
                        position += dice;
                        Console.WriteLine($"Roll#{dicecount}: Dice={dice}, Option={chosen} -> Move ahead to {position}");
                    }
                    else
                    {
                        Console.WriteLine($"Roll#{dicecount}: Dice={dice}, Option={chosen} -> Roll exceeds 100, stay at {position}");
                    }
                }
                else // Snake
                {
                    position -= dice;
                    if (position < 0) position = 0;
                    Console.WriteLine($"Roll#{dicecount}: Dice={dice}, Option={chosen} -> Move behind to {position}");
                }
            }

            Console.WriteLine("\nPlayer reached 100! Game over.");
        }
    }
}
