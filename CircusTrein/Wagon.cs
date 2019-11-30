                using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Wagon
    {
        private int currentWagonNumb;
        private static int Wagoncycle = 0;
        private int Wagonroom = 0;
        private int totalRoom  = 10;
        private List<Animal> animals = new List<Animal>();
        public enum Food { Herbivour = 1, Carnivour = 2 }

        public Wagon()
        {
            Wagoncycle +=1;
            currentWagonNumb = Wagoncycle;
        }
        public IReadOnlyList<Animal> Animals
        {
            get { return this.animals; }
        }

        private bool HerbivoreIsAdded(Animal animalrd)
        {
            if (animalrd.AnimalisCarnivour(animals, (int)Food.Carnivour) == true)
            {
                if (animalrd.Animalsizeis_BiggerThanCarnivour(animals, (int)Food.Carnivour) == true)
                {
                    if (Wagonroom + animalrd.Size <= totalRoom)
                    {
                        Wagonroom += animalrd.Size;
                        return true;
                    }
                }
            }
            else if (animalrd.AnimalisCarnivour(animals, (int)Food.Carnivour) == false)
            {
                if (Wagonroom + animalrd.Size <= totalRoom)
                {
                    Wagonroom += animalrd.Size;
                    return true;
                }
            }
            return false;
        }

        private bool CarnivourIsAdded(Animal animalrd)
        {
            if(animalrd.AnimalisCarnivour(animals, (int)Food.Carnivour) == false)
            {
                if (animalrd.Animalsizeis_SmallerThanHerbivour(animals) == true)
                {
                    if (Wagonroom + animalrd.Size <= totalRoom)
                    {
                        Wagonroom += animalrd.Size;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool AnimalIsAdded(Animal animalrd)
        {
            if(animalrd.Type == (int)Food.Carnivour)
            {
                if(CarnivourIsAdded(animalrd) == true)
                {
                    animals.Add(animalrd);
                    return true;
                }
            }
            else if (animalrd.Type == (int)Food.Herbivour)
            {
                if (HerbivoreIsAdded(animalrd) == true)
                {
                    animals.Add(animalrd);
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return "Wagon" + currentWagonNumb.ToString();
        }

    }
}
