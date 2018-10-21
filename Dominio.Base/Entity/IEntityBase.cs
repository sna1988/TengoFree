using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Base.Entity
{
    public interface IEntityBase
    {
       
        Guid? Id { get; set; }
    }
}