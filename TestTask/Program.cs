using System;

namespace TestTask;

public class Scalculator
{
    double Ans;
    public void Trl_rib( double a, double b, double c ){
        double p = (a + b + c)/2;
        Ans = Math.Round(Math.Sqrt(p*(p - a)*(p - b)*(p - c)), 2);
        Console.WriteLine("The area of this triangle is " + Ans);
    }
    public void Crl_r( double r ){
        Ans = Math.Round(Math.PI*Math.Pow(r,2), 2);    
        Console.WriteLine("The area of this circle is " + Ans);
    }
}

public class Type
{
    public double Check( double[] arg)
    {
        if( arg.Length == 1)
        {
            Console.WriteLine("It's a Circle.");
            return(1);
        }
        else if( arg.Length == 3)
        {
            if( arg[0] + arg[1] > arg[2] &&
                arg[0] + arg[2] > arg[1] &&
                arg[1] + arg[2] > arg[0] )
            {
                if( Math.Pow(arg[0], 2) + Math.Pow(arg[1], 2) == Math.Pow(arg[2], 2) ||
                    Math.Pow(arg[0], 2) + Math.Pow(arg[2], 2) == Math.Pow(arg[1], 2) ||
                    Math.Pow(arg[1], 2) + Math.Pow(arg[2], 2) == Math.Pow(arg[0], 2) )
                {
                    Console.WriteLine("It's a Rectangular triangle.");
                    return(2);
                }
                else 
                {
                    Console.WriteLine("It's a Triangle.");
                    return(3);
                }
            }
            else Console.WriteLine("Triangle import Error!");
        }
        else Console.WriteLine("Import Error!"); return(0);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter import data to run program: ");
        var line = Console.ReadLine();
        var data = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => double.Parse(x)).ToArray();
        Scalculator calc = new Scalculator();
        Type t = new Type();
        int call = Convert.ToInt32(t.Check(data));
        switch(call)
        {
            case 1 :
                calc.Crl_r(data[0]);
                break;
            case 2 :
                calc.Trl_rib(data[0], data[1], data[2]);
                break;
            case 3 :
                calc.Trl_rib(data[0], data[1], data[2]);
                break;
        }
        Console.ReadKey();
    }
}
