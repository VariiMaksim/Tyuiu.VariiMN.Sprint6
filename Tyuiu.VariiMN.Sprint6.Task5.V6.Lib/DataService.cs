using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VariiMN.Sprint6.Task5.V6.Lib
{
    public class DataService : ISprint6Task5V6

    {
        public int len = 20;
        public double[] LoadFromDataFile(string path)
        {
            List<int> numbers = new List<int>();

            try
            {
                
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null && numbers.Count < len)
                    {
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        if (int.TryParse(line.Trim(), out int number))
                        {
                            numbers.Add(number);
                        }
                    }
                }

                
                while (numbers.Count < len)
                {
                    numbers.Add(0);
                }

                
                List<double> result = new List<double>();
                foreach (int num in numbers)
                {
                    if (num % 3 == 0)
                    {
                        result.Add(num);
                    }
                }

                return result.ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка: {ex.Message}");
            }
        }
    }
    
}
