using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorBallsWithProperties
{
    /// <summary>
    /// This class contains the elements to represent a ball.
    /// </summary>
    public class Ball
    {
        // Color for instance of ball
        public Color Color { get; }

        // Radius for instance of ball
        public float Radius { get; set; }

        // Amount of times ball has been thrown
        public int ThrowAmount { get; set; }

        // Determines if ball has been popped
        private bool isPopped;

        /// <summary>
        /// Constructor that initializes Ball with given color and radius.
        /// </summary>
        /// <param name="color"> Color for current ball </param>
        /// <param name="radius"> Radius for current ball </param>
        public Ball(Color color, float radius)
        {
            Color = color;
            Radius = radius;
        }

        /// <summary>
        /// Pops the ball, setting its radius to 0.
        /// </summary>
        public void Pop()
        {
            isPopped = true;
            Radius = 0;
        }

        /// <summary>
        /// Throws the ball once.
        /// </summary>
        public void Throw()
        {   
            // Checks if ball has been popped
            if (!isPopped)
                ThrowAmount++;
        }
    }
}