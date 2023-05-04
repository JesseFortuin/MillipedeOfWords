namespace MillipedeOfWords.Test
{
    public class MillipedeCheckerTest
    {
        [Fact]
        public void MillipedeSuccessTest()
        {
            //arrange
            IMillipedeChecker checker = new MillipedeChecker();

            string[] input = new string[] { "excavate", "endure", "screen", "desire", "theater", "excess", "night" };
            
            bool expected = true;

            //act
            bool actual = checker.Millipede(input);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MillipedeFailureTest()
        {
            //arrange
            IMillipedeChecker checker = new MillipedeChecker();

            string[] input = new string[] { "trade", "pole", "view", "grave", "ladder", "mushroom", "president" };

            bool expected = false;

            //act
            bool actual = checker.Millipede(input);

            //assert
            Assert.Equal(expected, actual);
        }

        public void MillipedeSingleLetterFail()
        {
            //arrange
            IMillipedeChecker checker = new MillipedeChecker();

            string[] input = new string[] { "a", "b", "v", "z", "x", "r", "e" };

            bool expected = false;

            //act
            bool actual = checker.Millipede(input);

            //assert
            Assert.Equal(expected, actual);
        }

        public void MillipedeSingleLetterSuccess()
        {
            //arrange
            IMillipedeChecker checker = new MillipedeChecker();

            string[] input = new string[] { "east", "e", "e", "t", "t", "e", "time" };

            bool expected = false;

            //act
            bool actual = checker.Millipede(input);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}