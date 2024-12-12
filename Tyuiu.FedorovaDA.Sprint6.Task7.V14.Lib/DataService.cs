using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FedorovaDA.Sprint6.Task7.V14.Lib;

public class DataService : ISprint6Task7V14
{
    public int[,] GetMatrix(string path)
    {
        List<int[]> matrixList = new List<int[]>();
        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Изменяем разделитель на ';'
                string[] values = line.Split(';');
                int[] intValues = Array.ConvertAll(values, int.Parse);
                matrixList.Add(intValues);
            }
        }

        int rows = matrixList.Count;
        int columns = matrixList[0].Length;
        int[,] matrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = matrixList[i][j];
            }
        }

        if (rows > 1)
        {
            for (int j = 0; j < columns; j++)
            {
                if (matrix[1, j] % 2 == 0)
                {
                    matrix[1, j] = 44;
                }
            }
        }

        return matrix;
    }
}
