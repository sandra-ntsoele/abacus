namespace abacus
{
    class Calculator
    {
        /* 
         * Class properties
         */
        private double finalCalc;

        public Calculator(string input)
        {
            InputProcessor inputProcessor = new InputProcessor(input);

            PerformCalculation(inputProcessor.userMathSymbols, inputProcessor.operands);
        }

        // Perform calculation
        public void PerformCalculation (List<char> symbols, List<double> operands)
        {
            foreach (char symbol in symbols)
            {
                switch (symbol)
                {
                    case '+':
                    Addition(operands);
                    break;

                    default:
                    Console.WriteLine("Syntax error");
                    break;
                }
            }
        }

        // Addition
        private void Addition (List<double> operands)
        {
            if (operands.Count > 1)
            {
                this.finalCalc = operands.ElementAt(0) + operands.ElementAt(1);
                operands.RemoveRange(0, 2);
            }else
            {
                this.finalCalc += operands.ElementAt(0);
            }
            Console.WriteLine(finalCalc);
        }

        // Subtraction

        // Divide

        // Multiply
    }
}