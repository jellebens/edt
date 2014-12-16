using Sharpsolutions.Edt.System.Domain;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Data {
    public interface IRepository {
    }

    public interface IRepository<TEntity> where TEntity: IEntity
    {
        void Add(TEntity entity);

        TEntity Get(Guid id);

        IQueryable<TEntity> Query();

        TResult Get<TResult>(params object[] keyValues) where TResult : class;

        void Commit();
    }
}
