using System.ComponentModel.DataAnnotations;

namespace DataAssignment.Entities;

public class ProjectEntity
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public string Status { get; set; } = null!;

    public int CustomerId { get; set; }
}
