using System;
using System.Collections.Generic;

namespace SuiteCRMNetCore.Models
{
    public class Lead : SugarBean
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Company { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Status { get; set; }
        public string? Source { get; set; }
        public ICollection<Note> Notes { get; set; } = new List<Note>();
        public ICollection<Task> Tasks { get; set; } = new List<Task>();
        // Add other navigation properties as needed
    }
}
