using System.Collections.Generic;

namespace Sharpsolutions.Edt.Data.Eddb
{
    public interface IWebImport<TDto>
    {
        IList<TDto> Load();
    }
}