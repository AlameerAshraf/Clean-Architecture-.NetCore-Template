using Domain.Common;


namespace Domain.Students
{
    public class Students : IEntity
    {
        public int id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}