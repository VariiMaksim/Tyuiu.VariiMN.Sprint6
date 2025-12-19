using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VariiMN.Sprint6.Task4.V28.Lib
{
    public class DataService : ISprint6Task4V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double fx = 0.0;

                double denominator = x + 2.5;

                if (denominator == 0)
                {
                    fx = 0.0;
                }
                else
                {
                    fx = Math.Cos(2 * x) + Math.Sin(x)/ denominator + 2 * x;
                }

                fx = Math.Round(fx, 2);
                result[index] = fx;
                index++;
            }

            return result;
        }
    }
}
