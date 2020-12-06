using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class ButtonClickedNotClickedClass
    {
        public string ClickedOrNot { get; set; }
        public string ItIsClicked(bool buttonClicked)
        {
            if (buttonClicked == true)
            {
                ClickedOrNot = "Klickad";
            }
            return ClickedOrNot;
        }

        public string ItIsNotClicked(bool buttonClicked)
        {
            if (buttonClicked == false)
            {
                ClickedOrNot = "OKlickad";
            }
            return ClickedOrNot;
        }


    }
}
