using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productclass
{
    public class product
    {
        private int id, price;
        private string name;
        private double discount, FP, FP1;

        public product()
        {

            this.id = 123;
            this.name = "DELL";
            this.price = 40000;
            this.discount = 10;

        }
        public void final()
        {
            FP = (double)40000 / 100 * 10;
            FP1 = 40000 - FP;
        }
        public string Display()
        {
            return $"ID={id} Name={name} Price={price} Discount={discount} finalprice ={FP1}";
        }
    }
}
