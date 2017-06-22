using System;

namespace RetailStore.Core.Entity
{
    public abstract class BaseEntity : IEntity
    {
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
