using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VariiMN.Sprint6.Task2.V3.Lib
{
    public class DataService : ISprint6Task2V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double fx = 0.0;

                double denominator = x + 1.2;

                if (denominator == 0)
                {
                    fx = 0.0;
                }
                else
                {
                    fx = Math.Sin(x) / denominator + Math.Cos(x) + 7 * x - 2;
                }

                fx = Math.Round(fx, 2);
                result[index] = fx;
                index++;
            }

            return result;
        }
    }
}
