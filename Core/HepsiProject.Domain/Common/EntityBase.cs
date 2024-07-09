namespace HepsiProject.Domain.Common
{
    public class EntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }

        public EntityBase()
        {
            
        }
        public EntityBase(int id,DateTime createdDate, bool isDeleted)
        {
            Id = id;
            CreatedDate = createdDate;
            IsDeleted = isDeleted;
        }
    }
}
