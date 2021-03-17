using Xunit;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Abstracts;
using System;
using System.IO;
using System.Collections.Generic;

namespace PizzaBox.Testing.Tests
{
    public class StoreTests
    {
        //1
        [Fact]
        public void Test_ChicagoStore()
        {
            //sut == subject under test
            //Arrange
            var sut = new ChicagoPizzaStore();
            var expected = "Chicago Pizza Store";

            //act
            var actual = sut.ToString();

            //assert
            Assert.Equal(expected, actual);
        }

        //2
        [Fact]
        public void Test_Address()
        {
            //sut == subject under test
            //Arrange
            String reader = "00 Street Name City State 00000";
            String[] readerSplitter = reader.Split(' ');
            Address address = new Address();
            if(readerSplitter.Length == 6)
            {
                address = new Address(int.Parse(readerSplitter[0]), (readerSplitter[1] + ' ' 
                    + readerSplitter[2]), readerSplitter[3], readerSplitter[4], int.Parse(readerSplitter[5]));
            }else if(readerSplitter.Length == 7){
                address = new Address(int.Parse(readerSplitter[0]), (readerSplitter[1] + ' ' 
                    + readerSplitter[2]), int.Parse(readerSplitter[3]), readerSplitter[4], readerSplitter[5], int.Parse(readerSplitter[6]));
            }else{
                Console.WriteLine("Not a valid input");
            }
            var sut = address;
            var expected = "00 Street Name\nCity State 00000";

            //act
            var actual = sut.ToString();

            //assert
            
            Assert.Equal(expected, actual);
        }
        //3
        [Fact]
        public void Test_Customer()
        {
            //sut == subject under test
            //Arrange
            String reader = "00 Street Name City State 00000";
            String[] readerSplitter = reader.Split(' ');
            Address address = new Address();
            if(readerSplitter.Length == 6)
            {
                address = new Address(int.Parse(readerSplitter[0]), (readerSplitter[1] + ' ' 
                    + readerSplitter[2]), readerSplitter[3], readerSplitter[4], int.Parse(readerSplitter[5]));
            }else if(readerSplitter.Length == 7){
                address = new Address(int.Parse(readerSplitter[0]), (readerSplitter[1] + ' ' 
                    + readerSplitter[2]), int.Parse(readerSplitter[3]), readerSplitter[4], readerSplitter[5], int.Parse(readerSplitter[6]));
            }else{
                Console.WriteLine("Not a valid input");
            }
            
            
            var sut = new Customer("Test Testerson", address);
            var expected = "Test Testerson";

            //act
            var actual = sut.CustomerName;

            //assert
            Assert.Equal(expected, actual);
        }
        //4
        [Fact]
        public void Test_Order()
        {
            //sut == subject under test
            //Arrange
            String reader = "00 Street Name City State 00000";
            String[] readerSplitter = reader.Split(' ');
            Address address = new Address();
            if(readerSplitter.Length == 6)
            {
                address = new Address(int.Parse(readerSplitter[0]), (readerSplitter[1] + ' ' 
                    + readerSplitter[2]), readerSplitter[3], readerSplitter[4], int.Parse(readerSplitter[5]));
            }else if(readerSplitter.Length == 7){
                address = new Address(int.Parse(readerSplitter[0]), (readerSplitter[1] + ' ' 
                    + readerSplitter[2]), int.Parse(readerSplitter[3]), readerSplitter[4], readerSplitter[5], int.Parse(readerSplitter[6]));
            }else{
                Console.WriteLine("Not a valid input");
            }
            Customer customer = new Customer("Test Testerson", address);
            var sut = new Order();
            var expected = "Test Testerson";

            //act
            var actual = sut.GetCustomerName();

            //assert
            Assert.Equal(expected, actual);
        }

        //5
        [Fact]
        public void Test_ChrisStore()
        {
            //sut == subject under test
            //Arrange
            var sut = new ChrisPizzaStore();
            var expected = "Chris' Pizza Store";

            //act
            var actual = sut.ToString();

            //assert
            Assert.Equal(expected, actual);
        }

        //6
        [Fact]
        public void Test_DetroitStore()
        {
            //sut == subject under test
            //Arrange
            var sut = new DetroitPizzaStore();
            var expected = "Detroit Pizza Store";

            //act
            var actual = sut.ToString();

            //assert
            Assert.Equal(expected, actual);
        }

        //7
        [Fact]
        public void Test_NewYorkStore()
        {
            //sut == subject under test
            //Arrange
            var sut = new NewYorkPizzaStore();
            var expected = "New York Pizza Store";

            //act
            var actual = sut.ToString();

            //assert
            Assert.Equal(expected, actual);
        }

        //8
        [Fact]
        public void Test_Topping()
        {
            //sut == subject under test
            //Arrange
            var sut = new Topping("Pepperonni", .5);
            var expected = "Pepperonni";
            var expected2 = .5;

            //act
            var actual = sut.Name;
            var actual2 = sut.Price;

            //assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
            
        }

        //9
        [Fact]
        public void Test_Size()
        {
            //sut == subject under test
            //Arrange
            var sut = new Size("Small", 5.0);
            var expected = "Small";
            var expected2 = 5.0;

            //act
            var actual = sut.Name;
            var actual2 = sut.Price;

            //assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }

        //10
        [Fact]
        public void Test_Crust()
        {
            //sut == subject under test
            //Arrange
            var sut = new Crust("Garlic and Herb", 1.0);
            var expected = "Garlic and Herb";
            var expected2 = 1.0;

            //act
            var actual = sut.Name;
            var actual2 = sut.Price;

            //assert
            
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }
    }
}

/* 
Unit test needs:
    Arrange
    Act
    Assert

*/
