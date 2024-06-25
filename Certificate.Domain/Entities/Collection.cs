

namespace Certificate.Domain.Entities
{
    public class Collection : BaseEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public int noOfProject { get; set; }
        public string description { get; set; }
    }
}
