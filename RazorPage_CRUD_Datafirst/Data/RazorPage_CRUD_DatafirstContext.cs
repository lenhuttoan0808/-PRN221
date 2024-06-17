using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPage_CRUD_Datafirst.Data
{
    public class RazorPage_CRUD_DatafirstContext : DbContext
    {
        public RazorPage_CRUD_DatafirstContext (DbContextOptions<RazorPage_CRUD_DatafirstContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPage_CRUD_Datafirst.Data.Course> Course { get; set; } = default!;
    }
}
