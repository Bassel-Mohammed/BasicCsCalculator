﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator;

public class Calculator
{

    private double X { get; set; }
    private double Y { get; set; }

   
    public Calculator(double x, double y)
    {
        X = x;
        Y = y;
    }

    
    public double Add()
    {
        return X + Y;
    }

   
    public double Subtract()
    {
        return X - Y;
    }

   
    public double Multiply()
    {
        return X * Y;
    }

    
    public string Divide()
    {
        if (Y == 0)
        {
            return "Cannot divide by zero";
        }
        return (X / Y).ToString();
    }


}
