namespace CP_Logic_Image_Gallery.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string User_Id { get; set; }
        public DateTime Date_Created { get; set; }
        public int Parent_Id { get; set; }
        public string Description { get; set; }
        public string Meta_Data { get; set; }
        public bool Enabled { get; set; }
    }
}
