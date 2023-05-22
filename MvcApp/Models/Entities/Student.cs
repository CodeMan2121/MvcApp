namespace MvcApp.Models.Entities
{
    public class Student:Entity
    {
        public string StudentName { get; set; }
        public DateTime BirthDate { get; set; }
        public float GPA { get; set; }
    }
}
