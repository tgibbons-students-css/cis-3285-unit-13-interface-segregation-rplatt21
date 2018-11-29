using CrudInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudImplementations
{
    public class Reader<TEntity> : IRead<TEntity>
    {
        public TEntity ReadOne(Guid identity)
        {
            Console.WriteLine("Reader: Reading entiry with GUID of " + identity);
            return default(TEntity);
        }

        public IEnumerable<TEntity> ReadAll()
        {
            Console.WriteLine("Reader: ReadAll of the entities");
            return new List<TEntity>();
        }
    }
}
