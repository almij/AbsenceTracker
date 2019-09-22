using System;

namespace AbsenceTrackerLibrary.Models
{
    public class AbsenceModel : IComparable<AbsenceModel>
    {
        public AbsenceModel()
        {
            DaysWorkedOnHolidays = 0;
            EffectiveFrom = ExpiresOn = DateTime.Today;
        }

        public string Id { get; set; }
        public AbsenceTypeModel AbsenceType { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime ExpiresOn { get; set; }
        public int DaysWorkedOnHolidays { get; set; }
        public int DaysTotal => (ExpiresOn - EffectiveFrom).Days + 1;

        public int CompareTo(AbsenceModel other)
        {
            return EffectiveFrom.CompareTo(other.EffectiveFrom);
        }
    }
}
