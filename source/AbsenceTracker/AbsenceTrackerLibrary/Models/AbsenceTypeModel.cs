using System;

namespace AbsenceTrackerLibrary.Models
{
    public class AbsenceTypeModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsDayOff { get; set; }
        public bool IsOvertime { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
