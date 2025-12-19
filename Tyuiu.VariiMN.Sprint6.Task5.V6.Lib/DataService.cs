using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VariiMN.Sprint6.Task5.V6.Lib
{
    public class DataService : ISprint6Task5V6

    {
        public int len = 20;
        public double[] LoadFromDataFile(string path)
        {
            List<double> result = new List<double>();

            try
            {

                string[] lines = File.ReadAllLines(path);


                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        if (double.TryParse(line.Trim(), out double number))
                        {

                            if (Math.Abs(Math.Round(number) % 3) < 0.000001)
                            {
                                result.Add(number);
                            }
                        }
                    }
                }


                return result.ToArray();
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException($"Файл не найден по пути: {path}");
            }
            catch (IOException ex)
            {
                throw new IOException($"Ошибка чтения файла: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка обработки данных: {ex.Message}");
            }
        
        }
    } 
}
