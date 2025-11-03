using System;
using System.Collections.Generic;

namespace SuiteCRMNetCore.Models
{
    public class Contact : SugarBean
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Title { get; set; }
        public Guid? AccountId { get; set; }
        public Account? Account { get; set; }
        public ICollection<Note> Notes { get; set; } = new List<Note>();
        public ICollection<Task> Tasks { get; set; } = new List<Task>();
        // Add other navigation properties as needed
    }
}
