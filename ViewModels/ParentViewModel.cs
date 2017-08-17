using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using System.Diagnostics;

namespace Basic1.ViewModels
{
    public class ParentViewModel : Conductor<object>
    {
        HelloViewModel _helloViewModel;

        public ParentViewModel(HelloViewModel helloViewModel)
        {
            _helloViewModel = helloViewModel;

            ActivateItem(_helloViewModel);
        }

        public void BubbleSave()
        {
            Debug.WriteLine("Click BubbleSave");
        }
    }
}
