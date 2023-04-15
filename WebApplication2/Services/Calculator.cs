namespace WebApplication2.Services
{
    public class Calculator : ICalculator
    {
        int data = 10;
        public Calculator()
        {
            data = 0;
        }
        public decimal Calculate(decimal amount)
        {
            return amount*100;
        }
    }
}
