using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiDemo.Exceptions
{
    public class ItemNotFoundException : ArgumentException
    {
        public ItemNotFoundException() : base("Item not found")
        {

        }
    }
}
