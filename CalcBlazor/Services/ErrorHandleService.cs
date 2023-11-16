namespace CalcBlazor.Services
{
	public class ErrorHandleService
	{
		public static void SendError(Exception exception)
		{
			WriteError(exception);
		}

		private static void WriteError(Exception exception)
		{
			string projectDirectory = Directory.GetCurrentDirectory();
			string filePath = Path.Combine(projectDirectory, "errorLog.txt");
			try
			{
				using (StreamWriter writer = new StreamWriter(filePath, true)) // 'true' to append to the file
				{
					writer.WriteLine(exception.Message);
				}
			}
			catch (Exception e)
			{
				ErrorHandleService.SendError(e);
			}
		}
	}
}
