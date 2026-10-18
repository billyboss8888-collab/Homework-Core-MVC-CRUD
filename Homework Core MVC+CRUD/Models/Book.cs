namespace Homework_Core_MVC_CRUD.Models
{
    public class Book
    {
        public int Id { get; set; }          // 主鍵 (Primary Key)
        public string Title { get; set; }   // 書名
        public string Author { get; set; }  // 作者
        public decimal Price { get; set; }  // 價格
    }
}
