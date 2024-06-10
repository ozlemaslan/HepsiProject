using HepsiProject.Domain.Common;

namespace HepsiProject.Domain.Entities
{
    public class Category: EntityBase
    {
        public string CategoryName { get; set; }
        /// <summary>
        /// Hangi başlık altında ise onun idsi 
        /// örn: bilgisayar elektronik categorysi altında ise elektroniğin id si 1 ise bilgisayarın parentId si de 1 olmalı.
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// Öncelik sırası: Category sıralaması nasıl olmalı elektronik 2.sırada ise 2 gibi 
        /// </summary>
        public int Priorty { get; set; }
        public ICollection<Brand> Brands { get; set; }
        public ICollection<Product> Products { get; set; }
        public Category()
        {
            
        }

        public Category(string categoryName, int parentId, int priorty)
        {
            CategoryName = categoryName;
            ParentId = parentId;
            Priorty = priorty;
        }
    }
}
