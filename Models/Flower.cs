namespace fruit_api.Models
{
    public class Flower : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}