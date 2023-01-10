using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Personel_Vardiya_Programı_Team_.AutomaticSystems.AutomaticVardiyaAlgoritm;

namespace Personel_Vardiya_Programı_Team_.AutomaticSystems
{
    public class WeekAlgorithm
    {

        LinkedList<PersonalStabilizer> list;
        LinkedList<PersonalStabilizer[]> chosenPersonals = new LinkedList<PersonalStabilizer[]>();

        public WeekAlgorithm() { }

        public WeekAlgorithm(LinkedList<PersonalStabilizer> list)
        {
            this.list = list;
        }

        public void StartAlgorithm()
        {
            if (list == null) return;
            chosenPersonals.Clear();
            Generate();
            ControlPersonalsCrash();
        }

        public static int ControlPersonalNumber()
        {
            return 5 * 7;
        }

        void ControlPersonalsCrash()
        {

        }

        void Generate()
        {
            LinkedList<PersonalStabilizer> st = new LinkedList<PersonalStabilizer>();
            foreach (PersonalStabilizer s in list)
            {
                st.AddLast(s);
            }
            for (int i = 0; i < 7; i++)
            {
                DayAlgorithm alg = new DayAlgorithm(st);
                alg.StartAlgorithm();
                PersonalStabilizer[] per = alg.GetChosenPersonals();
                if (chosenPersonals.Count > 1)
                {
                    if (chosenPersonals.ToArray()[chosenPersonals.Count - 1].ToArray()[2].personel.Id == per.ToArray()[0].personel.Id)
                    {
                        PersonalStabilizer p = per.ToArray()[0];
                        per.ToArray()[0] = per.ToArray()[1];
                        per.ToArray()[1] = p;
                    }
                    if (chosenPersonals.ToArray()[chosenPersonals.Count - 1].ToArray()[4].personel.Id == per.ToArray()[3].personel.Id)
                    {
                        PersonalStabilizer p = per.ToArray()[3];
                        per.ToArray()[3] = per.ToArray()[4];
                        per.ToArray()[4] = p;
                    }
                }
                chosenPersonals.AddLast(alg.GetChosenPersonals());
            }
        }

        public LinkedList<PersonalStabilizer[]> GetChosenPersonal()
        {
            return chosenPersonals;
        }

    }
}
