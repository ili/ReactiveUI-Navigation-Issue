using System;
using System.Reactive.Disposables;
using MauiApp5.ViewModels;
using ReactiveUI;
using ReactiveUI.Maui;

namespace MauiApp5
{
	public partial class MainPage : ReactiveContentPage<MainPageViewModel>
	{
		public MainPage()
		{
			InitializeComponent();

			this.WhenActivated(disposable =>
			{
				this.BindCommand(ViewModel,vm => vm.NavigateToAnotherViewModel, view => view.NavigateBtn)
					.DisposeWith(disposable);
				this.BindCommand(ViewModel,vm => vm.NavigateToAnotherViewModel2, view => view.NavigateBtn2)
					.DisposeWith(disposable);
				this.BindCommand(ViewModel,vm => vm.NavigateToAnotherViewModel3, view => view.NavigateBtn3)
					.DisposeWith(disposable);
			});
		}
	}
}
