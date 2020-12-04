using System;
using System.Collections.Generic;
using System.Text;

namespace Parts
{
    public class Wheel
    {
        /// <summary>
        /// Gets or sets the PartNumber.
        /// </summary>
        public int PartNumber { get; set; }

        /// <summary>
        /// Gets or sets the Brand.
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Gets or sets the Tread.
        /// Keep track of wear and tear.
        /// </summary>
        public int Tread { get; set; }

        /// <summary>
        /// Gets or sets the Size.
        /// </summary>
        public int Size { get; set; }
    }
}
