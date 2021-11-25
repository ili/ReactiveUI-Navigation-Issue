using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp5.ViewModels
{
    public class AnotherViewModel : ReactiveObject, IRoutableViewModel
    {
        public AnotherViewModel()
        {
            HostScreen = Locator.Current.GetService<IScreen>();
        }

        public string UrlPathSegment => "Another view model";
        public IScreen HostScreen { get; }
    }
}
