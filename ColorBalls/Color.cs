using System;

namespace ColorBalls
{
    /// <summary>
    /// This class contains the values needed to represent a color.
    /// </summary>
    public class Color
    {
        // The variables that represent the state of a Color instance
        private byte red, green, blue, alpha;

        /// <summary>
        /// Constructor that accepts all parameters necessary to initialize
        /// color state.
        /// </summary>
        /// <param name="red">Red value of color</param>
        /// <param name="green">Green value of color</param>
        /// <param name="blue">Blue value of color</param>
        /// <param name="alpha">Alpha value of color</param>
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        /// <summary>
        /// Constructor that accepts RGB parameters and sets alpha at
        /// maximum value.
        /// </summary>
        /// <param name="red">Red value of color</param>
        /// <param name="green">Green value of color</param>
        /// <param name="blue">Blue value of color</param>
        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = byte.MaxValue;
        }
    }
}