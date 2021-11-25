using ReactiveUI;
using Splat;
using System.Windows.Input;

namespace MauiApp5.ViewModels
{
    public class MainPageViewModel : ReactiveObject, IRoutableViewModel
    {
        public MainPageViewModel()
        {
            HostScreen = Locator.Current.GetService<IScreen>();
            NavigateToAnotherViewModel = ReactiveCommand
                .CreateFromObservable(() => HostScreen.Router.Navigate.Execute(new AnotherViewModel()));
        }
        public string UrlPathSegment => "Main page";
        public IScreen HostScreen { get; }
        public ICommand NavigateToAnotherViewModel { get; }
    }
}
