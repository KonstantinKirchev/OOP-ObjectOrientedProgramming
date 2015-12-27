using System;

namespace Problem2.LaptopShop
{
    public class Battery
    {
        private string name;
        private float life;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException("Battery name cannot be null or empty!");
                }
                name = value;
            }
        }

        public float Life
        {
            get
            {
                return life;
            }
            set
            {
                if (value < 0.0f)
                {
                    throw new ArgumentOutOfRangeException("Battery life cannot be negative!");
                }
                life = value;
            }
        }
    }
}
