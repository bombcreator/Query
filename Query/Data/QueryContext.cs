using Microsoft.EntityFrameworkCore;
using Query.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Data
{
    public class QueryContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Entity> Entities { get; set; }
        public DbSet<Entities.Query> Queries { get; set; }
        public DbSet<ProjectPart> ProjectParts  { get; set; }
        public DbSet<ProjectEntity> ProjectEntities  { get; set; }
        

    }
}
