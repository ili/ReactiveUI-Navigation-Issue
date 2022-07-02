using DynamicData;
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

            NavigateToAnotherViewModel2 = ReactiveCommand.CreateFromObservable(() =>
            {
                HostScreen.Router.NavigationStack.Add(new AnotherViewModel());

				return HostScreen.Router.Navigate.Execute(new AnotherViewModel2());
			});

            NavigateToAnotherViewModel3 = ReactiveCommand.CreateFromObservable(() =>
            {
                HostScreen.Router.NavigationStack.Clear();
                HostScreen.Router.NavigationStack.Add(new AnotherViewModel());

                return HostScreen.Router.Navigate.Execute(new AnotherViewModel2());
            });
        }
        public string UrlPathSegment => "Main page";
        public IScreen HostScreen { get; }
        public ICommand NavigateToAnotherViewModel { get; }
        public ICommand NavigateToAnotherViewModel2 { get; }
        public ICommand NavigateToAnotherViewModel3 { get; }
    }
}
