using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Animal
    {
        private string name;
        private int size;
        private int type;

        public Animal(string name, int size, int type)
        {
            this.name = name;
            this.size = size;
            this.type = type;

        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public int Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public bool CheckCarnivour(List<Animal> animals,int type)
        {
            foreach (var animal in animals)
            {
                if (type == animal.type )
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckSizeAnimalType(List<Animal> animals, int typecarn, int typeherb)
        {
            foreach(Animal animal in animals)
            {
                if(animal == typecarn)
                {

                }
                else if (animal == typeherb)
                {

                }
            }
        }

        public bool CheckSizeHerbivour(Animal checkcarn, List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                if (animal.Size <= checkcarn.Size)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckSizeCarnivour(Animal checkherb, List<Animal> animals, int type)
        {
            foreach (var animal in animals)
            {
                if (animal.Type == type)
                {
                    if (checkherb.Size <= animal.Size)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public override string ToString()
        {
            return Name + " " + size + " " + type;
        }
    }
}
