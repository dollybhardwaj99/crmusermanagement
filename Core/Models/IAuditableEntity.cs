using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public interface IAuditableEntity
    {
        bool? IsActive { get; set; }
        string UpdatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
    }
}
