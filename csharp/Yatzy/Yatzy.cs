namespace Yatzy
{
    public class Yatzy
    {
        public static int Chance(int d1, int d2, int d3, int d4, int d5)
        {
            var total = 0;
            total += d1;
            total += d2;
            total += d3;
            total += d4;
            total += d5;
            return total;
        }

        public static int Ones(int d1, int d2, int d3, int d4, int d5)
        {
            return 0;
        }
        
        public static int Twos(int d1, int d2, int d3, int d4, int d5)
        {
            return 0;
        }
    }
}