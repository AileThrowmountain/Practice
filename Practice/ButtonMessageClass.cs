using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Practice
{
    public class ButtonMessageClass
    {
        public void ShowMessage()
        {
            string message = "Du klickade på mig";
            MessageBox.Show(message);
        }

        
    }
}
