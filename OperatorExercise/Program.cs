namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exersice 1

            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;



            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a} divided by {b} is {quotient} with a remainder of {remainder}." );
            }

            AreaOfCircle();



        }

        //Exercise 2

        public static void AreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * radius * radius;
            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");
        }
    }
}
