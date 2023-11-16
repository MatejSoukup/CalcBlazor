namespace CalcBlazor.Model
{
    public class Operation
    {
        public int Id { get; set; }
        public string? leftNumber { get; set; }
        public string? rightNumber { get; set; }
        public string? mathOperator { get; set; }
        public string? result {  get; set; }

		public override string ToString()
		{
            return leftNumber + mathOperator+ rightNumber + " = " + result;
		}
	}
}
