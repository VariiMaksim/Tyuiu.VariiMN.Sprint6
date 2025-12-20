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

                List<string[]> linesData = new List<string[]>();
                int maxCols = 0;

                using (StreamReader reader = new StreamReader(path, Encoding.Default))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {

                            string[] values = line.Split(',');
                            linesData.Add(values);
                            maxCols = Math.Max(maxCols, values.Length);
                        }
                    }
                }

                int rows = linesData.Count;
                int cols = maxCols;
                int[,] matrix = new int[rows, cols];


                for (int i = 0; i < rows; i++)
                {
                    string[] rowValues = linesData[i];
                    for (int j = 0; j < cols; j++)
                    {
                        if (j < rowValues.Length && int.TryParse(rowValues[j].Trim(), out int value))
                        {
                            matrix[i, j] = value;
                        }
                        else
                        {
                            matrix[i, j] = 0; 
                        }
                    }
                }


                for (int i = 0; i < rows; i++)
                {
                    int lastCol = cols - 1;
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
    }
}
