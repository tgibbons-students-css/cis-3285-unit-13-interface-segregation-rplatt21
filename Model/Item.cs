using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Item
    {
        //TEG added
        public Guid itemId { get; set; }
        public string product { get; set; }
        public double cost { get; set; }
    }
}
