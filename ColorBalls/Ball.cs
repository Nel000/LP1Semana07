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

        // Determines if ball has been popped
        bool isPopped;

        /// <summary>
        /// Constructor that initializes Ball with given color and radius.
        /// </summary>
        /// <param name="color"> Color for current ball </param>
        /// <param name="radius"> Radius for current ball </param>
        public Ball(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
        }

        /// <summary>
        /// Pops the ball, setting its radius to 0.
        /// </summary>
        public void Pop()
        {
            isPopped = true;
            radius = 0;
        }

        /// <summary>
        /// Throws the ball once.
        /// </summary>
        public void Throw()
        {   
            // Checks if ball has been popped
            if (!isPopped)
                throwAmount++;
        }

        /// <summary>
        /// Getter for amount of throws.
        /// </summary>
        /// <returns> The amount of throws </returns>
        public int GetThrows()
        {
            return throwAmount;
        }

        public Color GetColor()
        {
            return color;
        }
    }
}