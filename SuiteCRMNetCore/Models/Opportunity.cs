using System;
using System.Collections.Generic;

namespace SuiteCRMNetCore.Models
{
    public class Opportunity : SugarBean
    {
        public string? Name { get; set; }
        public decimal? Amount { get; set; }
        public string? Stage { get; set; }
        public DateTime? CloseDate { get; set; }
        public Guid? AccountId { get; set; }
        public Account? Account { get; set; }
        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();
        // Add other navigation properties as needed
    }
}
