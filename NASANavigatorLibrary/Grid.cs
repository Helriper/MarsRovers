using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASANavigatorLibrary
{
    public class Grid
    {
        private short _X;
        private short _Y;

        public Grid(short X, short Y)
        {
            _X = X;
            _Y = Y;
        }

        public short X { get => _X; }
        public short Y { get => _Y; }
    }
}
