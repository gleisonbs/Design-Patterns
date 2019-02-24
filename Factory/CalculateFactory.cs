namespace Factory
{
    public class CalculateFactory
    {
        public ICalculate GetCalculation(string operatorSymbol)
        {
            ICalculate calculate = null;
            if ("+".Equals(operatorSymbol))
                calculate = new Add();
            else if ("-".Equals(operatorSymbol))
                calculate = new Subtract();
            else if ("/".Equals(operatorSymbol))
                calculate = new Divide();

            return calculate;
        }
    }
}