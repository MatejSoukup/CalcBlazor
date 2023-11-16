using CalcBlazor.Database;
using CalcBlazor.Model;
using CalcBlazor.Services;
using Microsoft.AspNetCore.Components;

namespace CalcBlazor.Data
{
    public class CalculatorBase : ComponentBase
    {
		private readonly CalculatorContext _dbContext = new CalculatorContext();
		public Operation currentOperation = new Operation();
		public List<Operation> History = new List<Operation>();
		
		private bool writeLeft;
		public bool returnWholeNumbers;
		public string displayText { get; set; }


		public void AddNumber(string number)
		{
			if (writeLeft)
			{
				currentOperation.leftNumber += number;
			}
			else
			{
				currentOperation.rightNumber += number;
			}
			displayText = currentOperation.leftNumber + currentOperation.mathOperator + currentOperation.rightNumber;
		}
		public void SetMathOperator(string mathOperator)
		{
			currentOperation.mathOperator = mathOperator;
			writeLeft = false;

			displayText = currentOperation.leftNumber + currentOperation.mathOperator + currentOperation.rightNumber;
		}

		public void Calculate()
		{
			CalculatorService calculator = new CalculatorService();
			string result = "";
			if (currentOperation.mathOperator == "+")
			{
				result = calculator.Add(Convert.ToDecimal(currentOperation.leftNumber), Convert.ToDecimal(currentOperation.rightNumber)).ToString();
			}
			else if (currentOperation.mathOperator == "-")
			{
				result = calculator.Subtract(Convert.ToDecimal(currentOperation.leftNumber), Convert.ToDecimal(currentOperation.rightNumber)).ToString();
			}
			else if (currentOperation.mathOperator == "*")
			{
				result = calculator.Multiply(Convert.ToDecimal(currentOperation.leftNumber), Convert.ToDecimal(currentOperation.rightNumber)).ToString();
			}
			else if (currentOperation.mathOperator == "/")
			{
				result = calculator.Divide(Convert.ToDecimal(currentOperation.leftNumber), Convert.ToDecimal(currentOperation.rightNumber)).ToString();
			}

			if (returnWholeNumbers)
			{
				result = decimal.Floor(Convert.ToDecimal(result)).ToString();
			}
			currentOperation.result = result;

			try
			{
				_dbContext.Operations.Add(currentOperation);
				_dbContext.SaveChanges();
			}
			catch (Exception e)
			{
				ErrorHandleService.SendError(e);
			}
			

			displayText = result;
			if(History.Count >= 10)
			{
				History.RemoveAt(0);
				History.Add(currentOperation);
			}
			else
			{
				History.Add(currentOperation);
			}
			currentOperation = new Operation();
			writeLeft = true;
		}

		public void ResetOperation()
		{
			displayText = "";
			writeLeft = true;
			currentOperation = new Operation();
		}

		public void WholeNumbers()
		{
			returnWholeNumbers = !returnWholeNumbers;
		}


		protected override Task OnInitializedAsync()
		{
			try
			{
				List<Operation> databaseHistoryList = _dbContext.Operations
			.OrderByDescending(o => o.Id)
			.Take(10).ToList();

				databaseHistoryList.Reverse();

				foreach (Operation operation in databaseHistoryList)
				{
					History.Add(operation);
				}
			}
			catch (Exception e)
			{
				ErrorHandleService.SendError(e);
			}
			

			writeLeft = true;
			returnWholeNumbers =  false;
			return base.OnInitializedAsync();
		}
	}
}
