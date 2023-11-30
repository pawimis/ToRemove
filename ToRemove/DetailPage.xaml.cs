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

	private void TapGestureRecognizer_OnTapped(object? sender, TappedEventArgs e)
	{
		Navigation.PushAsync(new TestPage());
	}

	private void SwipeGestureRecognizer_OnSwiped(object? sender, SwipedEventArgs e)
	{
		Navigation.PushAsync(new TestPage());
	}
}