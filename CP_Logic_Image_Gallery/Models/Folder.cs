using System.ComponentModel.DataAnnotations;

namespace CP_Logic_Image_Gallery.Models;

public class Folder
{
    [Key]
    public int Id { get; set; }

    public int? Parent_Id { get; set; }

    public string? User_Id { get; set; }

    public DateTime Date { get; set; } = DateTime.Now;

    public bool Enabled { get; set; }

    public string? Description { get; set; }

    // Navigation property (optional)
    public ICollection<Image>? Images { get; set; }
}
