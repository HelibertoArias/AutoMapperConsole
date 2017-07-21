namespace AutoMapperConsole.ViewModel
{
    public class CameraVM
    {
        public int Id { get; set; }

        public int IdPreCalculated { get; set; }

        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public string Description { get; set; }

        public string PropertyCalculated { get; set; }

        public static string Calculate(string value)
        {
            return $"Dummy operation - {value}";
        }
    }
}