using Exam_distribution_test_QLNV.Models;

namespace Exam_distribution_test_QLNV.Repositories
{
    public interface IRepositories<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(Guid id);
        Task Create(T Obj);
        Task Update(T Obj);
        Task Delete(Guid id);
        Task<List<MajorFacility>> GetMjFcById(Guid id);
        Task<List<DepartmentFacility>> GetDpFcById(Guid id);
        Task<List<StaffMajorFacility>> GetStMjFcById(Guid id);
    }
}
