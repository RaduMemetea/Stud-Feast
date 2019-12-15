using DataModels.Models;
using DataModels.Translates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Services
{
    public interface IApiClient
    {
        Task<List<OrarResponse>> GetOrarAsync();
        Task<List<SalaResponse>> GetSalaAsync(int id);
        Task<Profesori> GetProfesorAsync(int id);
        Task<Facultate> GetFacultateAsync(int id);
        Task<Materie> GetMaterieAsync(int id);
        Task<SpecializareResponse> GetSpecializareAsync(int id);
        Task<StudentResponse> GetStudentAsync(int id);
    }
}
