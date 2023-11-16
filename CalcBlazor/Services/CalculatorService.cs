namespace CalcBlazor.Services
{
	public class CalculatorService
	{
		public decimal? Add(decimal leftNumber, decimal rightNumber)
		{
			try
			{
				return leftNumber + rightNumber;
			}
			catch (Exception e)
			{
				ErrorHandleService.SendError(e);
			}

			return null;
		}

		public decimal? Subtract(decimal leftNumber, decimal rightNumber)
		{
			try
			{
				return leftNumber - rightNumber;
			}
			catch (Exception e)
			{
				ErrorHandleService.SendError(e);
			}

			return null;
		}

		public decimal? Multiply(decimal leftNumber, decimal rightNumber)
		{
			try
			{
				return leftNumber * rightNumber;
			}
			catch (Exception e)
			{
				ErrorHandleService.SendError(e);
			}

			return null;
		}

		public decimal? Divide(decimal leftNumber, decimal rightNumber)
		{
			try
			{
				return leftNumber / rightNumber;
			}
			catch (Exception e)
			{
				ErrorHandleService.SendError(e);
			}

			return null;
		}
	}
}
