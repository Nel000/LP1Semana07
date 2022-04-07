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
        public int Gray { get { return (Red + Green + Blue) / 2; } }

        /// <summary>
        /// Name for current color instance, based on junction of absolute
        /// color values.
        /// </summary>
        /// <param name="c"> Properties of current color </param>
        /// <returns> Name of current color </returns>
        public string Name(Color c)
        { 
            return c switch
            {
                { Red: 255, Green: 0, Blue: 0 } => "Red 100%",
                { Red: 0, Green: 255, Blue: 0 } => "Green 100%",
                { Red: 0, Green: 0, Blue: 255 } => "Blue 100%",
                _ => "Mixed"
            };
        }

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
    }
}