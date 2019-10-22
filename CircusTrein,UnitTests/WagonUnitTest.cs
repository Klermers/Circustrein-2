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
        public void AddWagonHerbivour_CheckSizeWagon_ReturnTrue()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal checkherb = new Animal("Zebra", 3, 1);
            //Act
            var result =  wagon.AddWagonHerbivore(checkherb);

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void AddWagonHerbivour_CheckSizeWagon_ReturnFalse()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal checkherb = new Animal("Zebra", 3, 1);
            //Act
            wagon.AddWagonHerbivore(checkherb);
            wagon.AddWagonHerbivore(checkherb);
            wagon.AddWagonHerbivore(checkherb);
            var result = wagon.AddWagonHerbivore(checkherb);

            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void AddWagonCarnivour_CheckSizeWagon_ReturnTrue()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal checkcarn = new Animal("Lion", 3, 1);
            //Act
            var result = wagon.AddWagonCarnivour(checkcarn);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void AddWagonCarnivour_CheckSizeWagon_ReturnFalse()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal checkcarn = new Animal("Lion", 3, 1);
            //Act
            wagon.AddWagonCarnivour(checkcarn);
            wagon.AddWagonCarnivour(checkcarn);
            wagon.AddWagonCarnivour(checkcarn);
            var result = wagon.AddWagonCarnivour(checkcarn);
            //Assert
            Assert.IsFalse(result);
        }
    }
}
