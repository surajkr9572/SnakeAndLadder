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
            Console.WriteLine("UC2 Dice rolled: " + dice);
        }
    }
}
