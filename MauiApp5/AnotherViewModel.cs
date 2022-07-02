using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp5.ViewModels
{
    public class AnotherViewModel : ReactiveObject, IRoutableViewModel
    {
        public AnotherViewModel()
        {
            HostScreen = Locator.Current.GetService<IScreen>();

            BackCommand = ReactiveCommand.CreateFromObservable(() => HostScreen.Router.NavigateBack.Execute(),
                this.WhenAnyValue(_ => _.HostScreen.Router.NavigationStack.Count).Select(_ => _ > 0)
                );

            ToMainPageCommand = ReactiveCommand.CreateFromObservable(() => HostScreen.Router.NavigateAndReset.Execute(new MainPageViewModel()));
        }


        public virtual string UrlPathSegment => "Another view model";
        public IScreen HostScreen { get; }
        public ReactiveCommand<Unit, IRoutableViewModel> BackCommand { get; }
        public ReactiveCommand<Unit, IRoutableViewModel> ToMainPageCommand { get; }
    }
}
