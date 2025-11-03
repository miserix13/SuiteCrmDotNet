using System;

namespace SuiteCRMNetCore.Models
{
    public class Note : SugarBean
    {
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public Guid? ContactId { get; set; }
        public Contact? Contact { get; set; }
        public Guid? LeadId { get; set; }
        public Lead? Lead { get; set; }
        public DateTime? NoteDate { get; set; }
        // Add other navigation properties as needed
    }
}
