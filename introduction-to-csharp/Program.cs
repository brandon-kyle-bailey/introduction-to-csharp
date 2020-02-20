﻿using System;
using introduction_to_csharp.calculator;
using introduction_to_csharp.madlibs;

namespace introduction_to_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            calculator.Calculator.Run(args);
            madlibs.MadLibs.Run(args);
        }
    }
}