﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSharer.MVC.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class TransactionAttribute : Attribute
    { 
    }
}
