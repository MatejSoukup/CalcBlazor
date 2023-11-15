using CalcBlazor.Model;
using CalcBlazor.Services;
using Microsoft.AspNetCore.Components;

namespace CalcBlazor.Data
{
    public class CalculatorBase : ComponentBase
    {
        public Operation currentOperation = new Operation();
        public bool writeLeft { get; set; }
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
            if (currentOperation.mathOperator == "+")
            {
                displayText = CalculatorService.Add(Convert.ToDecimal(currentOperation.leftNumber), Convert.ToDecimal(currentOperation.rightNumber)).ToString();
            }
            else if (currentOperation.mathOperator == "-")
            {
                displayText = CalculatorService.Substract(Convert.ToDecimal(currentOperation.leftNumber), Convert.ToDecimal(currentOperation.rightNumber)).ToString();
            }
            else if (currentOperation.mathOperator == "*")
            {
                displayText = CalculatorService.Multiply(Convert.ToDecimal(currentOperation.leftNumber), Convert.ToDecimal(currentOperation.rightNumber)).ToString();
            }
            else if (currentOperation.mathOperator == "/")
            {
                displayText = CalculatorService.Divide(Convert.ToDecimal(currentOperation.leftNumber), Convert.ToDecimal(currentOperation.rightNumber)).ToString();
            }

            currentOperation = new Operation();
            writeLeft = true;
        }

        public void ResetOperation()
        {
            displayText = "";
            currentOperation = new Operation();
        }


        protected override Task OnInitializedAsync()
        {
            writeLeft = true;
            return base.OnInitializedAsync();
        }
    }
}
