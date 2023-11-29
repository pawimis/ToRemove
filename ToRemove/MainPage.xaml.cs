namespace ToRemove;

public partial class MainPage : ContentPage
{
	public event EventHandler NavigationEvent;
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		NavigationEvent.Invoke(this,null);
	}
}