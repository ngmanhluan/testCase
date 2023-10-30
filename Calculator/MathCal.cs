namespace Calculator
{
    //Tinh +,-,*,/ của 2 số nguyên
    public class MathCal
    {
        public MathCal() { }

        public int a {get; set; }
        public int b { get; set; }
        public int sum2Numbers(int a, int b) => a + b;
        public double devide2Numbers(int a, int b)
        {
            if (b == 0)
                throw new ArithmeticException("Error Devide By Zero");
            return (double) a / b; 
        }
    }

}