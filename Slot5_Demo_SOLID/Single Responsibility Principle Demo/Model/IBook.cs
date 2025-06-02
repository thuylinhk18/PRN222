﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle_Demo.Model
{
    interface IBook
    {
        string Title { get; set; }
        string Author { get; set; }
        double Price { get; set; }
    }
}
