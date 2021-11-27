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
                    case '/':
                    Subtract(operands);
                    break;

                    case '*':
                    Subtract(operands);
                    break;
                    
                    case '+':
                    Add(operands);
                    break;

                    case '-':
                    Subtract(operands);
                    break;

                    default:
                    Console.WriteLine("Syntax error");
                    break;
                }
            }
        }

        // Add
        private void Add (List<double> operands)
        {
            if (operands.Count > 1)
            {
                this.finalCalc = operands.ElementAt(0) + operands.ElementAt(1);
                operands.RemoveRange(0, 2);

                if (operands.Count == 0)
                    Console.WriteLine(finalCalc);

            }else
            {
                this.finalCalc += operands.ElementAt(0);
                Console.WriteLine(finalCalc);
            }
        }

        // Subtract
        private void Subtract (List<double> operands)
        {
            if (operands.Count > 1)
            {
                this.finalCalc = operands.ElementAt(0) - operands.ElementAt(1);
                operands.RemoveRange(0, 2);

                if (operands.Count == 0)
                    Console.WriteLine(finalCalc);

            }else
            {
                this.finalCalc -= operands.ElementAt(0);
                Console.WriteLine(finalCalc);
            }
        }

        // Divide
        private void Divide (List<double> operands)
        {
            if (operands.Count > 1)
            {
                this.finalCalc = operands.ElementAt(0) / operands.ElementAt(1);
                operands.RemoveRange(0, 2);

                if (operands.Count == 0)
                    Console.WriteLine(finalCalc);

            }else
            {
                this.finalCalc /= operands.ElementAt(0);
                Console.WriteLine(finalCalc);
            }
        }

        // Multiply
        private void Multiply (List<double> operands)
        {
            if (operands.Count > 1)
            {
                this.finalCalc = operands.ElementAt(0) * operands.ElementAt(1);
                operands.RemoveRange(0, 2);

                if (operands.Count == 0)
                    Console.WriteLine(finalCalc);

            }else
            {
                this.finalCalc *= operands.ElementAt(0);
                Console.WriteLine(finalCalc);
            }
        }
    }
}