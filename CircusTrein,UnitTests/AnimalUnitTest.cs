using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTrein;
using System.Collections.Generic;

namespace CircusTrein_UnitTests
{
    [TestClass]
    public class AnimalUnitTest
    {
        [TestMethod]
        public void CheckCarnivour_animalTypeCarnivour_Returntrue()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal TestAnimal = new Animal("Lion", 3, 2);
            List<Animal> animals = new List<Animal>();

            //Act
            animals.Add(TestAnimal);
            var result = TestAnimal.AnimalisCarnivour(animals,2);
            //Assert
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void CheckCarnivour_animalTypeNoCarnivour_Returnfalse()
        {
            //Arange
            Wagon wagon = new Wagon();
            List<Animal> animals = new List<Animal>();


            //Act
            Animal TestAnimal = new Animal("Lion", 3, 2);
            var result = TestAnimal.AnimalisCarnivour(animals,2);
            //Assert
            Assert.IsFalse(result);

        }
        [TestMethod]
        public void Isanimalsize_SmallerThanHerbivour_checkcarnSize_Returnfalse()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal animal = new Animal("lion", 3, 2);
            Animal animal2 = new Animal("Zebra", 1, 1);
            List<Animal> animals = new List<Animal>();

            //Act
            animals.Add(animal2);
            var result = animal.Animalsizeis_SmallerThanHerbivour(animals);

            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Isanimalsize_SmallerThanHerbivour_checkcarnSize_Returntrue()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal carnanimal = new Animal("Lion", 1, 2);
            Animal animal2 = new Animal("Zebra", 3, 1);
            List<Animal> animals = new List<Animal>();

            //Act
            animals.Add(animal2);
            var result = carnanimal.Animalsizeis_SmallerThanHerbivour(animals);

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Isanimalsize_BiggerThanCarnivour_checkherbSize_Returnfalse()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal carnanimal = new Animal("Lion", 5, 2);
            Animal checkherb = new Animal("Zebra", 3, 1);
            List<Animal> animals = new List<Animal>();

            //Act
            animals.Add(carnanimal);
            var result = checkherb.Animalsizeis_BiggerThanCarnivour(animals,2);

            //Assert
            Assert.IsFalse(result);

        }
        [TestMethod]
        public void Isanimalsize_BiggerThanCarnivour_checkherbSize_Returntrue()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal carnanimal = new Animal("Lion", 1, 2);
            Animal checkherb = new Animal("Zebra", 3, 1);
            List<Animal> animals = new List<Animal>();

            //Act
            animals.Add(carnanimal);
            var result = checkherb.Animalsizeis_BiggerThanCarnivour(animals,2);
            //Assert
            Assert.IsTrue(result);

        }
    }
}
