namespace WebApplication1.DataBase.Models
{
    public class Slider : BaseEntity, IAuditable
    {
        public string Subtitle { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
