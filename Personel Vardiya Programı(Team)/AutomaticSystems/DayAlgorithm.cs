using Personel_Vardiya_Programı_Team_.Base_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Personel_Vardiya_Programı_Team_.AutomaticSystems.AutomaticVardiyaAlgoritm;

namespace Personel_Vardiya_Programı_Team_.AutomaticSystems
{
    public class DayAlgorithm
    {
        LinkedList<PersonalStabilizer> randomedList;
        LinkedList<PersonalStabilizer> chosenList = new LinkedList<PersonalStabilizer>();

        public DayAlgorithm() { }
        public DayAlgorithm(LinkedList<PersonalStabilizer> list)
        {
            randomedList = list;
        }

        public void StartAlgorithm()
        {
            chosenList.Clear();
            for (int i = 0; i < 5; i++)
            {
                PersonalStabilizer p = ChosePersonal();
                for (int a = 0; a < chosenList.Count; a++)
                {
                    if (chosenList.ToArray()[a].personel.Id == p.personel.Id)
                    {
                        p = ChosePersonal();
                        a = 0;
                        continue;
                    }
                    continue;
                }
                randomedList.Remove(p);
                chosenList.AddLast(p);

            }
        }

        public PersonalStabilizer[] GetChosenPersonals()
        {
            return chosenList.ToArray();
        }

        public PersonalStabilizer ChosePersonal()
        {
            if (randomedList == null) throw new ArgumentNullException();
            Random rand = new Random();
            int randNumber = rand.Next(randomedList.Count);
            PersonalStabilizer s = randomedList.ToArray()[randNumber];
            return s;
        }


        public void setIds(Personal[] p)
        {

        }

    }
}
