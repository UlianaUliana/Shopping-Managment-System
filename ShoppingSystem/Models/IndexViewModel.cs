using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingSystem.Models
{
    public class IndexViewModel
    {
        public IEnumerable<SuperMarket> Supermarkets { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
