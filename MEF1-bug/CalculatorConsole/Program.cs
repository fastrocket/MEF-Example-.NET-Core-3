using System;
using System.Windows;
using CompositionHelper;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CalciCompositionHelper objCalciFactory = new CalciCompositionHelper();

            //Assembles the calculator components that will participate in composition
            objCalciFactory.AssembleCalculatorComponents();

            //Gets the result
            var result1 = objCalciFactory.GetResult(100, 10, "Add");
            Console.WriteLine(result1);

            var result2 = objCalciFactory.GetResult(100, 10, "Subtract");
            Console.WriteLine(result2);

            var result3 = objCalciFactory.GetResult(100, 10, "Multiply");
            Console.WriteLine(result3);

            var result4 = objCalciFactory.GetResult(100, 10, "Divide");
            Console.WriteLine(result4);

            Console.ReadLine();
        }
    }
}
