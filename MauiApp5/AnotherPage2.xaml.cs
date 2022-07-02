using System;
using System.Reactive.Disposables;
using MauiApp5.ViewModels;
using ReactiveUI;
using ReactiveUI.Maui;

namespace MauiApp5
{
	public partial class AnotherPage2 : ReactiveContentPage<AnotherViewModel2>
	{
		public AnotherPage2()
		{
			InitializeComponent();

			this.WhenActivated(disposable =>
			{
				this.BindCommand(ViewModel, vm => vm.BackCommand, view => view.BackBtn)
					.DisposeWith(disposable);

				this.BindCommand(ViewModel, vm => vm.ToMainPageCommand, view => view.ToMainBtn)
					.DisposeWith(disposable);
			});
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			await ((NavigationPage)Parent).PopToRootAsync();
		}
	}
}
