namespace AbsenceTrackerLibrary.Models
{
    public class DepartmentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PersonModel Head { get; set; }
    }
}
