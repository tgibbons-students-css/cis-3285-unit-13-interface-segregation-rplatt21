using CrudInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudImplementations
{
    public class Saver<TEntity> : ISave<TEntity>
    {
        public void Save(TEntity entity)
        {
            Console.WriteLine("Saver: Save entity");
        }
    }
}
