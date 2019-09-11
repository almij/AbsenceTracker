using System;
using System.Collections.Generic;

namespace AbsenceTrackerLibrary.Models
{
    public class PersonModel
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string FullNameForDocuments { get; set; }
        public DateTime StartedAt { get; set; }
        public DepartmentModel Department { get; set; }
        public int DaysOffBalance { get; set; }
        public List<ProjectModel> ProjectsInvolvedIn { get; set; }
        public List<AbsenceModel> Absences { get; set; }
        public List<PersonModel> Supervisors { get; set; }
        public List<PersonModel> Subordinates { get; set; }
        public List<PersonModel> Substitutes { get; set; }
    }
}
