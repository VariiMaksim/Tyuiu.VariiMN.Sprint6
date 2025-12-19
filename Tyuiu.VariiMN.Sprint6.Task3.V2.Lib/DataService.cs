using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VariiMN.Sprint6.Task3.V2.Lib
{
    public class DataService : ISprint6Task3V2
    {
        public int[,] Calculate(int[,] matrix)
        {
            
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                
                int[,] resultMatrix = (int[,])matrix.Clone();

                
                if (rows < 1 || cols < 1)
                {
                    throw new ArgumentException("Матрица должна иметь хотя бы 1 строку и 1 столбец");
                }

                

                for (int j = 0; j < cols; j++)
                {
                    
                    if (resultMatrix[0, j] % 2 == 0)
                    {
                        resultMatrix[0, j] = 0;
                    }
                }

                return resultMatrix;
            
        }
    }
}
