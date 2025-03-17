using DataAssignment.Contexts;
using DataAssignment.Entities;

namespace DataAssignment.Repositories;

public class ProjectRepository(DataContext context) : BaseRepository<ProjectEntity>(context)
{
}