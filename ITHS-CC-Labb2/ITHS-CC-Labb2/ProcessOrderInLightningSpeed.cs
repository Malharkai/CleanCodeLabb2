﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public class ProcessOrderInLightningSpeed: IOrderProcessor
    {
        public bool Process(Order order)
        {
            // Some logic we don't care about
            return true;
        }
    }
}
