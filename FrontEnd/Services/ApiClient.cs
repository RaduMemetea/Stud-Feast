using DataModels.Models;
using DataModels.Translates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace FrontEnd.Services
{
    public class ApiClient : IApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<OrarResponse>> GetOrarAsync()
        {
            var response = await _httpClient.GetAsync("https://localhost:5001/api/Orars");

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<List<OrarResponse>>();
        }


        public async Task<Facultate> GetFacultateAsync(int id)
        {
            var response = await _httpClient.GetAsync($"https://localhost:5001/api/Facultates/{id}");

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<Facultate>();
        }

        public async Task<Materie> GetMaterieAsync(int id)
        {
            var response = await _httpClient.GetAsync($"https://localhost:5001/api/Materies/{id}");

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<Materie>();

        }

        public async Task<Profesori> GetProfesorAsync(int id)
        {
            var response = await _httpClient.GetAsync($"https://localhost:5001/api/Profesoris/{id}");

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<Profesori>();
        }

        public async Task<List<SalaResponse>> GetSalaAsync(int id)
        {
            var response = await _httpClient.GetAsync($"https://localhost:5001/api/Salas/{id}");

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<List<SalaResponse>>();
        }

        public async Task<SpecializareResponse> GetSpecializareAsync(int id)
        {
            var response = await _httpClient.GetAsync($"https://localhost:5001/api/Specializares/{id}");

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<SpecializareResponse>();

        }

        public async Task<StudentResponse> GetStudentAsync(int id)
        {
            var response = await _httpClient.GetAsync($"https://localhost:5001/api/Students/{id}");

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<StudentResponse>();

        }
    }
}
