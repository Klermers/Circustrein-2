using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Train
    {
        List<Wagon> wagons;
        Wagon add;
        //  string wagonnumb;


        public List<Wagon> Wagons
        {
            get { return wagons; }
        }

        public Train()
        {
            add = new Wagon();
            wagons = new List<Wagon>();
            wagons.Add(add);
        }

        public string TrainWagonCycleAdd(Animal animalrd)
        {
            int Nextwagon = 1;
            int CurrentWagon = 0;

            for (CurrentWagon = 0; CurrentWagon < Nextwagon; CurrentWagon++)
            {
                bool AnimalIsAdded = wagons[CurrentWagon].AnimalIsAdded(animalrd);

                if (AnimalIsAdded == false)
                {
                    Nextwagon++;
                    add = new Wagon();
                    wagons.Add(add);
                }
            }

            return string.Format("Animal added to {0}", wagons[CurrentWagon-1].ToString());
        }   

        public IReadOnlyList<Animal> Wagonanimals(int currentwagon)
        {
            return wagons[currentwagon].Animals;
        }

         /* public string TrainWagoncycle(Animal animalrd)
        {
            foreach(Wagon wagon in wagons)
            {
                if(wagon.WagonAdd(animalrd) == false)
                {
                    wagons.Add(wagonadd);
                }
                else if(wagon.WagonAdd(animalrd) == true)
                {
                    wagon.WagonAdd(animalrd);
                    wagonnumb = wagon.ToString();
                    break;
                }
            }

            return string.Format("Animal added to {0}", wagonnumb);
        }
        */
    }
}
