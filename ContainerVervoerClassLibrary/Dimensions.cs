namespace ContainerVervoerClassLibrary
{
    public struct Dimensions
    {
        public Dimensions(int length, int width, int heigth)
        {
            Length = length;
            Width = width;
            Heigth = heigth;
        }

        public int Length { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }
    }
}
