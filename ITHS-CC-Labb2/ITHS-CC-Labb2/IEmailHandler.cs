﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public interface IEmailHandler
    {
        void Email(string email, Guid ID);
    }
}
