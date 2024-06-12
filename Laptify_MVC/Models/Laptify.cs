namespace Laptify_MVC.Models
{
    public class Laptify
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        public string Brand { get; set; }
        public string Model { get; set; }
        public float Price { get; set; }
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string GraphicsCard { get; set; }
        public string DisplaySize { get; set; }
        public string OperatingSystem { get; set; }
        public string Color { get; set; }
        public int Stock { get; set; }
        public string Img { get; set; }



    }
}
