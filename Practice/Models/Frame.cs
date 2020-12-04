namespace Parts
{
    /// <summary>
    /// The frame of the car.
    /// </summary>
    public class Frame
    {
        /// <summary>
        /// Creates an instance of <see cref="Frame"/>.
        /// </summary>
        /// <param name="size">The size of the frame.</param>
        /// <param name="wheels">The number of wheels.</param>
        public Frame(int size, int wheels)
        {
            Size = size;
            Wheels = wheels;
        }

        /// <summary>
        /// Gets or sets the Size.
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Gets or sets the number of Wheels
        /// </summary>
        public int Wheels { get; set; }
    }
}
