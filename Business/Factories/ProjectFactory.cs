using Business.Dto;
using Business.Models;
using DataAssignment.Entities;

namespace Business.Factories;

public static class ProjectFactory
{
    public static ProjectEntity? Create(ProjectRegistrationForm form) => form == null ? null : new()
    {
        Title = form.Title,
        CreatedDate = DateTime.Now,
    };

    public static Project? Create(ProjectEntity entity) => entity == null ? null : new()
    {
        Id = entity.Id,
        Title = entity.Title,
    };
}