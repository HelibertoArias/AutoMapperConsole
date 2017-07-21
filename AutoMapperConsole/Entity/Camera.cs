namespace AutoMapperConsole.Entity
{
    public class Camera
    {
        public int Id { get; set; }

        public Company Company { get; set; }

        public string Model { get; set; }

        public string Description { get; set; }
    }
}