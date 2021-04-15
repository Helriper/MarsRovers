namespace NASANavigatorLibrary
{
    public class Position
    {
        private short _X;
        private short _Y;
        private string _Z;

        public Position(short X, short Y, string Z)
        {
            _X = X;
            _Y = Y;
            _Z = Z;
        }

        public Position(string init)
        {
            string[] statusArr = init.Split(" ");
            _X = short.Parse(statusArr[0]);
            _Y = short.Parse(statusArr[1]);
            _Z = statusArr[2];
        }

        public short X { get => _X; set => _X = value; }
        public short Y { get => _Y; set => _Y = value; }
        public string Z { get => _Z; set => _Z = value; }
    }
}
