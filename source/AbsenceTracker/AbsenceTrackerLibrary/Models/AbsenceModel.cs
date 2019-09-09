using System;

namespace AbsenceTrackerLibrary.Models
{
    public class AbsenceModel
    {
        public int Id { get; set; }
        public AbsenceTypeModel AbsenceType { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime ExpiresOn { get; set; }
        public int DaysWorkedOnHolidays { get; set; }
    }
}
