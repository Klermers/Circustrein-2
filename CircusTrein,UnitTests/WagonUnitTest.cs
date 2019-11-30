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
            var result =  wagon.AnimalIsAdded(checkherb);

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void WagonAdd_AddWagonHerbivour_ReturnFalse()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal checkherb = new Animal("Zebra", 3, 1);
            //Act
            wagon.AnimalIsAdded(checkherb);
            wagon.AnimalIsAdded(checkherb);
            wagon.AnimalIsAdded(checkherb);
            var result = wagon.AnimalIsAdded(checkherb);

            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void WagonAdd_AddWagonHerbivourWithSmallCarnivour_ReturnTrue()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal checkherb = new Animal("Zebra", 3, 1);
            Animal carnivour = new Animal("Lion", 2, 2);
            //Act
            wagon.AnimalIsAdded(carnivour);
            var result = wagon.AnimalIsAdded(checkherb);

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void WagonAdd_AddWagonHerbivourEqualSizeCarnivour_ReturnFalse()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal checkherb = new Animal("Zebra", 2, 1);
            Animal carnivour = new Animal("Lion", 2, 2);
            //Act
            wagon.AnimalIsAdded(carnivour);
            var result = wagon.AnimalIsAdded(checkherb);

            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void WagonAdd_AddWagonHerbivourWithBigCarnivour_ReturnFalse()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal checkherb = new Animal("Zebra", 1, 1);
            Animal carnivour = new Animal("Lion", 3, 2);
            //Act
            wagon.AnimalIsAdded(carnivour);
            var result = wagon.AnimalIsAdded(checkherb);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void WagonAdd_AddWagonCarnivourWithBigHerbivour_ReturnTrue()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal checkcarn = new Animal("Lion", 1, 2);
            Animal herbivour = new Animal("Zebra", 3, 1);
            //Act
            wagon.AnimalIsAdded(herbivour);
            var result = wagon.AnimalIsAdded(checkcarn);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void WagonAdd_AddWagonCarnivourWithSmallHerbivour_ReturnFalse()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal checkcarn = new Animal("Lion", 3, 2);
            Animal herbivour = new Animal("Zebra", 1, 1);
            //Act
            wagon.AnimalIsAdded(herbivour);
            var result = wagon.AnimalIsAdded(checkcarn);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void WagonAdd_AddWagonCarnivourEqualSizeHerbivour_ReturnFalse()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal checkcarn = new Animal("Lion", 1, 2);
            Animal herbivour = new Animal("Zebra", 1, 1);
            //Act
            wagon.AnimalIsAdded(herbivour);
            var result = wagon.AnimalIsAdded(checkcarn);
            //Assert
            Assert.IsFalse(result);
        }
        public void WagonAdd_AddWagonCarnivourWithCarnivour_ReturnFalse()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal checkcarn = new Animal("Lion", 1, 1);
            Animal herbivour = new Animal("Lion", 1, 1);
            //Act
            wagon.AnimalIsAdded(herbivour);
            var result = wagon.AnimalIsAdded(checkcarn);
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
            var result = wagon.AnimalIsAdded(checkcarn);
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
            wagon.AnimalIsAdded(checkherb2);
            wagon.AnimalIsAdded(checkherb2);
            wagon.AnimalIsAdded(checkherb2);
            var result = wagon.AnimalIsAdded(checkcarn);
            //Assert
            Assert.IsFalse(result);
        }
    }
}
