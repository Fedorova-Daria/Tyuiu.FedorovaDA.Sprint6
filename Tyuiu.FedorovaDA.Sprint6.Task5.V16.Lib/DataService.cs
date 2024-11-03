using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FedorovaDA.Sprint6.Task5.V16.Lib
{
    public class DataService : ISprint6Task5V16
    {
        public double[] LoadFromDataFile(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);

                double[] tempArray = new double[lines.Length];
                int count = 0;

                for (int i = 0; i < lines.Length; i++)
                {
                    if (double.TryParse(lines[i], out double value))
                    {
                        if (value > 0)
                        {
                            tempArray[count] = Math.Round(value, 3);
                            count++;
                        }
                    }
                }

                double[] result = new double[count];
                for (int i = 0; i < count; i++)
                {
                    result[i] = tempArray[i];
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при обработке файла: {ex.Message}");
            }
        }
    }
}
