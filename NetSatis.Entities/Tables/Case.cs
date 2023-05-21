using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tables
{
   public class Case
    {
        public int Id { get; set; }
        public string CaseCode { get; set; }
        public string CaseName { get; set; }
        public string OfficialCode { get; set; }
        public string OfficialName { get; set; }
        public string Description { get; set; }
    }
}
