using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FedorovaDA.Sprint6.Task6.V6.Lib;

public class DataService : ISprint6Task6V6
{
    public string CollectTextFromFile(string path)
    {
        StringBuilder result = new StringBuilder();

        try
        {
            string input;
            using (var reader = new StreamReader(path))
            {
                input = reader.ReadToEnd();
            }

            
            var words = input.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var wordsWithLowercaseB = new List<string>();

            
            foreach (var word in words)
            {
                if (word.Contains('b'))
                {
                    wordsWithLowercaseB.Add(word);
                }
            }
            return string.Join(" ", wordsWithLowercaseB);
            
        }
        catch (Exception ex)
        {
            throw new Exception($"Ошибка: {ex.Message}", ex);
        }

        
    }
}

