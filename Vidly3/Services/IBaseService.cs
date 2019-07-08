using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidly3.Infraestructura.Services.Models;

namespace Vidly3.Services
{
    public interface IBaseService<TModel, TId>
        where TModel : BaseEntityModel<TId>
    {
        //Result<TModel> Insert(TModel entity);
        //Result<TModel> Update(TModel entity);
        //Result<TModel> Delete(TModel entity);
        //Result<TModel> Reactivate(TModel entity);

        TModel GetById(TId id);
        IList<TModel> GetAll();
    }
}
