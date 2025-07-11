using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP_Logic_Image_Gallery.Models;

public class Image
{
    [Key]
    public int Id { get; set; }

    public string? User_Id { get; set; }

    public DateTime Date_Created { get; set; } = DateTime.Now;

    [ForeignKey("Folder")]
    public int Folder_Id { get; set; }

    public string? Description { get; set; }

    public string? Meta_Data { get; set; }

    public bool Enabled { get; set; }

    // Navigation property
    public Folder? Folder { get; set; }
}
