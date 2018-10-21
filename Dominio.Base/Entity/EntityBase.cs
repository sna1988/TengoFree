using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Base.Entity
{
    public class EntityBase:  IEntityBase
    {
        public EntityBase()
        {
            if (Id == null)
                Id = Guid.NewGuid();
        }
        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid? Id { get; set; }
  
    }
}
