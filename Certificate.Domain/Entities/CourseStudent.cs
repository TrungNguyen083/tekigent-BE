namespace Certificate.Domain.Entities
{
    public class CourseStudent : BaseEntity
    {
        public int id { get; set; }
        public Course course { get; set; }
        public Student student { get; set; }
    }
}
