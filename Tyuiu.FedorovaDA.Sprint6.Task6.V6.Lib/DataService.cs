using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FedorovaDA.Sprint6.Task6.V6.Lib;

public class DataService : ISprint6Task6V6
{
    public string CollectTextFromFile(string str, string path)
    {
        StringBuilder result = new StringBuilder();

        try
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in words)
                    {
                        if (word.Contains("b", StringComparison.OrdinalIgnoreCase))
                        {
                            result.Append(word).Append(" ");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Ошибка: {ex.Message}", ex);
        }

        return result.ToString().Trim();
    }
}
