using System.Collections.Generic;

namespace AbsenceTrackerLibrary.Models
{
    public class ProjectModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public PersonModel Head { get; set; }
        public List<PersonModel> Personnel { get; set; }
    }
}
