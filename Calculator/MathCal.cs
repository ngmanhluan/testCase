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
            return (double) a / b; 
        }
    }

}