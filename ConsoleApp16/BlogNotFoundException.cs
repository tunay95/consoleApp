﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class BlogNotFoundException : ApplicationException
    {
        public BlogNotFoundException()
        {

        }
        public BlogNotFoundException(string message) : base(message)
        {

        }
    }
}
