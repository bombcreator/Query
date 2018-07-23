using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Entities
{
    public class QueryParts
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public Query Query { get; set; }

    }
}
