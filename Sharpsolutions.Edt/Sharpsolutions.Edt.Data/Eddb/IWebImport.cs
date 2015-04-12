using System.Collections.Generic;
using Sharpsolutions.Edt.Contracts.Data.Eddb;

namespace Sharpsolutions.Edt.Data.Eddb
{
    public interface IWebImport<TDto>
    {
        IList<TDto> Load();
    }
}