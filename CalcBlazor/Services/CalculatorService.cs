namespace CalcBlazor.Services
{
    public class CalculatorService
    {
        public static decimal Add(decimal leftNumber, decimal rightNumber)
        {
            return leftNumber + rightNumber;
        }

        public static decimal Substract(decimal leftNumber, decimal rightNumber)
        {
            return leftNumber - rightNumber;
        }

        public static decimal Multiply(decimal leftNumber, decimal rightNumber)
        {
            return leftNumber * rightNumber;
        }

        public static decimal Divide(decimal leftNumber, decimal rightNumber)
        {
            return leftNumber / rightNumber;
        }
    }
}
