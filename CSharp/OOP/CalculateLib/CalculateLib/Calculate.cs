

namespace CalculateLib
{
    public class Calculate
    {
        public double Addition(double number1, double number2)
        {
            if (number1 < 0 || number2 < 0)
            {
                throw new InvalidNumberException("Please entred positive(+ve) Number");
            }
            return number1 + number2;
        }
    }
}
