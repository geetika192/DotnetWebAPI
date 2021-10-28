using PatientRepository.Models;
using System.Collections.Generic;
namespace PatientRepository.DataAccess
{
    public interface IPatientsRepository
    {
        void AddPatientRecord(Patients patient);  
        void UpdatePatientRecord(Patients patient);  
        void DeletePatientRecord(string id);  
        Patients GetPatientSingleRecord(string id);  
        List<Patients> GetPatientRecords();  
    }  
} 
