

namespace CalculatorApp
{
    public class CalculatorApp
    {
        private readonly Calculator _calculator;
        private readonly CalculatorHistory _history;
        private readonly InputHandler _inputHandler;

        public CalculatorApp()
        {
            _calculator = new Calculator();
            _history = new CalculatorHistory();
            _inputHandler = new InputHandler();
        }

        public void Run()
        {
            while (true)
            {
                var mainChoice = _inputHandler.GetMainMenuChoice();

                switch (mainChoice)
                {
                    case "1":
                        var operation = _inputHandler.GetOperation();
                        var (num1, num2) = _inputHandler.GetNumbers();
                        double result = PerformCalculation(operation, num1, num2);
                        Console.WriteLine($"Resultatet är: {result}");
                        _history.AddHistory($"{num1} {GetOperator(operation)} {num2} = {result}");
                        Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        DisplayHistory();
                        Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        return; 
                }
            }
        }

        private double PerformCalculation(string operation, double num1, double num2)
        {
            return operation switch
            {
                "1" => _calculator.Add(num1, num2),
                "2" => _calculator.Subtract(num1, num2),
                "3" => _calculator.Multiply(num1, num2),
                "4" => _calculator.Divide(num1, num2),
                _ => throw new InvalidOperationException("Ogiltigt val")
            };
        }

        private string GetOperator(string operation)
        {
            return operation switch
            {
                "1" => "+",
                "2" => "-",
                "3" => "*",
                "4" => "/",
                _ => ""
            };
        }

        private void DisplayHistory()
        {
            Console.WriteLine("Beräkningar:");
            foreach (var entry in _history.GetHistory())
            {
                Console.WriteLine(entry);
            }
        }
    }
}
