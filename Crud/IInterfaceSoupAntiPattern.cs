using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudInterfaces
{
    interface IInterfaceSoupAntiPattern<TEntity> : IRead<TEntity>, ISave<TEntity>, IDelete<TEntity>
    {
    }
}
