namespace ToRemove;

public partial class ContainerPage : FlyoutPage
{
	private MainPage mainPage;
	public ContainerPage()
	{
		InitializeComponent();
		mainPage = new MainPage();
		mainPage.NavigationEvent += MainPageOnNavigationEvent;
		Flyout = mainPage;
		Detail = new NavigationPage(new DetailPage());
	}

	private void MainPageOnNavigationEvent(object? sender, EventArgs e)
	{
		var nav = (NavigationPage)Detail;
		var current = nav.CurrentPage;
		current.Navigation.PushAsync(new SimpleCalcPage());
	}
}