using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class OrderItem
    {
        public OrderItem()
        {
            IsActive = true;
        }

        public int IdUser { get; set; }
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public decimal Lot { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Status { get; set; }
        public bool IsPayed { get; set; }
        public bool IsActive { get; set; }
    }
}

