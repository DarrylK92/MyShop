using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guid = System.Guid;

namespace MyShop.Core.Models
{
    public class ProductCategory : BaseEntity
    {
        public string Category { get; set; }
    }
}
