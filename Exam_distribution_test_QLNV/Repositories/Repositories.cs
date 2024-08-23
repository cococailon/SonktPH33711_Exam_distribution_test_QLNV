using Exam_distribution_test_QLNV.Models;
using Microsoft.EntityFrameworkCore;

namespace Exam_distribution_test_QLNV.Repositories
{
    public class Repositories<T> : IRepositories<T> where T : class
    {
        exam_distribution_testContext _context;
        public Repositories(exam_distribution_testContext context)
        {
            _context = context;
        }

        public async Task Create(T Obj)
        {
            _context.Set<T>().Add(Obj);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var deleteObj = _context.Set<T>().Find(id);
            if(deleteObj != null)
            {
                _context.Set<T>().Remove(deleteObj);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<List<DepartmentFacility>> GetDpFcById(Guid id)
        {
            return await _context.DepartmentFacilities.Where(x => x.IdStaff == id).ToListAsync();
        }

        public async Task<List<MajorFacility>> GetMjFcById(Guid id)
        {
            return await _context.MajorFacilities.Where(x => x.IdDepartmentFacility == id).ToListAsync();
        }

        public async Task<List<StaffMajorFacility>> GetStMjFcById(Guid id)
        {
            return await _context.StaffMajorFacilities.Where(x => x.IdMajorFacility == id).ToListAsync();
        }

        public async Task Update(T Obj)
        {
            _context.Set<T>().Update(Obj);
            await _context.SaveChangesAsync();
        }
    }
}
