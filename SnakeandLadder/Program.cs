namespace SnakeandLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UC1
            int position = 0;
            Console.WriteLine("UC1: Player starts at position: " + position);

            // UC2
            Random rand = new Random();
            int dice = rand.Next(1, 7);
            int opt = rand.Next(0, 3);
            Console.WriteLine("UC2 Dice rolled: " + dice);

            //UC3
            string[] options = { "No Play", "Ladder", "Snake" };
            string chosen = options[opt];

            Console.WriteLine("UC3: Dice = " + dice);
            Console.WriteLine("UC3: Option = " + chosen);

            if (chosen == "No Play")
            {
               
                Console.WriteLine("Stay at: " + position);
            }
            else if (chosen == "Ladder")
            {
                position += dice;
                Console.WriteLine("Ladder -> New position: " + position);
            }
            else // Snake
            {
                position -= dice;
                if (position < 0) position = 0;
                Console.WriteLine("Snake -> New position: " + position);
            }
        }
    }
}
