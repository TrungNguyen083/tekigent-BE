namespace Certificate.Domain.Entities
{
    public class Student : BaseEntity
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string? imgSrc { get; set; }
        public string? phoneNo { get; set; }
        public string? address { get; set; }
    }
}
