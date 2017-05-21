using LeetcodeManager.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeManager.DAL
{
    public class MyDb:DbContext
    {
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Problem> Problems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tag>().HasMany(p => p.Problems).WithMany(r => r.Tags).Map(
                t => t.ToTable("TagProblem").
                    MapLeftKey("TagId").
                    MapRightKey("ProblemId"));
        }
    }
}
