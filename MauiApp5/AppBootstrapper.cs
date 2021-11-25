using MauiApp5.ViewModels;
using Microsoft.Maui.Controls;
using ReactiveUI;
using Splat;
using System;
using System.Reflection;

namespace MauiApp5
{
    public class AppBootstrapper : ReactiveObject, IScreen
    {
        public AppBootstrapper()
        {
            Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetExecutingAssembly());
            Locator.CurrentMutable.RegisterConstant(this, typeof(IScreen));

            Router
                .NavigateAndReset
                .Execute(new MainPageViewModel())
                .Subscribe();
        }

        public RoutingState Router { get; } = new RoutingState();

        public Page CreateMainPage()
        {
            return new ReactiveUI.Maui.RoutedViewHost();
        }
    }
}
