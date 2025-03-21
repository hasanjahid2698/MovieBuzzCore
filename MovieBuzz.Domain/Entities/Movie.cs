using System.ComponentModel.DataAnnotations;

namespace MovieBuzz.Domain.Entities;

public class Movie
{
    public int Id { get; set; }
    [MaxLength(50)]
    [Display(Name="Name of Movie")]
    public required string MovieName { get; set; }
    public string? Description { get; set; }
    public string? Title { get; set; }
}
