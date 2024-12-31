using PatientManagement.Client.Models;

namespace PatientManagement.Client.Services
{
    public class PatientService
    {
        private readonly HttpClient _httpClient;

        public PatientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Patient>> GetPatientsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Patient>>("api/patient");
        }

        public async Task<Patient> GetPatientAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Patient>($"api/patient/{id}");
        }

        public async Task AddPatientAsync(Patient patient)
        {
            await _httpClient.PostAsJsonAsync("api/patient", patient);
        }

        public async Task UpdatePatientAsync(Patient patient)
        {
            await _httpClient.PutAsJsonAsync($"api/patient/{patient.Id}", patient);
        }

        public async Task DeletePatientAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/patient/{id}");
        }
    }
}
