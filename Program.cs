namespace abacus
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Input");
            string text = Console.ReadLine();

            UserInput test = new UserInput(text);
        }
    }
}