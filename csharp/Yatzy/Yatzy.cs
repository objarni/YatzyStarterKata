namespace Yatzy
{
    public class Yatzy
    {
        public static int Chance(int dice1, int dice2, int dice3, int dice4, int dice5)
        {
            var total = 0;
            total += dice1;
            total += dice2;
            total += dice3;
            total += dice4;
            total += dice5;
            return total;
        }

        public static int Ones(int dice1, int dice2, int dice3, int dice4, int dice5)
        {
            return 0;
        }
        
        public static int Twos(int dice1, int dice2, int dice3, int dice4, int dice5)
        {
            return 0;
        }
    }
}
