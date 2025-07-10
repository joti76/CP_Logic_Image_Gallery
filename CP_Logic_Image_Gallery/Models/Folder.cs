namespace CP_Logic_Image_Gallery.Models
{
    public class Folder
    {
        public int Id { get; set; }
        public int? Parent_Id { get; set; } // For nested folders
        public string User_Id { get; set; }
        public DateTime Date { get; set; }
        public bool Enabled { get; set; }
        public string Description { get; set; }
    }
}
