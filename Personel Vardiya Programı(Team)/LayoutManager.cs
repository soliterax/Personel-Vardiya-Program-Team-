using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Vardiya_Programı_Team_
{
    internal class LayoutManager
    {

        static Color textHeaderColor;
        static Color normalTextColor;
        static Color backColor;

        public static Color getColor(ColorComponents comp)
        {
            return Color.White;
        }

        public enum ColorComponents
        {
            textHeaderColor,
            normalTextColor,
            BackColor

        }
    }
}
