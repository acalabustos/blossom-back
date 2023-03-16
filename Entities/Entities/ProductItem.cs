using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ProductItem
    {
        public ProductItem()
        {
            IsActive = true;
            IsPublic = true;

        }
        public int Id { get; set; }
        public int IdSuplier { get; set; }
        public int IdBrand { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string TypeProduct { get; set; }
        public bool IsActive { get; set; }
        public bool IsPublic { get; set; }
    }
}
