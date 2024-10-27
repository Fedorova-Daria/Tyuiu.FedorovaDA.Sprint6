using tyuiu.cources.programming.interfaces.Sprint6;
using Tyuiu.FedorovaDA.Sprint6.Task1.V22.Lib;
namespace Tyuiu.FedorovaDA.Sprint6.Task1.V22.Lib
{
    public class DataService : ISprint6Task1V22
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
                if (Math.Cos(x) + 1 == 0)
                {
                    valueArray[count] = 0;
                    count++;
                }
                y = Math.Round(3 * x + 2 - (2 * x - x) / (Math.Cos(x) + 1), 2);
                valueArray[count] = y;
                count++;
            }
            
            return valueArray;

        }
    }
}
