using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tables
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string WarehouseCode { get; set; }

        public string WarehouseName { get; set; }
        public string OfficialCode { get; set; }
        public string OfficialName { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Neighbourhood { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }



    }
}
