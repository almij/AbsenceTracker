using System;

namespace AbsenceTrackerLibrary.Models
{
    public class PersonModel
    {
        public int PersonId { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string FullNameForDocuments { get; set; }
        public DateTime StartedAt { get; set; }
        public ProjectModel Project { get; set; }
        public DepartmentModel Department { get; set; }
        public int DaysOffBalance { get; set; }
    }
}
