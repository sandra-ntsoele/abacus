namespace abacus
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Input");
            string text = Console.ReadLine();

            Calculator calculator = new Calculator(text);
        }
    }
}