namespace ToRemove;

public partial class DetailPage : ContentPage
{
	public DetailPage()
	{
		InitializeComponent();
		
	}

	private void CounterBtn_OnClicked(object? sender, EventArgs e)
	{
		Navigation.PushAsync(new TestPage());
	}
}