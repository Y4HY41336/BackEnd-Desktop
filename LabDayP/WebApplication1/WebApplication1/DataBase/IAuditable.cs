namespace WebApplication1.DataBase
{
    public interface IAuditable
    {
        public DateTime CreateDate { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
