namespace SuiteCRMNetCore.Models
{
    public abstract class SugarBean
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        protected SugarBean()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.UtcNow;
            UpdatedDate = DateTime.UtcNow;
        }

        public virtual void Save()
        {
            // Implement save logic in derived classes or via repository
            UpdatedDate = DateTime.UtcNow;
        }

        public virtual void Delete()
        {
            // Implement delete logic in derived classes or via repository
        }
    }
}
