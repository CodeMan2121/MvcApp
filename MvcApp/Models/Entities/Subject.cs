namespace MvcApp.Models.Entities
{
    public class Subject : Entity
    {
        public string SubjectName { get; set; }
        public int WeeklyHours { get; set; }
        public string Description { get; set; }
        public bool IsElective { get; set; }
    }
}
