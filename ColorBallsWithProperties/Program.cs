using System;

namespace ColorBallsWithProperties
{
    /// <summary>
    /// This class contains instances of the Ball and Color classes
    /// being modified.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Instantiates multiple balls, throws and pops them, and prints their
        /// state.
        /// </summary>
        /// <param name="args"> Arguments given through the console </param>
        static void Main(string[] args)
        {
            // Create instances of Color class with different values
            Color red = new Color(255, 0, 0);
            Color green = new Color(0, 255, 0);
            Color blue = new Color(0, 0, 255);

            // Create multiple balls
            Ball ball1 = new Ball(red, 10.5f);
            Ball ball2 = new Ball(green, 5.7f);
            Ball ball3 = new Ball(blue, 19.1f);

            // Get color for each ball
            Color color1 = ball1.Color;
            Color color2 = ball2.Color;
            Color color3 = ball3.Color;

            //  Throw balls
            ball1.Throw();
            ball2.Throw();
            ball3.Throw();
            ball2.Throw();
            ball1.Throw();
            ball1.Throw();

            // Pop some balls
            ball2.Pop();
            ball1.Pop();

            // Try to throw some more balls
            ball1.Throw();
            ball2.Throw();
            ball3.Throw();

            // Print state for all balls
            Console.WriteLine("Ball 1");
            Console.WriteLine("- Color");
            Console.WriteLine($"-- R: {color1.Red}");
            Console.WriteLine($"-- G: {color1.Green}");
            Console.WriteLine($"-- B: {color1.Blue}");
            Console.WriteLine($"-- G: {color1.Gray}");
            Console.WriteLine($"- Times thrown: {ball1.ThrowAmount}");

            Console.WriteLine();

            Console.WriteLine("Ball 2");
            Console.WriteLine("- Color");
            Console.WriteLine($"-- R: {color2.Red}");
            Console.WriteLine($"-- G: {color2.Green}");
            Console.WriteLine($"-- B: {color2.Blue}");
            Console.WriteLine($"-- G: {color1.Gray}");
            Console.WriteLine($"- Times thrown: {ball2.ThrowAmount}");

            Console.WriteLine();

            Console.WriteLine("Ball 3");
            Console.WriteLine("- Color");
            Console.WriteLine($"-- R: {color3.Red}");
            Console.WriteLine($"-- G: {color3.Green}");
            Console.WriteLine($"-- B: {color3.Blue}");
            Console.WriteLine($"-- G: {color1.Gray}");
            Console.WriteLine($"- Times thrown: {ball3.ThrowAmount}");
        }
    }
}
