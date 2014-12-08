using Sharpsolutions.Edt.System.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Data {
    public interface IRepository {
    }

    public interface IRepository<TEntity> where TEntity: IEntity
    {
        void Add(TEntity entity);

        TEntity Get(string id);

        IEnumerable<TEntity> Query();
    }
}
