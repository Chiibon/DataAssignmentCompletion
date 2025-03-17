using DataAssignment.Entities;
using System.Linq.Expressions;

namespace Business.Interfaces;

public interface IProjectService
{
    Task<ProjectEntity> CreateAsync(ProjectEntity customer);
    Task<IEnumerable<ProjectEntity>> GetAllAsync();
    Task<ProjectEntity> GetAsync(Expression<Func<ProjectEntity, bool>> expression);
    Task<ProjectEntity> UpdateAsync(ProjectEntity customer);
    Task<bool> DeleteAsync(Expression<Func<ProjectEntity, bool>> expression);
}

