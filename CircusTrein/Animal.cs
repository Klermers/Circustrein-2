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

        private string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Size
        {   
            get { return this.size; }
        }

        public int Type
        {
            get { return this.type; }
        }

        public bool AnimalisCarnivour(List<Animal> animals,int type)
        {
            foreach (var animal in animals)
            {
                if (type == animal.Type )
                {
                    return true;
                }
            }
            return false;
        }

        public bool Animalsizeis_SmallerThanHerbivour(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                if (animal.Size <= size)
                {
                    return false;
                }
            }
            return true;
        }

        public bool Animalsizeis_BiggerThanCarnivour(List<Animal> animals, int type)
        {
            foreach (var animal in animals)
            {
                if (animal.Type == type)
                {
                    if (size <= animal.Size)
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
