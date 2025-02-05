using System.Text;

namespace ImpjCodingAssesment.Tests.Utils
{
    internal static class Randomizer
    {
        private static readonly Random _random = new();

        public static int RandomInt() => _random.Next(1, 1000);

        public static long RandomLong(long minValue = 1, long maxValue = 100000)
        {
            byte[] buffer = new byte[8];
            _random.NextBytes(buffer);

            long longRand = BitConverter.ToInt64(buffer, 0);
            return Math.Abs(longRand % (maxValue - minValue)) + minValue;
        }

        public static decimal RandomDecimal(decimal minValue = 1, decimal maxValue = 100000000)
        {
            double range = (double)(maxValue - minValue);
            double sample = _random.NextDouble();
            decimal randomValue = (decimal)(sample * range) + minValue;

            return Math.Round(randomValue, 2);
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringBuilder = new StringBuilder(length);

            for (int i = 0; i < length; i++) stringBuilder.Append(chars[_random.Next(chars.Length)]);
            return stringBuilder.ToString();
        }
    }
}
