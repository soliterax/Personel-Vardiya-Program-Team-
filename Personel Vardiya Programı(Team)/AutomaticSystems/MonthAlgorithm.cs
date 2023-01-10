using Personel_Vardiya_Programı_Team_.Base_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Personel_Vardiya_Programı_Team_.AutomaticSystems.AutomaticVardiyaAlgoritm;

namespace Personel_Vardiya_Programı_Team_.AutomaticSystems
{
    public class MonthAlgorithm
    {

        LinkedList<PersonalStabilizer> list;
        LinkedList<PersonalStabilizer[][]> chosenList = new LinkedList<PersonalStabilizer[][]>();

        public MonthAlgorithm() { }
        public MonthAlgorithm(LinkedList<PersonalStabilizer> list)
        {
            this.list = list;
        }

        public static int ControlPersonalNumber()
        {
            return 7 * WeekAlgorithm.ControlPersonalNumber();
        }

        public void StartAlgorithm()
        {
            chosenList.Clear();
            WeekAlgorithm algorithm = new WeekAlgorithm(list);
            for (int i = 0; i < 4; i++)
            {
                algorithm.StartAlgorithm();
                if (i < 1)
                {
                    chosenList.AddLast(algorithm.GetChosenPersonal().ToArray());
                }

                for (int a = 0; a < chosenList.Count; a++)
                {
                    if (chosenList.ToArray()[a][chosenList.ToArray()[a].Length - 1][2].personel.Id == algorithm.GetChosenPersonal().ToArray()[0][0].personel.Id || chosenList.ToArray()[a][chosenList.ToArray()[a].Length - 1][4].personel.Id == algorithm.GetChosenPersonal().ToArray()[0][3].personel.Id)
                    {
                        PersonalStabilizer p = algorithm.GetChosenPersonal().ToArray()[0][0];
                        algorithm.GetChosenPersonal().ToArray()[0][0] = algorithm.GetChosenPersonal().ToArray()[0][1];
                        algorithm.GetChosenPersonal().ToArray()[0][1] = p;
                    }

                }

                chosenList.AddLast(algorithm.GetChosenPersonal().ToArray());

            }
        }

        public LinkedList<PersonalStabilizer[][]> GetChosenPersonal()
        {
            return chosenList;
        }

    }
}
