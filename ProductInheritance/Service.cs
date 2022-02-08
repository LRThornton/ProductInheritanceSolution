using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInheritance {

    public class Service : Product {

        public string ServiceLevel { get; set; } = "Basic";
        public int NumberofYears { get; set; } = 1;

        public override string ToPrint() {
            return $"{base.ToPrint()} | {ServiceLevel} | {NumberofYears}"; 
                }

        public Service(string code, decimal price, string servicelevel, int numberofYears)
            : base(code, price){

            ServiceLevel = servicelevel; //this initializes the two new parameters
            NumberofYears = numberofYears;
           
        }
        
    }
}
