using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concreate
{
    public class Category
    {
        //Acces Modifiers -> public, private, internal, protected
        //publıc -> uygulamadaki her yerden erişim
        //private -> sadece bulunduğu alandan
        //internal -> sadece bulunduğu katman
        // protected -> miras alan yerlerden erişim sağlar.

        public int CategoryId { get; set; } //sondaId olması primary ve
                                            // otomatik artan olarak ayarlamasını sağlar
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }
        // product'a category ekledik çünkü her ürünün
        // tek kategorisi olacak ama 
        // Category'e Products ekledik her categoryde
        // birden çok ürün olacak

    }
}
/*
 Field - Variable - Property

int x; --> Field
public int y{get;set;} --> Property
void test()
{
  int z;  --> Variable
}
 */