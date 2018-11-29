using CrudInterfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8Basis
{
    public class ItemController
    {
        private readonly IRead<Item> reader;
        private readonly ISave<Item> saver;
        private readonly IDelete<Item> deleter;

        public ItemController(IRead<Item> orderReader, ISave<Item> orderSaver, IDelete<Item> orderDeleter)
        {
            reader = orderReader;
            saver = orderSaver;
            deleter = orderDeleter;
        }

        public void CreateOrder(Item itm)
        {
            saver.Save(itm);
            Console.WriteLine("CreateOrder: Saving order of " + itm.product);
        }

        public Item GetSingleOrder(Guid identity)
        {
            Item itm = reader.ReadOne(identity);
            Console.WriteLine("GetSingleOrder: Saving item of " + itm.product);
            return itm;
        }

        public void UpdateOrder(Item itm)
        {
            saver.Save(itm);
            Console.WriteLine("UpdateOrder: Saving item of " + itm.product);
        }

        public void DeleteOrder(Item itm)
        {
            deleter.Delete(itm);
            Console.WriteLine("DeleteOrder: Delete item of " + itm.product);
        }
    }
}
