namespace abacus
{
    class UserInput
    {
        /* 
         * Class properties
         */
        private string input;
        private List<char> userMathSymbols = new List<char>();
        private List<double> operands = new List<double>();
        private char[] defaultMathSymbols = {'/', '*', '-', '+'};

        /* 
         * Class constructor
         */
        public UserInput(string userInput)
        {
            this.input = userInput;

            processInput(this.input);
        }

        /* 
         * Class methods
         */
        private void processInput(string input)
        {
            int symbolIndex;
            double num;

            for (int i = 0; i < input.Length;)
            {
                // Check for the index of a math symbol
                symbolIndex = input.IndexOfAny(defaultMathSymbols);


                if (symbolIndex >= 0)
                {
                    // If symbol exists copy and add it to the list of userMathSymbols
                    char symbol = Convert.ToChar(input.Substring(symbolIndex, 1));
                    userMathSymbols.Add(symbol);

                    // Then add the number before the symbol to List of operands
                    num = Convert.ToDouble( input.Substring(0, symbolIndex) );
                    operands.Add(num);
                }else
                {
                    if (input.Length >= 1)
                    {
                        num = Convert.ToDouble( input.Substring(0) );
                        operands.Add(num);    
                    }

                    i = input.Length;
                }

                input = input.Substring(symbolIndex + 1);
            }
        }
    }
}