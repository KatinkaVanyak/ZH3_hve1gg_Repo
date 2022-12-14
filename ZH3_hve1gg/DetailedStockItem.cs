using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH3_hve1gg
{
    public class DetailedStockItem
    {
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int? Quantity { get; set; }
    }
}
