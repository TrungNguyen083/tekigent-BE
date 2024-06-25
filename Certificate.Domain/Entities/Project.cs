namespace Certificate.Domain.Entities
{
    public class Project : BaseEntity
    {
        public int id { get; set; }
        public Collection? collection { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string projectBgImage { get; set; }
        public int credentialsNo { get; set; }
        public int unpublishedNo { get; set; }

    }
}
