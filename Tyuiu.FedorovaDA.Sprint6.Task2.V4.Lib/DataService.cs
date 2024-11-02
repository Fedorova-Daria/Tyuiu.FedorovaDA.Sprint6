﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FedorovaDA.Sprint6.Task2.V4.Lib
{
    public class DataService : ISprint6Task2V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) + 2 == 0)
                {
                    valueArray[count] = 0;
                    count++;
                }
                y = Math.Round((5 * x + 2.5) / (Math.Sin(x) + 2) + 2 * x + 2, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
