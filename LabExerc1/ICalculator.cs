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

        double Add(double a);

        double Subtract(double a, double b);

        double Subtract(double a);

        double Multiply(double a, double b);

        double Multiply(double a);

        double Power(double a, double b);

        double Power(double a);

        double Divide(double dividend, double divisor);

        double Divide(double dividend);

        void Clear();

    }
}
