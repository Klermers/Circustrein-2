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
        private static int Wagoncycle = 1;
        private int Wagonroom = 0;
        private int totalRoom  = 10;
        private List<Animal> animals = new List<Animal>();
        public enum Food { Herbivour = 1, Carnivour = 2 }

        public Wagon()
        {
            currentWagonNumb= Wagoncycle;
            Wagoncycle +=1;
        }
        public List<Animal> Animals
        {
            get { return this.animals; }
            set { animals = value; }
        }

        public bool AddWagonHerbivore(Animal animalrd)
        {
            if (animalrd.CheckCarnivour(Animals,(int)Food.Carnivour) == true)
            {
                if (animalrd.CheckSizeCarnivour(Animals,(int)Food.Carnivour) == true)
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

        public bool AddWagonCarnivour(Animal animalrd)
        {
            if(animalrd.CheckCarnivour(Animals,(int)Food.Carnivour) == false)
            {
                if (animalrd.CheckSizeHerbivour(Animals) == true)
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
