﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExerc1
{
    public interface ICalculator
    {
        double Add(double a, double b);

        double Subtract(double a, double b);

        double Multiply(double a, double b);

        double Power(double a, double b);

    }
}