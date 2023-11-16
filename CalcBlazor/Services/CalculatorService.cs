namespace CalcBlazor.Services
{
	public class CalculatorService
	{
		public static decimal? Add(decimal leftNumber, decimal rightNumber)
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

		public static decimal? Substract(decimal leftNumber, decimal rightNumber)
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

		public static decimal? Multiply(decimal leftNumber, decimal rightNumber)
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

		public static decimal? Divide(decimal leftNumber, decimal rightNumber)
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
