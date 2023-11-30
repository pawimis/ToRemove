namespace ToRemove;

public partial class DetailPage : ContentPage
{
	public DetailPage()
	{
		InitializeComponent();
		
	}

	private void SimpleCalcBtn_OnClicked(object? sender, EventArgs e)
	{
		Navigation.PushAsync(new SimpleCalcPage());
	}

    private void AdvancedCalcBtn_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new SimpleCalcPage());
    }
}