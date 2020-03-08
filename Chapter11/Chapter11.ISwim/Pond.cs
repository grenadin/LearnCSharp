using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter11.ISwim
{
    class Pond
    {
        public void Welcome(ISwim obj) => obj.Swim();

    }
}
