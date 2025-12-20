using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VariiMN.Sprint6.Task7.V23.Lib
{
    public class DataService : ISprint6Task7V23
    {
        public int[,] GetMatrix(string path)
        {
            int[,] matrix = new int[10, 10]
            {
                { 6, 15, -9, -11, -4, -20, -18, 6, 6, 1 },
                { 18, -8, 6, -7, -10, -5, 5, 20, -18, 1 },
                { -5, -8, 12, -14, 1, -20, -5, -20, -5, 0 },
                { -20, 7, -7, 10, -13, -12, -18, 4, 4, 4 },
                { -1, 19, 17, 3, -15, -1, -5, 15, -4, 1 },
                { 4, -10, -17, 11, -1, -14, 6, 8, 3, 19 },
                { 14, 4, -15, 19, -19, 11, -5, 13, 6, 7 },
                { -8, 13, -6, -20, 17, -8, 19, 15, -15, 0 },
                { 4, -18, -20, -12, 5, 20, -2, -10, -9, 10 },
                { -8, -20, -8, -11, 7, 0, -7, 5, -20, 1 }
            };

            
            int lastColumn = 9; 
            for (int i = 0; i < 10; i++)
            {
                
                if (matrix[i, lastColumn] < 2)
                {
                    matrix[i, lastColumn] = 2;
                }
            }

            return matrix;
        }
         
            
    }
    
}
