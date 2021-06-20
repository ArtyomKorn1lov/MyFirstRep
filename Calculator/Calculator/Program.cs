using System;
using System.Collections.Generic;
using CalculatorLib;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length < 1)
			{
				Console.WriteLine("Not enough arguments, please enter again");
				return;
			}
			List<IOperation> operations = new List<IOperation>
			{
				new AdditionOperation(),
				new SubstractionOperation(),
				new MultiplicationOperation(),
				new DivisionOperation(),
				new ModuloOperation(),
				new ExponentiationOperation(),
				new SqrtOperation()
			};
			ICalculator calculator = new SimpleCalculator(operations);
			int result = calculator.Calculate(args[0]);
			Console.WriteLine($"Result:{result}");
		}
	}
}
