using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Practice
{
    public class NameMessageBoxClass
    {
        public void ReturnNameMessage(string name)
        {
            MessageBox.Show($"Hej {name}, hoppas du mår bra!");
        }
    }
}
