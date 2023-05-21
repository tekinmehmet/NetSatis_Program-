using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tables
{
    public class Definition
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string DefinitionDescription { get; set; }
        public string Description { get; set; }
    }
}
