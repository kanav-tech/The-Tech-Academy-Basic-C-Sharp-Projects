using Microsoft.EntityFrameworkCore;

namespace StudentCodeFirst
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_e_sqlite3());

            optionsBuilder.UseSqlite("Data Source=school.db");
        }
    }
}