using System;
using System.Collections.Generic;

namespace SuiteCRMNetCore.Models
{
    public class Case : SugarBean
    {
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public string? Priority { get; set; }
        public Guid? AccountId { get; set; }
        public Account? Account { get; set; }
        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();
        public ICollection<Note> Notes { get; set; } = new List<Note>();
        // Add other navigation properties as needed
    }
}
