using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ThreeKTech.Models;

namespace ThreeKTech.Services
{
    public interface IMockPatientService
    {
        Task<Patient> GetPatientAsync(string patientId);
        Task<List<Patient>> GetAllPatientAsync();
    }
}
