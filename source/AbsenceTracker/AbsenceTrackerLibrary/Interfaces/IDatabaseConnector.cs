using AbsenceTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbsenceTrackerLibrary.Interfaces
{
    public interface IDatabaseConnector
    {
        void SavePerson(PersonModel personModel);
        void SaveAbsence(AbsenceModel absenceModel);
        PersonModel GetDefaultUser();
        void DeleteAbsence(AbsenceModel absence);
        List<AbsenceTypeModel> GetAbsenceTypes();
    }
}
