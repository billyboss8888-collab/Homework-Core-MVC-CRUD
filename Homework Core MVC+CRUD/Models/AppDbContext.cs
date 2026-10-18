using Microsoft.EntityFrameworkCore;
using Homework_Core_MVC_CRUD.Models;

namespace Homework_Core_MVC_CRUD.Data
{
    public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; } // 對應資料庫中的 Books 資料表
}
}
