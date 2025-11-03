namespace SuiteCRMNetCore.Models
{
    public class Account : SugarBean
    {
        public string? Name { get; set; }
        public string? SicCode { get; set; }
        public Guid? ParentId { get; set; }
        public Account? Parent { get; set; }
        public ICollection<Account> Members { get; set; } = new List<Account>();
        // Add other navigation properties as needed
    }
}
