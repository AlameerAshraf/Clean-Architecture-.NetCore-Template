using Domain.Common;

namespace Domain.Instructors
{
    public class Instructors : IEntity
    {
        public int id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public string Phone { get; set; }
    }
}