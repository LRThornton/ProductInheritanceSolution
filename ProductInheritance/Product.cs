using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInheritance {

    public class Product {

        private bool Flag { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        
        //next is a method
        public virtual string ToPrint() {
            return $"{GetType().ToString()} | {Code} | {Price:c}";  //this will use the class name Product
        }
        //next is constructor
        public Product(string Code, decimal price) {//these are perameters
            Flag = true;
            this.Code = Code; //this is a stand in for the variable name 
            Price = price;
        }
        public Product() {

        }
    }
}
