namespace Certificate.Domain.Entities
{
    public class ProjectCourse : BaseEntity
    {
        public int id { get; set; }
        public Project project { get; set; }
        public Course course { get; set; }
    }
}
