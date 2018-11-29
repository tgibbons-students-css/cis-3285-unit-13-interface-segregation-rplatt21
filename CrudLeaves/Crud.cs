using CrudInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudImplementations
{
    public class Crud<TEntity> : IRead<TEntity>, ISave<TEntity>, IDelete<TEntity>
    {
        public TEntity ReadOne(Guid identity)
        {
            Console.WriteLine("CRUD: Reading entiry with GUID of "+identity);
            return default(TEntity);   
        }

        public IEnumerable<TEntity> ReadAll()
        {
            Console.WriteLine("CRUD: ReadAll of the entities");
            return new List<TEntity>();
        }

        public void Save(TEntity entity)
        {
            Console.WriteLine("CRUD: Saving entity");
        }

        public void Delete(TEntity entity)
        {
            Console.WriteLine("CRUD: Deleting entity");
        }
    }
}
