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
            // Create multiple balls
            Ball ball1 = new Ball(new Color(255, 0, 0), 10.5f);
            Ball ball2 = new Ball(new Color(0, 255, 0), 5.7f);
            Ball ball3 = new Ball(new Color(0, 0, 255), 19.1f);
            Ball ball4 = new Ball(new Color(125, 150, 75), 2.3f);

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
            Console.WriteLine($"Ball 1 - {ball1.Color.Name(ball1.Color)}");
            Console.WriteLine("- Color");
            Console.WriteLine($"-- R: {ball1.Color.Red}");
            Console.WriteLine($"-- G: {ball1.Color.Green}");
            Console.WriteLine($"-- B: {ball1.Color.Blue}");
            Console.WriteLine($"-- Gr: {ball1.Color.Gray}");
            Console.WriteLine($"- Times thrown: {ball1.ThrowAmount}");

            Console.WriteLine();

            Console.WriteLine($"Ball 2 - {ball2.Color.Name(ball2.Color)}");
            Console.WriteLine("- Color");
            Console.WriteLine($"-- R: {ball2.Color.Red}");
            Console.WriteLine($"-- G: {ball2.Color.Green}");
            Console.WriteLine($"-- B: {ball2.Color.Blue}");
            Console.WriteLine($"-- Gr: {ball2.Color.Gray}");
            Console.WriteLine($"- Times thrown: {ball2.ThrowAmount}");

            Console.WriteLine();

            Console.WriteLine($"Ball 3 - {ball3.Color.Name(ball3.Color)}");
            Console.WriteLine("- Color");
            Console.WriteLine($"-- R: {ball3.Color.Red}");
            Console.WriteLine($"-- G: {ball3.Color.Green}");
            Console.WriteLine($"-- B: {ball3.Color.Blue}");
            Console.WriteLine($"-- Gr: {ball3.Color.Gray}");
            Console.WriteLine($"- Times thrown: {ball3.ThrowAmount}");

            Console.WriteLine();

            Console.WriteLine($"Ball 4 - {ball4.Color.Name(ball4.Color)}");
            Console.WriteLine("- Color");
            Console.WriteLine($"-- R: {ball4.Color.Red}");
            Console.WriteLine($"-- G: {ball4.Color.Green}");
            Console.WriteLine($"-- B: {ball4.Color.Blue}");
            Console.WriteLine($"-- Gr: {ball4.Color.Gray}");
            Console.WriteLine($"- Times thrown: {ball4.ThrowAmount}");
        }
    }
}
