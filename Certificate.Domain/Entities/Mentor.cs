namespace Certificate.Domain.Entities
{
    public class Mentor : BaseEntity
    {
        public int id { get; set; }
        public string mentorName { get; set; }
        public string? mentorImgSrc { get; set; }
    }
}