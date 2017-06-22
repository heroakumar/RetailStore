namespace RetailStore.Core.Entity
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? Quantity { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
    }
}
