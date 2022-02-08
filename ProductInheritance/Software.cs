using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInheritance {


    public class Software : Product {
        //property
        public bool Book { get; set; } = true;

        //method to print

        public override string ToPrint() {
            return $"{base.ToPrint()} | {(Book ? "Yes" : "No")}"; //ternary operator from Book to end of statement

        }
        public Software(string code, decimal price, bool book)
            : base(code, price) { //these two come from the parent class Product
            Book = book;
        }
        public Software() {  //this initiailizes the property for Software

        }
    }
}
