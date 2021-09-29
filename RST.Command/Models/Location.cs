namespace RST.Command.Models
{
    public struct Location
    {
        private int xCoord;
        private int yCoord;

        public Location(int xCoord, int yCoord)
        {
            this.xCoord = xCoord;
            this.yCoord = yCoord;
        }

        public int XCoord { get => xCoord; set => xCoord = value; }
        public int YCoord { get => yCoord; set => yCoord = value; }

        public override string ToString() => $"{xCoord}; {yCoord}";
    }
}
