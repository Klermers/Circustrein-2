using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTrein;
using System.Collections.Generic;

namespace CircusTrein_UnitTests
{
    [TestClass]
    public class WagonTest
    {
        [TestMethod]
        public void WagonAdd_AddWagonHerbivour_ReturnTrue()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal checkherb = new Animal("Zebra", 3, 1);
            //Act
            var result =  wagon.WagonAdd(checkherb);

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void WagonAdd_CAddWagonHerbivour_ReturnFalse()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal checkherb = new Animal("Zebra", 3, 1);
            //Act
            wagon.WagonAdd(checkherb);
            wagon.WagonAdd(checkherb);
            wagon.WagonAdd(checkherb);
            var result = wagon.WagonAdd(checkherb);

            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void WagonAdd_AddWagonCarnivour_ReturnTrue()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal checkcarn = new Animal("Lion", 3, 1);
            //Act
            var result = wagon.WagonAdd(checkcarn);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void WagonAdd_AddWagonCarnivour_ReturnFalse()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal checkcarn = new Animal("Lion", 3, 2);
            Animal checkherb2 = new Animal("Zebra", 3, 1);
            //Act
            wagon.WagonAdd(checkherb2);
            wagon.WagonAdd(checkherb2);
            wagon.WagonAdd(checkherb2);
            var result = wagon.WagonAdd(checkcarn);
            //Assert
            Assert.IsFalse(result);
        }
    }
}
