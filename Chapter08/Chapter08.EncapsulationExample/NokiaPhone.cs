using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter08.EncapsulationExample
{
    class NokiaPhone
    {
        

        string model;
        string mask;
        bool maskChangeable;

        public NokiaPhone(string model, string mask)
        {
            this.model = model;
            this.mask = mask;
            this.maskChangeable = false;
        }

        public NokiaPhone(string model, string mask, bool maskChangeable)
        {
            this.model = model;
            this.mask = mask;
            this.maskChangeable = maskChangeable;
        }

        public void changeMask(string mask)
        {
            if (maskChangeable)
            {
                this.mask = mask;
                Console.WriteLine($"{this.model} changemask already {this.mask}");
            }
            else
                Console.WriteLine($"sorry this model{this.model} can not changemask");
        }

    }
}
