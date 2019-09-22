using System;

namespace AbsenceTrackerLibrary.Models
{
    public class AbsenceModel : IComparable<AbsenceModel>
    {
        public string Id { get; set; }
        public AbsenceTypeModel AbsenceType { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime ExpiresOn { get; set; }
        public int DaysWorkedOnHolidays { get; set; }

        public int CompareTo(AbsenceModel other)
        {
            return EffectiveFrom.CompareTo(other.EffectiveFrom);
        }
    }
}
