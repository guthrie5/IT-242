using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner
{
    class Building
    {
        private string Designer { get; set; }

        private DateTime DateConstructed { get; set; }

        private string Address { get; set; }

        private string Owner { get; set; }

        public int Stories;

        public double Width;

        public double Depth;

        public double Volume {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        public class Constructor
        {
            public Constructor (string Address)
            {
                
            }
        }
    }
}