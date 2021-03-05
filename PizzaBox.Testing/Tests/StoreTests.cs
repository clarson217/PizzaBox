using XUnit;

namespace PizzaBox.Testing.Tests
{
    public class StoreTests
    {
        [Fact]
        public void Test_ChicagoStore()
        {
            //sut == subject under test
            //Arrange
            var sut = new ChicagoStore();
            var expected = "Chicago Store";

            //act
            var actual = sut.Name;

            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Chicago Store")]
        public void Test_ChicagoStore_Theory(string expected)
        {
            //sut == subject under test
            //Arrange
            var sut = new ChicagoStore();

            //act
            var actual = sut.Name;

            //assert
            Assert.Equal(expected, actual);
        }
    }
}

/* 
Unit test needs:
    Arrange
    Act
    Assert

*/