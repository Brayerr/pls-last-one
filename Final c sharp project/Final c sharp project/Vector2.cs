using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_c_sharp_project
{
    public struct Vector2
    {
        public float x { get; private set; }

        public float y { get; private set; }

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
