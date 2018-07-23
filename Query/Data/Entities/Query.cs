using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Entities
{/// <summary>
/// i have a doubt about id if query is going to inherit from file 
/// </summary>
    public class Query
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Comment { get; set; }
        public ProjectPart ProjectPart { get; set; }
        public ProjectEntity ProjectEntity { get; set; }
        public ICollection<QueryParts> QueryParts { get; set; }


    }
}
