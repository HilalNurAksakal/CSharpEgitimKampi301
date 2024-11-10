using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concreate
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerDistrict { get; set; }
        public string CustomerCity { get; set; }
        public List<Order> Orders { get; set; }
        public bool CustomerStatus { get; set; }

    }
}
/* class ilgili tabloya ait bilgileri tutar */

/*
 *            Solid
 *            
 * Single Responsibility her şeyin ayrı tutulması müşteri-sipaiş
 * 
 * 
 * 
 * 
 */
