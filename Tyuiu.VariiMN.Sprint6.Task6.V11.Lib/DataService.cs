using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VariiMN.Sprint6.Task6.V11.Lib
{
    public class DataService : ISprint6Task6V11
    {
        public string CollectTextFromFile(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    throw new FileNotFoundException($"Файл не найден: {path}");
                }

                List<string> resultWords = new List<string>();


                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {

                        string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                        if (words.Length >= 2)
                        {

                            resultWords.Add(words[words.Length - 2]);
                        }

                    }
                }


                return string.Join(" ", resultWords);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка обработки файла: {ex.Message}", ex);
            }
        }
    }
    }
}
