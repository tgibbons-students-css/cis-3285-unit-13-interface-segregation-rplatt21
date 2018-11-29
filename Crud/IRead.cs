using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudInterfaces
{
    public interface IRead<TEntity>
    {
        TEntity ReadOne(Guid identity);

        IEnumerable<TEntity> ReadAll();
    }
}
