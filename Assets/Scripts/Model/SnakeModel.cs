
namespace Snake
{
    public sealed class SnakeModel : ISnakeModel
    {
        public float Speed { get; set; }
        public float SpeedRotate { get; set; }
        public float ZOffset { get; set; }

        public SnakeModel(float speed, float speedRotate, float zOffset)
        {
            Speed = speed;
            SpeedRotate = speedRotate;
            ZOffset = zOffset;
        }
    }
}

