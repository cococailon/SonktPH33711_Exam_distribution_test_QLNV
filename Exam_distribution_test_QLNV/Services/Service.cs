using Exam_distribution_test_QLNV.Models;
using Exam_distribution_test_QLNV.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Exam_distribution_test_QLNV.Services
{
    public class Service<T> where T : class
    {
        private IRepositories<T> _repositories;
        public Service(IRepositories<T> repositories)
        {
            _repositories = repositories;
        }

        public async Task<List<T>> GetAll()
        {
            return await _repositories.GetAll();
        }

        public async Task<T> GetByID(Guid id)
        {
            return await _repositories.GetById(id);
        }

        public async Task Create(T obj)
        {
            await _repositories.Create(obj);
        }

        public async Task Update(T obj)
        {
            await _repositories.Update(obj);
        }

        public async Task Delete(Guid id)
        {
            await _repositories.Delete(id);
        }

        public async Task<List<DepartmentFacility>> GetDpFcById(Guid id)
        {
            return await _repositories.GetDpFcById(id);
        }

        public async Task<List<MajorFacility>> GetMjFcById(Guid id)
        {
            return await _repositories.GetMjFcById(id);
        }

        public async Task<List<StaffMajorFacility>> GetStMjFcById(Guid id)
        {
            return await _repositories.GetStMjFcById(id);
        }
    }
}
