using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal interface IBits
    {
        //Спроектируйте интерфейс для класса способного устанавливать и
        //получать  значения отдельных бит в  заданном числе. 
        // до 21:20

        long Value { get; set; }

        public void SetBit(bool value, int index);

        public bool GetBit(int index);

    }
}
