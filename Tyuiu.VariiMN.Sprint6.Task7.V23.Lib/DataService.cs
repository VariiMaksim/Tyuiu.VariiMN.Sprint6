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
                {
                    throw new FileNotFoundException($"Файл не найден: {path}");
                }

                
                string[] lines = File.ReadAllLines(path, Encoding.Default);

                // Определяем количество строк
                int rows = lines.Length;
                if (rows == 0)
                {
                    return new int[0, 0];
                }

                
                string[] firstRow = lines[0].Split(',');
                int cols = firstRow.Length;

                
                int[,] matrix = new int[rows, cols];

                
                for (int i = 0; i < rows; i++)
                {
                    string line = lines[i];

                    
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        
                        for (int j = 0; j < cols; j++)
                        {
                            matrix[i, j] = 0;
                        }
                        continue;
                    }

                    
                    string[] values = line.Split(',');

                    
                    for (int j = 0; j < cols; j++)
                    {
                        if (j < values.Length && !string.IsNullOrWhiteSpace(values[j]))
                        {
                            
                            if (int.TryParse(values[j].Trim(), out int value))
                            {
                                matrix[i, j] = value;
                            }
                            else
                            {
                                matrix[i, j] = 0;
                            }
                        }
                        else
                        {
                            matrix[i, j] = 0; 
                        }
                    }
                }

                
                int lastColumn = cols - 1;
                for (int i = 0; i < rows; i++)
                {
                    
                    if (matrix[i, lastColumn] < 2)
                    {
                        matrix[i, lastColumn] = 2;
                    }
                }

                return matrix;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при обработке файла: {ex.Message}", ex);
            }
        }
         
            
    }
    
}
