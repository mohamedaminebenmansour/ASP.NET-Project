using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mvcProject.Infrastructure.Data
{
    public class AppliacationDbContext : DbContext
    {
        //    public AppliacationDbContext(DbContextOptions<AppliacationDbContext> options) : base(options) {

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                                        Initial Catalog = BibliothequeBenFredjSkander; 
                                        Integrated Security = true");
        }
    }
}
