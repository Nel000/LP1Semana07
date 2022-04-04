using System;

namespace ColorBalls
{
    /// <summary>
    /// This class contains the elements to represent a ball.
    /// </summary>
    public class Ball
    {
        // Color for instance of ball
        private Color color;

        // Radius for instance of ball
        float radius;

        // Amount of times ball has been thrown
        int throwAmount;

        /// <summary>
        /// Constructor that initializes Ball with given color and radius.
        /// </summary>
        /// <param name="color">Color for current ball</param>
        /// <param name="radius">Radius for current ball</param>
        public Ball(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
        }
    }
}