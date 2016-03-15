using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart;

namespace PotterShoppingCartTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Buy_one_should_be_100()
        {
            //arrange
            var shoppingCar = new ShoppingCart();
            var expected=100; 
            shoppingCar.AddBookSetToCar(1);  //加入第一集
               
            //act
            var actual = shoppingCar.CheckOut();   
            //assertrt
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_one_two_should_be_190()
        {
            //arrange
            var shoppingCar = new ShoppingCart();
            var expected = 190;
            shoppingCar.AddBookSetToCar(1);  //加入第一集
            shoppingCar.AddBookSetToCar(2);  //加入第二集

            //act
            var actual = shoppingCar.CheckOut();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_one_two_three_should_be_270()
        {
            //arrange
            var shoppingCar = new ShoppingCart();
            var expected = 270;
            shoppingCar.AddBookSetToCar(1);  //加入第一集
            shoppingCar.AddBookSetToCar(2);  //加入第二集
            shoppingCar.AddBookSetToCar(3);  //加入第三集

            //act
            var actual = shoppingCar.CheckOut();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_one_two_three_four_should_be_320()
        {
            //arrange
            var shoppingCar = new ShoppingCart();
            var expected = 320;
            shoppingCar.AddBookSetToCar(1);  //加入第一集
            shoppingCar.AddBookSetToCar(2);  //加入第二集
            shoppingCar.AddBookSetToCar(3);  //加入第三集
            shoppingCar.AddBookSetToCar(4);  //加入第四集

            //act
            var actual = shoppingCar.CheckOut();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_one_two_three_four_five_should_be_375()
        {
            //arrange
            var shoppingCar = new ShoppingCart();
            var expected = 375;
            shoppingCar.AddBookSetToCar(1);  //加入第一集
            shoppingCar.AddBookSetToCar(2);  //加入第二集
            shoppingCar.AddBookSetToCar(3);  //加入第三集
            shoppingCar.AddBookSetToCar(4);  //加入第四集
            shoppingCar.AddBookSetToCar(5);  //加入第五集

            //act
            var actual = shoppingCar.CheckOut();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_one_two_three_three_should_be_370()
        {
            //arrange
            var shoppingCar = new ShoppingCart();
            var expected = 370;
            shoppingCar.AddBookSetToCar(1);  //加入第一集
            shoppingCar.AddBookSetToCar(2);  //加入第二集
            shoppingCar.AddBookSetToCar(3);  //加入第三集
            shoppingCar.AddBookSetToCar(3);  //加入第三集
    
            //act
            var actual = shoppingCar.CheckOut();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_one_two_two_three_three_should_be_460()
        {
            //arrange
            var shoppingCar = new ShoppingCart();
            var expected = 460;
            shoppingCar.AddBookSetToCar(1);  //加入第一集
            shoppingCar.AddBookSetToCar(2);  //加入第二集
            shoppingCar.AddBookSetToCar(2);  //加入第二集
            shoppingCar.AddBookSetToCar(3);  //加入第三集
            shoppingCar.AddBookSetToCar(3);  //加入第三集

            //act
            var actual = shoppingCar.CheckOut();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
    
}
