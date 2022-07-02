using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp5.ViewModels
{
    public class AnotherViewModel2 : AnotherViewModel
    {
        public AnotherViewModel2()
        {
            HostScreen = Locator.Current.GetService<IScreen>();
        }

        public override string UrlPathSegment => "Another view model 2";
        public IScreen HostScreen { get; }
    }
}
