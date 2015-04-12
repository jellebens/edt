using Sharpsolutions.Edt.System.Domain;

namespace Sharpsolutions.Edt.Data.Azure {
    public interface IRepository<TRoot> where TRoot : AgregateRootBase {
        void CommitChanges(TRoot root);
        TRoot Get(string id);
    }
}
