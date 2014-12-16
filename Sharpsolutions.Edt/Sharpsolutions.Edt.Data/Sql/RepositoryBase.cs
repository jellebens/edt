using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using Microsoft.WindowsAzure;
using Sharpsolutions.Edt.System.Data;
using Sharpsolutions.Edt.System.Domain;
using Sharpsolutions.Edt.System.Logging;

namespace Sharpsolutions.Edt.Data.Sql {
    public abstract class RepositoryBase<TEntity> : IRepository<TEntity>, IDisposable where TEntity : IEntity {
        protected readonly DbContext DbContext;
        private readonly ILogger _Logger;
        private readonly bool _OwnsContext = false;

        protected RepositoryBase(DbContext dbContext, ILoggerFactory loggerFactory) {
            DbContext = dbContext;
            _Logger = loggerFactory.Create(Loggers.System.Sql);

            DbContext.Database.Log = (s) => _Logger.DebugFormat("{0}", s.Replace(Environment.NewLine, string.Empty));
        }

        protected RepositoryBase(ILoggerFactory loggerFactory)
            : this(new EdtDbContext(), loggerFactory) {
            _OwnsContext = true;
        }


        public abstract void Add(TEntity entity);

        public abstract TEntity Get(Guid id);

        public abstract IQueryable<TEntity> Query();

        public void Commit() {
            DbContext.SaveChanges();
        }

        public void Dispose() {
            if (_OwnsContext) {
                DbContext.Dispose();
            }
        }

        public TResult Get<TResult>(params object[] keyValues) where TResult : class
        {

            return DbContext.Set<TResult>().Find(keyValues);
        }
    }
}
