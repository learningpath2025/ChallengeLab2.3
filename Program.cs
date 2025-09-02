namespace ChallengeLab2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintTriangle();
        }
        public static void PrintTriangle()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            for (int i = width; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
        }
    }
}
