using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudInterfaces
{
    public interface IDelete<TEntity>
    {
        void Delete(TEntity entity);
    }
}
