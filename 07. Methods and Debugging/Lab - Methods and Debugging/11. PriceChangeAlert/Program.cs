using System;

namespace _11.PriceChangeAlert
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double significanceThreshhold = double.Parse(Console.ReadLine());
            double previousPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double difference = differencePercent(previousPrice, currentPrice);
                bool isSignificantDifference = IsThereDifference(difference, significanceThreshhold);

                string message = PrintProperMessage(currentPrice, previousPrice, difference, isSignificantDifference);

                Console.WriteLine(message);

                previousPrice = currentPrice;
            }
        }

        private static string PrintProperMessage(double current, double previous, double difference, bool eitherTrueOrFalse)
        {
            string properMessage = "";

            if (difference == 0)
            {
                properMessage = string.Format("NO CHANGE: {0}", current);
            }
            else if (!eitherTrueOrFalse)
            {
                properMessage = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previous, current, difference * 100);
            }
            else if (eitherTrueOrFalse && (difference > 0))
            {
                properMessage = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previous, current, difference * 100);
            }
            else if (eitherTrueOrFalse && (difference < 0))
                properMessage = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previous, current, difference * 100);

            return properMessage;
        }

        private static bool IsThereDifference(double limit, double isDiff)
        {

            if (Math.Abs(limit) >= isDiff)
            {
                return true;
            }

            return false;
        }

        private static double differencePercent(double previous, double current)
        {
            return (current - previous) / previous;
        }
    }
}

            