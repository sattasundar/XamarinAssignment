using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ThreeKTech.Models;

namespace ThreeKTech.Services
{
    public class MockPatientService : IMockPatientService
    {
        readonly List<Patient> _patients;
        public MockPatientService() 
        { 
            this._patients= new List<Patient>() 
            { 
                new Patient{PatientId=Guid.NewGuid().ToString(), PatientName="Thomas Jefferson", Age="45", Gender="Male"},
                new Patient{PatientId=Guid.NewGuid().ToString(), PatientName="John Peterson", Age="24", Gender="Male"},
                new Patient{PatientId=Guid.NewGuid().ToString(), PatientName="Jessica Jeffreys", Age="27", Gender="Female"},
                new Patient{PatientId=Guid.NewGuid().ToString(), PatientName="Adam Savage", Age="59", Gender="Male"},
                new Patient{PatientId=Guid.NewGuid().ToString(), PatientName="George Washington", Age="75", Gender="Male"}
            };
        }
        public async Task<List<Patient>> GetAllPatientAsync()
        {
            return await Task.FromResult(this._patients);
        }

        public Task<Patient> GetPatientAsync(string patientId)
        {
            throw new NotImplementedException();
        }
    }
}
