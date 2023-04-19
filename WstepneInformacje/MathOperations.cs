namespace TestingMathOperations
{
    internal class MathOperations
    {
        public static double Addition(double a, double b)
        {
            return a + b;
        }
        public static double Subtraction(double a, double b)
        {
            return a - b;
        }
        public static double Multiplication(double a, double b)
        {
            return a * b;
        }
        public static double Division(double a, double b)
        {
            try
            {
                return a / b;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
