namespace UnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parasykite norima veiksma");
            var stringFromInput = Console.ReadLine();
            var actionSymbol = 0;
            var result = 0;
            if (stringFromInput.Contains("+"))
            {
                actionSymbol = stringFromInput.IndexOf("+");
            }
            else if (stringFromInput.Contains("-"))
            {
                actionSymbol = stringFromInput.IndexOf("-");
            }
            else if (stringFromInput.Contains("*"))
            {
                actionSymbol = stringFromInput.IndexOf("*");
            }
            else if (stringFromInput.Contains("/"))
            {
                actionSymbol = stringFromInput.IndexOf("/");
            }
            else if (stringFromInput.Contains("^"))
            {
                actionSymbol = stringFromInput.IndexOf("^");
            }

            string[] arrayStringFromInput = stringFromInput.Split(stringFromInput[actionSymbol]);    
            int firstNumber = Convert.ToInt32(arrayStringFromInput[0]);
            int secondNumber = Convert.ToInt32(arrayStringFromInput[1]);
            switch (stringFromInput[actionSymbol]) {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    result = firstNumber / secondNumber;
                    break;
                case '^':
                    result = (int)Math.Pow(firstNumber, secondNumber);
                    break;

            }
            Console.WriteLine(result);

           


        }
       
    }
}