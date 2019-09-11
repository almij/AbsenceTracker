using AbsenceTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbsenceTrackerLibrary.Interfaces
{
    public interface IDatabaseConnector
    {
        void SavePersonalData(ref PersonModel personModel);
        void SaveAbsence(ref AbsenceModel absenceModel);
    }
}
