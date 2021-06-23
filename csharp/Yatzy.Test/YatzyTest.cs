using Xunit;

namespace Yatzy.Test
{
    public class YatzyTest
    {
        [Fact]
        public void Chance_scores_sum_of_all_dice()
        {
            var expected = 15;
            var actual = Yatzy.Chance(2, 3, 4, 5, 1);
            Assert.Equal(expected, actual);
        }
   }
}
