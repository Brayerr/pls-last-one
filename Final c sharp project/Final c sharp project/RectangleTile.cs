using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_c_sharp_project
{
    public class RectangleTile : Tile
    {
        public RectangleTile(Vector2 position)
        {
            this.position = position;
            Log.InfoMessage($"A new rectangle tile was created at {this.position.x} , {this.position.y} position.");
        }
    }
}
