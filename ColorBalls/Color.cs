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
        /// <param name="red"> Red value of color </param>
        /// <param name="green"> Green value of color </param>
        /// <param name="blue"> Blue value of color </param>
        /// <param name="alpha"> Alpha value of color </param>
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
        /// <param name="red"> Red value of color </param>
        /// <param name="green"> Green value of color </param>
        /// <param name="blue"> Blue value of color </param>
        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = byte.MaxValue;
        }

        /// <summary>
        /// Getter for red value.
        /// </summary>
        /// <returns> The red value </returns>
        public byte GetRed()
        {
            return red;
        }

        /// <summary>
        /// Setter for red value.
        /// </summary>
        /// <param name="value"> New value for red variable </param>
        public void SetRed(byte value)
        {
            red = value;
        }

        /// <summary>
        /// Getter for green value.
        /// </summary>
        /// <returns> The green value </returns>
        public byte GetGreen()
        {
            return green;
        }

        /// <summary>
        /// Setter for green value.
        /// </summary>
        /// <param name="value"> New value for green variable </param>
        public void SetGreen(byte value)
        {
            green = value;
        }

        /// <summary>
        /// Getter for blue value.
        /// </summary>
        /// <returns> The blue value </returns>
        public byte GetBlue()
        {
            return blue;
        }

        /// <summary>
        /// Setter for blue value.
        /// </summary>
        /// <param name="value"> New value for blue variable </param>
        public void SetBlue(byte value)
        {
            blue = value;
        }

        /// <summary>
        /// Getter for alpha value.
        /// </summary>
        /// <returns> The alpha value </returns>
        public byte GetAlpha()
        {
            return alpha;
        }

        /// <summary>
        /// Setter for alpha value.
        /// </summary>
        /// <param name="value"> New value for alpha variable </param>
        public void SetAlpha(byte value)
        {
            alpha = value;
        }

        /// <summary>
        /// Getter for color gray.
        /// </summary>
        /// <returns> The gray value </returns>
        public byte GetGray()
        {
            // Returns average from sum of RGB values
            return (red + green + blue) / 3;
        }
    }
}