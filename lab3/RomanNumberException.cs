﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class RomanNumberException : Exception
    {
        public RomanNumberException(string message)
        {
            Console.WriteLine(message);
        }
        
    }
}
