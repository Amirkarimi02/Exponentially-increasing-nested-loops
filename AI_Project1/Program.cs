using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class AI_Project1
{
    static void Main()
    {
        const double del1 = 0.1;
        const double del2 = 0.01;
        const double del3= 0.001;

        var timer = new Stopwatch();
        timer.Start();

        //T1(del1);
        //T2(del1);
        //T3(del1);
        //T4(del1);
        //T5(del1);

        //T1(del2);
        //T2(del2);
        //T3(del2);
        //T4(del2);
        //T5(del2);
        
        //T1(del3);
        //T2(del3);
        T3(del3);
        //T4(del3);
        //T5(del3);
        
        timer.Stop();
        TimeSpan timetaken = timer.Elapsed;
        Console.WriteLine("Time Taken= " + timetaken.TotalNanoseconds.ToString()+" NanoSeconds");
    }

    public static void printres(double fxMax, double[] maxX, int arraySize, double deltasize)
    {
        Console.WriteLine("1\t2\t3\t4\t5");
        Console.WriteLine("---------------------------------------");
        for(int i = 0; i< arraySize; i++) 
        {
            Console.WriteLine("Delta Size = " + deltasize + "\t X_Max = " + maxX[i] + "\tFxMax = "+ fxMax);
        }
    }

    public static void T1(double step_size)
    {
        
        double[] x = new double[1];
        double[] xmax = new double[1];
        double fx = 0;
        double fxmax = 0;
        for (x[0] = 0; x[0]<=10; x[0] += step_size)
        {
            fx = func(x, 1);
            if (fx > fxmax)
            {
                fxmax = fx;
                xmax[0] = x[0];
            }
        }
        printres(fxmax, xmax, 1, step_size);
    }

    public static void T2(double step_size)
    {

        double[] x = new double[2];
        double[] xmax = new double[2];
        double fx = 0;
        double fxmax = 0;
        for (x[0] = 0; x[0] <= 10; x[0] += step_size)
        {
            for (x[1] = 0; x[1] <= 10; x[1] += step_size)
            {
                fx = func(x, 2);
                if (fx > fxmax)
                {
                    fxmax = fx;
                    for (int i = 0; i < 2; i++)
                    {
                        xmax[i] = x[i];
                    }
                }
            }
        }
        printres(fxmax, xmax, 2, step_size);
    }

    public static void T3(double step_size)
    {

        double[] x = new double[3];
        double[] xmax = new double[3];
        double fx = 0;
        double fxmax = 0;
        for (x[0] = 0; x[0] <= 10; x[0] += step_size)
        {
            for (x[1] = 0; x[1] <= 10; x[1] += step_size)
            {
                for (x[2] = 0; x[2] <= 10; x[2] += step_size)
                {
                    fx = func(x, 3);
                    if (fx > fxmax)
                    {
                        fxmax = fx;
                        for (int i = 0; i < 3; i++)
                        {
                            xmax[i] = x[i];
                        }
                    }
                }
            }
        }
        printres(fxmax, xmax, 3, step_size);
    }


    public static void T4(double step_size)
    {

        double[] x = new double[4];
        double[] xmax = new double[4];
        double fx = 0;
        double fxmax = 0;
        for (x[0] = 0; x[0] <= 10; x[0] += step_size)
        {
            for (x[1] = 0; x[1] <= 10; x[1] += step_size)
            {
                for (x[2] = 0; x[2] <= 10; x[2] += step_size)
                {
                    for (x[3] = 0; x[3] <= 10; x[3] += step_size)
                    {
                        fx = func(x, 4);
                        if (fx > fxmax)
                        {
                            fxmax = fx;
                            for (int i = 0; i < 4; i++)
                            {
                                xmax[i] = x[i];
                            }
                        }
                    }
                }
            }
        }
        printres(fxmax, xmax, 4, step_size);
    }


    public static void T5(double step_size)
    {

        double[] x = new double[5];
        double[] xmax = new double[5];
        double fx = 0;
        double fxmax = 0;
        for (x[0] = 0; x[0] <= 10; x[0] += step_size)
        {
            for (x[1] = 0; x[1] <= 10; x[1] += step_size)
            {
                for (x[2] = 0; x[2] <= 10; x[2] += step_size)
                {
                    for (x[3] = 0; x[3] <= 10; x[3] += step_size)
                    {
                        for (x[4] = 0; x[4] <= 10; x[4] += step_size)
                        {
                            fx = func(x, 4);
                            if (fx > fxmax)
                            {
                                fxmax = fx;
                                for (int i = 0; i < 4; i++)
                                {
                                    xmax[i] = x[i];
                                }
                            }
                        }
                    }
                }
            }
        }
        printres(fxmax, xmax, 5, step_size);
    }


    public static double func(double[] x, int size)
    {
        double sum = 0;
        for(int i = 0; i < size; i++)
        {
            sum += Convert.ToDouble(Math.Sin(x[i]));
        }
        return sum;
    }
}
