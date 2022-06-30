using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp5.ViewModels
{
    public class AnotherViewModel2 : ReactiveObject, IRoutableViewModel
    {
        public AnotherViewModel2()
        {
            HostScreen = Locator.Current.GetService<IScreen>();
        }

        public string UrlPathSegment => "Another view model 2";
        public IScreen HostScreen { get; }
    }
}
