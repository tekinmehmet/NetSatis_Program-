using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tables
{
    public class Current
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string CurrentType { get; set; }
        public string CurrentCode { get; set; }
        public string CurrentName { get; set; }
        public string AuthorizedPerson { get; set; }
        public string InvoiceTitle { get; set; }
        public string PhoneNumber { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Neighbourhood { get; set; }
        public string Adress { get; set; }
        public string CurrentGroup { get; set; }
        public string CurrentSubset { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public string SpecialCode4 { get; set; }
        public string TaxAdministration { get; set; }
        public string TaxNo { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal RiskLimit { get; set; }
        public string BuyingSpecialPrice { get; set; }
        public string SelligSpecialPrice { get; set; }
        public string Description { get; set; }
    }
}
