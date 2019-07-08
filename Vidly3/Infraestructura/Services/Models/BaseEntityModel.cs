using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly3.Infraestructura.Services.Models
{
    public abstract class BaseEntityModel<TId>
    {
        public TId  Id { get; set; }
        public DateTime?  FechaAlta { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaBaja { get; set; }
    
    }

    public abstract class BaseEntityModel : BaseEntityModel<int> {}
}