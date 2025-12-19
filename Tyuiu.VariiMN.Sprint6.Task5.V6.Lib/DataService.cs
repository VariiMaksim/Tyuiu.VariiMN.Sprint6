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
                        string trimmedLine = line.Trim();


                        if (int.TryParse(trimmedLine, out int intNumber))
                        {

                            if (intNumber % 3 == 0)
                            {
                                result.Add(intNumber);
                            }
                        }
                        else if (double.TryParse(trimmedLine, out double doubleNumber))
                        {

                            double rounded = Math.Round(doubleNumber);
                            if (Math.Abs(doubleNumber - rounded) < 0.0001) 
                            {
                                int intValue = (int)rounded;
                                if (intValue % 3 == 0)
                                {
                                    result.Add(doubleNumber);
                                }
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
