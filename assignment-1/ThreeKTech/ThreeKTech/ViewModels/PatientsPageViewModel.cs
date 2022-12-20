using Prism.Ioc;
using Prism.Navigation;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ThreeKTech.Models;
using ThreeKTech.Services;

namespace ThreeKTech.ViewModels
{
    public class PatientsPageViewModel : ViewModelBase
    {
        private ObservableCollection<Patient> _patients;
        public ObservableCollection<Patient> Patients
        {
            get { return _patients; }
            set { SetProperty(ref _patients, value); }
        }
        IMockPatientService _mockPatientService;
        public PatientsPageViewModel(INavigationService navigationService, IMockPatientService mockPatientService)
            : base(navigationService)
        {
            Title = "Patients";
            this._mockPatientService = mockPatientService;
        }
        public override async void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
            await GetAllPatients();
        }
        /// <summary>
        /// Fetching all patients from PatientService
        /// </summary>
        /// <returns></returns>
        private async Task GetAllPatients()
        {
            var result = await this._mockPatientService.GetAllPatientAsync();
            Debug.WriteLine(result);
            this.Patients = new ObservableCollection<Patient>(result);
        }
    }
}
