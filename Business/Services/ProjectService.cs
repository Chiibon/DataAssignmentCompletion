using Business.Dto;
using Business.Factories;
using DataAssignment.Repositories;

namespace Business.Services;

public class ProjectService(ProjectRepository projectRepository)
{
    private readonly ProjectRepository _projectRepository = projectRepository;

    //Create
    public async Task CreateProjectAsync(ProjectRegistrationForm form)
    {
        var projectEntity = ProjectFactory.Create(form);
        await _projectRepository.AddAsync(projectEntity!);
    }
    //Read by ID, Title

    //Update
    //Delete
}
