using CrudInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudImplementations
{
    public class Deleter<TEntity> : IDelete<TEntity>
    {
        public void Delete(TEntity entity)
        {
            Console.WriteLine("Deleter: Delete entiry");
        }
    }
}
