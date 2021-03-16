using Xunit;
using PizzaBox.Domain.Models;

namespace PizzaBox.Testing.Tests
{
    public class StoreTests
    {
        [Fact]
        public void Test_ChicagoStore()
        {
            //sut == subject under test
            //Arrange
            var sut = new ChicagoPizzaStore();
            var expected = "Chicago Store";

            //act
            var actual = sut.StoreName;

            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Chicago Store")]
        public void Test_ChicagoStore_Theory(string expected)
        {
            //sut == subject under test
            //Arrange
            var sut = new ChicagoPizzaStore();

            //act
            var actual = sut.StoreName;

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
