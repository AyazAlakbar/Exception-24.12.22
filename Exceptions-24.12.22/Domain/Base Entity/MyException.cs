﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_24._12._22.Domain.Base_Entity
{
    internal class MyException:Exception
    {
        public MyException(string message) : base(message)
        {

        }
    }
}
