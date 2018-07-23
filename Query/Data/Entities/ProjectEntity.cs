using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Entities
{
    public class ProjectEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Project Project { get; set; }
        public Entity Entity { get; set; }
    }
}
