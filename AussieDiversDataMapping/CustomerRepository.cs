using AussieDiversDataMapping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AussieDiversDataMapping
{
    public class CustomerRepository
    {
        public IList<Person> getCustomers()
        {
            using(var ctx = new AussieDiversContext())
            {
                return ctx.People.ToList();
            }
        }

    }
}
