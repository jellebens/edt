using Sharpsolutions.Edt.System.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Data {
    public interface IRepository {
    }

    public interface IRepository<TEntity, TId> where TEntity: IEntity<TId>
    {
        void Add(TEntity entity);
    }
}
