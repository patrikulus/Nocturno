using Nocturno.Data.Enums;

namespace Nocturno.Data.BaseModels
{
    public class MovableObject : BaseEntity
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int PositionZ { get; set; }
        public Alignment Alignment { get; set; }
    }
}