using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using System.Diagnostics;

namespace Basic1.ViewModels
{
    public class HelloViewModel : Screen
    {
        public void Save()
        {
            Debug.WriteLine("Click Save");
        }
    }
}
