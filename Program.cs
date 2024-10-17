namespace DivideByZero
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Initialising the variables.......
            int numerator = 10;
            int denominator = 0;

            //Indivating the Exception.......
            try
            {
                Console.WriteLine(numerator/denominator);
            }
            //Handling the exception......
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Can't divide by zero");
            }
        }
    }
}
