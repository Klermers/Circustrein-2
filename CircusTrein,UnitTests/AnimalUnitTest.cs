﻿using System;
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
            wagon.Animals = animals;
            var result = TestAnimal.CheckCarnivour(animals,2);
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
            var result = TestAnimal.CheckCarnivour(animals,2);
            //Assert
            Assert.IsFalse(result);

        }
        [TestMethod]
        public void CheckSizeHerbivour_checkcarnSize_Returnfalse()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal animal = new Animal("Zebra", 3, 1);
            Animal animal2 = new Animal("Zebra", 1, 1);
            List<Animal> animals = new List<Animal>();

            //Act
            animals.Add(animal2);
            wagon.Animals = animals;
            var result = animal.CheckSizeHerbivour(animals);

            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CheckSizeHerbivour_checkcarnSize_Returntrue()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal carnanimal = new Animal("Lion", 1, 2);
            Animal animal2 = new Animal("Zebra", 3, 1);
            List<Animal> animals = new List<Animal>();

            //Act
            animals.Add(animal2);
            wagon.Animals = animals;
            var result = carnanimal.CheckSizeHerbivour(animals);

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckSizeCarnivour_checkherbSize_Returnfalse()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal carnanimal = new Animal("Lion", 1, 2);
            Animal checkherb = new Animal("Zebra", 3, 1);
            List<Animal> animals = new List<Animal>();

            //Act
            animals.Add(carnanimal);
            wagon.Animals = animals;
            var result = carnanimal.CheckSizeCarnivour(animals,2);

            //Assert
            Assert.IsFalse(result);

        }
        [TestMethod]
        public void CheckSizeCarnivour_checkherbSize_Returntrue()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal carnanimal = new Animal("Lion", 1, 2);
            Animal checkherb = new Animal("Zebra", 3, 1);
            List<Animal> animals = new List<Animal>();

            //Act
            animals.Add(carnanimal);
            wagon.Animals = animals;
            var result = checkherb.CheckSizeCarnivour(animals,2);

            //Assert
            Assert.IsTrue(result);

        }
    }
}
