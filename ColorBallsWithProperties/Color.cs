using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorBallsWithProperties
{
    /// <summary>
    /// This class contains the values needed to represent a color.
    /// </summary>
    public class Color
    {
        // The variables that represent the state of a Color instance
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; }
        public int Grey { get { return (Red + Green + Blue) / 2; } }

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
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
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
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = byte.MaxValue;
        }

        /// <summary>
        /// Getter for color gray.
        /// </summary>
        /// <returns> The gray value </returns>
        public int GetGray()
        {
            // Returns average from sum of RGB values
            return (Red + Green + Blue) / 3;
        }
    }
}