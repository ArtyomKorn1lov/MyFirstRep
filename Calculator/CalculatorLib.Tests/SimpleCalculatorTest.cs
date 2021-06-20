using System;
using System.Collections.Generic;
using Xunit;

namespace CalculatorLib.Tests
{
	public class SimpleCalculatorTest
	{
		[Fact]
		public void SimpleCalculator_Calculate_AdditionOperation_Calculated()
		{
			List<IOperation> operations = new List<IOperation>
			{
				new AdditionOperation()
			};

			SimpleCalculator simpleCalculator = new SimpleCalculator(operations);

			int result = simpleCalculator.Calculate("2+2");

			Assert.Equal(4, result);
		}

		[Fact]
		public void SimpleCalculator_Calculate_SubstructionOperation_Calculated()
		{
			List<IOperation> operations = new List<IOperation>
			{
				new SubstractionOperation()
			};

			SimpleCalculator simpleCalculator = new SimpleCalculator(operations);

			int result = simpleCalculator.Calculate("2-3");

			Assert.Equal(-1, result);
		}
		[Fact]
		public void SimpleCalculator_Calculate_MultiplicationOperation_Calculated()
		{
			List<IOperation> operations = new List<IOperation>
			{
				new MultiplicationOperation()
			};

			SimpleCalculator simpleCalculator = new SimpleCalculator(operations);

			int result = simpleCalculator.Calculate("4*2");

			Assert.Equal(8, result);
		}
		[Fact]
		public void SimpleCalculator_Calculate_DivisionOperation_Calculated()
		{
			List<IOperation> operations = new List<IOperation>
			{
				new DivisionOperation()
			};

			SimpleCalculator simpleCalculator = new SimpleCalculator(operations);

			int result = simpleCalculator.Calculate("4/2");

			Assert.Equal(2, result);
		}
		[Fact]
		public void SimpleCalculator_Calculate_ModuloOperation_Calculated()
		{
			List<IOperation> operations = new List<IOperation>
			{
				new ModuloOperation()
			};

			SimpleCalculator simpleCalculator = new SimpleCalculator(operations);

			int result = simpleCalculator.Calculate("5%2");

			Assert.Equal(1, result);
		}
		[Fact]
		public void SimpleCalculator_Calculate_ExponentialOperation_Calculated()
		{
			List<IOperation> operations = new List<IOperation>
			{
				new ExponentiationOperation()
			};

			SimpleCalculator simpleCalculator = new SimpleCalculator(operations);

			int result = simpleCalculator.Calculate("2^2");

			Assert.Equal(4, result);
		}
		[Fact]
		public void SimpleCalculator_Calculate_SqrtOperation_Calculated()
		{
			List<IOperation> operations = new List<IOperation>
			{
				new SqrtOperation()
			};

			SimpleCalculator simpleCalculator = new SimpleCalculator(operations);

			int result = simpleCalculator.Calculate("2√4");

			Assert.Equal(2, result);
		}
	}
}
