using System.Collections.Generic;
using CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircusTrein_UnitTests
{
    [TestClass]
    public class Traintest
    {
        [TestMethod]
        public void TrainWagonAdd_Animalcycle_ReturnString()
        {
            //arrange

            Train train = new Train();
            Animal animalrd = new Animal("Zebra", 3, 1);

            //act

            var result = train.TrainWagonCycleAdd(animalrd);

            //assert

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TrainWagonAdd_AddHerbivourToFirstWagon_AreEqualWagon1()
        {
            //arrange

            Train train = new Train();
            Animal animalrd = new Animal("Zebra", 3, 1);
            string compareresult = "Animal added to Wagon1";

            //act

            var result = train.TrainWagonCycleAdd(animalrd);

            //assert

            Assert.AreEqual(result,compareresult);
        }
        [TestMethod]
        public void TrainWagonAdd_AddCarnivourToFirstWagon_AreEqualWagon1()
        {
            //arrange

            Train train = new Train();
            Animal animalrd = new Animal("Lion", 3, 2);
            string compareresult = "Animal added to Wagon1";

            //act

            var result = train.TrainWagonCycleAdd(animalrd);

            //assert

            Assert.AreEqual(result, compareresult);
        }
        [TestMethod]
        public void TrainWagonAdd_AddCarnivourToNextWagon_AreEqualWagon2()
        {
            //arrange

            Train train = new Train();
            Animal animalrd = new Animal("Lion", 3, 2);
            Animal animalrd2 = new Animal("Zebra", 3, 1);
            string compareresult = "Animal added to Wagon2";

            //act
            train.TrainWagonCycleAdd(animalrd2);
            var result = train.TrainWagonCycleAdd(animalrd);

            //assert

            Assert.AreEqual(result, compareresult);
        }
        [TestMethod]
        public void TrainWagonAdd_AddHerbivourToNextWagon_AreEqualWagon2()
        {
            //arrange
            Train train = new Train();
            Animal animalrd = new Animal("Zebra", 3, 1);
            Animal animalrd2 = new Animal("Lion", 3, 2);
            string compareresult = "Animal added to Wagon2";

            //act
            train.TrainWagonCycleAdd(animalrd2);
            var result = train.TrainWagonCycleAdd(animalrd);

            //assert

            Assert.AreEqual(result, compareresult);
        }


    }
}
