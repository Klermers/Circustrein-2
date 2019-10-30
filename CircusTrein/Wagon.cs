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
        public List<Animal> Animals
        {
            get { return this.animals; }
            set { animals = value; }
        }

        private bool AddWagonHerbivore(Animal animalrd)
        {
            if (animalrd.CheckCarnivour(Animals,(int)Food.Carnivour) == true)
            {
                if (animalrd.Isanimalsize_BiggerThanCarnivour(Animals,(int)Food.Carnivour) == true)
                {
                    if (Wagonroom + animalrd.Size <= totalRoom)
                    {
                        Wagonroom += animalrd.Size;
                        return true;
                    }
                }
            }
            else if (animalrd.CheckCarnivour(Animals,(int)Food.Carnivour) == false)
            {
                if (Wagonroom + animalrd.Size <= totalRoom)
                {
                    Wagonroom += animalrd.Size;
                    return true;
                }
            }
            return false;
        }

        private bool AddWagonCarnivour(Animal animalrd)
        {
            if(animalrd.CheckCarnivour(Animals,(int)Food.Carnivour) == false)
            {
                if (animalrd.Isanimalsize_SmallerThanHerbivour(Animals) == true)
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

        public bool WagonAdd(Animal animalrd)
        {
            if(animalrd.Type == (int)Food.Carnivour)
            {
                if(AddWagonCarnivour(animalrd) == true)
                {
                    return true;
                }
            }
            else if (animalrd.Type == (int)Food.Herbivour)
            {
                if (AddWagonHerbivore(animalrd) == true)
                {
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
