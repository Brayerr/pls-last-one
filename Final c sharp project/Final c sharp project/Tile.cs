using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_c_sharp_project
{
    public abstract class Tile
    {
        public Vector2 position { get; protected set; }
        public int indexer { get; protected set; }
        public enum Actor
        {
            Player1,
            Player2
        }
        public Actor actor;

        public void IndexerSetter(int value)
        {
            indexer = value;
        }
    }
}
