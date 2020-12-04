namespace Models
{
    using System.Collections.Generic;

    using Parts;

    public class Car
    {
        public ICollection<Wheel> Wheels { get; set; }

        public Wheel Wheel { get; set; }

    }
}
