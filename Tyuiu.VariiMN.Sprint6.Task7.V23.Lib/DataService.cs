using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VariiMN.Sprint6.Task7.V23.Lib
{
    public class DataService : ISprint6Task7V23
    {
        public int[,] GetMatrix(string path)
        {
            try
            {
                if (!File.Exists(path))
                    throw new FileNotFoundException($"Файл не найден: {path}");


                string[] lines = File.ReadAllLines(path, Encoding.UTF8);


                int rows = lines.Length;
                if (rows == 0) return new int[0, 0];


                string[] firstRowValues = ParseCSVLine(lines[0]);
                int cols = firstRowValues.Length;


                int[,] matrix = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    string[] values = ParseCSVLine(lines[i]);

                    for (int j = 0; j < cols; j++)
                    {
                        if (j < values.Length && int.TryParse(values[j].Trim(), out int num))
                        {
                            matrix[i, j] = num;
                        }
                        else
                        {
                            matrix[i, j] = 0;
                        }
                    }
                }


                int lastCol = cols - 1;
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, lastCol] < 2)
                    {
                        matrix[i, lastCol] = 2;
                    }
                }

                return matrix;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка обработки файла: {ex.Message}", ex);
            }
        }

        private string[] ParseCSVLine(string line)
        {
            if (string.IsNullOrEmpty(line))
                return new string[0];

            List<string> result = new List<string>();
            StringBuilder current = new StringBuilder();
            bool inQuotes = false;

            for (int i = 0; i < line.Length; i++)
            {
                char ch = line[i];

                if (ch == '"')
                {
                    inQuotes = !inQuotes;
                }
                else if (ch == ',' && !inQuotes)
                {
                    result.Add(current.ToString());
                    current.Clear();
                }
                else
                {
                    current.Append(ch);
                }
            }

            result.Add(current.ToString());
            return result.ToArray();
        }
    }
    }
}
