using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInheritance {
    
    public class Widget : Product {

        public string Size { get; set; } = "Medium";
        public string Color { get; set; } = "Black";

        //next is a method
        public override string ToPrint() {
            return $"{base.ToPrint()} | { Size} | { Color}";
        }
        //constructor
        public Widget(string code, decimal price, string size, string color)
            : base(code, price) {  //this : base is calling the constructor from parent class, which includes code and price

            Size = size;
            Color = color;            
        }
        
    }   
}
