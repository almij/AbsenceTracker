using System;
using System.Collections.Generic;
using System.Linq;

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
        public DateTime StartedAt { get; set; } = DateTime.Today;
        public DepartmentModel Department { get; set; }
        public List<ProjectModel> ProjectsInvolvedIn { get; set; } = new List<ProjectModel>();
        public List<AbsenceModel> Absences { get; set; } = new List<AbsenceModel>();
        public List<PersonModel> Supervisors { get; set; } = new List<PersonModel>();
        public List<PersonModel> Subordinates { get; set; } = new List<PersonModel>();
        public List<PersonModel> Substitutes { get; set; } = new List<PersonModel>();

        public int DaysOffBalance
        {
            get
            {
                var surplus = Absences.Sum(_ => _.DaysWorkedOnHolidays);
                var deficit = Absences.Where(_ => _.AbsenceType.IsDayOff)
                    .Sum(_ => (_.ExpiresOn - _.EffectiveFrom).Days + 1);
                return surplus - deficit;
            }
        }
    }
}
