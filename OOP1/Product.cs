using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; } 
        public int CategoryId { get; set; }     //Hangi kategoriye dahil olduğu bilgisi
        public string ProductName { get; set; } //Ürün İsmi
        public double UnitPrice { get; set; }   //Birim Fiyatı
        public int UnitsInStock { get; set; }   //Ürün Stok Adedi


    }
}
