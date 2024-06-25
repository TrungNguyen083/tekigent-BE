namespace Certificate.Domain.Entities
{
    public class Course : BaseEntity
    {
        public int id { get; set; }
        public string courseName { get; set; }
        public Mentor mentor { get; set; }
        public string courseWebsite { get; set; }
        public string description { get; set; }
        public string skills { get; set; }
        public string primary { get; set; }
        public string bgImgSrc { get; set; }
        public string certificateImage { get; set; }
        public string? badgeImage { get; set; }
        public DateTime publishAt { get; set; }
        public int like { get; set; }
        public int noOfMembers { get; set; }
    }
}
